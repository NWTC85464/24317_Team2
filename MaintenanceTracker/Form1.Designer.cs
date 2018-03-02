namespace MaintenanceTracker
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tiresButton
            // 
            this.tiresButton.Location = new System.Drawing.Point(64, 415);
            this.tiresButton.Name = "tiresButton";
            this.tiresButton.Size = new System.Drawing.Size(80, 80);
            this.tiresButton.TabIndex = 0;
            this.tiresButton.Text = "Tires";
            this.tiresButton.UseVisualStyleBackColor = true;
            this.tiresButton.Click += new System.EventHandler(this.tiresButton_Click);
            // 
            // wipersButton
            // 
            this.wipersButton.Location = new System.Drawing.Point(157, 415);
            this.wipersButton.Name = "wipersButton";
            this.wipersButton.Size = new System.Drawing.Size(80, 80);
            this.wipersButton.TabIndex = 1;
            this.wipersButton.Text = "Wipers";
            this.wipersButton.UseVisualStyleBackColor = true;
            this.wipersButton.Click += new System.EventHandler(this.wipersButton_Click);
            // 
            // airFilterButton
            // 
            this.airFilterButton.Location = new System.Drawing.Point(243, 415);
            this.airFilterButton.Name = "airFilterButton";
            this.airFilterButton.Size = new System.Drawing.Size(80, 80);
            this.airFilterButton.TabIndex = 2;
            this.airFilterButton.Text = "Air Filter";
            this.airFilterButton.UseVisualStyleBackColor = true;
            this.airFilterButton.Click += new System.EventHandler(this.airFilterButton_Click);
            // 
            // oilButton
            // 
            this.oilButton.Location = new System.Drawing.Point(64, 501);
            this.oilButton.Name = "oilButton";
            this.oilButton.Size = new System.Drawing.Size(80, 80);
            this.oilButton.TabIndex = 3;
            this.oilButton.Text = "Oil";
            this.oilButton.UseVisualStyleBackColor = true;
            this.oilButton.Click += new System.EventHandler(this.oilButton_Click);
            // 
            // mpgButton
            // 
            this.mpgButton.Location = new System.Drawing.Point(157, 501);
            this.mpgButton.Name = "mpgButton";
            this.mpgButton.Size = new System.Drawing.Size(80, 80);
            this.mpgButton.TabIndex = 4;
            this.mpgButton.Text = "MPG";
            this.mpgButton.UseVisualStyleBackColor = true;
            this.mpgButton.Click += new System.EventHandler(this.mpgButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(243, 501);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 80);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(130, 613);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 53);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 667);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.mpgButton);
            this.Controls.Add(this.oilButton);
            this.Controls.Add(this.airFilterButton);
            this.Controls.Add(this.wipersButton);
            this.Controls.Add(this.tiresButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tiresButton;
        private System.Windows.Forms.Button wipersButton;
        private System.Windows.Forms.Button airFilterButton;
        private System.Windows.Forms.Button oilButton;
        private System.Windows.Forms.Button mpgButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

