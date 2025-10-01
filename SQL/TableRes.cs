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

            db db1 = new db(serverName);

            DataTable table = new DataTable();

            try
            {
                db1.openConnect();

                using (SqlCommand command = new SqlCommand("SELECT * FROM testRes", db1.GetConnection()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                db1.closeConnect();
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