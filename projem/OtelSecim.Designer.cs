namespace projem
{
    partial class OtelSecim
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
            this.chckonaklama = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chctema = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chcuygunluk = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chcerisebilirlik = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chcyildiz = new System.Windows.Forms.CheckedListBox();
            this.btnfiltrele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chckonaklama
            // 
            this.chckonaklama.FormattingEnabled = true;
            this.chckonaklama.Items.AddRange(new object[] {
            "Apart Hotel",
            "Resort",
            "Yazlık",
            "Otel"});
            this.chckonaklama.Location = new System.Drawing.Point(16, 43);
            this.chckonaklama.Name = "chckonaklama";
            this.chckonaklama.Size = new System.Drawing.Size(134, 89);
            this.chckonaklama.TabIndex = 0;
            this.chckonaklama.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chckonaklama_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konaklama Tipi";
            // 
            // chctema
            // 
            this.chctema.FormattingEnabled = true;
            this.chctema.Items.AddRange(new object[] {
            "Lüks Otel",
            "Sehir Oteli",
            "Doga Oteli",
            "Saglik Oteli"});
            this.chctema.Location = new System.Drawing.Point(193, 42);
            this.chctema.Name = "chctema";
            this.chctema.Size = new System.Drawing.Size(134, 89);
            this.chctema.TabIndex = 0;
            this.chctema.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chctema_ItemCheck);
            this.chctema.SelectedIndexChanged += new System.EventHandler(this.chctema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otel Teması";
            // 
            // chcuygunluk
            // 
            this.chcuygunluk.FormattingEnabled = true;
            this.chcuygunluk.Items.AddRange(new object[] {
            "Aileler",
            "Balayı Çiftleri",
            "Bekarlar"});
            this.chcuygunluk.Location = new System.Drawing.Point(359, 42);
            this.chcuygunluk.Name = "chcuygunluk";
            this.chcuygunluk.Size = new System.Drawing.Size(134, 89);
            this.chcuygunluk.TabIndex = 0;
            this.chcuygunluk.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcuygunluk_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uygunluk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Erişilebilirlik";
            // 
            // chcerisebilirlik
            // 
            this.chcerisebilirlik.FormattingEnabled = true;
            this.chcerisebilirlik.Items.AddRange(new object[] {
            "Engelli Otoparkı",
            "Engellilere Özel Oda",
            "Engellilere Özel Yol",
            "Tekerlekli Sandalye"});
            this.chcerisebilirlik.Location = new System.Drawing.Point(549, 43);
            this.chcerisebilirlik.Name = "chcerisebilirlik";
            this.chcerisebilirlik.Size = new System.Drawing.Size(162, 89);
            this.chcerisebilirlik.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yıldız Sayısı";
            // 
            // chcyildiz
            // 
            this.chcyildiz.FormattingEnabled = true;
            this.chcyildiz.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chcyildiz.Location = new System.Drawing.Point(739, 42);
            this.chcyildiz.Name = "chcyildiz";
            this.chcyildiz.Size = new System.Drawing.Size(134, 89);
            this.chcyildiz.TabIndex = 5;
            this.chcyildiz.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcyildiz_ItemCheck);
            // 
            // btnfiltrele
            // 
            this.btnfiltrele.Location = new System.Drawing.Point(16, 138);
            this.btnfiltrele.Name = "btnfiltrele";
            this.btnfiltrele.Size = new System.Drawing.Size(857, 69);
            this.btnfiltrele.TabIndex = 7;
            this.btnfiltrele.Text = "FILTRELE";
            this.btnfiltrele.UseVisualStyleBackColor = true;
            this.btnfiltrele.Click += new System.EventHandler(this.btnfiltrele_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 248);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "label10";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(49, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(505, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "* Boş Geçilmez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(190, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "* Boş Geçilmez";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(366, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "* Boş Geçilmez";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(736, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "* Boş Geçilmez";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rezervasyon Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtelSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfiltrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chcyildiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chcerisebilirlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcuygunluk);
            this.Controls.Add(this.chctema);
            this.Controls.Add(this.chckonaklama);
            this.Name = "OtelSecim";
            this.Text = "OtelSecim";
            this.Load += new System.EventHandler(this.OtelSecim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chckonaklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chctema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chcuygunluk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chcerisebilirlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox chcyildiz;
        private System.Windows.Forms.Button btnfiltrele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}