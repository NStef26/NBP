namespace Autoshop
{
    partial class Pretraga
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxMarka = new System.Windows.Forms.ComboBox();
            this.cBoxModel = new System.Windows.Forms.ComboBox();
            this.cBoxKomponente = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmsUD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista delova:";
            // 
            // cBoxMarka
            // 
            this.cBoxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMarka.FormattingEnabled = true;
            this.cBoxMarka.Location = new System.Drawing.Point(129, 23);
            this.cBoxMarka.Name = "cBoxMarka";
            this.cBoxMarka.Size = new System.Drawing.Size(121, 21);
            this.cBoxMarka.TabIndex = 3;
            this.cBoxMarka.SelectedValueChanged += new System.EventHandler(this.cBoxMarka_SelectedValueChanged);
            // 
            // cBoxModel
            // 
            this.cBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxModel.FormattingEnabled = true;
            this.cBoxModel.Location = new System.Drawing.Point(129, 65);
            this.cBoxModel.Name = "cBoxModel";
            this.cBoxModel.Size = new System.Drawing.Size(121, 21);
            this.cBoxModel.TabIndex = 4;
            this.cBoxModel.SelectedValueChanged += new System.EventHandler(this.cBoxModel_SelectedValueChanged);
            // 
            // cBoxKomponente
            // 
            this.cBoxKomponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxKomponente.FormattingEnabled = true;
            this.cBoxKomponente.Location = new System.Drawing.Point(129, 113);
            this.cBoxKomponente.Name = "cBoxKomponente";
            this.cBoxKomponente.Size = new System.Drawing.Size(121, 21);
            this.cBoxKomponente.TabIndex = 5;
            this.cBoxKomponente.SelectedValueChanged += new System.EventHandler(this.cBoxKomponente_SelectedValueChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(281, 23);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(648, 384);
            this.dgv.TabIndex = 6;
            this.dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // cmsUD
            // 
            this.cmsUD.Name = "cmsUD";
            this.cmsUD.Size = new System.Drawing.Size(61, 4);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(24, 19);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(147, 23);
            this.btnKupi.TabIndex = 7;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(24, 60);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(147, 23);
            this.btnPonisti.TabIndex = 8;
            this.btnPonisti.Text = "Isprazni korpu";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKupi);
            this.groupBox1.Controls.Add(this.btnPonisti);
            this.groupBox1.Location = new System.Drawing.Point(31, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korpa";
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cBoxKomponente);
            this.Controls.Add(this.cBoxModel);
            this.Controls.Add(this.cBoxMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxMarka;
        private System.Windows.Forms.ComboBox cBoxModel;
        private System.Windows.Forms.ComboBox cBoxKomponente;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cmsUD;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}