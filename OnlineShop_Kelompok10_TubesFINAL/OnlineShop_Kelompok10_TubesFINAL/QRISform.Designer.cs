namespace OnlineShop_Kelompok10_TubesFINAL
{
    partial class QRISform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRISform));
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.pictureBoxQRcode = new System.Windows.Forms.PictureBox();
            this.buttonSelesai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeterangan.Location = new System.Drawing.Point(19, 21);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(244, 44);
            this.labelKeterangan.TabIndex = 0;
            this.labelKeterangan.Text = "Silahkan scane QR Di bawah\r\nlalu lanjutkan pembayaran";
            this.labelKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxQRcode
            // 
            this.pictureBoxQRcode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQRcode.Image")));
            this.pictureBoxQRcode.Location = new System.Drawing.Point(15, 81);
            this.pictureBoxQRcode.Name = "pictureBoxQRcode";
            this.pictureBoxQRcode.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRcode.TabIndex = 1;
            this.pictureBoxQRcode.TabStop = false;
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(96, 364);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(65, 65);
            this.buttonSelesai.TabIndex = 2;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
            // 
            // QRISform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.pictureBoxQRcode);
            this.Controls.Add(this.labelKeterangan);
            this.Name = "QRISform";
            this.Text = "QRISform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.PictureBox pictureBoxQRcode;
        private System.Windows.Forms.Button buttonSelesai;
    }
}