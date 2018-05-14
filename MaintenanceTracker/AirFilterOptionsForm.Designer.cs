namespace MaintenanceTracker
{
    partial class AirFilterOptionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirFilterOptionsForm));
            this.engAirFilter = new System.Windows.Forms.Button();
            this.cabAirFilter = new System.Windows.Forms.Button();
            this.engAirFilterLB = new System.Windows.Forms.Label();
            this.cabAirFilterLB = new System.Windows.Forms.Label();
            this.engAirFilterTB = new System.Windows.Forms.TrackBar();
            this.cabAirFilterTB = new System.Windows.Forms.TrackBar();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.generalMessageLB = new System.Windows.Forms.Label();
            this.engMaxMilesLabel = new System.Windows.Forms.Label();
            this.cabMaxMilesLabel = new System.Windows.Forms.Label();
            this.engFilterChangedBTTN = new System.Windows.Forms.Button();
            this.cabFilterChangedBTTN = new System.Windows.Forms.Button();
            this.engAirFilterTBarLabel = new System.Windows.Forms.Label();
            this.cabAirFilterTBarLabel = new System.Windows.Forms.Label();
            this.engMaxMilesLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.calLB = new System.Windows.Forms.Label();
            this.cabMaxMilesLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.generalMessagePanel = new System.Windows.Forms.Panel();
            this.engAirFilterPanel = new System.Windows.Forms.Panel();
            this.engDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.engTextBox = new System.Windows.Forms.TextBox();
            this.cabAirFilterPanel = new System.Windows.Forms.Panel();
            this.cabDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cabTextBox = new System.Windows.Forms.TextBox();
            this.engFilterReplacementToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cabFilterReplacementToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).BeginInit();
            this.generalMessagePanel.SuspendLayout();
            this.engAirFilterPanel.SuspendLayout();
            this.cabAirFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // engAirFilter
            // 
            this.engAirFilter.Location = new System.Drawing.Point(12, 582);
            this.engAirFilter.Margin = new System.Windows.Forms.Padding(4);
            this.engAirFilter.Name = "engAirFilter";
            this.engAirFilter.Size = new System.Drawing.Size(256, 177);
            this.engAirFilter.TabIndex = 4;
            this.engAirFilter.Text = "Engine Air Filter Settings";
            this.engAirFilter.UseVisualStyleBackColor = true;
            this.engAirFilter.Click += new System.EventHandler(this.EngAirFilter_Click);
            // 
            // cabAirFilter
            // 
            this.cabAirFilter.Location = new System.Drawing.Point(276, 582);
            this.cabAirFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cabAirFilter.Name = "cabAirFilter";
            this.cabAirFilter.Size = new System.Drawing.Size(256, 177);
            this.cabAirFilter.TabIndex = 7;
            this.cabAirFilter.Text = "Cabin Air Filter Settings";
            this.cabAirFilter.UseVisualStyleBackColor = true;
            this.cabAirFilter.Click += new System.EventHandler(this.CabAirFilter_Click);
            // 
            // engAirFilterLB
            // 
            this.engAirFilterLB.AutoSize = true;
            this.engAirFilterLB.Location = new System.Drawing.Point(6, 5);
            this.engAirFilterLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.engAirFilterLB.Name = "engAirFilterLB";
            this.engAirFilterLB.Size = new System.Drawing.Size(17, 25);
            this.engAirFilterLB.TabIndex = 2;
            this.engAirFilterLB.Text = "|";
            // 
            // cabAirFilterLB
            // 
            this.cabAirFilterLB.AutoSize = true;
            this.cabAirFilterLB.Location = new System.Drawing.Point(6, 5);
            this.cabAirFilterLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cabAirFilterLB.Name = "cabAirFilterLB";
            this.cabAirFilterLB.Size = new System.Drawing.Size(17, 25);
            this.cabAirFilterLB.TabIndex = 3;
            this.cabAirFilterLB.Text = "|";
            // 
            // engAirFilterTB
            // 
            this.engAirFilterTB.Location = new System.Drawing.Point(13, 397);
            this.engAirFilterTB.Margin = new System.Windows.Forms.Padding(4);
            this.engAirFilterTB.Name = "engAirFilterTB";
            this.engAirFilterTB.Size = new System.Drawing.Size(255, 90);
            this.engAirFilterTB.TabIndex = 5;
            // 
            // cabAirFilterTB
            // 
            this.cabAirFilterTB.Location = new System.Drawing.Point(276, 397);
            this.cabAirFilterTB.Margin = new System.Windows.Forms.Padding(4);
            this.cabAirFilterTB.Name = "cabAirFilterTB";
            this.cabAirFilterTB.Size = new System.Drawing.Size(256, 90);
            this.cabAirFilterTB.TabIndex = 8;
            // 
            // exitBTTN
            // 
            this.exitBTTN.Location = new System.Drawing.Point(12, 766);
            this.exitBTTN.Margin = new System.Windows.Forms.Padding(4);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(520, 56);
            this.exitBTTN.TabIndex = 10;
            this.exitBTTN.Text = "Exit";
            this.exitBTTN.UseVisualStyleBackColor = true;
            this.exitBTTN.Click += new System.EventHandler(this.ExitBTTN_Click);
            // 
            // generalMessageLB
            // 
            this.generalMessageLB.AutoSize = true;
            this.generalMessageLB.Location = new System.Drawing.Point(6, 5);
            this.generalMessageLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.generalMessageLB.Name = "generalMessageLB";
            this.generalMessageLB.Size = new System.Drawing.Size(17, 25);
            this.generalMessageLB.TabIndex = 1;
            this.generalMessageLB.Text = "|";
            // 
            // engMaxMilesLabel
            // 
            this.engMaxMilesLabel.AutoSize = true;
            this.engMaxMilesLabel.Location = new System.Drawing.Point(19, 368);
            this.engMaxMilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.engMaxMilesLabel.Name = "engMaxMilesLabel";
            this.engMaxMilesLabel.Size = new System.Drawing.Size(116, 25);
            this.engMaxMilesLabel.TabIndex = 18;
            this.engMaxMilesLabel.Text = "Max Miles:";
            this.engMaxMilesLabelToolTip.SetToolTip(this.engMaxMilesLabel, "Set the amount of miles you would like to drive before replacing your engine air " +
        "filter.\r\n");
            // 
            // cabMaxMilesLabel
            // 
            this.cabMaxMilesLabel.AutoSize = true;
            this.cabMaxMilesLabel.Location = new System.Drawing.Point(283, 368);
            this.cabMaxMilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cabMaxMilesLabel.Name = "cabMaxMilesLabel";
            this.cabMaxMilesLabel.Size = new System.Drawing.Size(116, 25);
            this.cabMaxMilesLabel.TabIndex = 19;
            this.cabMaxMilesLabel.Text = "Max Miles:";
            this.cabMaxMilesLabelToolTip.SetToolTip(this.cabMaxMilesLabel, "Set the amount of miles you would like to drive before replacing your cabin air f" +
        "ilter.");
            // 
            // engFilterChangedBTTN
            // 
            this.engFilterChangedBTTN.Location = new System.Drawing.Point(12, 498);
            this.engFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(6);
            this.engFilterChangedBTTN.Name = "engFilterChangedBTTN";
            this.engFilterChangedBTTN.Size = new System.Drawing.Size(256, 75);
            this.engFilterChangedBTTN.TabIndex = 6;
            this.engFilterChangedBTTN.Text = "Engine Filter Replaced";
            this.engFilterReplacementToolTip.SetToolTip(this.engFilterChangedBTTN, "Clicking on the Engine Filter Replaced button and accepting the prompt \r\n your st" +
        "ored miles for the engine filter will be reset to 0, and your date \r\nwill be set" +
        " to the current date.");
            this.engFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.engFilterChangedBTTN.Click += new System.EventHandler(this.EngFilterChangedBTTN_Click);
            // 
            // cabFilterChangedBTTN
            // 
            this.cabFilterChangedBTTN.Location = new System.Drawing.Point(276, 498);
            this.cabFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(6);
            this.cabFilterChangedBTTN.Name = "cabFilterChangedBTTN";
            this.cabFilterChangedBTTN.Size = new System.Drawing.Size(256, 75);
            this.cabFilterChangedBTTN.TabIndex = 9;
            this.cabFilterChangedBTTN.Text = "Cabin Filter Replaced";
            this.cabFilterReplacementToolTip.SetToolTip(this.cabFilterChangedBTTN, "Clicking on the Cabin Filter Replaced button and accepting the prompt \r\nyour stor" +
        "ed miles for the cabin filter will be reset to 0, and your date \r\nwill be set to" +
        " the current date.");
            this.cabFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.cabFilterChangedBTTN.Click += new System.EventHandler(this.CabFilterChangedBTTN_Click);
            // 
            // engAirFilterTBarLabel
            // 
            this.engAirFilterTBarLabel.AutoSize = true;
            this.engAirFilterTBarLabel.Location = new System.Drawing.Point(19, 462);
            this.engAirFilterTBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engAirFilterTBarLabel.Name = "engAirFilterTBarLabel";
            this.engAirFilterTBarLabel.Size = new System.Drawing.Size(17, 25);
            this.engAirFilterTBarLabel.TabIndex = 22;
            this.engAirFilterTBarLabel.Text = "|";
            // 
            // cabAirFilterTBarLabel
            // 
            this.cabAirFilterTBarLabel.AutoSize = true;
            this.cabAirFilterTBarLabel.Location = new System.Drawing.Point(283, 462);
            this.cabAirFilterTBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabAirFilterTBarLabel.Name = "cabAirFilterTBarLabel";
            this.cabAirFilterTBarLabel.Size = new System.Drawing.Size(17, 25);
            this.cabAirFilterTBarLabel.TabIndex = 23;
            this.cabAirFilterTBarLabel.Text = "|";
            // 
            // calLB
            // 
            this.calLB.AutoSize = true;
            this.calLB.Location = new System.Drawing.Point(42, 376);
            this.calLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calLB.Name = "calLB";
            this.calLB.Size = new System.Drawing.Size(0, 25);
            this.calLB.TabIndex = 12;
            // 
            // generalMessagePanel
            // 
            this.generalMessagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generalMessagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalMessagePanel.Controls.Add(this.generalMessageLB);
            this.generalMessagePanel.Location = new System.Drawing.Point(12, 13);
            this.generalMessagePanel.Name = "generalMessagePanel";
            this.generalMessagePanel.Size = new System.Drawing.Size(520, 106);
            this.generalMessagePanel.TabIndex = 26;
            // 
            // engAirFilterPanel
            // 
            this.engAirFilterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.engAirFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engAirFilterPanel.Controls.Add(this.engDateTimePicker);
            this.engAirFilterPanel.Controls.Add(this.engTextBox);
            this.engAirFilterPanel.Controls.Add(this.engAirFilterLB);
            this.engAirFilterPanel.Location = new System.Drawing.Point(12, 125);
            this.engAirFilterPanel.Name = "engAirFilterPanel";
            this.engAirFilterPanel.Size = new System.Drawing.Size(256, 219);
            this.engAirFilterPanel.TabIndex = 27;
            this.engAirFilterPanel.Tag = "";
            // 
            // engDateTimePicker
            // 
            this.engDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.engDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.engDateTimePicker.Location = new System.Drawing.Point(11, 124);
            this.engDateTimePicker.Name = "engDateTimePicker";
            this.engDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.engDateTimePicker.TabIndex = 4;
            // 
            // engTextBox
            // 
            this.engTextBox.Location = new System.Drawing.Point(11, 34);
            this.engTextBox.Name = "engTextBox";
            this.engTextBox.Size = new System.Drawing.Size(200, 31);
            this.engTextBox.TabIndex = 3;
            // 
            // cabAirFilterPanel
            // 
            this.cabAirFilterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cabAirFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cabAirFilterPanel.Controls.Add(this.cabDateTimePicker);
            this.cabAirFilterPanel.Controls.Add(this.cabTextBox);
            this.cabAirFilterPanel.Controls.Add(this.cabAirFilterLB);
            this.cabAirFilterPanel.Location = new System.Drawing.Point(276, 125);
            this.cabAirFilterPanel.Name = "cabAirFilterPanel";
            this.cabAirFilterPanel.Size = new System.Drawing.Size(256, 219);
            this.cabAirFilterPanel.TabIndex = 28;
            // 
            // cabDateTimePicker
            // 
            this.cabDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.cabDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cabDateTimePicker.Location = new System.Drawing.Point(11, 124);
            this.cabDateTimePicker.Name = "cabDateTimePicker";
            this.cabDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.cabDateTimePicker.TabIndex = 5;
            // 
            // cabTextBox
            // 
            this.cabTextBox.Location = new System.Drawing.Point(11, 34);
            this.cabTextBox.Name = "cabTextBox";
            this.cabTextBox.Size = new System.Drawing.Size(200, 31);
            this.cabTextBox.TabIndex = 4;
            // 
            // AirFilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 834);
            this.ControlBox = false;
            this.Controls.Add(this.cabAirFilterPanel);
            this.Controls.Add(this.engAirFilterPanel);
            this.Controls.Add(this.generalMessagePanel);
            this.Controls.Add(this.engAirFilterTBarLabel);
            this.Controls.Add(this.cabMaxMilesLabel);
            this.Controls.Add(this.cabFilterChangedBTTN);
            this.Controls.Add(this.engFilterChangedBTTN);
            this.Controls.Add(this.engMaxMilesLabel);
            this.Controls.Add(this.calLB);
            this.Controls.Add(this.cabAirFilterTBarLabel);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.cabAirFilter);
            this.Controls.Add(this.engAirFilter);
            this.Controls.Add(this.engAirFilterTB);
            this.Controls.Add(this.cabAirFilterTB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AirFilterOptionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Air Filter";
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).EndInit();
            this.generalMessagePanel.ResumeLayout(false);
            this.generalMessagePanel.PerformLayout();
            this.engAirFilterPanel.ResumeLayout(false);
            this.engAirFilterPanel.PerformLayout();
            this.cabAirFilterPanel.ResumeLayout(false);
            this.cabAirFilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button engAirFilter;
        private System.Windows.Forms.Button cabAirFilter;
        private System.Windows.Forms.Label engAirFilterLB;
        private System.Windows.Forms.Label cabAirFilterLB;
        private System.Windows.Forms.TrackBar engAirFilterTB;
        private System.Windows.Forms.TrackBar cabAirFilterTB;
        private System.Windows.Forms.Button exitBTTN;
        private System.Windows.Forms.Label generalMessageLB;
        private System.Windows.Forms.Label engMaxMilesLabel;
        private System.Windows.Forms.Label cabMaxMilesLabel;
        private System.Windows.Forms.Button engFilterChangedBTTN;
        private System.Windows.Forms.Button cabFilterChangedBTTN;
        private System.Windows.Forms.Label engAirFilterTBarLabel;
        private System.Windows.Forms.Label cabAirFilterTBarLabel;
        private System.Windows.Forms.ToolTip engMaxMilesLabelToolTip;
        private System.Windows.Forms.ToolTip cabMaxMilesLabelToolTip;
        private System.Windows.Forms.Label calLB;
        private System.Windows.Forms.Panel generalMessagePanel;
        private System.Windows.Forms.Panel engAirFilterPanel;
        private System.Windows.Forms.Panel cabAirFilterPanel;
        private System.Windows.Forms.ToolTip engFilterReplacementToolTip;
        private System.Windows.Forms.ToolTip cabFilterReplacementToolTip;
        private System.Windows.Forms.TextBox engTextBox;
        private System.Windows.Forms.TextBox cabTextBox;
        private System.Windows.Forms.DateTimePicker engDateTimePicker;
        private System.Windows.Forms.DateTimePicker cabDateTimePicker;
    }
}