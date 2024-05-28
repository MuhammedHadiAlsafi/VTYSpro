namespace VTYSpro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ekle = new System.Windows.Forms.Button();
            this.favore = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GameAw = new System.Windows.Forms.Button();
            this.Oyun = new System.Windows.Forms.Button();
            this.Sirket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Veritablo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Veritablo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.Ekle);
            this.panel1.Controls.Add(this.favore);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.GameAw);
            this.panel1.Controls.Add(this.Oyun);
            this.panel1.Controls.Add(this.Sirket);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 620);
            this.panel1.TabIndex = 0;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(3, 594);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(244, 23);
            this.Ekle.TabIndex = 8;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // favore
            // 
            this.favore.BackColor = System.Drawing.Color.Gold;
            this.favore.Location = new System.Drawing.Point(3, 363);
            this.favore.Name = "favore";
            this.favore.Size = new System.Drawing.Size(244, 44);
            this.favore.TabIndex = 7;
            this.favore.Text = "favore";
            this.favore.UseVisualStyleBackColor = false;
            this.favore.Click += new System.EventHandler(this.favore_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // GameAw
            // 
            this.GameAw.BackColor = System.Drawing.Color.Gold;
            this.GameAw.Location = new System.Drawing.Point(3, 263);
            this.GameAw.Name = "GameAw";
            this.GameAw.Size = new System.Drawing.Size(244, 44);
            this.GameAw.TabIndex = 4;
            this.GameAw.Text = "GameAw";
            this.GameAw.UseVisualStyleBackColor = false;
            this.GameAw.Click += new System.EventHandler(this.GameAw_Click);
            // 
            // Oyun
            // 
            this.Oyun.BackColor = System.Drawing.Color.Gold;
            this.Oyun.Location = new System.Drawing.Point(3, 213);
            this.Oyun.Name = "Oyun";
            this.Oyun.Size = new System.Drawing.Size(244, 44);
            this.Oyun.TabIndex = 2;
            this.Oyun.Text = "Oyunlar";
            this.Oyun.UseVisualStyleBackColor = false;
            this.Oyun.Click += new System.EventHandler(this.Oyun_Click);
            // 
            // Sirket
            // 
            this.Sirket.BackColor = System.Drawing.Color.Gold;
            this.Sirket.Location = new System.Drawing.Point(3, 313);
            this.Sirket.Name = "Sirket";
            this.Sirket.Size = new System.Drawing.Size(244, 44);
            this.Sirket.TabIndex = 1;
            this.Sirket.Text = "Şirketler";
            this.Sirket.UseVisualStyleBackColor = false;
            this.Sirket.Click += new System.EventHandler(this.Sirket_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(268, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 82);
            this.panel2.TabIndex = 1;
            // 
            // Veritablo
            // 
            this.Veritablo.AllowUserToAddRows = false;
            this.Veritablo.AllowUserToDeleteRows = false;
            this.Veritablo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Veritablo.ColumnHeadersHeight = 29;
            this.Veritablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Veritablo.Location = new System.Drawing.Point(268, 100);
            this.Veritablo.Name = "Veritablo";
            this.Veritablo.ReadOnly = true;
            this.Veritablo.RowHeadersWidth = 51;
            this.Veritablo.RowTemplate.Height = 24;
            this.Veritablo.Size = new System.Drawing.Size(818, 532);
            this.Veritablo.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 643);
            this.Controls.Add(this.Veritablo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Veritablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GameAw;
        private System.Windows.Forms.Button Oyun;
        private System.Windows.Forms.Button Sirket;
        private System.Windows.Forms.DataGridView Veritablo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button favore;
        private System.Windows.Forms.Button Ekle;
    }
}