namespace MaintenanceTracker
{
    partial class MPGOptionsForm
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
            this.btnEnterMpg = new System.Windows.Forms.Button();
            this.lblOdometer = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.txtbxOdoRead = new System.Windows.Forms.TextBox();
            this.txtbxGallonsRead = new System.Windows.Forms.TextBox();
            this.lblCurrentMpg = new System.Windows.Forms.Label();
            this.lblShowCurrentMpg = new System.Windows.Forms.Label();
            this.lblLifetimeMpg = new System.Windows.Forms.Label();
            this.lblShowLifeMpg = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.dgTrack = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitMpg = new System.Windows.Forms.Button();
            this.mpgList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterMpg
            // 
            this.btnEnterMpg.Location = new System.Drawing.Point(105, 115);
            this.btnEnterMpg.Name = "btnEnterMpg";
            this.btnEnterMpg.Size = new System.Drawing.Size(111, 42);
            this.btnEnterMpg.TabIndex = 0;
            this.btnEnterMpg.Text = "Enter MPG";
            this.btnEnterMpg.UseVisualStyleBackColor = true;
            this.btnEnterMpg.Click += new System.EventHandler(this.btnEnterMpg_Click);
            // 
            // lblOdometer
            // 
            this.lblOdometer.AutoSize = true;
            this.lblOdometer.Location = new System.Drawing.Point(29, 25);
            this.lblOdometer.Name = "lblOdometer";
            this.lblOdometer.Size = new System.Drawing.Size(123, 17);
            this.lblOdometer.TabIndex = 1;
            this.lblOdometer.Text = "Odometer reading";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(197, 25);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(89, 17);
            this.lblGallons.TabIndex = 2;
            this.lblGallons.Text = "Gallons filled";
            // 
            // txtbxOdoRead
            // 
            this.txtbxOdoRead.Location = new System.Drawing.Point(32, 76);
            this.txtbxOdoRead.Name = "txtbxOdoRead";
            this.txtbxOdoRead.Size = new System.Drawing.Size(100, 22);
            this.txtbxOdoRead.TabIndex = 3;
            // 
            // txtbxGallonsRead
            // 
            this.txtbxGallonsRead.Location = new System.Drawing.Point(200, 75);
            this.txtbxGallonsRead.Name = "txtbxGallonsRead";
            this.txtbxGallonsRead.Size = new System.Drawing.Size(100, 22);
            this.txtbxGallonsRead.TabIndex = 4;
            // 
            // lblCurrentMpg
            // 
            this.lblCurrentMpg.AutoSize = true;
            this.lblCurrentMpg.Location = new System.Drawing.Point(32, 172);
            this.lblCurrentMpg.Name = "lblCurrentMpg";
            this.lblCurrentMpg.Size = new System.Drawing.Size(90, 17);
            this.lblCurrentMpg.TabIndex = 5;
            this.lblCurrentMpg.Text = "Current MPG";
            // 
            // lblShowCurrentMpg
            // 
            this.lblShowCurrentMpg.AutoSize = true;
            this.lblShowCurrentMpg.Location = new System.Drawing.Point(32, 220);
            this.lblShowCurrentMpg.Name = "lblShowCurrentMpg";
            this.lblShowCurrentMpg.Size = new System.Drawing.Size(90, 17);
            this.lblShowCurrentMpg.TabIndex = 6;
            this.lblShowCurrentMpg.Text = "Current Here";
            // 
            // lblLifetimeMpg
            // 
            this.lblLifetimeMpg.AutoSize = true;
            this.lblLifetimeMpg.Location = new System.Drawing.Point(200, 172);
            this.lblLifetimeMpg.Name = "lblLifetimeMpg";
            this.lblLifetimeMpg.Size = new System.Drawing.Size(92, 17);
            this.lblLifetimeMpg.TabIndex = 7;
            this.lblLifetimeMpg.Text = "Lifetime MPG";
            // 
            // lblShowLifeMpg
            // 
            this.lblShowLifeMpg.AutoSize = true;
            this.lblShowLifeMpg.Location = new System.Drawing.Point(200, 219);
            this.lblShowLifeMpg.Name = "lblShowLifeMpg";
            this.lblShowLifeMpg.Size = new System.Drawing.Size(61, 17);
            this.lblShowLifeMpg.TabIndex = 8;
            this.lblShowLifeMpg.Text = "life Here";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(29, 51);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 17);
            this.lblAlert.TabIndex = 10;
            // 
            // dgTrack
            // 
            this.dgTrack.AllowUserToDeleteRows = false;
            this.dgTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgTrack.Location = new System.Drawing.Point(12, 364);
            this.dgTrack.Name = "dgTrack";
            this.dgTrack.ReadOnly = true;
            this.dgTrack.RowTemplate.Height = 24;
            this.dgTrack.Size = new System.Drawing.Size(338, 114);
            this.dgTrack.TabIndex = 11;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MPG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ODO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GAL";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // btnExitMpg
            // 
            this.btnExitMpg.Location = new System.Drawing.Point(140, 484);
            this.btnExitMpg.Name = "btnExitMpg";
            this.btnExitMpg.Size = new System.Drawing.Size(76, 38);
            this.btnExitMpg.TabIndex = 12;
            this.btnExitMpg.Text = "Exit MPG";
            this.btnExitMpg.UseVisualStyleBackColor = true;
            this.btnExitMpg.Click += new System.EventHandler(this.btnExitMpg_Click);
            // 
            // mpgList
            // 
            this.mpgList.FormattingEnabled = true;
            this.mpgList.ItemHeight = 16;
            this.mpgList.Location = new System.Drawing.Point(35, 249);
            this.mpgList.Name = "mpgList";
            this.mpgList.Size = new System.Drawing.Size(268, 84);
            this.mpgList.TabIndex = 13;
            // 
            // MPGOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 534);
            this.Controls.Add(this.mpgList);
            this.Controls.Add(this.btnExitMpg);
            this.Controls.Add(this.dgTrack);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblShowLifeMpg);
            this.Controls.Add(this.lblLifetimeMpg);
            this.Controls.Add(this.lblShowCurrentMpg);
            this.Controls.Add(this.lblCurrentMpg);
            this.Controls.Add(this.txtbxGallonsRead);
            this.Controls.Add(this.txtbxOdoRead);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblOdometer);
            this.Controls.Add(this.btnEnterMpg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MPGOptionsForm";
            this.Text = "MPGOptionsForm";
            this.Load += new System.EventHandler(this.MPGOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterMpg;
        private System.Windows.Forms.Label lblOdometer;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.TextBox txtbxOdoRead;
        private System.Windows.Forms.TextBox txtbxGallonsRead;
        private System.Windows.Forms.Label lblCurrentMpg;
        private System.Windows.Forms.Label lblShowCurrentMpg;
        private System.Windows.Forms.Label lblLifetimeMpg;
        private System.Windows.Forms.Label lblShowLifeMpg;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.DataGridView dgTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnExitMpg;
        private System.Windows.Forms.ListBox mpgList;
    }
}