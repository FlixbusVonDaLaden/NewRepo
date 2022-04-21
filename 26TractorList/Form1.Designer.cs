
namespace _26TractorList
{
    partial class Form1
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
            this.txtMarke = new System.Windows.Forms.TextBox();
            this.txtBez = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lbMarke = new System.Windows.Forms.Label();
            this.lbBez = new System.Windows.Forms.Label();
            this.lbPower = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMarke
            // 
            this.txtMarke.Location = new System.Drawing.Point(38, 55);
            this.txtMarke.Name = "txtMarke";
            this.txtMarke.Size = new System.Drawing.Size(261, 23);
            this.txtMarke.TabIndex = 0;
            this.txtMarke.TextChanged += new System.EventHandler(this.txtMarke_TextChanged);
            // 
            // txtBez
            // 
            this.txtBez.Location = new System.Drawing.Point(38, 114);
            this.txtBez.Name = "txtBez";
            this.txtBez.Size = new System.Drawing.Size(261, 23);
            this.txtBez.TabIndex = 1;
            this.txtBez.TextChanged += new System.EventHandler(this.txtMarke_TextChanged);
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(38, 173);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(261, 23);
            this.txtPower.TabIndex = 2;
            this.txtPower.TextChanged += new System.EventHandler(this.txtMarke_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(166, 250);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(155, 45);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Hinzufügen";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(534, 250);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(124, 45);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Liste löschen";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lbMarke
            // 
            this.lbMarke.AutoSize = true;
            this.lbMarke.Location = new System.Drawing.Point(38, 37);
            this.lbMarke.Name = "lbMarke";
            this.lbMarke.Size = new System.Drawing.Size(40, 15);
            this.lbMarke.TabIndex = 5;
            this.lbMarke.Text = "Marke";
            // 
            // lbBez
            // 
            this.lbBez.AutoSize = true;
            this.lbBez.Location = new System.Drawing.Point(38, 96);
            this.lbBez.Name = "lbBez";
            this.lbBez.Size = new System.Drawing.Size(75, 15);
            this.lbBez.TabIndex = 6;
            this.lbBez.Text = "Bezeichnung";
            // 
            // lbPower
            // 
            this.lbPower.AutoSize = true;
            this.lbPower.Location = new System.Drawing.Point(38, 155);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(52, 15);
            this.lbPower.TabIndex = 7;
            this.lbPower.Text = "Leistung";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(457, 37);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(261, 164);
            this.txtList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.lbPower);
            this.Controls.Add(this.lbBez);
            this.Controls.Add(this.lbMarke);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtBez);
            this.Controls.Add(this.txtMarke);
            this.Name = "Form1";
            this.Text = "Traktorliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarke;
        private System.Windows.Forms.TextBox txtBez;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lbMarke;
        private System.Windows.Forms.Label lbBez;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.TextBox txtList;
    }
}

