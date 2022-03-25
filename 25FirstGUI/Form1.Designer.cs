
namespace _25FirstGUI
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.txtHelloWorld = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.AccessibleDescription = "";
            this.btnHelloWorld.AccessibleName = "";
            this.btnHelloWorld.BackColor = System.Drawing.Color.Yellow;
            this.btnHelloWorld.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelloWorld.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHelloWorld.Location = new System.Drawing.Point(210, 125);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(234, 150);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Click!";
            this.btnHelloWorld.UseVisualStyleBackColor = false;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            this.btnHelloWorld.MouseEnter += new System.EventHandler(this.btnHelloWorld_MouseEnter);
            // 
            // txtHelloWorld
            // 
            this.txtHelloWorld.Location = new System.Drawing.Point(601, 190);
            this.txtHelloWorld.Name = "txtHelloWorld";
            this.txtHelloWorld.Size = new System.Drawing.Size(100, 23);
            this.txtHelloWorld.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Text Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHelloWorld);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.TextBox txtHelloWorld;
        private System.Windows.Forms.Button button1;
    }
}

