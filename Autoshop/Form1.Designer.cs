namespace Autoshop
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.cBoxMarka = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cBoxModel = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cBoxDodaj = new System.Windows.Forms.ComboBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(49, 26);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(94, 13);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka automobila:";
            // 
            // cBoxMarka
            // 
            this.cBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMarka.FormattingEnabled = true;
            this.cBoxMarka.Location = new System.Drawing.Point(36, 52);
            this.cBoxMarka.Name = "cBoxMarka";
            this.cBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.cBoxMarka.TabIndex = 1;
            this.cBoxMarka.SelectedValueChanged += new System.EventHandler(this.cBoxMarka_SelectedValueChanged);
            this.cBoxMarka.TextChanged += new System.EventHandler(this.cBoxMarka_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(49, 94);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(93, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model automobila:";
            // 
            // cBoxModel
            // 
            this.cBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxModel.FormattingEnabled = true;
            this.cBoxModel.Location = new System.Drawing.Point(36, 125);
            this.cBoxModel.Name = "cBoxModel";
            this.cBoxModel.Size = new System.Drawing.Size(121, 21);
            this.cBoxModel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Inicijalizuj bazu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cBoxDodaj
            // 
            this.cBoxDodaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDodaj.FormattingEnabled = true;
            this.cBoxDodaj.Items.AddRange(new object[] {
            "Akumulatori",
            "Brisaci",
            "Dodatna Oprema",
            "Farovi",
            "Motor",
            "Pneumatici",
            "Rashladni Sistem",
            "Retrovizor",
            "Sijalice",
            "Stakla"});
            this.cBoxDodaj.Location = new System.Drawing.Point(6, 19);
            this.cBoxDodaj.Name = "cBoxDodaj";
            this.cBoxDodaj.Size = new System.Drawing.Size(148, 21);
            this.cBoxDodaj.TabIndex = 8;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(45, 55);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 9;
            this.Dodaj.Text = "Odaberi";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Pretrazivanje";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxDodaj);
            this.groupBox1.Controls.Add(this.Dodaj);
            this.groupBox1.Location = new System.Drawing.Point(235, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj komponente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(25, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inicijalizacija baze";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(235, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 80);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretrazuj komponente:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBoxMarka);
            this.groupBox4.Controls.Add(this.lblMarka);
            this.groupBox4.Controls.Add(this.lblModel);
            this.groupBox4.Controls.Add(this.cBoxModel);
            this.groupBox4.Location = new System.Drawing.Point(25, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 159);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pregledaj sve marke i modele:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kliknuti samo jednom!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 313);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Autoshop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cBoxMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cBoxModel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cBoxDodaj;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}

