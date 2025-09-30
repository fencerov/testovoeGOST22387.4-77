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

            string masterConnectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";
            string dbName = "testBD";

            try
            {
                string createDbScript = $"CREATE DATABASE [{dbName}];";
                ExecuteSqlCommand(masterConnectionString, createDbScript);

                var builder = new SqlConnectionStringBuilder(masterConnectionString)
                {
                    InitialCatalog = dbName
                };
                string dbConnectionString = builder.ConnectionString;

                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string tableScriptPath = Path.Combine(basePath, "createTable.sql");

                if (!File.Exists(tableScriptPath))
                    throw new FileNotFoundException($"Файл 'createTable.sql' не найден по пути {tableScriptPath}");

                string tableScript = File.ReadAllText(tableScriptPath);

                ExecuteSqlScript(dbConnectionString, tableScript);

                MessageBox.Show("База данных и таблицы успешно созданы.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void ExecuteSqlCommand(string connectionString, string commandText)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ExecuteSqlScript(string connectionString, string script)
        {
            string[] commands = script.Split(new[] { "\r\nGO", "\nGO", "\rGO" }, StringSplitOptions.RemoveEmptyEntries);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var command in commands)
                {
                    if (!string.IsNullOrWhiteSpace(command))
                    {
                        using (SqlCommand cmd = new SqlCommand(command, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
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
