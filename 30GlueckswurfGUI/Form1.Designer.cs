
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGuthaben = new System.Windows.Forms.TextBox();
            this.nudEinsatz = new System.Windows.Forms.NumericUpDown();
            this.lbEinsatz = new System.Windows.Forms.Label();
            this.lbGuthaben = new System.Windows.Forms.Label();
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lbGewinn = new System.Windows.Forms.Label();
            this.lbGewinnchance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEinsatz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGuthaben
            // 
            this.txtGuthaben.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtGuthaben.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuthaben.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGuthaben.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtGuthaben.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGuthaben.Location = new System.Drawing.Point(879, 152);
            this.txtGuthaben.Name = "txtGuthaben";
            this.txtGuthaben.ReadOnly = true;
            this.txtGuthaben.Size = new System.Drawing.Size(100, 40);
            this.txtGuthaben.TabIndex = 0;
            this.txtGuthaben.TextChanged += new System.EventHandler(this.txtGuthaben_TextChanged);
            // 
            // nudEinsatz
            // 
            this.nudEinsatz.BackColor = System.Drawing.Color.MidnightBlue;
            this.nudEinsatz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudEinsatz.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudEinsatz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nudEinsatz.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEinsatz.Location = new System.Drawing.Point(53, 150);
            this.nudEinsatz.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEinsatz.Name = "nudEinsatz";
            this.nudEinsatz.ReadOnly = true;
            this.nudEinsatz.Size = new System.Drawing.Size(100, 43);
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
            this.lbEinsatz.BackColor = System.Drawing.Color.Transparent;
            this.lbEinsatz.Font = new System.Drawing.Font("Magneto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEinsatz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbEinsatz.Location = new System.Drawing.Point(53, 111);
            this.lbEinsatz.Name = "lbEinsatz";
            this.lbEinsatz.Size = new System.Drawing.Size(135, 36);
            this.lbEinsatz.TabIndex = 2;
            this.lbEinsatz.Text = "Einsatz";
            this.lbEinsatz.Click += new System.EventHandler(this.lbEinsatz_Click);
            // 
            // lbGuthaben
            // 
            this.lbGuthaben.AutoSize = true;
            this.lbGuthaben.BackColor = System.Drawing.Color.Transparent;
            this.lbGuthaben.Font = new System.Drawing.Font("Magneto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGuthaben.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbGuthaben.Location = new System.Drawing.Point(860, 111);
            this.lbGuthaben.Name = "lbGuthaben";
            this.lbGuthaben.Size = new System.Drawing.Size(168, 36);
            this.lbGuthaben.TabIndex = 3;
            this.lbGuthaben.Text = "Guthaben";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.HotPink;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.Snow;
            this.btn1.Location = new System.Drawing.Point(276, 133);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.HotPink;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.Snow;
            this.btn2.Location = new System.Drawing.Point(357, 133);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.HotPink;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.Color.Snow;
            this.btn3.Location = new System.Drawing.Point(440, 133);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.HotPink;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ForeColor = System.Drawing.Color.Snow;
            this.btn4.Location = new System.Drawing.Point(521, 133);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.HotPink;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.Color.Snow;
            this.btn5.Location = new System.Drawing.Point(602, 133);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.HotPink;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ForeColor = System.Drawing.Color.Snow;
            this.btn6.Location = new System.Drawing.Point(683, 133);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnGlueckszahl_Click);
            // 
            // btnSpielen
            // 
            this.btnSpielen.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSpielen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpielen.Enabled = false;
            this.btnSpielen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpielen.ForeColor = System.Drawing.Color.Coral;
            this.btnSpielen.Location = new System.Drawing.Point(423, 298);
            this.btnSpielen.Name = "btnSpielen";
            this.btnSpielen.Size = new System.Drawing.Size(156, 23);
            this.btnSpielen.TabIndex = 11;
            this.btnSpielen.Text = "Spielen und Gewinnen";
            this.btnSpielen.UseVisualStyleBackColor = false;
            this.btnSpielen.Click += new System.EventHandler(this.btnSpielen_Click);
            // 
            // txtWuerfel1
            // 
            this.txtWuerfel1.BackColor = System.Drawing.Color.HotPink;
            this.txtWuerfel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWuerfel1.Location = new System.Drawing.Point(332, 182);
            this.txtWuerfel1.Multiline = true;
            this.txtWuerfel1.Name = "txtWuerfel1";
            this.txtWuerfel1.ReadOnly = true;
            this.txtWuerfel1.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel1.TabIndex = 12;
            this.txtWuerfel1.TabStop = false;
            this.txtWuerfel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWuerfel1.TextChanged += new System.EventHandler(this.txtWuerfel1_TextChanged);
            // 
            // txtWuerfel2
            // 
            this.txtWuerfel2.BackColor = System.Drawing.Color.HotPink;
            this.txtWuerfel2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWuerfel2.Location = new System.Drawing.Point(454, 182);
            this.txtWuerfel2.Multiline = true;
            this.txtWuerfel2.Name = "txtWuerfel2";
            this.txtWuerfel2.ReadOnly = true;
            this.txtWuerfel2.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel2.TabIndex = 13;
            this.txtWuerfel2.TabStop = false;
            this.txtWuerfel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWuerfel2.TextChanged += new System.EventHandler(this.txtWuerfel2_TextChanged);
            // 
            // txtWuerfel3
            // 
            this.txtWuerfel3.BackColor = System.Drawing.Color.HotPink;
            this.txtWuerfel3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWuerfel3.Location = new System.Drawing.Point(580, 182);
            this.txtWuerfel3.Multiline = true;
            this.txtWuerfel3.Name = "txtWuerfel3";
            this.txtWuerfel3.ReadOnly = true;
            this.txtWuerfel3.Size = new System.Drawing.Size(100, 85);
            this.txtWuerfel3.TabIndex = 14;
            this.txtWuerfel3.TabStop = false;
            this.txtWuerfel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWuerfel3.TextChanged += new System.EventHandler(this.txtWuerfel3_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(446, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Nächstes Spiel";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbGewinn
            // 
            this.lbGewinn.AutoSize = true;
            this.lbGewinn.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbGewinn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGewinn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbGewinn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGewinn.ForeColor = System.Drawing.Color.Coral;
            this.lbGewinn.Location = new System.Drawing.Point(348, 330);
            this.lbGewinn.Name = "lbGewinn";
            this.lbGewinn.Size = new System.Drawing.Size(181, 39);
            this.lbGewinn.TabIndex = 15;
            this.lbGewinn.Text = "<<Gewinn>>";
            this.lbGewinn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGewinn.Click += new System.EventHandler(this.lbGewinn_Click);
            // 
            // lbGewinnchance
            // 
            this.lbGewinnchance.AutoSize = true;
            this.lbGewinnchance.BackColor = System.Drawing.Color.HotPink;
            this.lbGewinnchance.ForeColor = System.Drawing.Color.White;
            this.lbGewinnchance.Location = new System.Drawing.Point(446, 91);
            this.lbGewinnchance.Name = "lbGewinnchance";
            this.lbGewinnchance.Size = new System.Drawing.Size(117, 15);
            this.lbGewinnchance.TabIndex = 4;
            this.lbGewinnchance.Text = "<<Gewinnchance>>";
            this.lbGewinnchance.Click += new System.EventHandler(this.lbGewinnchance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Glueckswurf";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 623);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbGewinn;
        private System.Windows.Forms.Label lbGewinnchance;
        private System.Windows.Forms.Label label1;
    }
}

