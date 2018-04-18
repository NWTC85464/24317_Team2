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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirFilterOptionsForm));
            this.engAirFilter = new System.Windows.Forms.Button();
            this.cabAirFilter = new System.Windows.Forms.Button();
            this.engAirFilterLB = new System.Windows.Forms.Label();
            this.cabAirFilterLB = new System.Windows.Forms.Label();
            this.engAirFilterTB = new System.Windows.Forms.TrackBar();
            this.cabAirFilterTB = new System.Windows.Forms.TrackBar();
            this.resetBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.calLB = new System.Windows.Forms.Label();
            this.generalMessageLB = new System.Windows.Forms.Label();
            this.engMaxMilesLabel = new System.Windows.Forms.Label();
            this.cabMaxMilesLabel = new System.Windows.Forms.Label();
            this.engFilterChangedBTTN = new System.Windows.Forms.Button();
            this.cabFilterChangedBTTN = new System.Windows.Forms.Button();
            this.engAirFilterTBarLabel = new System.Windows.Forms.Label();
            this.cabAirFilterTBarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).BeginInit();
            this.SuspendLayout();
            // 
            // engAirFilter
            // 
            this.engAirFilter.Location = new System.Drawing.Point(44, 553);
            this.engAirFilter.Margin = new System.Windows.Forms.Padding(4);
            this.engAirFilter.Name = "engAirFilter";
            this.engAirFilter.Size = new System.Drawing.Size(176, 177);
            this.engAirFilter.TabIndex = 0;
            this.engAirFilter.Text = "Engine Air Filter Settings";
            this.engAirFilter.UseVisualStyleBackColor = true;
            this.engAirFilter.Click += new System.EventHandler(this.EngAirFilter_Click);
            // 
            // cabAirFilter
            // 
            this.cabAirFilter.Location = new System.Drawing.Point(308, 553);
            this.cabAirFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cabAirFilter.Name = "cabAirFilter";
            this.cabAirFilter.Size = new System.Drawing.Size(176, 177);
            this.cabAirFilter.TabIndex = 1;
            this.cabAirFilter.Text = "Cabin Air Filter Settings";
            this.cabAirFilter.UseVisualStyleBackColor = true;
            this.cabAirFilter.Click += new System.EventHandler(this.CabAirFilter_Click);
            // 
            // engAirFilterLB
            // 
            this.engAirFilterLB.AutoSize = true;
            this.engAirFilterLB.Location = new System.Drawing.Point(12, 121);
            this.engAirFilterLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.engAirFilterLB.Name = "engAirFilterLB";
            this.engAirFilterLB.Size = new System.Drawing.Size(165, 25);
            this.engAirFilterLB.TabIndex = 4;
            this.engAirFilterLB.Text = "Engine Air Filter";
            // 
            // cabAirFilterLB
            // 
            this.cabAirFilterLB.AutoSize = true;
            this.cabAirFilterLB.Location = new System.Drawing.Point(12, 190);
            this.cabAirFilterLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cabAirFilterLB.Name = "cabAirFilterLB";
            this.cabAirFilterLB.Size = new System.Drawing.Size(154, 25);
            this.cabAirFilterLB.TabIndex = 5;
            this.cabAirFilterLB.Text = "Cabin Air Filter";
            // 
            // engAirFilterTB
            // 
            this.engAirFilterTB.Location = new System.Drawing.Point(44, 362);
            this.engAirFilterTB.Margin = new System.Windows.Forms.Padding(4);
            this.engAirFilterTB.Name = "engAirFilterTB";
            this.engAirFilterTB.Size = new System.Drawing.Size(176, 90);
            this.engAirFilterTB.TabIndex = 6;
            // 
            // cabAirFilterTB
            // 
            this.cabAirFilterTB.Location = new System.Drawing.Point(308, 362);
            this.cabAirFilterTB.Margin = new System.Windows.Forms.Padding(4);
            this.cabAirFilterTB.Name = "cabAirFilterTB";
            this.cabAirFilterTB.Size = new System.Drawing.Size(176, 90);
            this.cabAirFilterTB.TabIndex = 7;
            // 
            // resetBTTN
            // 
            this.resetBTTN.Location = new System.Drawing.Point(44, 738);
            this.resetBTTN.Margin = new System.Windows.Forms.Padding(4);
            this.resetBTTN.Name = "resetBTTN";
            this.resetBTTN.Size = new System.Drawing.Size(176, 56);
            this.resetBTTN.TabIndex = 9;
            this.resetBTTN.Text = "Reset";
            this.resetBTTN.UseVisualStyleBackColor = true;
            this.resetBTTN.Click += new System.EventHandler(this.ResetBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.Location = new System.Drawing.Point(308, 738);
            this.exitBTTN.Margin = new System.Windows.Forms.Padding(4);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(176, 56);
            this.exitBTTN.TabIndex = 8;
            this.exitBTTN.Text = "Exit";
            this.exitBTTN.UseVisualStyleBackColor = true;
            this.exitBTTN.Click += new System.EventHandler(this.ExitBTTN_Click);
            // 
            // calLB
            // 
            this.calLB.AutoSize = true;
            this.calLB.Location = new System.Drawing.Point(40, 348);
            this.calLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calLB.Name = "calLB";
            this.calLB.Size = new System.Drawing.Size(0, 25);
            this.calLB.TabIndex = 12;
            // 
            // generalMessageLB
            // 
            this.generalMessageLB.AutoSize = true;
            this.generalMessageLB.Location = new System.Drawing.Point(12, 17);
            this.generalMessageLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.generalMessageLB.Name = "generalMessageLB";
            this.generalMessageLB.Size = new System.Drawing.Size(0, 25);
            this.generalMessageLB.TabIndex = 13;
            // 
            // engMaxMilesLabel
            // 
            this.engMaxMilesLabel.AutoSize = true;
            this.engMaxMilesLabel.Location = new System.Drawing.Point(12, 333);
            this.engMaxMilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.engMaxMilesLabel.Name = "engMaxMilesLabel";
            this.engMaxMilesLabel.Size = new System.Drawing.Size(116, 25);
            this.engMaxMilesLabel.TabIndex = 18;
            this.engMaxMilesLabel.Text = "Max Miles:";
            // 
            // cabMaxMilesLabel
            // 
            this.cabMaxMilesLabel.AutoSize = true;
            this.cabMaxMilesLabel.Location = new System.Drawing.Point(278, 333);
            this.cabMaxMilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cabMaxMilesLabel.Name = "cabMaxMilesLabel";
            this.cabMaxMilesLabel.Size = new System.Drawing.Size(116, 25);
            this.cabMaxMilesLabel.TabIndex = 19;
            this.cabMaxMilesLabel.Text = "Max Miles:";
            // 
            // engFilterChangedBTTN
            // 
            this.engFilterChangedBTTN.Location = new System.Drawing.Point(44, 470);
            this.engFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(6);
            this.engFilterChangedBTTN.Name = "engFilterChangedBTTN";
            this.engFilterChangedBTTN.Size = new System.Drawing.Size(176, 75);
            this.engFilterChangedBTTN.TabIndex = 20;
            this.engFilterChangedBTTN.Text = "Engine Filter Replaced";
            this.engFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.engFilterChangedBTTN.Click += new System.EventHandler(this.EngFilterChangedBTTN_Click);
            // 
            // cabFilterChangedBTTN
            // 
            this.cabFilterChangedBTTN.Location = new System.Drawing.Point(308, 470);
            this.cabFilterChangedBTTN.Margin = new System.Windows.Forms.Padding(6);
            this.cabFilterChangedBTTN.Name = "cabFilterChangedBTTN";
            this.cabFilterChangedBTTN.Size = new System.Drawing.Size(176, 75);
            this.cabFilterChangedBTTN.TabIndex = 21;
            this.cabFilterChangedBTTN.Text = "Cabin Filter Replaced";
            this.cabFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.cabFilterChangedBTTN.Click += new System.EventHandler(this.CabFilterChangedBTTN_Click);
            // 
            // engAirFilterTBarLabel
            // 
            this.engAirFilterTBarLabel.AutoSize = true;
            this.engAirFilterTBarLabel.Location = new System.Drawing.Point(40, 427);
            this.engAirFilterTBarLabel.Name = "engAirFilterTBarLabel";
            this.engAirFilterTBarLabel.Size = new System.Drawing.Size(0, 25);
            this.engAirFilterTBarLabel.TabIndex = 22;
            // 
            // cabAirFilterTBarLabel
            // 
            this.cabAirFilterTBarLabel.AutoSize = true;
            this.cabAirFilterTBarLabel.Location = new System.Drawing.Point(303, 427);
            this.cabAirFilterTBarLabel.Name = "cabAirFilterTBarLabel";
            this.cabAirFilterTBarLabel.Size = new System.Drawing.Size(0, 25);
            this.cabAirFilterTBarLabel.TabIndex = 23;
            // 
            // AirFilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 835);
            this.Controls.Add(this.cabAirFilterTBarLabel);
            this.Controls.Add(this.engAirFilterTBarLabel);
            this.Controls.Add(this.cabFilterChangedBTTN);
            this.Controls.Add(this.engFilterChangedBTTN);
            this.Controls.Add(this.cabMaxMilesLabel);
            this.Controls.Add(this.engMaxMilesLabel);
            this.Controls.Add(this.generalMessageLB);
            this.Controls.Add(this.calLB);
            this.Controls.Add(this.cabAirFilterTBarLabel);
            this.Controls.Add(this.resetBTTN);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.cabAirFilterTB);
            this.Controls.Add(this.engAirFilterTB);
            this.Controls.Add(this.cabAirFilterLB);
            this.Controls.Add(this.engAirFilterLB);
            this.Controls.Add(this.cabAirFilter);
            this.Controls.Add(this.engAirFilter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AirFilterOptionsForm";
            this.ShowIcon = false;
            this.Text = "Air Filter";
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).EndInit();
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
        private System.Windows.Forms.Label calLB;
        private System.Windows.Forms.Label generalMessageLB;
        private System.Windows.Forms.Label engMaxMilesLabel;
        private System.Windows.Forms.Label cabMaxMilesLabel;
        private System.Windows.Forms.Button engFilterChangedBTTN;
        private System.Windows.Forms.Button cabFilterChangedBTTN;
        private System.Windows.Forms.Label engAirFilterTBarLabel;
        private System.Windows.Forms.Label cabAirFilterTBarLabel;
    }
}