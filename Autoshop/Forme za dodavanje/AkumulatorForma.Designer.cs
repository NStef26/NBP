namespace Autoshop.Forme_za_dodavanje
{
    partial class AkumulatorForma
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
            this.tBoxDim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.numVoltaza = new System.Windows.Forms.NumericUpDown();
            this.numKapacitet = new System.Windows.Forms.NumericUpDown();
            this.numSnaga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoltaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapacitet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolicina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voltaza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kapacitet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Snaga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dimenzije";
            // 
            // tBoxDim
            // 
            this.tBoxDim.Location = new System.Drawing.Point(87, 223);
            this.tBoxDim.Name = "tBoxDim";
            this.tBoxDim.Size = new System.Drawing.Size(100, 20);
            this.tBoxDim.TabIndex = 6;
            
            this.tBoxDim.Leave += new System.EventHandler(this.tBoxDim_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(89, 44);
            this.numCena.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(98, 20);
            this.numCena.TabIndex = 1;
            this.numCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCena.Leave += new System.EventHandler(this.numCena_Leave);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(89, 78);
            this.numKolicina.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(98, 20);
            this.numKolicina.TabIndex = 2;
            this.numKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKolicina.Leave += new System.EventHandler(this.numKolicina_Leave);
            // 
            // numVoltaza
            // 
            this.numVoltaza.Location = new System.Drawing.Point(87, 113);
            this.numVoltaza.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numVoltaza.Name = "numVoltaza";
            this.numVoltaza.Size = new System.Drawing.Size(98, 20);
            this.numVoltaza.TabIndex = 3;
            this.numVoltaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVoltaza.Leave += new System.EventHandler(this.numVoltaza_Leave);
            // 
            // numKapacitet
            // 
            this.numKapacitet.Location = new System.Drawing.Point(89, 150);
            this.numKapacitet.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numKapacitet.Name = "numKapacitet";
            this.numKapacitet.Size = new System.Drawing.Size(98, 20);
            this.numKapacitet.TabIndex = 4;
            this.numKapacitet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKapacitet.Leave += new System.EventHandler(this.numKapacitet_Leave);
            // 
            // numSnaga
            // 
            this.numSnaga.Location = new System.Drawing.Point(87, 188);
            this.numSnaga.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numSnaga.Name = "numSnaga";
            this.numSnaga.Size = new System.Drawing.Size(98, 20);
            this.numSnaga.TabIndex = 5;
            this.numSnaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSnaga.Leave += new System.EventHandler(this.numSnaga_Leave);
            // 
            // AkumulatorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 337);
            this.Controls.Add(this.numSnaga);
            this.Controls.Add(this.numKapacitet);
            this.Controls.Add(this.numVoltaza);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxDim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AkumulatorForma";
            this.Text = "Dodaj akumulator";
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoltaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapacitet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnaga)).EndInit();
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
        private System.Windows.Forms.TextBox tBoxDim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.NumericUpDown numVoltaza;
        private System.Windows.Forms.NumericUpDown numKapacitet;
        private System.Windows.Forms.NumericUpDown numSnaga;
    }
}