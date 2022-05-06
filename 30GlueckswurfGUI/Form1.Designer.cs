
namespace _30GlueckswurfGUI
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
            this.txtGuthaben = new System.Windows.Forms.TextBox();
            this.nudEinsatz = new System.Windows.Forms.NumericUpDown();
            this.lbEinsatz = new System.Windows.Forms.Label();
            this.lbGuthaben = new System.Windows.Forms.Label();
            this.lbGewinnchance = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSpielen = new System.Windows.Forms.Button();
            this.txtWuerfel1 = new System.Windows.Forms.TextBox();
            this.txtWuerfel2 = new System.Windows.Forms.TextBox();
            this.txtWuerfel3 = new System.Windows.Forms.TextBox();
            this.lbGewinn = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuthaben
            // 
            this.txtGuthaben.Location = new System.Drawing.Point(35, 27);
            this.txtGuthaben.Name = "txtGuthaben";
            this.txtGuthaben.ReadOnly = true;
            this.txtGuthaben.Size = new System.Drawing.Size(100, 23);
            this.txtGuthaben.TabIndex = 0;
            // 
            // nudEinsatz
            // 
            this.nudEinsatz.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEinsatz.Location = new System.Drawing.Point(164, 28);
            this.nudEinsatz.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEinsatz.Name = "nudEinsatz";
            this.nudEinsatz.ReadOnly = true;
            this.nudEinsatz.Size = new System.Drawing.Size(120, 23);
            this.nudEinsatz.TabIndex = 1;
            this.nudEinsatz.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEinsatz.ValueChanged += new System.EventHandler(this.nudEinsatz_ValueChanged);
            // 
            // lbEinsatz
            // 
            this.lbEinsatz.AutoSize = true;
            this.lbEinsatz.Location = new System.Drawing.Point(164, 9);
            this.lbEinsatz.Name = "lbEinsatz";
            this.lbEinsatz.Size = new System.Drawing.Size(43, 15);
            this.lbEinsatz.TabIndex = 2;
            this.lbEinsatz.Text = "Einsatz";
            // 
            // lbGuthaben
            // 
            this.lbGuthaben.AutoSize = true;
            this.lbGuthaben.Location = new System.Drawing.Point(35, 9);
            this.lbGuthaben.Name = "lbGuthaben";
            this.lbGuthaben.Size = new System.Drawing.Size(59, 15);
            this.lbGuthaben.TabIndex = 3;
            this.lbGuthaben.Text = "Guthaben";
            // 
            // lbGewinnchance
            // 
            this.lbGewinnchance.AutoSize = true;
            this.lbGewinnchance.Location = new System.Drawing.Point(353, 9);
            this.lbGewinnchance.Name = "lbGewinnchance";
            this.lbGewinnchance.Size = new System.Drawing.Size(117, 15);
            this.lbGewinnchance.TabIndex = 4;
            this.lbGewinnchance.Text = "<<Gewinnchance>>";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(152, 151);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(233, 151);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(314, 151);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(395, 151);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(476, 151);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(557, 151);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btnSpielen
            // 
            this.btnSpielen.Enabled = false;
            this.btnSpielen.Location = new System.Drawing.Point(314, 180);
            this.btnSpielen.Name = "btnSpielen";
            this.btnSpielen.Size = new System.Drawing.Size(156, 23);
            this.btnSpielen.TabIndex = 11;
            this.btnSpielen.Text = "Spielen und Gewinnen";
            this.btnSpielen.UseVisualStyleBackColor = true;
            this.btnSpielen.Click += new System.EventHandler(this.btnSpielen_Click);
            // 
            // txtWuerfel1
            // 
            this.txtWuerfel1.Location = new System.Drawing.Point(234, 220);
            this.txtWuerfel1.Multiline = true;
            this.txtWuerfel1.Name = "txtWuerfel1";
            this.txtWuerfel1.ReadOnly = true;
            this.txtWuerfel1.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel1.TabIndex = 12;
            // 
            // txtWuerfel2
            // 
            this.txtWuerfel2.Location = new System.Drawing.Point(340, 220);
            this.txtWuerfel2.Multiline = true;
            this.txtWuerfel2.Name = "txtWuerfel2";
            this.txtWuerfel2.ReadOnly = true;
            this.txtWuerfel2.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel2.TabIndex = 13;
            // 
            // txtWuerfel3
            // 
            this.txtWuerfel3.Location = new System.Drawing.Point(446, 220);
            this.txtWuerfel3.Multiline = true;
            this.txtWuerfel3.Name = "txtWuerfel3";
            this.txtWuerfel3.ReadOnly = true;
            this.txtWuerfel3.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel3.TabIndex = 14;
            // 
            // lbGewinn
            // 
            this.lbGewinn.AutoSize = true;
            this.lbGewinn.Location = new System.Drawing.Point(353, 324);
            this.lbGewinn.Name = "lbGewinn";
            this.lbGewinn.Size = new System.Drawing.Size(79, 15);
            this.lbGewinn.TabIndex = 15;
            this.lbGewinn.Text = "<<Gewinn>>";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(660, 395);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Nächstes Spiel";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbGewinn);
            this.Controls.Add(this.txtWuerfel3);
            this.Controls.Add(this.txtWuerfel2);
            this.Controls.Add(this.txtWuerfel1);
            this.Controls.Add(this.btnSpielen);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbGewinnchance);
            this.Controls.Add(this.lbGuthaben);
            this.Controls.Add(this.lbEinsatz);
            this.Controls.Add(this.nudEinsatz);
            this.Controls.Add(this.txtGuthaben);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Glückswurf";
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuthaben;
        private System.Windows.Forms.NumericUpDown nudEinsatz;
        private System.Windows.Forms.Label lbEinsatz;
        private System.Windows.Forms.Label lbGuthaben;
        private System.Windows.Forms.Label lbGewinnchance;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSpielen;
        private System.Windows.Forms.TextBox txtWuerfel1;
        private System.Windows.Forms.TextBox txtWuerfel2;
        private System.Windows.Forms.TextBox txtWuerfel3;
        private System.Windows.Forms.Label lbGewinn;
        private System.Windows.Forms.Button btnNext;
    }
}

