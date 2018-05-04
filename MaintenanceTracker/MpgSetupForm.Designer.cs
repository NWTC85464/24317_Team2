namespace MaintenanceTracker
{
    partial class MpgSetupForm
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.introLbl1 = new System.Windows.Forms.Label();
            this.txtbxStartOdo = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.introLbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(51, 230);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 28);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // introLbl1
            // 
            this.introLbl1.AutoSize = true;
            this.introLbl1.Location = new System.Drawing.Point(47, 52);
            this.introLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLbl1.Name = "introLbl1";
            this.introLbl1.Size = new System.Drawing.Size(247, 17);
            this.introLbl1.TabIndex = 1;
            this.introLbl1.Text = "Initial setup requires your cars current";
            this.introLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxStartOdo
            // 
            this.txtbxStartOdo.Location = new System.Drawing.Point(101, 137);
            this.txtbxStartOdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxStartOdo.Name = "txtbxStartOdo";
            this.txtbxStartOdo.Size = new System.Drawing.Size(132, 22);
            this.txtbxStartOdo.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(189, 230);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // introLbl2
            // 
            this.introLbl2.AutoSize = true;
            this.introLbl2.Location = new System.Drawing.Point(43, 81);
            this.introLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLbl2.Name = "introLbl2";
            this.introLbl2.Size = new System.Drawing.Size(252, 17);
            this.introLbl2.TabIndex = 4;
            this.introLbl2.Text = "odometer reading: Please enter below.";
            // 
            // MpgSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(363, 534);
            this.ControlBox = false;
            this.Controls.Add(this.introLbl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.txtbxStartOdo);
            this.Controls.Add(this.introLbl1);
            this.Controls.Add(this.enterBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MpgSetupForm";
            this.Text = "MpgSetupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label introLbl1;
        private System.Windows.Forms.TextBox txtbxStartOdo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label introLbl2;
    }
}