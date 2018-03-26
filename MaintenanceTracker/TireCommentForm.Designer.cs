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
            this.commentFormClearButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.commentsLbl = new System.Windows.Forms.Label();
            this.saveCommentButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentFormClearButton
            // 
            this.commentFormClearButton.Location = new System.Drawing.Point(31, 353);
            this.commentFormClearButton.Name = "commentFormClearButton";
            this.commentFormClearButton.Size = new System.Drawing.Size(135, 53);
            this.commentFormClearButton.TabIndex = 0;
            this.commentFormClearButton.Text = "Clear";
            this.commentFormClearButton.UseVisualStyleBackColor = true;
            this.commentFormClearButton.Click += new System.EventHandler(this.commentFormClearButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(31, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 298);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // commentsLbl
            // 
            this.commentsLbl.AutoSize = true;
            this.commentsLbl.Location = new System.Drawing.Point(107, 9);
            this.commentsLbl.Name = "commentsLbl";
            this.commentsLbl.Size = new System.Drawing.Size(203, 20);
            this.commentsLbl.TabIndex = 3;
            this.commentsLbl.Text = "Enter Additional Comments";
            // 
            // saveCommentButton
            // 
            this.saveCommentButton.Location = new System.Drawing.Point(242, 353);
            this.saveCommentButton.Name = "saveCommentButton";
            this.saveCommentButton.Size = new System.Drawing.Size(135, 53);
            this.saveCommentButton.TabIndex = 4;
            this.saveCommentButton.Text = "Save";
            this.saveCommentButton.UseVisualStyleBackColor = true;
            this.saveCommentButton.Click += new System.EventHandler(this.saveCommentButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(139, 602);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(135, 53);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // TireCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 667);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveCommentButton);
            this.Controls.Add(this.commentsLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.commentFormClearButton);
            this.Name = "TireCommentForm";
            this.Text = "Comments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commentFormClearButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label commentsLbl;
        private System.Windows.Forms.Button saveCommentButton;
        private System.Windows.Forms.Button returnButton;
    }
}