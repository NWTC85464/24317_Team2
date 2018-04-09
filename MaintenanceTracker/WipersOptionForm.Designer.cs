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
            this.brandTextBox.Location = new System.Drawing.Point(68, 282);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(184, 20);
            this.brandTextBox.TabIndex = 36;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(20, 285);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(44, 13);
            this.brandLabel.TabIndex = 35;
            this.brandLabel.Text = "Brand:";
            // 
            // rearTextBox
            // 
            this.rearTextBox.Location = new System.Drawing.Point(162, 248);
            this.rearTextBox.Name = "rearTextBox";
            this.rearTextBox.Size = new System.Drawing.Size(90, 20);
            this.rearTextBox.TabIndex = 34;
            // 
            // rearLabel
            // 
            this.rearLabel.AutoSize = true;
            this.rearLabel.Location = new System.Drawing.Point(124, 255);
            this.rearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rearLabel.Name = "rearLabel";
            this.rearLabel.Size = new System.Drawing.Size(33, 13);
            this.rearLabel.TabIndex = 33;
            this.rearLabel.Text = "Rear:";
            // 
            // passagerSideTextBox
            // 
            this.passagerSideTextBox.Location = new System.Drawing.Point(162, 224);
            this.passagerSideTextBox.Name = "passagerSideTextBox";
            this.passagerSideTextBox.Size = new System.Drawing.Size(90, 20);
            this.passagerSideTextBox.TabIndex = 32;
            // 
            // passagerSideLabel
            // 
            this.passagerSideLabel.AutoSize = true;
            this.passagerSideLabel.Location = new System.Drawing.Point(79, 231);
            this.passagerSideLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passagerSideLabel.Name = "passagerSideLabel";
            this.passagerSideLabel.Size = new System.Drawing.Size(78, 13);
            this.passagerSideLabel.TabIndex = 31;
            this.passagerSideLabel.Text = "Passager Side:";
            // 
            // driverSideTextBox
            // 
            this.driverSideTextBox.Location = new System.Drawing.Point(162, 199);
            this.driverSideTextBox.Name = "driverSideTextBox";
            this.driverSideTextBox.Size = new System.Drawing.Size(90, 20);
            this.driverSideTextBox.TabIndex = 30;
            // 
            // driverSideLabel
            // 
            this.driverSideLabel.AutoSize = true;
            this.driverSideLabel.Location = new System.Drawing.Point(95, 206);
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
            this.notesTextBox.Location = new System.Drawing.Point(23, 319);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(229, 33);
            this.notesTextBox.TabIndex = 27;
            this.notesTextBox.Text = "Notes";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 23);
            this.exitButton.TabIndex = 40;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(102, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(55, 23);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(21, 399);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(55, 23);
            this.resetButton.TabIndex = 38;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // tipAndInfoButton
            // 
            this.tipAndInfoButton.Location = new System.Drawing.Point(68, 358);
            this.tipAndInfoButton.Name = "tipAndInfoButton";
            this.tipAndInfoButton.Size = new System.Drawing.Size(114, 23);
            this.tipAndInfoButton.TabIndex = 37;
            this.tipAndInfoButton.Text = "Tips and Information";
            this.tipAndInfoButton.UseVisualStyleBackColor = true;
            this.tipAndInfoButton.Click += new System.EventHandler(this.tipAndInfoButton_Click_1);
            // 
            // nextReplaceDateDisplayLabel
            // 
            this.nextReplaceDateDisplayLabel.Location = new System.Drawing.Point(20, 155);
            this.nextReplaceDateDisplayLabel.Name = "nextReplaceDateDisplayLabel";
            this.nextReplaceDateDisplayLabel.Size = new System.Drawing.Size(232, 23);
            this.nextReplaceDateDisplayLabel.TabIndex = 41;
            // 
            // WipersOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaintenanceTracker.Properties.Resources.wiper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(271, 434);
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
    }
}