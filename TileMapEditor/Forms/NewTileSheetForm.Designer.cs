namespace TileMapEditor.Forms
{
    partial class NewTileSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.tileSheetLocationLabel = new System.Windows.Forms.Label();
            this.tileHeightLabel = new System.Windows.Forms.Label();
            this.tileWidthLabel = new System.Windows.Forms.Label();
            this.tileSheetLocationBox = new System.Windows.Forms.TextBox();
            this.tileHeightBox = new System.Windows.Forms.NumericUpDown();
            this.tileWidthBox = new System.Windows.Forms.NumericUpDown();
            this.tileDimensionsGroup = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthBox)).BeginInit();
            this.tileDimensionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(169, 136);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 29);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Load Tileset";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(415, 15);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(26, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "..";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // tileSheetLocationLabel
            // 
            this.tileSheetLocationLabel.AutoSize = true;
            this.tileSheetLocationLabel.Location = new System.Drawing.Point(86, 20);
            this.tileSheetLocationLabel.Name = "tileSheetLocationLabel";
            this.tileSheetLocationLabel.Size = new System.Drawing.Size(102, 13);
            this.tileSheetLocationLabel.TabIndex = 3;
            this.tileSheetLocationLabel.Text = "Tile Sheet Location:";
            // 
            // tileHeightLabel
            // 
            this.tileHeightLabel.AutoSize = true;
            this.tileHeightLabel.Location = new System.Drawing.Point(6, 26);
            this.tileHeightLabel.Name = "tileHeightLabel";
            this.tileHeightLabel.Size = new System.Drawing.Size(61, 13);
            this.tileHeightLabel.TabIndex = 5;
            this.tileHeightLabel.Text = "Tile Height:";
            // 
            // tileWidthLabel
            // 
            this.tileWidthLabel.AutoSize = true;
            this.tileWidthLabel.Location = new System.Drawing.Point(6, 52);
            this.tileWidthLabel.Name = "tileWidthLabel";
            this.tileWidthLabel.Size = new System.Drawing.Size(58, 13);
            this.tileWidthLabel.TabIndex = 6;
            this.tileWidthLabel.Text = "Tile Width:";
            // 
            // tileSheetLocationBox
            // 
            this.tileSheetLocationBox.Location = new System.Drawing.Point(194, 17);
            this.tileSheetLocationBox.Name = "tileSheetLocationBox";
            this.tileSheetLocationBox.Size = new System.Drawing.Size(215, 20);
            this.tileSheetLocationBox.TabIndex = 7;
            // 
            // tileHeightBox
            // 
            this.tileHeightBox.Location = new System.Drawing.Point(124, 24);
            this.tileHeightBox.Name = "tileHeightBox";
            this.tileHeightBox.Size = new System.Drawing.Size(55, 20);
            this.tileHeightBox.TabIndex = 8;
            this.tileHeightBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // tileWidthBox
            // 
            this.tileWidthBox.Location = new System.Drawing.Point(124, 50);
            this.tileWidthBox.Name = "tileWidthBox";
            this.tileWidthBox.Size = new System.Drawing.Size(55, 20);
            this.tileWidthBox.TabIndex = 9;
            this.tileWidthBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // tileDimensionsGroup
            // 
            this.tileDimensionsGroup.Controls.Add(this.tileHeightLabel);
            this.tileDimensionsGroup.Controls.Add(this.tileWidthBox);
            this.tileDimensionsGroup.Controls.Add(this.tileWidthLabel);
            this.tileDimensionsGroup.Controls.Add(this.tileHeightBox);
            this.tileDimensionsGroup.Location = new System.Drawing.Point(122, 48);
            this.tileDimensionsGroup.Name = "tileDimensionsGroup";
            this.tileDimensionsGroup.Size = new System.Drawing.Size(272, 82);
            this.tileDimensionsGroup.TabIndex = 10;
            this.tileDimensionsGroup.TabStop = false;
            this.tileDimensionsGroup.Text = "Tile Dimensions";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // NewTileSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 182);
            this.Controls.Add(this.tileDimensionsGroup);
            this.Controls.Add(this.tileSheetLocationBox);
            this.Controls.Add(this.tileSheetLocationLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "NewTileSheetForm";
            this.Text = "NewTileSheetForm";
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthBox)).EndInit();
            this.tileDimensionsGroup.ResumeLayout(false);
            this.tileDimensionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label tileSheetLocationLabel;
        private System.Windows.Forms.Label tileHeightLabel;
        private System.Windows.Forms.Label tileWidthLabel;
        private System.Windows.Forms.TextBox tileSheetLocationBox;
        private System.Windows.Forms.NumericUpDown tileHeightBox;
        private System.Windows.Forms.NumericUpDown tileWidthBox;
        private System.Windows.Forms.GroupBox tileDimensionsGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}