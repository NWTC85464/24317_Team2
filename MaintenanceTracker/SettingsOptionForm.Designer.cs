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
            this.button1 = new System.Windows.Forms.Button();
            this.carNum = new System.Windows.Forms.ComboBox();
            this.delLbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carNum
            // 
            this.carNum.FormattingEnabled = true;
            this.carNum.Items.AddRange(new object[] {
            "Vehicle 1",
            "Vehicle 2",
            "Vehicle 3",
            "Vehicle 4"});
            this.carNum.Location = new System.Drawing.Point(127, 156);
            this.carNum.Name = "carNum";
            this.carNum.Size = new System.Drawing.Size(148, 28);
            this.carNum.TabIndex = 1;
            this.carNum.Text = "Select Vehicle";
            // 
            // delLbl
            // 
            this.delLbl.AutoSize = true;
            this.delLbl.BackColor = System.Drawing.Color.Transparent;
            this.delLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delLbl.Location = new System.Drawing.Point(49, 9);
            this.delLbl.Name = "delLbl";
            this.delLbl.Size = new System.Drawing.Size(299, 26);
            this.delLbl.TabIndex = 2;
            this.delLbl.Text = "Delete Vehicle Saved Files";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.Control;
            this.returnBtn.Location = new System.Drawing.Point(127, 573);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(142, 46);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // SettingsOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(407, 667);
            this.ControlBox = false;
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.delLbl);
            this.Controls.Add(this.carNum);
            this.Controls.Add(this.button1);
            this.Name = "SettingsOptionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SettingsOptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox carNum;
        private System.Windows.Forms.Label delLbl;
        private System.Windows.Forms.Button returnBtn;
    }
}