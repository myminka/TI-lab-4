namespace Lab4
{
    partial class Form1
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
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKs = new System.Windows.Forms.TextBox();
            this.tbTextToCrypt = new System.Windows.Forms.TextBox();
            this.tbCryptText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKo = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKo1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbN2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTextToEncrypt = new System.Windows.Forms.TextBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.btnEncryptText = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEncryptText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKsEC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbN1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(97, 60);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(52, 50);
            this.tbP.TabIndex = 0;
            this.tbP.TextChanged += new System.EventHandler(this.tbP_TextChanged);
            this.tbP.Leave += new System.EventHandler(this.tbP_Leave);
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(97, 131);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(52, 50);
            this.tbQ.TabIndex = 1;
            this.tbQ.Leave += new System.EventHandler(this.tbQ_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "p = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "q =";
            // 
            // tbFi
            // 
            this.tbFi.Location = new System.Drawing.Point(279, 128);
            this.tbFi.Name = "tbFi";
            this.tbFi.ReadOnly = true;
            this.tbFi.Size = new System.Drawing.Size(94, 50);
            this.tbFi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kc =";
            // 
            // tbKs
            // 
            this.tbKs.Location = new System.Drawing.Point(524, 51);
            this.tbKs.Name = "tbKs";
            this.tbKs.Size = new System.Drawing.Size(81, 50);
            this.tbKs.TabIndex = 6;
            this.tbKs.TextChanged += new System.EventHandler(this.tbKs_TextChanged);
            this.tbKs.Leave += new System.EventHandler(this.tbKs_Leave);
            // 
            // tbTextToCrypt
            // 
            this.tbTextToCrypt.Location = new System.Drawing.Point(16, 127);
            this.tbTextToCrypt.Multiline = true;
            this.tbTextToCrypt.Name = "tbTextToCrypt";
            this.tbTextToCrypt.Size = new System.Drawing.Size(343, 128);
            this.tbTextToCrypt.TabIndex = 8;
            // 
            // tbCryptText
            // 
            this.tbCryptText.Location = new System.Drawing.Point(365, 127);
            this.tbCryptText.Multiline = true;
            this.tbCryptText.Name = "tbCryptText";
            this.tbCryptText.Size = new System.Drawing.Size(344, 128);
            this.tbCryptText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ko =";
            // 
            // tbKo
            // 
            this.tbKo.Location = new System.Drawing.Point(524, 119);
            this.tbKo.Name = "tbKo";
            this.tbKo.ReadOnly = true;
            this.tbKo.Size = new System.Drawing.Size(82, 50);
            this.tbKo.TabIndex = 10;
            this.tbKo.TextChanged += new System.EventHandler(this.tbKo_TextChanged);
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(8, 261);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(359, 62);
            this.btnCrypt.TabIndex = 12;
            this.btnCrypt.Text = "Зашифровать";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(236, 62);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKo1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbN2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTextToCrypt);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCrypt);
            this.groupBox1.Controls.Add(this.tbCryptText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 328);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифрование";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbKo1
            // 
            this.tbKo1.Location = new System.Drawing.Point(365, 54);
            this.tbKo1.Name = "tbKo1";
            this.tbKo1.Size = new System.Drawing.Size(115, 50);
            this.tbKo1.TabIndex = 14;
            this.tbKo1.TextChanged += new System.EventHandler(this.tbKo1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 44);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ko =";
            // 
            // tbN2
            // 
            this.tbN2.Location = new System.Drawing.Point(97, 54);
            this.tbN2.Name = "tbN2";
            this.tbN2.Size = new System.Drawing.Size(133, 50);
            this.tbN2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 44);
            this.label7.TabIndex = 15;
            this.label7.Text = "n =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTextToEncrypt);
            this.groupBox2.Controls.Add(this.btnCancel1);
            this.groupBox2.Controls.Add(this.tbN);
            this.groupBox2.Controls.Add(this.btnEncryptText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbEncryptText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbKsEC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(770, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 328);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифрование";
            // 
            // tbTextToEncrypt
            // 
            this.tbTextToEncrypt.Location = new System.Drawing.Point(369, 127);
            this.tbTextToEncrypt.Multiline = true;
            this.tbTextToEncrypt.Name = "tbTextToEncrypt";
            this.tbTextToEncrypt.Size = new System.Drawing.Size(335, 128);
            this.tbTextToEncrypt.TabIndex = 8;
            this.tbTextToEncrypt.TextChanged += new System.EventHandler(this.tbTextToEncrypt_TextChanged);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(453, 261);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(210, 64);
            this.btnCancel1.TabIndex = 13;
            this.btnCancel1.Text = "Выход";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(103, 63);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(133, 50);
            this.tbN.TabIndex = 0;
            // 
            // btnEncryptText
            // 
            this.btnEncryptText.Location = new System.Drawing.Point(6, 264);
            this.btnEncryptText.Name = "btnEncryptText";
            this.btnEncryptText.Size = new System.Drawing.Size(385, 59);
            this.btnEncryptText.TabIndex = 12;
            this.btnEncryptText.Text = "Расшифровать";
            this.btnEncryptText.UseVisualStyleBackColor = true;
            this.btnEncryptText.Click += new System.EventHandler(this.btnEncryptText_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 44);
            this.label6.TabIndex = 2;
            this.label6.Text = "n = ";
            // 
            // tbEncryptText
            // 
            this.tbEncryptText.Location = new System.Drawing.Point(16, 127);
            this.tbEncryptText.Multiline = true;
            this.tbEncryptText.Name = "tbEncryptText";
            this.tbEncryptText.Size = new System.Drawing.Size(336, 128);
            this.tbEncryptText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kc =";
            // 
            // tbKsEC
            // 
            this.tbKsEC.Location = new System.Drawing.Point(369, 63);
            this.tbKsEC.Name = "tbKsEC";
            this.tbKsEC.Size = new System.Drawing.Size(156, 50);
            this.tbKsEC.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbN1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbP);
            this.groupBox3.Controls.Add(this.tbKs);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbFi);
            this.groupBox3.Controls.Add(this.tbQ);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbKo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 215);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Генерация ключей";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 44);
            this.label10.TabIndex = 14;
            this.label10.Text = " φ =";
            // 
            // tbN1
            // 
            this.tbN1.Location = new System.Drawing.Point(276, 54);
            this.tbN1.Name = "tbN1";
            this.tbN1.ReadOnly = true;
            this.tbN1.Size = new System.Drawing.Size(94, 50);
            this.tbN1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "n =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(528, 627);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(424, 46);
            this.label11.TabIndex = 17;
            this.label11.Text = "Kc - секретный ключ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(528, 683);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(407, 46);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kо - открытый ключ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(26, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(418, 46);
            this.label13.TabIndex = 19;
            this.label13.Text = "p, q - простые числа";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(26, 627);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 46);
            this.label14.TabIndex = 20;
            this.label14.Text = "n=p*q";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(12, 683);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(274, 46);
            this.label15.TabIndex = 21;
            this.label15.Text = " φ=(p-1)*(q-1)";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(528, 571);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(661, 46);
            this.label16.TabIndex = 22;
            this.label16.Text = "Kc и Ко - взаимнопростые числа";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(528, 738);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(390, 46);
            this.label17.TabIndex = 23;
            this.label17.Text = "(Ko * Kc) mod φ = 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 1055);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKs;
        private System.Windows.Forms.TextBox tbTextToCrypt;
        private System.Windows.Forms.TextBox tbCryptText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKo;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTextToEncrypt;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button btnEncryptText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEncryptText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbKsEC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbN1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKo1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbN2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

