using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TileMapEditor.Forms
{
    public partial class SaveMapForm : Form
    {
        // Declare the save file name
        string saveFileName;


        public SaveMapForm()
        {
            InitializeComponent();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Return the cancel dialog result
            this.DialogResult = DialogResult.Cancel;
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            // Open the save file dialog
            saveFileDialog.Title = "Specify Destination File Name";

            // Set the default file name to the map name
            saveFileDialog.FileName = Game1.mapName;

            // Prompt the user before overwriting a file
            saveFileDialog.OverwritePrompt = true;

            // Set the file name
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog.FileName;
                fileNameBox.Text = saveFileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Save the map
            if (Game1.tileSheetFileName != null)
            {
                saveFileName = saveFileDialog.FileName;
                Game1.map.SaveMap(saveFileName);
            }
            else
            {
                MessageBox.Show("You have not loaded a tile sheet.");
            }

            // Return the OK dialog result
            this.DialogResult = DialogResult.OK;
        }


    }
}
