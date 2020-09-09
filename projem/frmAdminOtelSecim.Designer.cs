namespace projem
{
    partial class frmAdminOtelSecim
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
            this.btnDedeman = new System.Windows.Forms.Button();
            this.btnHilton = new System.Windows.Forms.Button();
            this.btnKutberk = new System.Windows.Forms.Button();
            this.btnEceSaray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDedeman
            // 
            this.btnDedeman.Location = new System.Drawing.Point(72, 78);
            this.btnDedeman.Name = "btnDedeman";
            this.btnDedeman.Size = new System.Drawing.Size(90, 50);
            this.btnDedeman.TabIndex = 0;
            this.btnDedeman.Text = "Dedeman Müşteriler";
            this.btnDedeman.UseVisualStyleBackColor = true;
            this.btnDedeman.Click += new System.EventHandler(this.btnDedeman_Click);
            // 
            // btnHilton
            // 
            this.btnHilton.Location = new System.Drawing.Point(72, 160);
            this.btnHilton.Name = "btnHilton";
            this.btnHilton.Size = new System.Drawing.Size(90, 50);
            this.btnHilton.TabIndex = 1;
            this.btnHilton.Text = "Hilton Müşteriler";
            this.btnHilton.UseVisualStyleBackColor = true;
            this.btnHilton.Click += new System.EventHandler(this.btnHilton_Click);
            // 
            // btnKutberk
            // 
            this.btnKutberk.Location = new System.Drawing.Point(72, 249);
            this.btnKutberk.Name = "btnKutberk";
            this.btnKutberk.Size = new System.Drawing.Size(90, 50);
            this.btnKutberk.TabIndex = 2;
            this.btnKutberk.Text = "Kutberk Müşteriler";
            this.btnKutberk.UseVisualStyleBackColor = true;
            this.btnKutberk.Click += new System.EventHandler(this.btnKutberk_Click);
            // 
            // btnEceSaray
            // 
            this.btnEceSaray.Location = new System.Drawing.Point(243, 78);
            this.btnEceSaray.Name = "btnEceSaray";
            this.btnEceSaray.Size = new System.Drawing.Size(90, 50);
            this.btnEceSaray.TabIndex = 3;
            this.btnEceSaray.Text = "EceSaray Müşteriler";
            this.btnEceSaray.UseVisualStyleBackColor = true;
            this.btnEceSaray.Click += new System.EventHandler(this.btnEceSaray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "AntalyaSu Müşteriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdminOtelSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEceSaray);
            this.Controls.Add(this.btnKutberk);
            this.Controls.Add(this.btnHilton);
            this.Controls.Add(this.btnDedeman);
            this.Name = "frmAdminOtelSecim";
            this.Text = "frmAdminOtelSecim";
            this.Load += new System.EventHandler(this.frmAdminOtelSecim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDedeman;
        private System.Windows.Forms.Button btnHilton;
        private System.Windows.Forms.Button btnKutberk;
        private System.Windows.Forms.Button btnEceSaray;
        private System.Windows.Forms.Button button1;
    }
}