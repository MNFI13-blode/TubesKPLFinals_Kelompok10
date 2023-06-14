namespace OnlineShop_Kelompok10_TubesFINAL
{
    partial class TFBform
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
            this.bca = new System.Windows.Forms.Button();
            this.bni = new System.Windows.Forms.Button();
            this.bri = new System.Windows.Forms.Button();
            this.mandiri = new System.Windows.Forms.Button();
            this.labelBiayaAdmin = new System.Windows.Forms.Label();
            this.textBoxNomorRekening = new System.Windows.Forms.TextBox();
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bca
            // 
            this.bca.Location = new System.Drawing.Point(41, 94);
            this.bca.Name = "bca";
            this.bca.Size = new System.Drawing.Size(192, 36);
            this.bca.TabIndex = 0;
            this.bca.Text = "BCA";
            this.bca.UseVisualStyleBackColor = true;
            this.bca.Click += new System.EventHandler(this.bca_Click);
            // 
            // bni
            // 
            this.bni.Location = new System.Drawing.Point(41, 136);
            this.bni.Name = "bni";
            this.bni.Size = new System.Drawing.Size(192, 36);
            this.bni.TabIndex = 1;
            this.bni.Text = "BNI";
            this.bni.UseVisualStyleBackColor = true;
            this.bni.Click += new System.EventHandler(this.bni_Click);
            // 
            // bri
            // 
            this.bri.Location = new System.Drawing.Point(41, 178);
            this.bri.Name = "bri";
            this.bri.Size = new System.Drawing.Size(192, 36);
            this.bri.TabIndex = 2;
            this.bri.Text = "BRI";
            this.bri.UseVisualStyleBackColor = true;
            this.bri.Click += new System.EventHandler(this.bri_Click);
            // 
            // mandiri
            // 
            this.mandiri.Location = new System.Drawing.Point(41, 220);
            this.mandiri.Name = "mandiri";
            this.mandiri.Size = new System.Drawing.Size(192, 36);
            this.mandiri.TabIndex = 3;
            this.mandiri.Text = "MANDIRI";
            this.mandiri.UseVisualStyleBackColor = true;
            this.mandiri.Click += new System.EventHandler(this.mandiri_Click);
            // 
            // labelBiayaAdmin
            // 
            this.labelBiayaAdmin.AutoSize = true;
            this.labelBiayaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiayaAdmin.Location = new System.Drawing.Point(34, 32);
            this.labelBiayaAdmin.Name = "labelBiayaAdmin";
            this.labelBiayaAdmin.Size = new System.Drawing.Size(209, 39);
            this.labelBiayaAdmin.TabIndex = 4;
            this.labelBiayaAdmin.Text = "Biaya Admin";
            // 
            // textBoxNomorRekening
            // 
            this.textBoxNomorRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomorRekening.Location = new System.Drawing.Point(23, 300);
            this.textBoxNomorRekening.Name = "textBoxNomorRekening";
            this.textBoxNomorRekening.Size = new System.Drawing.Size(229, 45);
            this.textBoxNomorRekening.TabIndex = 5;
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(41, 351);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(75, 35);
            this.buttonSelesai.TabIndex = 6;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // TFBform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 442);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.textBoxNomorRekening);
            this.Controls.Add(this.labelBiayaAdmin);
            this.Controls.Add(this.mandiri);
            this.Controls.Add(this.bri);
            this.Controls.Add(this.bni);
            this.Controls.Add(this.bca);
            this.Name = "TFBform";
            this.Text = "TFBform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bca;
        private System.Windows.Forms.Button bni;
        private System.Windows.Forms.Button bri;
        private System.Windows.Forms.Button mandiri;
        private System.Windows.Forms.Label labelBiayaAdmin;
        private System.Windows.Forms.TextBox textBoxNomorRekening;
        private System.Windows.Forms.Button buttonSelesai;
    }
}