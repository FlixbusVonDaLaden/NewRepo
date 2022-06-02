
namespace _31ImageBrowser
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
            this.gbDatei = new System.Windows.Forms.GroupBox();
            this.btnEditList = new System.Windows.Forms.Button();
            this.lbDatei = new System.Windows.Forms.Label();
            this.btnDatei = new System.Windows.Forms.Button();
            this.pbBild = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.ofdDatei = new System.Windows.Forms.OpenFileDialog();
            this.gbDatei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBild)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatei
            // 
            this.gbDatei.Controls.Add(this.btnEditList);
            this.gbDatei.Controls.Add(this.lbDatei);
            this.gbDatei.Controls.Add(this.btnDatei);
            this.gbDatei.Location = new System.Drawing.Point(12, 12);
            this.gbDatei.Name = "gbDatei";
            this.gbDatei.Size = new System.Drawing.Size(776, 144);
            this.gbDatei.TabIndex = 0;
            this.gbDatei.TabStop = false;
            this.gbDatei.Text = "Datei";
            // 
            // btnEditList
            // 
            this.btnEditList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditList.Location = new System.Drawing.Point(644, 61);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(117, 25);
            this.btnEditList.TabIndex = 2;
            this.btnEditList.Text = "Liste bearbeiten";
            this.btnEditList.UseVisualStyleBackColor = true;
            this.btnEditList.Click += new System.EventHandler(this.btnEditList_Click);
            // 
            // lbDatei
            // 
            this.lbDatei.AutoSize = true;
            this.lbDatei.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDatei.Location = new System.Drawing.Point(211, 65);
            this.lbDatei.Name = "lbDatei";
            this.lbDatei.Size = new System.Drawing.Size(130, 19);
            this.lbDatei.TabIndex = 1;
            this.lbDatei.Text = "Keine Datei geladen";
            this.lbDatei.Click += new System.EventHandler(this.lbDatei_Click);
            // 
            // btnDatei
            // 
            this.btnDatei.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatei.Location = new System.Drawing.Point(79, 61);
            this.btnDatei.Name = "btnDatei";
            this.btnDatei.Size = new System.Drawing.Size(111, 25);
            this.btnDatei.TabIndex = 0;
            this.btnDatei.Text = "Datei laden";
            this.btnDatei.UseVisualStyleBackColor = true;
            this.btnDatei.Click += new System.EventHandler(this.btnDatei_Click);
            // 
            // pbBild
            // 
            this.pbBild.Location = new System.Drawing.Point(12, 162);
            this.pbBild.Name = "pbBild";
            this.pbBild.Size = new System.Drawing.Size(627, 276);
            this.pbBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBild.TabIndex = 1;
            this.pbBild.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(645, 162);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 42);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = " ➤";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ofdDatei
            // 
            this.ofdDatei.FileName = "openFileDialog1";
            this.ofdDatei.Filter = "ImageBrowser Datei|*.ibf|Textdateien|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbBild);
            this.Controls.Add(this.gbDatei);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatei.ResumeLayout(false);
            this.gbDatei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatei;
        private System.Windows.Forms.Label lbDatei;
        private System.Windows.Forms.Button btnDatei;
        private System.Windows.Forms.PictureBox pbBild;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.OpenFileDialog ofdDatei;
        private System.Windows.Forms.Button btnEditList;
    }
}

