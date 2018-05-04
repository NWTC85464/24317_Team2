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
            this.brand = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.oilBrand = new System.Windows.Forms.TextBox();
            this.oilUse = new System.Windows.Forms.TextBox();
            this.TotalTxT = new System.Windows.Forms.TextBox();
            this.AmountTotal = new System.Windows.Forms.TextBox();
            this.GYRTXT = new System.Windows.Forms.TextBox();
            this.GYR = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.Control;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(315, 554);
            this.Options.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(176, 78);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(315, 466);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 78);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(0, 374);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount.Maximum = 60;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(380, 69);
            this.Amount.TabIndex = 9;
            this.Amount.Scroll += new System.EventHandler(this.FindNumber);
            // 
            // Lock
            // 
            this.Lock.BackColor = System.Drawing.SystemColors.Control;
            this.Lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lock.Location = new System.Drawing.Point(388, 374);
            this.Lock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(102, 54);
            this.Lock.TabIndex = 3;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = false;
            this.Lock.Click += new System.EventHandler(this.LockScoll);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(18, 462);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Size = new System.Drawing.Size(268, 152);
            this.Information.TabIndex = 4;
            this.Information.Text = "";
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(18, 137);
            this.brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(193, 26);
            this.brand.TabIndex = 8;
            this.brand.Text = "Brand of oil using";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(18, 197);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(193, 26);
            this.type.TabIndex = 8;
            this.type.Text = "Type of oil using";
            // 
            // oilBrand
            // 
            this.oilBrand.Location = new System.Drawing.Point(225, 137);
            this.oilBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oilBrand.Name = "oilBrand";
            this.oilBrand.Size = new System.Drawing.Size(193, 26);
            this.oilBrand.TabIndex = 8;
            this.oilBrand.TextChanged += new System.EventHandler(this.oilBrandChange);
            // 
            // oilUse
            // 
            this.oilUse.Location = new System.Drawing.Point(225, 197);
            this.oilUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oilUse.Name = "oilUse";
            this.oilUse.Size = new System.Drawing.Size(193, 26);
            this.oilUse.TabIndex = 8;
            this.oilUse.TextChanged += new System.EventHandler(this.oilUseChange);
            // 
            // TotalTxT
            // 
            this.TotalTxT.Location = new System.Drawing.Point(18, 295);
            this.TotalTxT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalTxT.Name = "TotalTxT";
            this.TotalTxT.ReadOnly = true;
            this.TotalTxT.Size = new System.Drawing.Size(247, 26);
            this.TotalTxT.TabIndex = 6;
            this.TotalTxT.Text = "Oil Amount";
            // 
            // AmountTotal
            // 
            this.AmountTotal.Location = new System.Drawing.Point(315, 295);
            this.AmountTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTotal.Name = "AmountTotal";
            this.AmountTotal.Size = new System.Drawing.Size(109, 26);
            this.AmountTotal.TabIndex = 7;
            this.AmountTotal.TextChanged += new System.EventHandler(this.TotalChange);
            // 
            // GYRTXT
            // 
            this.GYRTXT.Location = new System.Drawing.Point(10, 77);
            this.GYRTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GYRTXT.Name = "GYRTXT";
            this.GYRTXT.ReadOnly = true;
            this.GYRTXT.Size = new System.Drawing.Size(478, 26);
            this.GYRTXT.TabIndex = 1;
            this.GYRTXT.Text = "GOOD";
            // 
            // GYR
            // 
            this.GYR.Location = new System.Drawing.Point(10, 18);
            this.GYR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GYR.Name = "GYR";
            this.GYR.Size = new System.Drawing.Size(480, 62);
            this.GYR.TabIndex = 0;
            // 
            // OilOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(508, 651);
            this.ControlBox = false;
            this.Controls.Add(this.GYR);
            this.Controls.Add(this.GYRTXT);
            this.Controls.Add(this.type);
            this.Controls.Add(this.oilUse);
            this.Controls.Add(this.AmountTotal);
            this.Controls.Add(this.TotalTxT);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.oilBrand);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Options);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OilOptionsForm";
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
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox TotalTxT;
        private System.Windows.Forms.TextBox oilBrand;
        private System.Windows.Forms.TextBox oilUse;
        private System.Windows.Forms.TextBox AmountTotal;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox GYRTXT;
        private System.Windows.Forms.ProgressBar GYR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

