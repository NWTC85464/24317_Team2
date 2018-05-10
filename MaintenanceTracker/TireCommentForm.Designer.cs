namespace MaintenanceTracker
{
    partial class TireCommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TireCommentForm));
            this.returnButton = new System.Windows.Forms.Button();
            this.commentFormClearButton = new System.Windows.Forms.Button();
            this.saveCommentButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notePadLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.Name = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // commentFormClearButton
            // 
            this.commentFormClearButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.commentFormClearButton, "commentFormClearButton");
            this.commentFormClearButton.Name = "commentFormClearButton";
            this.commentFormClearButton.UseVisualStyleBackColor = false;
            this.commentFormClearButton.Click += new System.EventHandler(this.commentFormClearButton_Click);
            // 
            // saveCommentButton
            // 
            this.saveCommentButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.saveCommentButton, "saveCommentButton");
            this.saveCommentButton.Name = "saveCommentButton";
            this.saveCommentButton.UseVisualStyleBackColor = false;
            this.saveCommentButton.Click += new System.EventHandler(this.saveCommentButton_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // notePadLbl
            // 
            resources.ApplyResources(this.notePadLbl, "notePadLbl");
            this.notePadLbl.Name = "notePadLbl";
            // 
            // TireCommentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ControlBox = false;
            this.Controls.Add(this.notePadLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveCommentButton);
            this.Controls.Add(this.commentFormClearButton);
            this.Controls.Add(this.returnButton);
            this.Name = "TireCommentForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.TireCommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button commentFormClearButton;
        private System.Windows.Forms.Button saveCommentButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label notePadLbl;
    }
}