namespace MaintenanceTracker
{
    partial class SettingsOptionForm
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
            this.theme1Btn = new System.Windows.Forms.Button();
            this.theme2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // theme1Btn
            // 
            this.theme1Btn.Location = new System.Drawing.Point(0, 0);
            this.theme1Btn.Name = "theme1Btn";
            this.theme1Btn.Size = new System.Drawing.Size(75, 23);
            this.theme1Btn.TabIndex = 2;
            // 
            // theme2Btn
            // 
            this.theme2Btn.Location = new System.Drawing.Point(0, 0);
            this.theme2Btn.Name = "theme2Btn";
            this.theme2Btn.Size = new System.Drawing.Size(75, 23);
            this.theme2Btn.TabIndex = 1;
            // 
            // SettingsOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(407, 667);
            this.Controls.Add(this.theme2Btn);
            this.Controls.Add(this.theme1Btn);
            this.Name = "SettingsOptionForm";
            this.Text = "SettingsOptionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button theme1Btn;
        private System.Windows.Forms.Button theme2Btn;
    }
}