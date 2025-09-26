namespace SQL
{
    partial class Podg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.skPodg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.VPodg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.buttonPodg = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "подготовка к испытанию";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Скорость:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(443, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "дм^3/ч";
            // 
            // skPodg
            // 
            this.skPodg.Location = new System.Drawing.Point(337, 60);
            this.skPodg.Name = "skPodg";
            this.skPodg.Size = new System.Drawing.Size(100, 20);
            this.skPodg.TabIndex = 28;
            this.skPodg.TextChanged += new System.EventHandler(this.skPodg_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "дм^3";
            // 
            // VPodg
            // 
            this.VPodg.Location = new System.Drawing.Point(99, 64);
            this.VPodg.Name = "VPodg";
            this.VPodg.Size = new System.Drawing.Size(100, 20);
            this.VPodg.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Объем газа:";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(25, 105);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(118, 17);
            this.check1.TabIndex = 31;
            this.check1.Text = "налет отсутствует";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // buttonPodg
            // 
            this.buttonPodg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPodg.Location = new System.Drawing.Point(208, 140);
            this.buttonPodg.Name = "buttonPodg";
            this.buttonPodg.Size = new System.Drawing.Size(75, 23);
            this.buttonPodg.TabIndex = 32;
            this.buttonPodg.Text = "начать";
            this.buttonPodg.UseVisualStyleBackColor = true;
            this.buttonPodg.Click += new System.EventHandler(this.buttonPodg_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.close.Location = new System.Drawing.Point(490, -7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 29);
            this.close.TabIndex = 33;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "создать БД";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Podg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.buttonPodg);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.skPodg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.VPodg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Podg";
            this.Text = "Podg";
            this.Load += new System.EventHandler(this.Podg_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Podg_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Podg_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox skPodg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox VPodg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Button buttonPodg;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
    }
}