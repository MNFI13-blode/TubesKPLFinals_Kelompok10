namespace OnlineShop_Kelompok10_TubesFINAL
{
    partial class formMetodePembayaran
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
            this.COD = new System.Windows.Forms.Button();
            this.TFB = new System.Windows.Forms.Button();
            this.QRC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // COD
            // 
            this.COD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COD.Location = new System.Drawing.Point(39, 102);
            this.COD.Name = "COD";
            this.COD.Size = new System.Drawing.Size(205, 62);
            this.COD.TabIndex = 0;
            this.COD.Text = "Cash On Delivery";
            this.COD.UseVisualStyleBackColor = true;
            this.COD.Click += new System.EventHandler(this.COD_Click);
            // 
            // TFB
            // 
            this.TFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFB.Location = new System.Drawing.Point(39, 170);
            this.TFB.Name = "TFB";
            this.TFB.Size = new System.Drawing.Size(205, 62);
            this.TFB.TabIndex = 1;
            this.TFB.Text = "Transfer Bank";
            this.TFB.UseVisualStyleBackColor = true;
            this.TFB.Click += new System.EventHandler(this.TFB_Click);
            // 
            // QRC
            // 
            this.QRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRC.Location = new System.Drawing.Point(39, 238);
            this.QRC.Name = "QRC";
            this.QRC.Size = new System.Drawing.Size(205, 62);
            this.QRC.TabIndex = 2;
            this.QRC.Text = "QRIS";
            this.QRC.UseVisualStyleBackColor = true;
            this.QRC.Click += new System.EventHandler(this.QRC_Click);
            // 
            // formMetodePembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.QRC);
            this.Controls.Add(this.TFB);
            this.Controls.Add(this.COD);
            this.Name = "formMetodePembayaran";
            this.Text = "formMetodePembayaran";
            this.Load += new System.EventHandler(this.formMetodePembayaran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button COD;
        private System.Windows.Forms.Button TFB;
        private System.Windows.Forms.Button QRC;
    }
}