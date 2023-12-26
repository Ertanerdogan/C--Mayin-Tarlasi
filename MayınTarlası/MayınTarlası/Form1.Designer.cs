namespace MayınTarlası
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOyna = new System.Windows.Forms.Button();
            this.RdbKolay = new System.Windows.Forms.RadioButton();
            this.RdbOrta = new System.Windows.Forms.RadioButton();
            this.RdbZor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAYIN TARLASI";
            // 
            // BtnOyna
            // 
            this.BtnOyna.BackColor = System.Drawing.Color.Black;
            this.BtnOyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOyna.ForeColor = System.Drawing.Color.White;
            this.BtnOyna.Location = new System.Drawing.Point(174, 135);
            this.BtnOyna.Name = "BtnOyna";
            this.BtnOyna.Size = new System.Drawing.Size(191, 70);
            this.BtnOyna.TabIndex = 1;
            this.BtnOyna.Text = "OYNA";
            this.BtnOyna.UseVisualStyleBackColor = false;
            this.BtnOyna.Click += new System.EventHandler(this.BtnOyna_Click);
            this.BtnOyna.MouseEnter += new System.EventHandler(this.BtnOyna_MouseEnter);
            this.BtnOyna.MouseLeave += new System.EventHandler(this.BtnOyna_MouseLeave);
            // 
            // RdbKolay
            // 
            this.RdbKolay.AutoSize = true;
            this.RdbKolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbKolay.Location = new System.Drawing.Point(203, 313);
            this.RdbKolay.Name = "RdbKolay";
            this.RdbKolay.Size = new System.Drawing.Size(141, 40);
            this.RdbKolay.TabIndex = 2;
            this.RdbKolay.TabStop = true;
            this.RdbKolay.Text = "KOLAY";
            this.RdbKolay.UseVisualStyleBackColor = true;
            // 
            // RdbOrta
            // 
            this.RdbOrta.AutoSize = true;
            this.RdbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbOrta.Location = new System.Drawing.Point(203, 349);
            this.RdbOrta.Name = "RdbOrta";
            this.RdbOrta.Size = new System.Drawing.Size(123, 40);
            this.RdbOrta.TabIndex = 3;
            this.RdbOrta.TabStop = true;
            this.RdbOrta.Text = "ORTA";
            this.RdbOrta.UseVisualStyleBackColor = true;
            // 
            // RdbZor
            // 
            this.RdbZor.AutoSize = true;
            this.RdbZor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbZor.Location = new System.Drawing.Point(203, 385);
            this.RdbZor.Name = "RdbZor";
            this.RdbZor.Size = new System.Drawing.Size(101, 40);
            this.RdbZor.TabIndex = 4;
            this.RdbZor.TabStop = true;
            this.RdbZor.Text = "ZOR";
            this.RdbZor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(517, 545);
            this.Controls.Add(this.RdbZor);
            this.Controls.Add(this.RdbOrta);
            this.Controls.Add(this.RdbKolay);
            this.Controls.Add(this.BtnOyna);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAYIN TARLASI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOyna;
        private System.Windows.Forms.RadioButton RdbKolay;
        private System.Windows.Forms.RadioButton RdbOrta;
        private System.Windows.Forms.RadioButton RdbZor;
    }
}

