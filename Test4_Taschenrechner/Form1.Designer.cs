
namespace Test4_Taschenrechner
{
    partial class Taschenrechner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitel = new System.Windows.Forms.Label();
            this.txtZahl1 = new System.Windows.Forms.TextBox();
            this.btnZeichen = new System.Windows.Forms.Button();
            this.txtZahl2 = new System.Windows.Forms.TextBox();
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.ofdDatei = new System.Windows.Forms.OpenFileDialog();
            this.btnDatei = new System.Windows.Forms.Button();
            this.lbDatei = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitel.ForeColor = System.Drawing.Color.Orange;
            this.lbTitel.Location = new System.Drawing.Point(208, 53);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(314, 35);
            this.lbTitel.TabIndex = 0;
            this.lbTitel.Text = "Einfacher Taschenrechner";
            // 
            // txtZahl1
            // 
            this.txtZahl1.Location = new System.Drawing.Point(39, 184);
            this.txtZahl1.Name = "txtZahl1";
            this.txtZahl1.Size = new System.Drawing.Size(100, 23);
            this.txtZahl1.TabIndex = 1;
            // 
            // btnZeichen
            // 
            this.btnZeichen.Location = new System.Drawing.Point(167, 183);
            this.btnZeichen.Name = "btnZeichen";
            this.btnZeichen.Size = new System.Drawing.Size(75, 23);
            this.btnZeichen.TabIndex = 2;
            this.btnZeichen.Text = "+";
            this.btnZeichen.UseVisualStyleBackColor = true;
            this.btnZeichen.Click += new System.EventHandler(this.btnZeichen_Click);
            // 
            // txtZahl2
            // 
            this.txtZahl2.Location = new System.Drawing.Point(270, 183);
            this.txtZahl2.Name = "txtZahl2";
            this.txtZahl2.Size = new System.Drawing.Size(100, 23);
            this.txtZahl2.TabIndex = 3;
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.Location = new System.Drawing.Point(413, 184);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(75, 23);
            this.btnAusgabe.TabIndex = 4;
            this.btnAusgabe.Text = "=";
            this.btnAusgabe.UseVisualStyleBackColor = true;
            this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.AcceptsReturn = true;
            this.txtAusgabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAusgabe.Location = new System.Drawing.Point(535, 183);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(100, 23);
            this.txtAusgabe.TabIndex = 5;
            // 
            // ofdDatei
            // 
            this.ofdDatei.FileName = "openFileDialog1";
            this.ofdDatei.Filter = "Taschenrechner Datei|*.etr";
            // 
            // btnDatei
            // 
            this.btnDatei.Location = new System.Drawing.Point(39, 123);
            this.btnDatei.Name = "btnDatei";
            this.btnDatei.Size = new System.Drawing.Size(174, 23);
            this.btnDatei.TabIndex = 6;
            this.btnDatei.Text = "Protokolldatei auswählen";
            this.btnDatei.UseVisualStyleBackColor = true;
            this.btnDatei.Click += new System.EventHandler(this.btnDatei_Click);
            // 
            // lbDatei
            // 
            this.lbDatei.AutoSize = true;
            this.lbDatei.Location = new System.Drawing.Point(285, 123);
            this.lbDatei.Name = "lbDatei";
            this.lbDatei.Size = new System.Drawing.Size(0, 15);
            this.lbDatei.TabIndex = 7;
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 303);
            this.Controls.Add(this.lbDatei);
            this.Controls.Add(this.btnDatei);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.btnAusgabe);
            this.Controls.Add(this.txtZahl2);
            this.Controls.Add(this.btnZeichen);
            this.Controls.Add(this.txtZahl1);
            this.Controls.Add(this.lbTitel);
            this.Name = "Taschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TextBox txtZahl1;
        private System.Windows.Forms.Button btnZeichen;
        private System.Windows.Forms.TextBox txtZahl2;
        private System.Windows.Forms.Button btnAusgabe;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.OpenFileDialog ofdDatei;
        private System.Windows.Forms.Button btnDatei;
        private System.Windows.Forms.Label lbDatei;
    }
}

