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
            this.enterBtn.Location = new System.Drawing.Point(57, 288);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(112, 35);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // introLbl1
            // 
            this.introLbl1.AutoSize = true;
            this.introLbl1.Location = new System.Drawing.Point(53, 65);
            this.introLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLbl1.Name = "introLbl1";
            this.introLbl1.Size = new System.Drawing.Size(273, 20);
            this.introLbl1.TabIndex = 1;
            this.introLbl1.Text = "Initial setup requires your cars current";
            this.introLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxStartOdo
            // 
            this.txtbxStartOdo.Location = new System.Drawing.Point(114, 171);
            this.txtbxStartOdo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxStartOdo.Name = "txtbxStartOdo";
            this.txtbxStartOdo.Size = new System.Drawing.Size(148, 26);
            this.txtbxStartOdo.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(213, 288);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // introLbl2
            // 
            this.introLbl2.AutoSize = true;
            this.introLbl2.Location = new System.Drawing.Point(48, 101);
            this.introLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.introLbl2.Name = "introLbl2";
            this.introLbl2.Size = new System.Drawing.Size(280, 20);
            this.introLbl2.TabIndex = 4;
            this.introLbl2.Text = "odometer reading: Please enter below.";
            // 
            // MpgSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(408, 668);
            this.ControlBox = false;
            this.Controls.Add(this.introLbl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.txtbxStartOdo);
            this.Controls.Add(this.introLbl1);
            this.Controls.Add(this.enterBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MpgSetupForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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