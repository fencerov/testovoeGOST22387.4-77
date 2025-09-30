
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using static SQL.sqlserver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SQL
{
    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;

            if (tb == t11 || tb == t13 || tb == t21 || tb == t23)
            {
                ValidateTextBox(tb, 20.0, 30.0);
            }
            if (tb == t12 || tb == t14 || tb == t22 || tb == t24)
            {
                ValidateTextBox(tb, 15.0, 20.0);
            }
            if (tb == sk11 || tb == sk12 || tb == sk21 || tb == sk22)
            {
                ValidateTextBox(tb, 75.0, 80.0);
            }
            if (tb == V1 || tb == V2)
            {
                ValidateTextBox(tb, 1000.0);
            }
            if (tb == pm11 || tb == pm12 || tb == pm21 || tb == pm22)
            {
                ValidateTextBox(tb, 0, 0.0002);
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint1;
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint1.X;
                this.Top += e.Y - lastpoint1.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint1 = new Point(e.X, e.Y);
        }
        private bool checkValid = false;
        private void ValidateTextBox(System.Windows.Forms.TextBox textBox, double min, double? max = null)
        {
            double value;
            if (!double.TryParse(textBox.Text, out value) || value < min || (max.HasValue && value > max.Value))
            {
                textBox.BackColor = Color.LightCoral;
                checkValid = false;
            }
            else
            {
                textBox.BackColor = Color.White;
                checkValid = true;
            }
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {

            List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox> { t11, t12, t13, t14, t21, t22, t23, t24, sk11, sk12, sk21, sk22, V1, V2, pm11, pm12, pm21, pm22 };
            bool allFilled = textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));
            double.TryParse(m11.Text, out double rm11);
            double.TryParse(m12.Text, out double rm12);
            double.TryParse(m21.Text, out double rm21);
            double.TryParse(m22.Text, out double rm22);
            double.TryParse(V1.Text, out double rV1);
            double.TryParse(V2.Text, out double rV2);
            if (allFilled && checkValid)
            {
                if (rm11 > rm12 || rm21 > rm22) MessageBox.Show("масса не может уменьшиться");
                else 
                {
                double X1 = (rm12 - rm11) * 100000 / rV1;
                double X2 = (rm22 - rm21) * 100000 / rV2;
                    if (Math.Abs(X1 * 1000000 - (X2 * 1000000)) <= 0.05)
                    {
                        double X = (X1 + X2) / 2;
                        MessageBox.Show("Массовая доля смолы и пыли в испытуемом газе равна: " + X +"г/100см^3");
                        SaveToBD(X1, X2, X);
                    }
                    else MessageBox.Show("Расхождение выше допустимого");
                }
            }
            else
            {
                MessageBox.Show("Введите все необходимые значения");
            }
        }
        private void SaveToBD(double X1, double X2, double X)
        {
            string srv = Globalname.ServerName;
            db db1 = new db(srv);
            MessageBox.Show(srv);
            SqlConnection connection = db1.GetConnection();

            string query = "INSERT INTO testRes (X1, X2, X) VALUES (@X1, @X2, @X)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@X1", X1);
                command.Parameters.AddWithValue("@X2", X2);
                command.Parameters.AddWithValue("@X", X);

                try
                {
                    db1.openConnect();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении в базу: " + ex.Message);
                }
                finally
                {
                    db1.closeConnect();
                }
            }
        }

    }
}
