using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _31ImageBrowser
{
    public partial class Form1 : Form
    {
        private string[] pathToImages;
        private int currentImage = 0;
        private Timer timer = new Timer();
        private  int cnt = 0;

        public Form1()
        {
            InitializeComponent();
            this.timer.Interval = 1000;
            this.timer.Tick += Timer_Tick;
            this.timer.Enabled = true;          // Timer ist nur aktiv wenn true

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(cnt % 2 == 0)
            {
                this.btnDatei.BackColor = Color.Beige;
            }
            else
            {
                this.btnDatei.BackColor = Color.Gray;
            }
            this.cnt++;
        }

        private void btnDatei_Click(object sender, EventArgs e)
        {
            DialogResult result = this.ofdDatei.ShowDialog();
            if(result == DialogResult.OK)
            {
                string fileName = ofdDatei.FileName;
                this.lbDatei.Text = fileName;
                readImagePaths(fileName);
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Leider keine Datei Ausgewählt", "Datei wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void readImagePaths(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            this.pathToImages = lines;
            loadImage();
        }

        private void loadImage()
        {
            if(this.pathToImages.Length > 0)
            {
                // Bild nur laden, wenn auch eines verfügbar ist
                this.pbBild.ImageLocation = this.pathToImages[this.currentImage];
            }
            this.btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(this.currentImage + 1 < this.pathToImages.Length)
            {
                this.currentImage += 1;
                loadImage();
            }
            else
            {
                this.currentImage = 0;
                loadImage();
            }
        }

        private void btnEditList_Click(object sender, EventArgs e)
        {
            EditList editListForm = new EditList();
            editListForm.PathToImageList = this.lbDatei.Text;        // ein eigenes Property des Dialogs
            DialogResult result = editListForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                readImagePaths(this.lbDatei.Text);
            }
            else if(result == DialogResult.Cancel)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
