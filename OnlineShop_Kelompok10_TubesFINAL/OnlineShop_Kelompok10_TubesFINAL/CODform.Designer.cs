namespace OnlineShop_Kelompok10_TubesFINAL
{
    partial class CODform
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
            this.labelpenjelasan = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelpenjelasan
            // 
            this.labelpenjelasan.AutoSize = true;
            this.labelpenjelasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpenjelasan.Location = new System.Drawing.Point(13, 54);
            this.labelpenjelasan.Name = "labelpenjelasan";
            this.labelpenjelasan.Size = new System.Drawing.Size(257, 116);
            this.labelpenjelasan.TabIndex = 0;
            this.labelpenjelasan.Text = "Pesanan anda\r\nsegera kami diproses\r\ntunggu barang sampai \r\nlalu bayar";
            this.labelpenjelasan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(106, 281);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(60, 60);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CODform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.labelpenjelasan);
            this.Name = "CODform";
            this.Text = "CODform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpenjelasan;
        private System.Windows.Forms.Button OK;
    }
}