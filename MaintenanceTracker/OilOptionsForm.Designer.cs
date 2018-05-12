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
            this.notesButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TrackBar();
            this.Lock = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.brand = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.oilBrand = new System.Windows.Forms.TextBox();
            this.oilUse = new System.Windows.Forms.TextBox();
            this.TotalTxT = new System.Windows.Forms.Label();
            this.AmountTotal = new System.Windows.Forms.TextBox();
            this.GYRTXT = new System.Windows.Forms.TextBox();
            this.GYR = new System.Windows.Forms.ProgressBar();
            this.Notes = new System.Windows.Forms.RichTextBox();
            this.SaveNotes = new System.Windows.Forms.Button();
            this.StartingDateTxT = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.ODStartingTxT = new System.Windows.Forms.Label();
            this.ODStart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.SystemColors.Control;
            this.notesButton.Location = new System.Drawing.Point(216, 445);
            this.notesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(129, 78);
            this.notesButton.TabIndex = 0;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.NotesButton);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(216, 548);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 78);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit and Save";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(120, 349);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amount.Maximum = 60;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(393, 69);
            this.Amount.TabIndex = 9;
            this.Amount.Scroll += new System.EventHandler(this.FindNumber);
            // 
            // Lock
            // 
            this.Lock.BackColor = System.Drawing.SystemColors.Control;
            this.Lock.Location = new System.Drawing.Point(348, 445);
            this.Lock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(84, 182);
            this.Lock.TabIndex = 3;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.LockScoll);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(15, 445);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Size = new System.Drawing.Size(192, 182);
            this.Information.TabIndex = 4;
            this.Information.Text = "";
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(15, 137);
            this.brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(167, 31);
            this.brand.TabIndex = 8;
            this.brand.Text = "Brand of oil using:";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(15, 197);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(167, 31);
            this.type.TabIndex = 8;
            this.type.Text = "Type of oil using:";
            // 
            // oilBrand
            // 
            this.oilBrand.Location = new System.Drawing.Point(193, 137);
            this.oilBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oilBrand.Name = "oilBrand";
            this.oilBrand.Size = new System.Drawing.Size(166, 26);
            this.oilBrand.TabIndex = 8;
            this.oilBrand.TextChanged += new System.EventHandler(this.oilBrandChange);
            // 
            // oilUse
            // 
            this.oilUse.Location = new System.Drawing.Point(193, 197);
            this.oilUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oilUse.Name = "oilUse";
            this.oilUse.Size = new System.Drawing.Size(166, 26);
            this.oilUse.TabIndex = 8;
            this.oilUse.TextChanged += new System.EventHandler(this.oilUseChange);
            // 
            // TotalTxT
            // 
            this.TotalTxT.Location = new System.Drawing.Point(4, 362);
            this.TotalTxT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalTxT.Name = "TotalTxT";
            this.TotalTxT.Size = new System.Drawing.Size(213, 31);
            this.TotalTxT.TabIndex = 6;
            this.TotalTxT.Text = "Oil Amount:";
            // 
            // AmountTotal
            // 
            this.AmountTotal.Location = new System.Drawing.Point(321, 362);
            this.AmountTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTotal.Name = "AmountTotal";
            this.AmountTotal.Size = new System.Drawing.Size(94, 26);
            this.AmountTotal.TabIndex = 7;
            this.AmountTotal.TextChanged += new System.EventHandler(this.TotalChange);
            // 
            // GYRTXT
            // 
            this.GYRTXT.Location = new System.Drawing.Point(9, 77);
            this.GYRTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GYRTXT.Name = "GYRTXT";
            this.GYRTXT.ReadOnly = true;
            this.GYRTXT.Size = new System.Drawing.Size(504, 26);
            this.GYRTXT.TabIndex = 1;
            this.GYRTXT.Text = "GOOD";
            this.GYRTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GYR
            // 
            this.GYR.Location = new System.Drawing.Point(13, 28);
            this.GYR.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.GYR.Name = "GYR";
            this.GYR.Size = new System.Drawing.Size(500, 95);
            this.GYR.TabIndex = 0;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(15, 18);
            this.Notes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(404, 382);
            this.Notes.TabIndex = 4;
            this.Notes.Text = "";
            this.Notes.Visible = false;
            // 
            // SaveNotes
            // 
            this.SaveNotes.Location = new System.Drawing.Point(26, 466);
            this.SaveNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveNotes.Name = "SaveNotes";
            this.SaveNotes.Size = new System.Drawing.Size(150, 78);
            this.SaveNotes.TabIndex = 1;
            this.SaveNotes.Text = "Save";
            this.SaveNotes.UseVisualStyleBackColor = true;
            this.SaveNotes.Visible = false;
            this.SaveNotes.Click += new System.EventHandler(this.SavingNotes);
            // 
            // StartingDateTxT
            // 
            this.StartingDateTxT.Location = new System.Drawing.Point(15, 308);
            this.StartingDateTxT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartingDateTxT.Name = "StartingDateTxT";
            this.StartingDateTxT.Size = new System.Drawing.Size(167, 31);
            this.StartingDateTxT.TabIndex = 8;
            this.StartingDateTxT.Text = "Last Oil Change:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(193, 308);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(166, 26);
            this.Start.TabIndex = 9;
            this.Start.TabStop = false;
            this.Start.Value = new System.DateTime(2018, 5, 11, 22, 28, 42, 764);
            this.Start.ValueChanged += new System.EventHandler(this.StartingDatePicker);
            // 
            // ODStartingTxT
            // 
            this.ODStartingTxT.Location = new System.Drawing.Point(15, 257);
            this.ODStartingTxT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ODStartingTxT.Name = "ODStartingTxT";
            this.ODStartingTxT.Size = new System.Drawing.Size(167, 31);
            this.ODStartingTxT.TabIndex = 8;
            this.ODStartingTxT.Text = "Begaining OD Reading:";
            // 
            // ODStart
            // 
            this.ODStart.Location = new System.Drawing.Point(193, 257);
            this.ODStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ODStart.Name = "ODStart";
            this.ODStart.Size = new System.Drawing.Size(166, 26);
            this.ODStart.TabIndex = 8;
            this.ODStart.TextChanged += new System.EventHandler(this.ODFirstReading);
            // 
            // OilOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(532, 1028);
            this.ControlBox = false;
            this.Controls.Add(this.GYRTXT);
            this.Controls.Add(this.GYR);
            this.Controls.Add(this.StartingDateTxT);
            this.Controls.Add(this.ODStartingTxT);
            this.Controls.Add(this.ODStart);
            this.Controls.Add(this.type);
            this.Controls.Add(this.oilUse);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.AmountTotal);
            this.Controls.Add(this.TotalTxT);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.oilBrand);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.SaveNotes);
            this.Controls.Add(this.Start);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OilOptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Oil Options Form";
            this.Load += new System.EventHandler(this.OilTrackerForm);
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TrackBar Amount;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label TotalTxT;
        private System.Windows.Forms.TextBox oilBrand;
        private System.Windows.Forms.TextBox oilUse;
        private System.Windows.Forms.TextBox AmountTotal;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox GYRTXT;
        private System.Windows.Forms.ProgressBar GYR;
        private System.Windows.Forms.RichTextBox Notes;
        private System.Windows.Forms.Button SaveNotes;
        private System.Windows.Forms.Label StartingDateTxT;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.Label ODStartingTxT;
        private System.Windows.Forms.TextBox ODStart;
    }
}

