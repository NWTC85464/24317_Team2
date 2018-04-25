namespace MaintenanceTracker
{
    partial class MainTracker
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
            this.tiresButton = new System.Windows.Forms.Button();
            this.wipersButton = new System.Windows.Forms.Button();
            this.airFilterButton = new System.Windows.Forms.Button();
            this.oilButton = new System.Windows.Forms.Button();
            this.mpgButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicalSelectList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tiresButton
            // 
            this.tiresButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tiresButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tiresButton.Location = new System.Drawing.Point(276, 468);
            this.tiresButton.Name = "tiresButton";
            this.tiresButton.Size = new System.Drawing.Size(122, 128);
            this.tiresButton.TabIndex = 0;
            this.tiresButton.Text = "Tires";
            this.tiresButton.UseVisualStyleBackColor = true;
            this.tiresButton.Click += new System.EventHandler(this.tiresButton_Click);
            // 
            // wipersButton
            // 
            this.wipersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wipersButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wipersButton.Location = new System.Drawing.Point(142, 468);
            this.wipersButton.Name = "wipersButton";
            this.wipersButton.Size = new System.Drawing.Size(122, 128);
            this.wipersButton.TabIndex = 1;
            this.wipersButton.Text = "Wipers";
            this.wipersButton.UseVisualStyleBackColor = true;
            this.wipersButton.Click += new System.EventHandler(this.wipersButton_Click);
            // 
            // airFilterButton
            // 
            this.airFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.airFilterButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.airFilterButton.Location = new System.Drawing.Point(10, 468);
            this.airFilterButton.Name = "airFilterButton";
            this.airFilterButton.Size = new System.Drawing.Size(122, 130);
            this.airFilterButton.TabIndex = 2;
            this.airFilterButton.Text = "Air Filter";
            this.airFilterButton.UseVisualStyleBackColor = true;
            this.airFilterButton.Click += new System.EventHandler(this.airFilterButton_Click);
            // 
            // oilButton
            // 
            this.oilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oilButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oilButton.Location = new System.Drawing.Point(10, 334);
            this.oilButton.Name = "oilButton";
            this.oilButton.Size = new System.Drawing.Size(191, 128);
            this.oilButton.TabIndex = 3;
            this.oilButton.Text = "Oil";
            this.oilButton.UseVisualStyleBackColor = true;
            this.oilButton.Click += new System.EventHandler(this.oilButton_Click);
            // 
            // mpgButton
            // 
            this.mpgButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mpgButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mpgButton.Location = new System.Drawing.Point(207, 334);
            this.mpgButton.Name = "mpgButton";
            this.mpgButton.Size = new System.Drawing.Size(191, 128);
            this.mpgButton.TabIndex = 4;
            this.mpgButton.Text = "MPG";
            this.mpgButton.UseVisualStyleBackColor = true;
            this.mpgButton.Click += new System.EventHandler(this.mpgButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.settingsButton.Location = new System.Drawing.Point(8, 610);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(388, 46);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // vehicalSelectList
            // 
            this.vehicalSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicalSelectList.FormattingEnabled = true;
            this.vehicalSelectList.Items.AddRange(new object[] {
            "Vehicle #1",
            "Vehicle #2",
            "Vehicle #3",
            "Vehicle #4"});
            this.vehicalSelectList.Location = new System.Drawing.Point(103, 12);
            this.vehicalSelectList.Name = "vehicalSelectList";
            this.vehicalSelectList.Size = new System.Drawing.Size(191, 33);
            this.vehicalSelectList.TabIndex = 24;
            this.vehicalSelectList.Text = "Select A Vehicle";
            this.vehicalSelectList.SelectedIndexChanged += new System.EventHandler(this.vehicalSelectList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vehicalSelectList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.mpgButton);
            this.Controls.Add(this.oilButton);
            this.Controls.Add(this.airFilterButton);
            this.Controls.Add(this.wipersButton);
            this.Controls.Add(this.tiresButton);
            this.Name = "MainTracker";
            this.Text = "Maintenance Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tiresButton;
        private System.Windows.Forms.Button wipersButton;
        private System.Windows.Forms.Button airFilterButton;
        private System.Windows.Forms.Button oilButton;
        private System.Windows.Forms.Button mpgButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vehicalSelectList;
        private System.Windows.Forms.Button button1;
    }
}

