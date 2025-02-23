namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(428, 175);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(149, 42);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.Text = "How To Play?";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(30, 95);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(147, 45);
            this.txtGuess.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.MistyRose;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.Location = new System.Drawing.Point(193, 93);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 47);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeRemaining.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimeRemaining.Location = new System.Drawing.Point(298, 62);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(204, 29);
            this.lblTimeRemaining.TabIndex = 4;
            this.lblTimeRemaining.Text = "Time Elapsed: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(298, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Point:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPoints.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoints.Location = new System.Drawing.Point(423, 111);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(55, 29);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHint.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHint.Location = new System.Drawing.Point(25, 148);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 25);
            this.lblHint.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(589, 229);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guess!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHint;

    }
}

