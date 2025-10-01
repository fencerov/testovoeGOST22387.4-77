using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL
{
    public partial class TableRes : Form
    {
        public TableRes()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void LoadTableData()
        {
            string serverName = Globalname.ServerName;
            string connectionString = $"Data Source={serverName};Initial Catalog=testBD;Integrated Security=True";

            string query = "SELECT * FROM testRes";

            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }

            dataGridView1.DataSource = table;
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form2 = new Form1();
            Form2.Show();
        }
    }
}