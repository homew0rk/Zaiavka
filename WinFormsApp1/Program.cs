using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace RepairRequestApp
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ��������� ���������� ������ � ������������� ���������� ����������
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "Server=S111-05\\SQLEXPRESS;DataBase=staff;Trusted_Connection=True;";
            Data data = new(connectionString);

            data.testConnection();


            // ������ �������� ����� ����������
            Application.Run(new Form1());
        }
    }
}