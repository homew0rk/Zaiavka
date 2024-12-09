using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace RepairRequestApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настройка визуальных стилей и совместимости текстового рендеринга
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "Server=S111-05\\SQLEXPRESS;DataBase=staff;Trusted_Connection=True;";
            Data data = new(connectionString);

            data.testConnection();


            // Запуск основной формы приложения
            Application.Run(new Form1());
        }
    }
}