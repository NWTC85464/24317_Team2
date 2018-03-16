namespace MaintenanceTracker
{
    partial class TireOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TireOptionsForm));
            this.tireOptionsFormLBL = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.setMilageLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.installDateTextBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.sliderValueLbl = new System.Windows.Forms.Label();
            this.milageTrackBar = new System.Windows.Forms.TrackBar();
            this.saveValuesButton = new System.Windows.Forms.Button();
            this.milesLbl = new System.Windows.Forms.Label();
            this.lockTrackBarButton = new System.Windows.Forms.PictureBox();
            this.tireInfoButton = new System.Windows.Forms.Button();
            this.otherInfoButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rotateMilagelbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.milageTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockTrackBarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tireOptionsFormLBL
            // 
            this.tireOptionsFormLBL.AutoSize = true;
            this.tireOptionsFormLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireOptionsFormLBL.Location = new System.Drawing.Point(122, 9);
            this.tireOptionsFormLBL.Name = "tireOptionsFormLBL";
            this.tireOptionsFormLBL.Size = new System.Drawing.Size(186, 25);
            this.tireOptionsFormLBL.TabIndex = 9;
            this.tireOptionsFormLBL.Text = "Tire Options Form";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(232, 578);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 57);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(34, 578);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 57);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Installed date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // setMilageLbl
            // 
            this.setMilageLbl.AutoSize = true;
            this.setMilageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMilageLbl.Location = new System.Drawing.Point(75, 179);
            this.setMilageLbl.Name = "setMilageLbl";
            this.setMilageLbl.Size = new System.Drawing.Size(233, 29);
            this.setMilageLbl.TabIndex = 16;
            this.setMilageLbl.Text = "Set rotation milage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Adjust slider to set rotation milage";
            // 
            // installDateTextBox
            // 
            this.installDateTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.installDateTextBox.Location = new System.Drawing.Point(199, 150);
            this.installDateTextBox.Name = "installDateTextBox";
            this.installDateTextBox.Size = new System.Drawing.Size(135, 26);
            this.installDateTextBox.TabIndex = 2;
            this.installDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLbl
            // 
            this.infoLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(-2, 0);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(94, 47);
            this.infoLbl.TabIndex = 15;
            this.infoLbl.Text = "Info";
            this.infoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderValueLbl
            // 
            this.sliderValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sliderValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sliderValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValueLbl.Location = new System.Drawing.Point(95, 213);
            this.sliderValueLbl.Name = "sliderValueLbl";
            this.sliderValueLbl.Size = new System.Drawing.Size(107, 37);
            this.sliderValueLbl.TabIndex = 17;
            this.sliderValueLbl.Text = "0";
            this.sliderValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // milageTrackBar
            // 
            this.milageTrackBar.AutoSize = false;
            this.milageTrackBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.milageTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.milageTrackBar.LargeChange = 100;
            this.milageTrackBar.Location = new System.Drawing.Point(55, 283);
            this.milageTrackBar.Maximum = 10000;
            this.milageTrackBar.Name = "milageTrackBar";
            this.milageTrackBar.Size = new System.Drawing.Size(279, 40);
            this.milageTrackBar.SmallChange = 100;
            this.milageTrackBar.TabIndex = 4;
            this.milageTrackBar.TickFrequency = 100;
            this.milageTrackBar.Value = 5000;
            this.milageTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveValuesButton
            // 
            this.saveValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveValuesButton.Location = new System.Drawing.Point(210, 329);
            this.saveValuesButton.Name = "saveValuesButton";
            this.saveValuesButton.Size = new System.Drawing.Size(135, 53);
            this.saveValuesButton.TabIndex = 6;
            this.saveValuesButton.Text = "Save";
            this.saveValuesButton.UseVisualStyleBackColor = true;
            this.saveValuesButton.Click += new System.EventHandler(this.saveValuesButton_Click);
            // 
            // milesLbl
            // 
            this.milesLbl.BackColor = System.Drawing.SystemColors.Control;
            this.milesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLbl.Location = new System.Drawing.Point(205, 213);
            this.milesLbl.Name = "milesLbl";
            this.milesLbl.Size = new System.Drawing.Size(87, 37);
            this.milesLbl.TabIndex = 18;
            this.milesLbl.Text = "Miles";
            this.milesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lockTrackBarButton
            // 
            this.lockTrackBarButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lockTrackBarButton.Image = ((System.Drawing.Image)(resources.GetObject("lockTrackBarButton.Image")));
            this.lockTrackBarButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("lockTrackBarButton.InitialImage")));
            this.lockTrackBarButton.Location = new System.Drawing.Point(340, 296);
            this.lockTrackBarButton.Name = "lockTrackBarButton";
            this.lockTrackBarButton.Size = new System.Drawing.Size(28, 27);
            this.lockTrackBarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockTrackBarButton.TabIndex = 21;
            this.lockTrackBarButton.TabStop = false;
            this.lockTrackBarButton.Click += new System.EventHandler(this.lockTrackBarButton_Click_1);
            // 
            // tireInfoButton
            // 
            this.tireInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireInfoButton.Location = new System.Drawing.Point(229, 510);
            this.tireInfoButton.Name = "tireInfoButton";
            this.tireInfoButton.Size = new System.Drawing.Size(135, 53);
            this.tireInfoButton.TabIndex = 5;
            this.tireInfoButton.Text = "Tire Info";
            this.tireInfoButton.UseVisualStyleBackColor = true;
            this.tireInfoButton.Click += new System.EventHandler(this.tireInfoButton_Click);
            // 
            // otherInfoButton
            // 
            this.otherInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherInfoButton.Location = new System.Drawing.Point(34, 510);
            this.otherInfoButton.Name = "otherInfoButton";
            this.otherInfoButton.Size = new System.Drawing.Size(135, 53);
            this.otherInfoButton.TabIndex = 22;
            this.otherInfoButton.Text = "Tips";
            this.otherInfoButton.UseVisualStyleBackColor = true;
            this.otherInfoButton.Click += new System.EventHandler(this.otherInfoButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(12, 37);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(386, 45);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 24;
            // 
            // rotateMilagelbl
            // 
            this.rotateMilagelbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rotateMilagelbl.BackColor = System.Drawing.Color.Transparent;
            this.rotateMilagelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rotateMilagelbl.Location = new System.Drawing.Point(336, 88);
            this.rotateMilagelbl.Name = "rotateMilagelbl";
            this.rotateMilagelbl.Size = new System.Drawing.Size(68, 20);
            this.rotateMilagelbl.TabIndex = 26;
            this.rotateMilagelbl.Text = "0";
            this.rotateMilagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Location = new System.Drawing.Point(135, 85);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(144, 20);
            this.percentLbl.TabIndex = 27;
            this.percentLbl.Text = "Percent Remaining";
            // 
            // commentButton
            // 
            this.commentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.Location = new System.Drawing.Point(34, 444);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(135, 53);
            this.commentButton.TabIndex = 28;
            this.commentButton.Text = "Comments";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // TireOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 667);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.rotateMilagelbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.otherInfoButton);
            this.Controls.Add(this.tireInfoButton);
            this.Controls.Add(this.lockTrackBarButton);
            this.Controls.Add(this.milesLbl);
            this.Controls.Add(this.saveValuesButton);
            this.Controls.Add(this.milageTrackBar);
            this.Controls.Add(this.sliderValueLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.installDateTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setMilageLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tireOptionsFormLBL);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "TireOptionsForm";
            this.Text = "TireOptionsForm";
            this.Load += new System.EventHandler(this.TireOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milageTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockTrackBarButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tireOptionsFormLBL;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label setMilageLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox installDateTextBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label sliderValueLbl;
        private System.Windows.Forms.TrackBar milageTrackBar;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveValuesButton;
        private System.Windows.Forms.Label milesLbl;
        private System.Windows.Forms.PictureBox lockTrackBarButton;
        private System.Windows.Forms.Button tireInfoButton;
        private System.Windows.Forms.Button otherInfoButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label rotateMilagelbl;
        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Button commentButton;
    }
}