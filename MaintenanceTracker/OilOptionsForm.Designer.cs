namespace MaintenanceTracker
{
    partial class OilOptionsForm
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
            this.Options = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TrackBar();
            this.Lock = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.TxTBOX1 = new System.Windows.Forms.TextBox();
            this.TxTBOX2 = new System.Windows.Forms.TextBox();
            this.Answer1 = new System.Windows.Forms.TextBox();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.TotalTxT = new System.Windows.Forms.TextBox();
            this.AmountTotal = new System.Windows.Forms.TextBox();
            this.box_GYR = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Option button
            // 
            this.Options.Location = new System.Drawing.Point(210, 360);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(117, 51);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // Exit button
            // 
            this.Exit.Location = new System.Drawing.Point(210, 303);
            this.Exit.Name = "exit";
            this.Exit.Size = new System.Drawing.Size(117, 51);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // trackBar oil amount
            // 
            this.Amount.Location = new System.Drawing.Point(0, 243);
            this.Amount.Name = "amount";
            this.Amount.Size = new System.Drawing.Size(253, 45);
            this.Amount.Maximum = 60;
            this.Amount.Scroll += new System.EventHandler(this.FindNumber);
            // 
            // Lock button
            // 
            this.Lock.Location = new System.Drawing.Point(259, 243);
            this.Lock.Name = "lockButton";
            this.Lock.Size = new System.Drawing.Size(68, 35);
            this.Lock.TabIndex = 3;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.LockScoll);
            // 
            // Information TxT
            // 
            this.Information.Location = new System.Drawing.Point(12, 300);
            this.Information.Name = "richTextBox1";
            this.Information.Size = new System.Drawing.Size(180, 100);
            this.Information.TabIndex = 4;
            this.Information.Text = "";
            this.Information.ReadOnly = true;
            // 
            // Brand of oil using
            // 
            this.TxTBOX1.Location = new System.Drawing.Point(12, 89);
            this.TxTBOX1.Name = "brandOfOil";
            this.TxTBOX1.Text = "Brand of oil using";
            this.TxTBOX1.Size = new System.Drawing.Size(130, 20);
            this.TxTBOX1.TabIndex = 8;
            this.TxTBOX1.ReadOnly = true;
            //
            // brand
            //
            this.Answer1.Location = new System.Drawing.Point(150, 89);
            this.Answer1.Name = "brand";
            this.Answer1.Text = "";
            this.Answer1.Size = new System.Drawing.Size(130, 20);
            this.Answer1.TabIndex = 8;
            // 
            // Type of oil using
            // 
            this.TxTBOX2.Location = new System.Drawing.Point(12, 128);
            this.TxTBOX2.Name = "oilType";
            this.TxTBOX2.Text = "Type of oil using";
            this.TxTBOX2.Size = new System.Drawing.Size(130, 20);
            this.TxTBOX2.TabIndex = 8;
            this.TxTBOX2.ReadOnly = true;
            //
            // oil
            //
            this.Answer2.Location = new System.Drawing.Point(150, 128);
            this.Answer2.Name = "brand";
            this.Answer2.Text = "";
            this.Answer2.Size = new System.Drawing.Size(130, 20);
            this.Answer2.TabIndex = 8;
            // 
            // 
            // Oil Amount Text
            // 
            this.TotalTxT.Location = new System.Drawing.Point(12, 192);
            this.TotalTxT.Name = "OilAmount";
            this.TotalTxT.Text = "Oil Amount";
            this.TotalTxT.Size = new System.Drawing.Size(166, 20);
            this.TotalTxT.TabIndex = 6;
            this.TotalTxT.ReadOnly = true;
            // 
            // Oil Amount Total
            // 
            this.AmountTotal.Location = new System.Drawing.Point(210, 192);
            this.AmountTotal.Name = "AmountTxT";
            this.AmountTotal.Size = new System.Drawing.Size(74, 20);
            this.AmountTotal.TabIndex = 7;
            //
            // Time to change or not
            // 
            this.box_GYR.AllowDrop = true;
            this.box_GYR.Location = new System.Drawing.Point(12, 12);
            this.box_GYR.Name = "box_GYR";
            this.box_GYR.Size = new System.Drawing.Size(253, 45);
            this.box_GYR.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 423);
            this.Controls.Add(this.box_GYR);
            this.Controls.Add(this.TxTBOX2);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.AmountTotal);
            this.Controls.Add(this.TotalTxT);
            this.Controls.Add(this.TxTBOX1);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Options);
            this.Name = "oil Form";
            this.Text = "Oil Options Form";
            this.Load += new System.EventHandler(this.OilTrackerForm);
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TrackBar Amount;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.TextBox TxTBOX1;
        private System.Windows.Forms.TextBox TotalTxT;
        private System.Windows.Forms.TextBox Answer1;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.TextBox AmountTotal;
        private System.Windows.Forms.TextBox TxTBOX2;
        private System.Windows.Forms.TrackBar box_GYR;
    }
}

