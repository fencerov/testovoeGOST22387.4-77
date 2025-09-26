using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL
{
    public partial class Podg : Form
    {
        public Podg()
        {
            InitializeComponent();

        }

        private void buttonPodg_Click(object sender, EventArgs e)
        {
            int VP, skP;
            bool VPValid = int.TryParse(VPodg.Text, out VP);
            bool SkPValid = int.TryParse(skPodg.Text, out skP);
            if (VPValid && SkPValid)
            {
                if (VP == 500 && skP <= 80 && skP >= 75)
                {
                    if (check1.Checked)
                    {
                        MessageBox.Show("Смола и пыль в газе отсутствуют");
                        return;
                    }
                    OpenForm1();
                }
                else
                {
                    MessageBox.Show("Неверные данные");
                }
            }
        }
        private void OpenForm1()
        {
            Form1 form2 = new Form1(); 
            form2.Left = this.Left;    
            form2.Top = this.Top;      
            form2.Show();              
            this.Hide();               
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastpoint;
        private void Podg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Podg_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Podg_Load(object sender, EventArgs e)
        {

        }

        private void skPodg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqlserver sqlserver = new sqlserver();
            sqlserver.Show();
        }
    }
}
