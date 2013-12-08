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
    public partial class NewTileSheetForm : Form
    {
        // File name for the tile sheet
        public String sheetFileName;

        // Tile dimensions
        public int tileHeight = 32;
        public int tileWidth = 32;

        public NewTileSheetForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Set the initial directory
            openFileDialog.InitialDirectory = "C:\\";

            // Set the title for the dialog box
            openFileDialog.Title = "Select a map file.";
            openFileDialog.FileName = "";

            // Set the filter for text files only
            openFileDialog.Filter = "Image Files (*.png) | *.png";
            openFileDialog.FilterIndex = 1;

            // Browse for the tile sheet file
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                sheetFileName = openFileDialog.FileName;
            }
            else
            {
                sheetFileName = "";
            }

            // Display the file name
            tileSheetLocationBox.Text = sheetFileName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Return ok dialog result
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Cancel input
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
