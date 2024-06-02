namespace VTYSpro
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sirketRB = new System.Windows.Forms.RadioButton();
            this.oyunRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.var5 = new System.Windows.Forms.ComboBox();
            this.Kazanan = new System.Windows.Forms.RadioButton();
            this.var6 = new System.Windows.Forms.ComboBox();
            this.Aday = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.var4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.var3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.var2 = new System.Windows.Forms.ComboBox();
            this.Sil = new System.Windows.Forms.Button();
            this.var1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(215, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oyun Türü";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.var1);
            this.panel1.Controls.Add(this.sirketRB);
            this.panel1.Controls.Add(this.oyunRB);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.var4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.var3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.var2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 391);
            this.panel1.TabIndex = 3;
            // 
            // sirketRB
            // 
            this.sirketRB.AutoSize = true;
            this.sirketRB.Location = new System.Drawing.Point(320, 3);
            this.sirketRB.Name = "sirketRB";
            this.sirketRB.Size = new System.Drawing.Size(62, 20);
            this.sirketRB.TabIndex = 18;
            this.sirketRB.Text = "Şirket";
            this.sirketRB.UseVisualStyleBackColor = true;
            this.sirketRB.Click += new System.EventHandler(this.sirketRB_Click);
            // 
            // oyunRB
            // 
            this.oyunRB.AutoSize = true;
            this.oyunRB.Checked = true;
            this.oyunRB.Location = new System.Drawing.Point(6, 3);
            this.oyunRB.Name = "oyunRB";
            this.oyunRB.Size = new System.Drawing.Size(59, 20);
            this.oyunRB.TabIndex = 17;
            this.oyunRB.TabStop = true;
            this.oyunRB.Text = "Oyun";
            this.oyunRB.UseVisualStyleBackColor = true;
            this.oyunRB.Click += new System.EventHandler(this.oyunRB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.var5);
            this.groupBox1.Controls.Add(this.Kazanan);
            this.groupBox1.Controls.Add(this.var6);
            this.groupBox1.Controls.Add(this.Aday);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 128);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // var5
            // 
            this.var5.FormattingEnabled = true;
            this.var5.Location = new System.Drawing.Point(93, 20);
            this.var5.Name = "var5";
            this.var5.Size = new System.Drawing.Size(289, 24);
            this.var5.TabIndex = 10;
            // 
            // Kazanan
            // 
            this.Kazanan.AutoSize = true;
            this.Kazanan.Location = new System.Drawing.Point(203, 102);
            this.Kazanan.Name = "Kazanan";
            this.Kazanan.Size = new System.Drawing.Size(80, 20);
            this.Kazanan.TabIndex = 13;
            this.Kazanan.TabStop = true;
            this.Kazanan.Text = "Kazanan";
            this.Kazanan.UseVisualStyleBackColor = true;
            // 
            // var6
            // 
            this.var6.FormattingEnabled = true;
            this.var6.Location = new System.Drawing.Point(93, 56);
            this.var6.Name = "var6";
            this.var6.Size = new System.Drawing.Size(289, 24);
            this.var6.TabIndex = 11;
            // 
            // Aday
            // 
            this.Aday.AutoSize = true;
            this.Aday.Checked = true;
            this.Aday.Location = new System.Drawing.Point(93, 102);
            this.Aday.Name = "Aday";
            this.Aday.Size = new System.Drawing.Size(60, 20);
            this.Aday.TabIndex = 12;
            this.Aday.TabStop = true;
            this.Aday.Text = "Aday";
            this.Aday.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kategori";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Game Awards";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // var4
            // 
            this.var4.Location = new System.Drawing.Point(99, 169);
            this.var4.Name = "var4";
            this.var4.Size = new System.Drawing.Size(283, 22);
            this.var4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oyun çıkış yılı";
            // 
            // var3
            // 
            this.var3.FormattingEnabled = true;
            this.var3.Items.AddRange(new object[] {
            "RPG",
            "FBS",
            "MMO",
            "MOBA"});
            this.var3.Location = new System.Drawing.Point(99, 128);
            this.var3.Name = "var3";
            this.var3.Size = new System.Drawing.Size(283, 24);
            this.var3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oyun Şirketi";
            // 
            // var2
            // 
            this.var2.FormattingEnabled = true;
            this.var2.Items.AddRange(new object[] {
            "RPG",
            "MOBA",
            "FPS",
            "MMO"});
            this.var2.Location = new System.Drawing.Point(93, 84);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(289, 24);
            this.var2.TabIndex = 4;
            this.var2.Text = "  ";
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.DimGray;
            this.Sil.Location = new System.Drawing.Point(12, 409);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(193, 29);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // var1
            // 
            this.var1.FormattingEnabled = true;
            this.var1.Location = new System.Drawing.Point(93, 48);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(289, 24);
            this.var1.TabIndex = 19;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Oyun ekle";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox var2;
        private System.Windows.Forms.ComboBox var3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox var4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Kazanan;
        private System.Windows.Forms.RadioButton Aday;
        private System.Windows.Forms.ComboBox var6;
        private System.Windows.Forms.ComboBox var5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sirketRB;
        private System.Windows.Forms.RadioButton oyunRB;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.ComboBox var1;
    }
}