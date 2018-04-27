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
            this.engAirFilterTbLb = new System.Windows.Forms.Label();
            this.cabAirFilterTbLb = new System.Windows.Forms.Label();
            this.calLB = new System.Windows.Forms.Label();
            this.generalMessageLB = new System.Windows.Forms.Label();
            this.engMaxMilesLabel = new System.Windows.Forms.Label();
            this.cabMaxMilesLabel = new System.Windows.Forms.Label();
            this.engFilterChangedBTTN = new System.Windows.Forms.Button();
            this.cabFilterChangedBTTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.engAirFilterTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabAirFilterTB)).BeginInit();
            this.SuspendLayout();
            // 
            // engAirFilter
            // 
            this.engAirFilter.Location = new System.Drawing.Point(22, 282);
            this.engAirFilter.Margin = new System.Windows.Forms.Padding(2);
            this.engAirFilter.Name = "engAirFilter";
            this.engAirFilter.Size = new System.Drawing.Size(88, 92);
            this.engAirFilter.TabIndex = 0;
            this.engAirFilter.Text = "Engine Air Filter Settings";
            this.engAirFilter.UseVisualStyleBackColor = true;
            this.engAirFilter.Click += new System.EventHandler(this.EngAirFilter_Click);
            // 
            // cabAirFilter
            // 
            this.cabAirFilter.Location = new System.Drawing.Point(154, 282);
            this.cabAirFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cabAirFilter.Name = "cabAirFilter";
            this.cabAirFilter.Size = new System.Drawing.Size(88, 92);
            this.cabAirFilter.TabIndex = 1;
            this.cabAirFilter.Text = "Cabin Air Filter Settings";
            this.cabAirFilter.UseVisualStyleBackColor = true;
            this.cabAirFilter.Click += new System.EventHandler(this.CabAirFilter_Click);
            // 
            // engAirFilterLB
            // 
            this.engAirFilterLB.AutoSize = true;
            this.engAirFilterLB.Location = new System.Drawing.Point(6, 63);
            this.engAirFilterLB.Name = "engAirFilterLB";
            this.engAirFilterLB.Size = new System.Drawing.Size(80, 13);
            this.engAirFilterLB.TabIndex = 4;
            this.engAirFilterLB.Text = "Engine Air Filter";
            // 
            // cabAirFilterLB
            // 
            this.cabAirFilterLB.AutoSize = true;
            this.cabAirFilterLB.Location = new System.Drawing.Point(6, 99);
            this.cabAirFilterLB.Name = "cabAirFilterLB";
            this.cabAirFilterLB.Size = new System.Drawing.Size(74, 13);
            this.cabAirFilterLB.TabIndex = 5;
            this.cabAirFilterLB.Text = "Cabin Air Filter";
            // 
            // engAirFilterTB
            // 
            this.engAirFilterTB.Location = new System.Drawing.Point(22, 188);
            this.engAirFilterTB.Margin = new System.Windows.Forms.Padding(2);
            this.engAirFilterTB.Name = "engAirFilterTB";
            this.engAirFilterTB.Size = new System.Drawing.Size(88, 45);
            this.engAirFilterTB.TabIndex = 6;
            // 
            // cabAirFilterTB
            // 
            this.cabAirFilterTB.Location = new System.Drawing.Point(154, 188);
            this.cabAirFilterTB.Margin = new System.Windows.Forms.Padding(2);
            this.cabAirFilterTB.Name = "cabAirFilterTB";
            this.cabAirFilterTB.Size = new System.Drawing.Size(88, 45);
            this.cabAirFilterTB.TabIndex = 7;
            // 
            // resetBTTN
            // 
            this.resetBTTN.Location = new System.Drawing.Point(22, 384);
            this.resetBTTN.Margin = new System.Windows.Forms.Padding(2);
            this.resetBTTN.Name = "resetBTTN";
            this.resetBTTN.Size = new System.Drawing.Size(88, 29);
            this.resetBTTN.TabIndex = 9;
            this.resetBTTN.Text = "Reset";
            this.resetBTTN.UseVisualStyleBackColor = true;
            this.resetBTTN.Click += new System.EventHandler(this.ResetBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.Location = new System.Drawing.Point(154, 384);
            this.exitBTTN.Margin = new System.Windows.Forms.Padding(2);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(88, 29);
            this.exitBTTN.TabIndex = 8;
            this.exitBTTN.Text = "Exit";
            this.exitBTTN.UseVisualStyleBackColor = true;
            this.exitBTTN.Click += new System.EventHandler(this.ExitBTTN_Click);
            // 
            // engAirFilterTbLb
            // 
            this.engAirFilterTbLb.AutoSize = true;
            this.engAirFilterTbLb.Location = new System.Drawing.Point(20, 257);
            this.engAirFilterTbLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.engAirFilterTbLb.Name = "engAirFilterTbLb";
            this.engAirFilterTbLb.Size = new System.Drawing.Size(0, 13);
            this.engAirFilterTbLb.TabIndex = 10;
            // 
            // cabAirFilterTbLb
            // 
            this.cabAirFilterTbLb.AutoSize = true;
            this.cabAirFilterTbLb.Location = new System.Drawing.Point(152, 257);
            this.cabAirFilterTbLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cabAirFilterTbLb.Name = "cabAirFilterTbLb";
            this.cabAirFilterTbLb.Size = new System.Drawing.Size(0, 13);
            this.cabAirFilterTbLb.TabIndex = 11;
            // 
            // calLB
            // 
            this.calLB.AutoSize = true;
            this.calLB.Location = new System.Drawing.Point(20, 181);
            this.calLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calLB.Name = "calLB";
            this.calLB.Size = new System.Drawing.Size(0, 13);
            this.calLB.TabIndex = 12;
            // 
            // generalMessageLB
            // 
            this.generalMessageLB.AutoSize = true;
            this.generalMessageLB.Location = new System.Drawing.Point(6, 9);
            this.generalMessageLB.Name = "generalMessageLB";
            this.generalMessageLB.Size = new System.Drawing.Size(0, 13);
            this.generalMessageLB.TabIndex = 13;
            // 
            // engMaxMilesLabel
            // 
            this.engMaxMilesLabel.AutoSize = true;
            this.engMaxMilesLabel.Location = new System.Drawing.Point(6, 173);
            this.engMaxMilesLabel.Name = "engMaxMilesLabel";
            this.engMaxMilesLabel.Size = new System.Drawing.Size(57, 13);
            this.engMaxMilesLabel.TabIndex = 18;
            this.engMaxMilesLabel.Text = "Max Miles:";
            // 
            // cabMaxMilesLabel
            // 
            this.cabMaxMilesLabel.AutoSize = true;
            this.cabMaxMilesLabel.Location = new System.Drawing.Point(139, 173);
            this.cabMaxMilesLabel.Name = "cabMaxMilesLabel";
            this.cabMaxMilesLabel.Size = new System.Drawing.Size(57, 13);
            this.cabMaxMilesLabel.TabIndex = 19;
            this.cabMaxMilesLabel.Text = "Max Miles:";
            // 
            // engFilterChangedBTTN
            // 
            this.engFilterChangedBTTN.Location = new System.Drawing.Point(22, 238);
            this.engFilterChangedBTTN.Name = "engFilterChangedBTTN";
            this.engFilterChangedBTTN.Size = new System.Drawing.Size(88, 39);
            this.engFilterChangedBTTN.TabIndex = 20;
            this.engFilterChangedBTTN.Text = "Engine Filter Replaced";
            this.engFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.engFilterChangedBTTN.Click += new System.EventHandler(this.EngFilterChangedBTTN_Click);
            // 
            // cabFilterChangedBTTN
            // 
            this.cabFilterChangedBTTN.Location = new System.Drawing.Point(154, 238);
            this.cabFilterChangedBTTN.Name = "cabFilterChangedBTTN";
            this.cabFilterChangedBTTN.Size = new System.Drawing.Size(88, 39);
            this.cabFilterChangedBTTN.TabIndex = 21;
            this.cabFilterChangedBTTN.Text = "Cabin Filter Replaced";
            this.cabFilterChangedBTTN.UseVisualStyleBackColor = true;
            this.cabFilterChangedBTTN.Click += new System.EventHandler(this.CabFilterChangedBTTN_Click);
            // 
            // AirFilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 434);
            this.Controls.Add(this.cabFilterChangedBTTN);
            this.Controls.Add(this.engFilterChangedBTTN);
            this.Controls.Add(this.cabMaxMilesLabel);
            this.Controls.Add(this.engMaxMilesLabel);
            this.Controls.Add(this.generalMessageLB);
            this.Controls.Add(this.calLB);
            this.Controls.Add(this.cabAirFilterTbLb);
            this.Controls.Add(this.engAirFilterTbLb);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label engAirFilterTbLb;
        private System.Windows.Forms.Label cabAirFilterTbLb;
        private System.Windows.Forms.Label calLB;
        private System.Windows.Forms.Label generalMessageLB;
        private System.Windows.Forms.Label engMaxMilesLabel;
        private System.Windows.Forms.Label cabMaxMilesLabel;
        private System.Windows.Forms.Button engFilterChangedBTTN;
        private System.Windows.Forms.Button cabFilterChangedBTTN;
    }
}