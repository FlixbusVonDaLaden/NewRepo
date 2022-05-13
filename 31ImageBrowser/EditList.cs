using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _31ImageBrowser
{
    public partial class EditList : Form
    {
        public string PathToImageList { get; set; }

        public EditList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // hier Text in eine Datei schreiben

            // OpenFileDialog, wo man ein Bild auswählen kann
            // Filter
            // Pfad zur ImageList hinzufügen (Datei)

            //File.AppendAllText(PathToImageList, "Pfad zur neuen Datei");

            DialogResult result = this.ofdAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofdAdd.FileName;
                File.AppendAllText(PathToImageList, Environment.NewLine + fileName);
                this.lbAdd.Text = fileName;
            }
            else if(result == DialogResult.Cancel)
            {
                MessageBox.Show("Leider keine Datei Ausgewählt", "Datei wählen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
