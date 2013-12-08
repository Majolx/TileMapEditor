namespace TileMapEditor.Forms
{
    partial class NewMapForm
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
            this.mapNameLabel = new System.Windows.Forms.Label();
            this.mapHeightLabel = new System.Windows.Forms.Label();
            this.tileHeightLabel = new System.Windows.Forms.Label();
            this.mapNameTextBox = new System.Windows.Forms.TextBox();
            this.mapHeightBox = new System.Windows.Forms.NumericUpDown();
            this.tileHeightBox = new System.Windows.Forms.NumericUpDown();
            this.mapWidthBox = new System.Windows.Forms.NumericUpDown();
            this.tileWidthBox = new System.Windows.Forms.NumericUpDown();
            this.mapWidthLabel = new System.Windows.Forms.Label();
            this.tileWIdthLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapNameLabel
            // 
            this.mapNameLabel.AutoSize = true;
            this.mapNameLabel.Location = new System.Drawing.Point(51, 9);
            this.mapNameLabel.Name = "mapNameLabel";
            this.mapNameLabel.Size = new System.Drawing.Size(62, 13);
            this.mapNameLabel.TabIndex = 0;
            this.mapNameLabel.Text = "Map Name:";
            // 
            // mapHeightLabel
            // 
            this.mapHeightLabel.AutoSize = true;
            this.mapHeightLabel.Location = new System.Drawing.Point(46, 42);
            this.mapHeightLabel.Name = "mapHeightLabel";
            this.mapHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.mapHeightLabel.TabIndex = 1;
            this.mapHeightLabel.Text = "Map Height:";
            // 
            // tileHeightLabel
            // 
            this.tileHeightLabel.AutoSize = true;
            this.tileHeightLabel.Location = new System.Drawing.Point(46, 70);
            this.tileHeightLabel.Name = "tileHeightLabel";
            this.tileHeightLabel.Size = new System.Drawing.Size(61, 13);
            this.tileHeightLabel.TabIndex = 2;
            this.tileHeightLabel.Text = "Tile Height:";
            // 
            // mapNameTextBox
            // 
            this.mapNameTextBox.Location = new System.Drawing.Point(117, 6);
            this.mapNameTextBox.Name = "mapNameTextBox";
            this.mapNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.mapNameTextBox.TabIndex = 3;
            // 
            // mapHeightBox
            // 
            this.mapHeightBox.Location = new System.Drawing.Point(117, 40);
            this.mapHeightBox.Name = "mapHeightBox";
            this.mapHeightBox.Size = new System.Drawing.Size(64, 20);
            this.mapHeightBox.TabIndex = 4;
            this.mapHeightBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tileHeightBox
            // 
            this.tileHeightBox.Location = new System.Drawing.Point(117, 70);
            this.tileHeightBox.Name = "tileHeightBox";
            this.tileHeightBox.Size = new System.Drawing.Size(64, 20);
            this.tileHeightBox.TabIndex = 5;
            this.tileHeightBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // mapWidthBox
            // 
            this.mapWidthBox.Location = new System.Drawing.Point(264, 40);
            this.mapWidthBox.Name = "mapWidthBox";
            this.mapWidthBox.Size = new System.Drawing.Size(69, 20);
            this.mapWidthBox.TabIndex = 6;
            this.mapWidthBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tileWidthBox
            // 
            this.tileWidthBox.Location = new System.Drawing.Point(264, 70);
            this.tileWidthBox.Name = "tileWidthBox";
            this.tileWidthBox.Size = new System.Drawing.Size(69, 20);
            this.tileWidthBox.TabIndex = 7;
            this.tileWidthBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // mapWidthLabel
            // 
            this.mapWidthLabel.AutoSize = true;
            this.mapWidthLabel.Location = new System.Drawing.Point(196, 42);
            this.mapWidthLabel.Name = "mapWidthLabel";
            this.mapWidthLabel.Size = new System.Drawing.Size(62, 13);
            this.mapWidthLabel.TabIndex = 8;
            this.mapWidthLabel.Text = "Map Width:";
            // 
            // tileWIdthLabel
            // 
            this.tileWIdthLabel.AutoSize = true;
            this.tileWIdthLabel.Location = new System.Drawing.Point(196, 72);
            this.tileWIdthLabel.Name = "tileWIdthLabel";
            this.tileWIdthLabel.Size = new System.Drawing.Size(58, 13);
            this.tileWIdthLabel.TabIndex = 9;
            this.tileWIdthLabel.Text = "Tile Width:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(85, 105);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 28);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 28);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 151);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tileWIdthLabel);
            this.Controls.Add(this.mapWidthLabel);
            this.Controls.Add(this.tileWidthBox);
            this.Controls.Add(this.mapWidthBox);
            this.Controls.Add(this.tileHeightBox);
            this.Controls.Add(this.mapHeightBox);
            this.Controls.Add(this.mapNameTextBox);
            this.Controls.Add(this.tileHeightLabel);
            this.Controls.Add(this.mapHeightLabel);
            this.Controls.Add(this.mapNameLabel);
            this.Name = "NewMapForm";
            this.Text = "NewMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.mapHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileWidthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mapNameLabel;
        private System.Windows.Forms.Label mapHeightLabel;
        private System.Windows.Forms.Label tileHeightLabel;
        private System.Windows.Forms.TextBox mapNameTextBox;
        private System.Windows.Forms.NumericUpDown mapHeightBox;
        private System.Windows.Forms.NumericUpDown tileHeightBox;
        private System.Windows.Forms.NumericUpDown mapWidthBox;
        private System.Windows.Forms.NumericUpDown tileWidthBox;
        private System.Windows.Forms.Label mapWidthLabel;
        private System.Windows.Forms.Label tileWIdthLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}