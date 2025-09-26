using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SQL
{
    public partial class sqlserver : Form
    {
        public sqlserver()
        {
            InitializeComponent();
           
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text.Trim();

            if (string.IsNullOrEmpty(serverName))
            {
                MessageBox.Show("Введите имя сервера");
                return;
            }

            string connectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";

            try
            {
                ExecuteSqlFile(connectionString, "createBD.sql");
                string dbConnectionString = $"Data Source={serverName};Initial Catalog=testBD;Integrated Security=True";
                ExecuteSqlFile(dbConnectionString, "createTable.sql");

                MessageBox.Show("База данных и таблицы успешно созданы.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void ExecuteSqlFile(string connectionString, string fileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл {fileName} не найден по пути {filePath}");

            string script = File.ReadAllText(filePath);
            string[] commands = script.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var commandText in commands)
                {
                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Podg podg = new Podg();
            podg.Show();
        }
    }
}
