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
            this.resetBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.generalMessageLB = new System.Windows.Forms.Label();
            this.engMaxMilesLabel = new System.Windows.Forms.Label();
            this.cabMaxMilesLabel = new System.Windows.Forms.Label();
            this.engFilterChangedBTTN = new System.Windows.Forms.Button();
            this.cabFilterChangedBTTN = new System.Windows.Forms.Button();
            this.engAirFilterTBarLabel = new System.Windows.Forms.Label();
            this.cabAirFilterTBarLabel = new System.Windows.Forms.Label();
            this.engAirFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.cabAirFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.engMaxMilesLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.calLB = new System.Windows.Forms.Label();
            this.cabMaxMilesLabelToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).BeginInit();
            this.engAirFilterGroupBox.SuspendLayout();
            this.cabAirFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // engAirFilter
            // 
            this.engAirFilter.Location = new System.Drawing.Point(33, 443);
            this.engAirFilter.Name = "engAirFilter";
            this.engAirFilter.Size = new System.Drawing.Size(132, 142);
            this.engAirFilter.TabIndex = 0;
            this.engAirFilter.Text = "Engine Air Filter Settings";
            this.engAirFilter.UseVisualStyleBackColor = true;
            this.engAirFilter.Click += new System.EventHandler(this.EngAirFilter_Click);
            // 
            // cabAirFilter
            // 
            this.cabAirFilter.Location = new System.Drawing.Point(231, 443);
            this.cabAirFilter.Name = "cabAirFilter";
            this.cabAirFilter.Size = new System.Drawing.Size(132, 142);
            this.cabAirFilter.TabIndex = 1;
            this.cabAirFilter.Text = "Cabin Air Filter Settings";
            this.cabAirFilter.UseVisualStyleBackColor = true;
            this.cabAirFilter.Click += new System.EventHandler(this.CabAirFilter_Click);
            // 
            // engAirFilterLB
            // 
            this.engAirFilterLB.AutoSize = true;
            this.engAirFilterLB.Location = new System.Drawing.Point(4, 15);
            this.engAirFilterLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engAirFilterLB.Name = "engAirFilterLB";
            this.engAirFilterLB.Size = new System.Drawing.Size(14, 20);
            this.engAirFilterLB.TabIndex = 4;
            this.engAirFilterLB.Text = "|";
            // 
            // cabAirFilterLB
            // 
            this.cabAirFilterLB.AutoSize = true;
            this.cabAirFilterLB.Location = new System.Drawing.Point(4, 15);
            this.cabAirFilterLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabAirFilterLB.Name = "cabAirFilterLB";
            this.cabAirFilterLB.Size = new System.Drawing.Size(14, 20);
            this.cabAirFilterLB.TabIndex = 5;
            this.cabAirFilterLB.Text = "|";
            // 
            // engAirFilterTB
            // 
            this.engAirFilterTB.Location = new System.Drawing.Point(33, 290);
            this.engAirFilterTB.Name = "engAirFilterTB";
            this.engAirFilterTB.Size = new System.Drawing.Size(132, 69);
            this.engAirFilterTB.TabIndex = 6;
            // 
            // cabAirFilterTB
            // 
            this.cabAirFilterTB.Location = new System.Drawing.Point(231, 290);
            this.cabAirFilterTB.Name = "cabAirFilterTB";
            this.cabAirFilterTB.Size = new System.Drawing.Size(132, 69);
            this.cabAirFilterTB.TabIndex = 7;
            // 
            // resetBTTN
            // 
            this.resetBTTN.Location = new System.Drawing.Point(33, 590);
            this.resetBTTN.Name = "resetBTTN";
            this.resetBTTN.Size = new System.Drawing.Size(132, 45);
            this.resetBTTN.TabIndex = 9;
            this.resetBTTN.Text = "Reset";
            this.resetBTTN.UseVisualStyleBackColor = true;
            this.resetBTTN.Click += new System.EventHandler(this.ResetBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.Location = new System.Drawing.Point(231, 590);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(132, 45);
            this.exitBTTN.TabIndex = 8;
            this.exitBTTN.Text = "Exit";
            this.exitBTTN.UseVisualStyleBackColor = true;
            this.exitBTTN.Click += new System.EventHandler(this.ExitBTTN_Click);
            // 
            // generalMessageLB
            // 
            this.generalMessageLB.AutoSize = true;
            this.generalMessageLB.Location = new System.Drawing.Point(9, 14);
            this.generalMessageLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generalMessageLB.Name = "generalMessageLB";
            this.generalMessageLB.Size = new System.Drawing.Size(0, 20);
            this.generalMessageLB.TabIndex = 13;
            // 
            // engMaxMilesLabel
            // 
            this.engMaxMilesLabel.AutoSize = true;
            this.engMaxMilesLabel.Location = new System.Drawing.Point(9, 266);
            this.engMaxMilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engMaxMilesLabel.Name = "engMaxMilesLabel";
            this.engMaxMilesLabel.Size = new System.Drawing.Size(176, 20);
            this.engMaxMilesLabel.TabIndex = 18;
            this.engMaxMilesLabel.Text = "Miles Before Replacing:";
            this.engMaxMilesLabelToolTip.SetToolTip(this.engMaxMilesLabel, "Set the amount of miles you would like to drive before replacing your engine air " +
        "filter.\r\n");
            // 
            // cabMaxMilesLabel
            // 
            this.cabMaxMilesLabel.AutoSize = true;
            this.cabMaxMilesLabel.Location = new System.Drawing.Point(207, 266);
            this.cabMaxMilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabMaxMilesLabel.Name = "cabMaxMilesLabel";
            this.cabMaxMilesLabel.Size = new System.Drawing.Size(176, 20);
            this.cabMaxMilesLabel.TabIndex = 19;
            this.cabMaxMilesLabel.Text = "Miles Before Replacing:";
            this.cabMaxMilesLabelToolTip.SetToolTip(this.cabMaxMilesLabel, "Set the amount of miles you would like to drive before replacing your cabin air f" +
        "ilter.");
            // 
            // engFilterChangedBTTN
            // 
            this.engFilterChangedBTTN.Location = new System.Drawing.Point(33, 375);
            this.engFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.engFilterChangedBTTN.Name = "engFilterChangedBTTN";
            this.engFilterChangedBTTN.Size = new System.Drawing.Size(132, 60);
            this.engFilterChangedBTTN.TabIndex = 20;
            this.engFilterChangedBTTN.Text = "Engine Filter Replaced";
            this.engFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.engFilterChangedBTTN.Click += new System.EventHandler(this.EngFilterChangedBTTN_Click);
            // 
            // cabFilterChangedBTTN
            // 
            this.cabFilterChangedBTTN.Location = new System.Drawing.Point(231, 375);
            this.cabFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cabFilterChangedBTTN.Name = "cabFilterChangedBTTN";
            this.cabFilterChangedBTTN.Size = new System.Drawing.Size(132, 60);
            this.cabFilterChangedBTTN.TabIndex = 21;
            this.cabFilterChangedBTTN.Text = "Cabin Filter Replaced";
            this.cabFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.cabFilterChangedBTTN.Click += new System.EventHandler(this.CabFilterChangedBTTN_Click);
            // 
            // engAirFilterTBarLabel
            // 
            this.engAirFilterTBarLabel.AutoSize = true;
            this.engAirFilterTBarLabel.Location = new System.Drawing.Point(30, 342);
            this.engAirFilterTBarLabel.Name = "engAirFilterTBarLabel";
            this.engAirFilterTBarLabel.Size = new System.Drawing.Size(0, 20);
            this.engAirFilterTBarLabel.TabIndex = 22;
            // 
            // cabAirFilterTBarLabel
            // 
            this.cabAirFilterTBarLabel.AutoSize = true;
            this.cabAirFilterTBarLabel.Location = new System.Drawing.Point(228, 342);
            this.cabAirFilterTBarLabel.Name = "cabAirFilterTBarLabel";
            this.cabAirFilterTBarLabel.Size = new System.Drawing.Size(0, 20);
            this.cabAirFilterTBarLabel.TabIndex = 23;
            // 
            // engAirFilterGroupBox
            // 
            this.engAirFilterGroupBox.Controls.Add(this.engAirFilterLB);
            this.engAirFilterGroupBox.Location = new System.Drawing.Point(12, 130);
            this.engAirFilterGroupBox.Name = "engAirFilterGroupBox";
            this.engAirFilterGroupBox.Size = new System.Drawing.Size(188, 238);
            this.engAirFilterGroupBox.TabIndex = 24;
            this.engAirFilterGroupBox.TabStop = false;
            // 
            // cabAirFilterGroupBox
            // 
            this.cabAirFilterGroupBox.Controls.Add(this.cabAirFilterLB);
            this.cabAirFilterGroupBox.Location = new System.Drawing.Point(210, 130);
            this.cabAirFilterGroupBox.Name = "cabAirFilterGroupBox";
            this.cabAirFilterGroupBox.Size = new System.Drawing.Size(188, 238);
            this.cabAirFilterGroupBox.TabIndex = 25;
            this.cabAirFilterGroupBox.TabStop = false;
            // 
            // calLB
            // 
            this.calLB.AutoSize = true;
            this.calLB.Location = new System.Drawing.Point(30, 278);
            this.calLB.Name = "calLB";
            this.calLB.Size = new System.Drawing.Size(0, 20);
            this.calLB.TabIndex = 12;
            // 
            // AirFilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 668);
            this.ControlBox = false;
            this.Controls.Add(this.engAirFilterTBarLabel);
            this.Controls.Add(this.cabMaxMilesLabel);
            this.Controls.Add(this.cabFilterChangedBTTN);
            this.Controls.Add(this.engFilterChangedBTTN);
            this.Controls.Add(this.engMaxMilesLabel);
            this.Controls.Add(this.generalMessageLB);
            this.Controls.Add(this.calLB);
            this.Controls.Add(this.cabAirFilterTBarLabel);
            this.Controls.Add(this.resetBTTN);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.cabAirFilterTB);
            this.Controls.Add(this.engAirFilterTB);
            this.Controls.Add(this.cabAirFilter);
            this.Controls.Add(this.engAirFilter);
            this.Controls.Add(this.cabAirFilterGroupBox);
            this.Controls.Add(this.engAirFilterGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AirFilterOptionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Air Filter";
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).EndInit();
            this.engAirFilterGroupBox.ResumeLayout(false);
            this.engAirFilterGroupBox.PerformLayout();
            this.cabAirFilterGroupBox.ResumeLayout(false);
            this.cabAirFilterGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button resetBTTN;
        private System.Windows.Forms.Button exitBTTN;
        private System.Windows.Forms.Label generalMessageLB;
        private System.Windows.Forms.Label engMaxMilesLabel;
        private System.Windows.Forms.Label cabMaxMilesLabel;
        private System.Windows.Forms.Button engFilterChangedBTTN;
        private System.Windows.Forms.Button cabFilterChangedBTTN;
        private System.Windows.Forms.Label engAirFilterTBarLabel;
        private System.Windows.Forms.Label cabAirFilterTBarLabel;
        private System.Windows.Forms.GroupBox engAirFilterGroupBox;
        private System.Windows.Forms.GroupBox cabAirFilterGroupBox;
        private System.Windows.Forms.ToolTip engMaxMilesLabelToolTip;
        private System.Windows.Forms.ToolTip cabMaxMilesLabelToolTip;
        private System.Windows.Forms.Label calLB;
    }
}