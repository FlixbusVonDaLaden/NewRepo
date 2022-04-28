
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
            this.lbMaxCount = new System.Windows.Forms.Label();
            this.lbCurrentCount = new System.Windows.Forms.Label();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.txtCurrentCount = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.txtIncrementMultiple = new System.Windows.Forms.TextBox();
            this.btnIncrementMultiple = new System.Windows.Forms.Button();
            this.txtDecrementMultiple = new System.Windows.Forms.TextBox();
            this.btnDecrementMultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaxCount
            // 
            this.lbMaxCount.AutoSize = true;
            this.lbMaxCount.Location = new System.Drawing.Point(147, 80);
            this.lbMaxCount.Name = "lbMaxCount";
            this.lbMaxCount.Size = new System.Drawing.Size(169, 15);
            this.lbMaxCount.TabIndex = 0;
            this.lbMaxCount.Text = "Maximale Anzahl an Personen:";
            // 
            // lbCurrentCount
            // 
            this.lbCurrentCount.AutoSize = true;
            this.lbCurrentCount.Location = new System.Drawing.Point(156, 116);
            this.lbCurrentCount.Name = "lbCurrentCount";
            this.lbCurrentCount.Size = new System.Drawing.Size(160, 15);
            this.lbCurrentCount.TabIndex = 1;
            this.lbCurrentCount.Text = "Aktuelle Anzahl an Personen:";
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(380, 77);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(214, 23);
            this.txtMaxCount.TabIndex = 2;
            this.txtMaxCount.TextChanged += new System.EventHandler(this.txtMaxCount_TextChanged);
            // 
            // txtCurrentCount
            // 
            this.txtCurrentCount.Location = new System.Drawing.Point(380, 113);
            this.txtCurrentCount.Name = "txtCurrentCount";
            this.txtCurrentCount.ReadOnly = true;
            this.txtCurrentCount.Size = new System.Drawing.Size(214, 23);
            this.txtCurrentCount.TabIndex = 3;
            // 
            // btnIncrement
            // 
            this.btnIncrement.Enabled = false;
            this.btnIncrement.Location = new System.Drawing.Point(216, 174);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(100, 100);
            this.btnIncrement.TabIndex = 4;
            this.btnIncrement.Text = "+1";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Enabled = false;
            this.btnDecrement.Location = new System.Drawing.Point(494, 174);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(100, 100);
            this.btnDecrement.TabIndex = 5;
            this.btnDecrement.Text = "-1";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // txtIncrementMultiple
            // 
            this.txtIncrementMultiple.Location = new System.Drawing.Point(216, 298);
            this.txtIncrementMultiple.Name = "txtIncrementMultiple";
            this.txtIncrementMultiple.Size = new System.Drawing.Size(100, 23);
            this.txtIncrementMultiple.TabIndex = 6;
            this.txtIncrementMultiple.TextChanged += new System.EventHandler(this.txtIncrementMultiple_TextChanged);
            // 
            // btnIncrementMultiple
            // 
            this.btnIncrementMultiple.Enabled = false;
            this.btnIncrementMultiple.Location = new System.Drawing.Point(229, 327);
            this.btnIncrementMultiple.Name = "btnIncrementMultiple";
            this.btnIncrementMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementMultiple.TabIndex = 7;
            this.btnIncrementMultiple.Text = "vergrößern";
            this.btnIncrementMultiple.UseVisualStyleBackColor = true;
            this.btnIncrementMultiple.Click += new System.EventHandler(this.btnIncrementMultiple_Click);
            // 
            // txtDecrementMultiple
            // 
            this.txtDecrementMultiple.Location = new System.Drawing.Point(494, 298);
            this.txtDecrementMultiple.Name = "txtDecrementMultiple";
            this.txtDecrementMultiple.Size = new System.Drawing.Size(100, 23);
            this.txtDecrementMultiple.TabIndex = 8;
            this.txtDecrementMultiple.TextChanged += new System.EventHandler(this.txtDecrementMultiple_TextChanged);
            // 
            // btnDecrementMultiple
            // 
            this.btnDecrementMultiple.Enabled = false;
            this.btnDecrementMultiple.Location = new System.Drawing.Point(508, 327);
            this.btnDecrementMultiple.Name = "btnDecrementMultiple";
            this.btnDecrementMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnDecrementMultiple.TabIndex = 9;
            this.btnDecrementMultiple.Text = "verkleinern";
            this.btnDecrementMultiple.UseVisualStyleBackColor = true;
            this.btnDecrementMultiple.Click += new System.EventHandler(this.btnDencrementMultiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecrementMultiple);
            this.Controls.Add(this.txtDecrementMultiple);
            this.Controls.Add(this.btnIncrementMultiple);
            this.Controls.Add(this.txtIncrementMultiple);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.txtCurrentCount);
            this.Controls.Add(this.txtMaxCount);
            this.Controls.Add(this.lbCurrentCount);
            this.Controls.Add(this.lbMaxCount);
            this.Name = "Form1";
            this.Text = "Access Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaxCount;
        private System.Windows.Forms.Label lbCurrentCount;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.TextBox txtCurrentCount;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.TextBox txtIncrementMultiple;
        private System.Windows.Forms.Button btnIncrementMultiple;
        private System.Windows.Forms.TextBox txtDecrementMultiple;
        private System.Windows.Forms.Button btnDecrementMultiple;
    }
}

