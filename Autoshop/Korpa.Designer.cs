namespace Autoshop
{
    partial class Korpa
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
            this.lBox = new System.Windows.Forms.ListBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(12, 12);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(313, 160);
            this.lBox.TabIndex = 0;
            this.lBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBox_MouseDoubleClick);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(27, 226);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(115, 23);
            this.btnUkloni.TabIndex = 1;
            this.btnUkloni.Text = "Izbaci iz korpe";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(181, 226);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(115, 23);
            this.btnKupi.TabIndex = 2;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(106, 192);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(86, 13);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Ukupna cena je ";
            // 
            // Korpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.lBox);
            this.Name = "Korpa";
            this.Text = "Korpa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Label lblCena;
    }
}