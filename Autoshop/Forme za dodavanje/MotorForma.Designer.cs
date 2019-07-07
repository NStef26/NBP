namespace Autoshop.Forme_za_dodavanje
{
    partial class MotorForma
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.numKonjske = new System.Windows.Forms.NumericUpDown();
            this.numKubikaza = new System.Windows.Forms.NumericUpDown();
            this.numKilovati = new System.Windows.Forms.NumericUpDown();
            this.tBoxMarka = new System.Windows.Forms.TextBox();
            this.tBoxModel = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKonjske)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKubikaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilovati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolicina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Konjske snage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kubikaza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kilovati:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vrsta goriva:";
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(109, 35);
            this.numCena.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(120, 20);
            this.numCena.TabIndex = 8;
            this.numCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCena.Leave += new System.EventHandler(this.numCena_Leave);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(109, 64);
            this.numKolicina.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 20);
            this.numKolicina.TabIndex = 9;
            this.numKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKolicina.Leave += new System.EventHandler(this.numKolicina_Leave);
            // 
            // numKonjske
            // 
            this.numKonjske.Location = new System.Drawing.Point(109, 162);
            this.numKonjske.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numKonjske.Name = "numKonjske";
            this.numKonjske.Size = new System.Drawing.Size(120, 20);
            this.numKonjske.TabIndex = 12;
            this.numKonjske.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKonjske.Leave += new System.EventHandler(this.numKonjske_Leave);
            // 
            // numKubikaza
            // 
            this.numKubikaza.Location = new System.Drawing.Point(109, 195);
            this.numKubikaza.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numKubikaza.Name = "numKubikaza";
            this.numKubikaza.Size = new System.Drawing.Size(120, 20);
            this.numKubikaza.TabIndex = 13;
            this.numKubikaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKubikaza.Leave += new System.EventHandler(this.numKubikaza_Leave);
            // 
            // numKilovati
            // 
            this.numKilovati.Location = new System.Drawing.Point(109, 230);
            this.numKilovati.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numKilovati.Name = "numKilovati";
            this.numKilovati.Size = new System.Drawing.Size(120, 20);
            this.numKilovati.TabIndex = 14;
            this.numKilovati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKilovati.Leave += new System.EventHandler(this.numKilovati_Leave);
            // 
            // tBoxMarka
            // 
            this.tBoxMarka.Location = new System.Drawing.Point(109, 100);
            this.tBoxMarka.Name = "tBoxMarka";
            this.tBoxMarka.Size = new System.Drawing.Size(120, 20);
            this.tBoxMarka.TabIndex = 10;
            this.tBoxMarka.Leave += new System.EventHandler(this.tBoxMarka_Leave);
            // 
            // tBoxModel
            // 
            this.tBoxModel.Location = new System.Drawing.Point(109, 128);
            this.tBoxModel.Name = "tBoxModel";
            this.tBoxModel.Size = new System.Drawing.Size(120, 20);
            this.tBoxModel.TabIndex = 11;
            this.tBoxModel.Leave += new System.EventHandler(this.tBoxModel_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "TNG"});
            this.comboBox1.Location = new System.Drawing.Point(108, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MotorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tBoxModel);
            this.Controls.Add(this.tBoxMarka);
            this.Controls.Add(this.numKilovati);
            this.Controls.Add(this.numKubikaza);
            this.Controls.Add(this.numKonjske);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MotorForma";
            this.Text = "Dodaj motor";
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKonjske)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKubikaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilovati)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.NumericUpDown numKonjske;
        private System.Windows.Forms.NumericUpDown numKubikaza;
        private System.Windows.Forms.NumericUpDown numKilovati;
        private System.Windows.Forms.TextBox tBoxMarka;
        private System.Windows.Forms.TextBox tBoxModel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}