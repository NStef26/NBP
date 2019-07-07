namespace Autoshop.Forme_za_dodavanje
{
    partial class BrisacForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.tBoxModel = new System.Windows.Forms.TextBox();
            this.tBoxMarka = new System.Windows.Forms.TextBox();
            this.tBoxDimenzija = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolicina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dimenzija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tip:";
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(99, 33);
            this.numCena.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(100, 20);
            this.numCena.TabIndex = 1;
            this.numCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCena.Leave += new System.EventHandler(this.numCena_Leave);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(99, 68);
            this.numKolicina.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(100, 20);
            this.numKolicina.TabIndex = 2;
            this.numKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKolicina.Leave += new System.EventHandler(this.numKolicina_Leave);
            // 
            // tBoxModel
            // 
            this.tBoxModel.Location = new System.Drawing.Point(99, 106);
            this.tBoxModel.Name = "tBoxModel";
            this.tBoxModel.Size = new System.Drawing.Size(100, 20);
            this.tBoxModel.TabIndex = 3;
            this.tBoxModel.Leave += new System.EventHandler(this.tBoxModel_Leave);
            // 
            // tBoxMarka
            // 
            this.tBoxMarka.Location = new System.Drawing.Point(99, 145);
            this.tBoxMarka.Name = "tBoxMarka";
            this.tBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.tBoxMarka.TabIndex = 4;
            this.tBoxMarka.TextChanged += new System.EventHandler(this.tBoxMarka_TextChanged);
            // 
            // tBoxDimenzija
            // 
            this.tBoxDimenzija.Location = new System.Drawing.Point(99, 185);
            this.tBoxDimenzija.Name = "tBoxDimenzija";
            this.tBoxDimenzija.Size = new System.Drawing.Size(100, 20);
            this.tBoxDimenzija.TabIndex = 5;
            this.tBoxDimenzija.TextChanged += new System.EventHandler(this.tBoxDimenzija_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxTip
            // 
            this.cBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTip.FormattingEnabled = true;
            this.cBoxTip.ItemHeight = 13;
            this.cBoxTip.Items.AddRange(new object[] {
            "Prednji",
            "Zadnji"});
            this.cBoxTip.Location = new System.Drawing.Point(99, 223);
            this.cBoxTip.Name = "cBoxTip";
            this.cBoxTip.Size = new System.Drawing.Size(100, 21);
            this.cBoxTip.TabIndex = 6;
            this.cBoxTip.Leave += new System.EventHandler(this.cBoxTip_Leave);
            // 
            // BrisacForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 334);
            this.Controls.Add(this.cBoxTip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxDimenzija);
            this.Controls.Add(this.tBoxMarka);
            this.Controls.Add(this.tBoxModel);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BrisacForma";
            this.Text = "Dodaj brisac";
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.TextBox tBoxModel;
        private System.Windows.Forms.TextBox tBoxMarka;
        private System.Windows.Forms.TextBox tBoxDimenzija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBoxTip;
    }
}