namespace at_yarışı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_212701005 = new System.Windows.Forms.Label();
            this.label2_212701005 = new System.Windows.Forms.Label();
            this.button1_212701005 = new System.Windows.Forms.Button();
            this.textBox1_212701005 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1_212701005
            // 
            this.label1_212701005.AutoSize = true;
            this.label1_212701005.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1_212701005.Location = new System.Drawing.Point(84, 211);
            this.label1_212701005.Name = "label1_212701005";
            this.label1_212701005.Size = new System.Drawing.Size(239, 17);
            this.label1_212701005.TabIndex = 0;
            this.label1_212701005.Text = "lütfen geçerli bir oyuncu sayısı giriniz";
            this.label1_212701005.Visible = false;
            // 
            // label2_212701005
            // 
            this.label2_212701005.AutoSize = true;
            this.label2_212701005.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2_212701005.Location = new System.Drawing.Point(82, 21);
            this.label2_212701005.Name = "label2_212701005";
            this.label2_212701005.Size = new System.Drawing.Size(237, 29);
            this.label2_212701005.TabIndex = 1;
            this.label2_212701005.Text = "Kişi  Sayısını Giriniz";
            // 
            // button1_212701005
            // 
            this.button1_212701005.Location = new System.Drawing.Point(87, 127);
            this.button1_212701005.Name = "button1_212701005";
            this.button1_212701005.Size = new System.Drawing.Size(232, 45);
            this.button1_212701005.TabIndex = 3;
            this.button1_212701005.Text = "BAŞLA";
            this.button1_212701005.UseVisualStyleBackColor = true;
            this.button1_212701005.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_212701005
            // 
            this.textBox1_212701005.Location = new System.Drawing.Point(87, 66);
            this.textBox1_212701005.Mask = "0";
            this.textBox1_212701005.Name = "textBox1_212701005";
            this.textBox1_212701005.Size = new System.Drawing.Size(232, 22);
            this.textBox1_212701005.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 238);
            this.Controls.Add(this.textBox1_212701005);
            this.Controls.Add(this.button1_212701005);
            this.Controls.Add(this.label2_212701005);
            this.Controls.Add(this.label1_212701005);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_212701005;
        private System.Windows.Forms.Label label2_212701005;
        private System.Windows.Forms.Button button1_212701005;
        private System.Windows.Forms.MaskedTextBox textBox1_212701005;
    }
}

