namespace sayı_tahmin
{
    partial class tahminet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbasla = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKontrol = new System.Windows.Forms.Button();
            this.labelkontrol = new System.Windows.Forms.Label();
            this.labelsure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelpuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Et";
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.Color.Lime;
            this.btnbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(648, 130);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(131, 72);
            this.btnbasla.TabIndex = 1;
            this.btnbasla.Text = "Oyuna Başla";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Location = new System.Drawing.Point(21, 145);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(106, 43);
            this.btnhelp.TabIndex = 2;
            this.btnhelp.Text = "Nasıl Oynanır?";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(21, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 50);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(287, 73);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(103, 50);
            this.btnKontrol.TabIndex = 4;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // labelkontrol
            // 
            this.labelkontrol.AutoSize = true;
            this.labelkontrol.Location = new System.Drawing.Point(313, 172);
            this.labelkontrol.Name = "labelkontrol";
            this.labelkontrol.Size = new System.Drawing.Size(0, 16);
            this.labelkontrol.TabIndex = 5;
            // 
            // labelsure
            // 
            this.labelsure.AutoSize = true;
            this.labelsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsure.Location = new System.Drawing.Point(733, 15);
            this.labelsure.Name = "labelsure";
            this.labelsure.Size = new System.Drawing.Size(35, 38);
            this.labelsure.TabIndex = 6;
            this.labelsure.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(490, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Geçen Süre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(490, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puan:";
            // 
            // labelpuan
            // 
            this.labelpuan.AutoSize = true;
            this.labelpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpuan.Location = new System.Drawing.Point(697, 73);
            this.labelpuan.Name = "labelpuan";
            this.labelpuan.Size = new System.Drawing.Size(71, 38);
            this.labelpuan.TabIndex = 9;
            this.labelpuan.Text = "100";
            // 
            // tahminet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.labelpuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelsure);
            this.Controls.Add(this.labelkontrol);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.label1);
            this.Name = "tahminet";
            this.Text = "Tahmin Et";
            this.Load += new System.EventHandler(this.tahminet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label labelkontrol;
        private System.Windows.Forms.Label labelsure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelpuan;
    }
}

