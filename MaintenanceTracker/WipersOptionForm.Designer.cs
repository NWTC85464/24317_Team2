namespace MaintenanceTracker
{
    partial class WipersOptionForm
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
            this.installedDateLabel = new System.Windows.Forms.Label();
            this.installedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextReplaceDateLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.rearTextBox = new System.Windows.Forms.TextBox();
            this.rearLabel = new System.Windows.Forms.Label();
            this.passagerSideTextBox = new System.Windows.Forms.TextBox();
            this.passagerSideLabel = new System.Windows.Forms.Label();
            this.driverSideTextBox = new System.Windows.Forms.TextBox();
            this.driverSideLabel = new System.Windows.Forms.Label();
            this.wiperSizeLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tipAndInfoButton = new System.Windows.Forms.Button();
            this.nextReplaceDateDisplayLabel = new System.Windows.Forms.Label();
            this.vehicleNumLabel = new System.Windows.Forms.Label();
            this.wiperProgressBar = new System.Windows.Forms.ProgressBar();
            this.displayNotesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayBrandLabel = new System.Windows.Forms.Label();
            this.displayRearLabel = new System.Windows.Forms.Label();
            this.displayPassSideLabel = new System.Windows.Forms.Label();
            this.displayDrSideLabel = new System.Windows.Forms.Label();
            this.displayNextDateLabel = new System.Windows.Forms.Label();
            this.displayInstDateLabel = new System.Windows.Forms.Label();
            this.newFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // installedDateLabel
            // 
            this.installedDateLabel.AutoSize = true;
            this.installedDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installedDateLabel.Location = new System.Drawing.Point(20, 81);
            this.installedDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.installedDateLabel.Name = "installedDateLabel";
            this.installedDateLabel.Size = new System.Drawing.Size(90, 13);
            this.installedDateLabel.TabIndex = 8;
            this.installedDateLabel.Text = "Installed Date:";
            // 
            // installedDateTimePicker
            // 
            this.installedDateTimePicker.Location = new System.Drawing.Point(23, 97);
            this.installedDateTimePicker.Name = "installedDateTimePicker";
            this.installedDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.installedDateTimePicker.TabIndex = 9;
            this.installedDateTimePicker.TabStop = false;
            this.installedDateTimePicker.ValueChanged += new System.EventHandler(this.installedDateTimePicker_ValueChanged_1);
            // 
            // nextReplaceDateLabel
            // 
            this.nextReplaceDateLabel.AutoSize = true;
            this.nextReplaceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextReplaceDateLabel.Location = new System.Drawing.Point(20, 135);
            this.nextReplaceDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextReplaceDateLabel.Name = "nextReplaceDateLabel";
            this.nextReplaceDateLabel.Size = new System.Drawing.Size(119, 13);
            this.nextReplaceDateLabel.TabIndex = 10;
            this.nextReplaceDateLabel.Text = "Next Replace Date:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(102, 272);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(150, 20);
            this.brandTextBox.TabIndex = 36;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(48, 272);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(44, 13);
            this.brandLabel.TabIndex = 35;
            this.brandLabel.Text = "Brand:";
            // 
            // rearTextBox
            // 
            this.rearTextBox.Location = new System.Drawing.Point(102, 248);
            this.rearTextBox.Name = "rearTextBox";
            this.rearTextBox.Size = new System.Drawing.Size(150, 20);
            this.rearTextBox.TabIndex = 34;
            // 
            // rearLabel
            // 
            this.rearLabel.AutoSize = true;
            this.rearLabel.Location = new System.Drawing.Point(59, 255);
            this.rearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rearLabel.Name = "rearLabel";
            this.rearLabel.Size = new System.Drawing.Size(33, 13);
            this.rearLabel.TabIndex = 33;
            this.rearLabel.Text = "Rear:";
            // 
            // passagerSideTextBox
            // 
            this.passagerSideTextBox.Location = new System.Drawing.Point(102, 224);
            this.passagerSideTextBox.Name = "passagerSideTextBox";
            this.passagerSideTextBox.Size = new System.Drawing.Size(150, 20);
            this.passagerSideTextBox.TabIndex = 32;
            // 
            // passagerSideLabel
            // 
            this.passagerSideLabel.AutoSize = true;
            this.passagerSideLabel.Location = new System.Drawing.Point(14, 231);
            this.passagerSideLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passagerSideLabel.Name = "passagerSideLabel";
            this.passagerSideLabel.Size = new System.Drawing.Size(78, 13);
            this.passagerSideLabel.TabIndex = 31;
            this.passagerSideLabel.Text = "Passager Side:";
            // 
            // driverSideTextBox
            // 
            this.driverSideTextBox.Location = new System.Drawing.Point(102, 199);
            this.driverSideTextBox.Name = "driverSideTextBox";
            this.driverSideTextBox.Size = new System.Drawing.Size(150, 20);
            this.driverSideTextBox.TabIndex = 30;
            // 
            // driverSideLabel
            // 
            this.driverSideLabel.AutoSize = true;
            this.driverSideLabel.Location = new System.Drawing.Point(30, 206);
            this.driverSideLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.driverSideLabel.Name = "driverSideLabel";
            this.driverSideLabel.Size = new System.Drawing.Size(62, 13);
            this.driverSideLabel.TabIndex = 29;
            this.driverSideLabel.Text = "Driver Side:";
            // 
            // wiperSizeLabel
            // 
            this.wiperSizeLabel.AutoSize = true;
            this.wiperSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiperSizeLabel.Location = new System.Drawing.Point(20, 183);
            this.wiperSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wiperSizeLabel.Name = "wiperSizeLabel";
            this.wiperSizeLabel.Size = new System.Drawing.Size(72, 13);
            this.wiperSizeLabel.TabIndex = 28;
            this.wiperSizeLabel.Text = "Wiper Size:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(23, 308);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(229, 44);
            this.notesTextBox.TabIndex = 37;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 23);
            this.exitButton.TabIndex = 41;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(102, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(55, 23);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(21, 399);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(55, 23);
            this.resetButton.TabIndex = 39;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tipAndInfoButton
            // 
            this.tipAndInfoButton.Location = new System.Drawing.Point(68, 358);
            this.tipAndInfoButton.Name = "tipAndInfoButton";
            this.tipAndInfoButton.Size = new System.Drawing.Size(114, 23);
            this.tipAndInfoButton.TabIndex = 38;
            this.tipAndInfoButton.Text = "Tips and Information";
            this.tipAndInfoButton.UseVisualStyleBackColor = true;
            this.tipAndInfoButton.Click += new System.EventHandler(this.tipAndInfoButton_Click_1);
            // 
            // nextReplaceDateDisplayLabel
            // 
            this.nextReplaceDateDisplayLabel.Location = new System.Drawing.Point(20, 155);
            this.nextReplaceDateDisplayLabel.Name = "nextReplaceDateDisplayLabel";
            this.nextReplaceDateDisplayLabel.Size = new System.Drawing.Size(232, 23);
            this.nextReplaceDateDisplayLabel.TabIndex = 11;
            // 
            // vehicleNumLabel
            // 
            this.vehicleNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNumLabel.Location = new System.Drawing.Point(23, 9);
            this.vehicleNumLabel.Name = "vehicleNumLabel";
            this.vehicleNumLabel.Size = new System.Drawing.Size(229, 20);
            this.vehicleNumLabel.TabIndex = 44;
            this.vehicleNumLabel.Text = "Wiper Info for Vehicle # ";
            // 
            // wiperProgressBar
            // 
            this.wiperProgressBar.BackColor = System.Drawing.Color.White;
            this.wiperProgressBar.ForeColor = System.Drawing.Color.White;
            this.wiperProgressBar.Location = new System.Drawing.Point(23, 40);
            this.wiperProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.wiperProgressBar.Maximum = 500;
            this.wiperProgressBar.Name = "wiperProgressBar";
            this.wiperProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wiperProgressBar.Size = new System.Drawing.Size(229, 28);
            this.wiperProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.wiperProgressBar.TabIndex = 46;
            // 
            // displayNotesLabel
            // 
            this.displayNotesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNotesLabel.Location = new System.Drawing.Point(23, 308);
            this.displayNotesLabel.Name = "displayNotesLabel";
            this.displayNotesLabel.Size = new System.Drawing.Size(229, 46);
            this.displayNotesLabel.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Notes:";
            // 
            // displayBrandLabel
            // 
            this.displayBrandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBrandLabel.Location = new System.Drawing.Point(102, 272);
            this.displayBrandLabel.Name = "displayBrandLabel";
            this.displayBrandLabel.Size = new System.Drawing.Size(155, 23);
            this.displayBrandLabel.TabIndex = 82;
            // 
            // displayRearLabel
            // 
            this.displayRearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayRearLabel.Location = new System.Drawing.Point(102, 245);
            this.displayRearLabel.Name = "displayRearLabel";
            this.displayRearLabel.Size = new System.Drawing.Size(155, 23);
            this.displayRearLabel.TabIndex = 80;
            // 
            // displayPassSideLabel
            // 
            this.displayPassSideLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPassSideLabel.Location = new System.Drawing.Point(102, 221);
            this.displayPassSideLabel.Name = "displayPassSideLabel";
            this.displayPassSideLabel.Size = new System.Drawing.Size(155, 23);
            this.displayPassSideLabel.TabIndex = 79;
            // 
            // displayDrSideLabel
            // 
            this.displayDrSideLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDrSideLabel.Location = new System.Drawing.Point(102, 196);
            this.displayDrSideLabel.Name = "displayDrSideLabel";
            this.displayDrSideLabel.Size = new System.Drawing.Size(155, 23);
            this.displayDrSideLabel.TabIndex = 78;
            // 
            // displayNextDateLabel
            // 
            this.displayNextDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayNextDateLabel.Location = new System.Drawing.Point(23, 155);
            this.displayNextDateLabel.Name = "displayNextDateLabel";
            this.displayNextDateLabel.Size = new System.Drawing.Size(232, 23);
            this.displayNextDateLabel.TabIndex = 73;
            // 
            // displayInstDateLabel
            // 
            this.displayInstDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayInstDateLabel.Location = new System.Drawing.Point(23, 97);
            this.displayInstDateLabel.Name = "displayInstDateLabel";
            this.displayInstDateLabel.Size = new System.Drawing.Size(229, 23);
            this.displayInstDateLabel.TabIndex = 70;
            // 
            // newFormButton
            // 
            this.newFormButton.Location = new System.Drawing.Point(188, 358);
            this.newFormButton.Name = "newFormButton";
            this.newFormButton.Size = new System.Drawing.Size(55, 23);
            this.newFormButton.TabIndex = 86;
            this.newFormButton.Text = "New";
            this.newFormButton.UseVisualStyleBackColor = true;
            this.newFormButton.Click += new System.EventHandler(this.newFormButton_Click);
            // 
            // WipersOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaintenanceTracker.Properties.Resources.wiper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(276, 434);
            this.Controls.Add(this.newFormButton);
            this.Controls.Add(this.displayNotesLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displayBrandLabel);
            this.Controls.Add(this.displayRearLabel);
            this.Controls.Add(this.displayPassSideLabel);
            this.Controls.Add(this.displayDrSideLabel);
            this.Controls.Add(this.displayNextDateLabel);
            this.Controls.Add(this.displayInstDateLabel);
            this.Controls.Add(this.wiperProgressBar);
            this.Controls.Add(this.vehicleNumLabel);
            this.Controls.Add(this.nextReplaceDateDisplayLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tipAndInfoButton);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.rearTextBox);
            this.Controls.Add(this.rearLabel);
            this.Controls.Add(this.passagerSideTextBox);
            this.Controls.Add(this.passagerSideLabel);
            this.Controls.Add(this.driverSideTextBox);
            this.Controls.Add(this.driverSideLabel);
            this.Controls.Add(this.wiperSizeLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.nextReplaceDateLabel);
            this.Controls.Add(this.installedDateTimePicker);
            this.Controls.Add(this.installedDateLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WipersOptionForm";
            this.Text = "WipersOptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label installedDateLabel;
        private System.Windows.Forms.DateTimePicker installedDateTimePicker;
        private System.Windows.Forms.Label nextReplaceDateLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox rearTextBox;
        private System.Windows.Forms.Label rearLabel;
        private System.Windows.Forms.TextBox passagerSideTextBox;
        private System.Windows.Forms.Label passagerSideLabel;
        private System.Windows.Forms.TextBox driverSideTextBox;
        private System.Windows.Forms.Label driverSideLabel;
        private System.Windows.Forms.Label wiperSizeLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button tipAndInfoButton;
        private System.Windows.Forms.Label nextReplaceDateDisplayLabel;
        private System.Windows.Forms.Label vehicleNumLabel;
        private System.Windows.Forms.ProgressBar wiperProgressBar;
        private System.Windows.Forms.Label displayNotesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displayBrandLabel;
        private System.Windows.Forms.Label displayRearLabel;
        private System.Windows.Forms.Label displayPassSideLabel;
        private System.Windows.Forms.Label displayDrSideLabel;
        private System.Windows.Forms.Label displayNextDateLabel;
        private System.Windows.Forms.Label displayInstDateLabel;
        private System.Windows.Forms.Button newFormButton;
    }
}