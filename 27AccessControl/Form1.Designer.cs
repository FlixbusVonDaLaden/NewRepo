
namespace _27AccessControl
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
            this.lbCurrentCount = new System.Windows.Forms.Label();
            this.lbMaxCount = new System.Windows.Forms.Label();
            this.txtCurrentCount = new System.Windows.Forms.TextBox();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCurrentCount
            // 
            this.lbCurrentCount.AutoSize = true;
            this.lbCurrentCount.Location = new System.Drawing.Point(12, 38);
            this.lbCurrentCount.Name = "lbCurrentCount";
            this.lbCurrentCount.Size = new System.Drawing.Size(160, 15);
            this.lbCurrentCount.TabIndex = 0;
            this.lbCurrentCount.Text = "Aktuelle Anzahl an Personen:";
            // 
            // lbMaxCount
            // 
            this.lbMaxCount.AutoSize = true;
            this.lbMaxCount.Location = new System.Drawing.Point(12, 87);
            this.lbMaxCount.Name = "lbMaxCount";
            this.lbMaxCount.Size = new System.Drawing.Size(169, 15);
            this.lbMaxCount.TabIndex = 1;
            this.lbMaxCount.Text = "Maximale Anzahl an Personen:";
            // 
            // txtCurrentCount
            // 
            this.txtCurrentCount.Location = new System.Drawing.Point(187, 30);
            this.txtCurrentCount.Name = "txtCurrentCount";
            this.txtCurrentCount.ReadOnly = true;
            this.txtCurrentCount.Size = new System.Drawing.Size(189, 23);
            this.txtCurrentCount.TabIndex = 2;
            this.txtCurrentCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(187, 79);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(189, 23);
            this.txtMaxCount.TabIndex = 3;
            this.txtMaxCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Decrement
            // 
            this.Decrement.Enabled = false;
            this.Decrement.Location = new System.Drawing.Point(570, 12);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(110, 100);
            this.Decrement.TabIndex = 4;
            this.Decrement.Text = "-1";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Decrement_Click);
            // 
            // Increment
            // 
            this.Increment.Enabled = false;
            this.Increment.Location = new System.Drawing.Point(420, 12);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(110, 100);
            this.Increment.TabIndex = 5;
            this.Increment.Text = "+1";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.txtMaxCount);
            this.Controls.Add(this.txtCurrentCount);
            this.Controls.Add(this.lbMaxCount);
            this.Controls.Add(this.lbCurrentCount);
            this.Name = "Form1";
            this.Text = "AccessControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentCount;
        private System.Windows.Forms.Label lbMaxCount;
        private System.Windows.Forms.TextBox txtCurrentCount;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increment;
    }
}

