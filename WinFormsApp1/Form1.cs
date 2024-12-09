using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RepairRequestApp
{
    public partial class Form1 : Form
    {
        private List<RepairRequest> requests = new List<RepairRequest>();
        private const string filePath = "requests.json"; // Путь к файлу для хранения заявок

        public Form1()
        {
            InitializeComponent();
            LoadRequests(); // Загружаем заявки при старте приложения
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на заполненность обязательных полей
                if (string.IsNullOrWhiteSpace(txtRequestNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtEquipment.Text) ||
                    string.IsNullOrWhiteSpace(txtFaultType.Text) ||
                    string.IsNullOrWhiteSpace(txtProblemDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtClientName.Text) ||
                    cmbStatus.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Проверка на уникальность номера заявки
                foreach (var request in requests)
                {
                    if (request.RequestNumber == txtRequestNumber.Text)
                    {
                        MessageBox.Show("Заявка с таким номером уже существует. Пожалуйста, введите уникальный номер.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Создание новой заявки
                var newRequest = new RepairRequest
                {
                    RequestNumber = txtRequestNumber.Text,
                    DateAdded = DateTime.Now,
                    Equipment = txtEquipment.Text,
                    FaultType = txtFaultType.Text,
                    ProblemDescription = txtProblemDescription.Text,
                    ClientName = txtClientName.Text,
                    Status = cmbStatus.SelectedItem.ToString()
                };

                // Добавление заявки в список
                requests.Add(newRequest);
                UpdateRequestList();
                SaveRequests(); // Сохраняем заявки после добавления

                // Уведомление об успешном добавлении
                MessageBox.Show("Заявка успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRequestList()
        {
            lstRequests.Items.Clear();
            foreach (var request in requests)
            {
                lstRequests.Items.Add(request);
            }
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRequests.SelectedItem is RepairRequest selectedRequest)
                {
                    selectedRequest.ProblemDescription = txtProblemDescription.Text;
                    selectedRequest.Status = cmbStatus.SelectedItem.ToString();
                    UpdateRequestList();

                    // Уведомление об успешном редактировании
                    MessageBox.Show("Заявка успешно отредактирована!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveRequests(); // Сохраняем изменения после редактирования
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите заявку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRequests()
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                requests = JsonConvert.DeserializeObject<List<RepairRequest>>(jsonData) ?? new List<RepairRequest>();
                UpdateRequestList();
            }
        }

        private void SaveRequests()
        {
            var jsonData = JsonConvert.SerializeObject(requests, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        private void txtRequestNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или является ли это клавишей Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменяем ввод символа
            }
        }
    }

    public class RepairRequest
    {
        public string RequestNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public string Equipment { get; set; }
        public string FaultType { get; set; }
        public string ProblemDescription { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{RequestNumber} - {Equipment} - {Status}";
        }
    }
}