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
            this.installLbl = new System.Windows.Forms.Label();
            this.sldLbl = new System.Windows.Forms.Label();
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
            this.percentLbl = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tireMilLbl = new System.Windows.Forms.Label();
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
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(213, 578);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Back";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(11, 578);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(194, 77);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // installLbl
            // 
            this.installLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installLbl.Location = new System.Drawing.Point(62, 250);
            this.installLbl.Name = "installLbl";
            this.installLbl.Size = new System.Drawing.Size(171, 27);
            this.installLbl.TabIndex = 12;
            this.installLbl.Text = "Tire Install Date:";
            this.installLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sldLbl
            // 
            this.sldLbl.AutoSize = true;
            this.sldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sldLbl.Location = new System.Drawing.Point(58, 128);
            this.sldLbl.Name = "sldLbl";
            this.sldLbl.Size = new System.Drawing.Size(283, 20);
            this.sldLbl.TabIndex = 19;
            this.sldLbl.Text = "Adjust slider to set rotation milage";
            // 
            // installDateTextBox
            // 
            this.installDateTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.installDateTextBox.Location = new System.Drawing.Point(239, 251);
            this.installDateTextBox.Name = "installDateTextBox";
            this.installDateTextBox.Size = new System.Drawing.Size(102, 26);
            this.installDateTextBox.TabIndex = 2;
            this.installDateTextBox.Text = "10-10-2016";
            this.installDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.installDateTextBox.Click += new System.EventHandler(this.installDateTextBox_Click);
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
            this.sliderValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValueLbl.Location = new System.Drawing.Point(109, 194);
            this.sliderValueLbl.Name = "sliderValueLbl";
            this.sliderValueLbl.Size = new System.Drawing.Size(107, 37);
            this.sliderValueLbl.TabIndex = 17;
            this.sliderValueLbl.Text = "0";
            this.sliderValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // milageTrackBar
            // 
            this.milageTrackBar.AutoSize = false;
            this.milageTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.milageTrackBar.LargeChange = 100;
            this.milageTrackBar.Location = new System.Drawing.Point(62, 151);
            this.milageTrackBar.Maximum = 10000;
            this.milageTrackBar.Name = "milageTrackBar";
            this.milageTrackBar.Size = new System.Drawing.Size(279, 40);
            this.milageTrackBar.SmallChange = 100;
            this.milageTrackBar.TabIndex = 4;
            this.milageTrackBar.TickFrequency = 100;
            this.milageTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.milageTrackBar.Value = 5000;
            this.milageTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveValuesButton
            // 
            this.saveValuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveValuesButton.Location = new System.Drawing.Point(11, 367);
            this.saveValuesButton.Name = "saveValuesButton";
            this.saveValuesButton.Size = new System.Drawing.Size(387, 44);
            this.saveValuesButton.TabIndex = 6;
            this.saveValuesButton.Text = "Save All";
            this.saveValuesButton.UseVisualStyleBackColor = true;
            this.saveValuesButton.Click += new System.EventHandler(this.saveValuesButton_Click);
            // 
            // milesLbl
            // 
            this.milesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLbl.Location = new System.Drawing.Point(208, 194);
            this.milesLbl.Name = "milesLbl";
            this.milesLbl.Size = new System.Drawing.Size(71, 37);
            this.milesLbl.TabIndex = 18;
            this.milesLbl.Text = "Miles";
            this.milesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lockTrackBarButton
            // 
            this.lockTrackBarButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lockTrackBarButton.Image = ((System.Drawing.Image)(resources.GetObject("lockTrackBarButton.Image")));
            this.lockTrackBarButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("lockTrackBarButton.InitialImage")));
            this.lockTrackBarButton.Location = new System.Drawing.Point(290, 197);
            this.lockTrackBarButton.Name = "lockTrackBarButton";
            this.lockTrackBarButton.Size = new System.Drawing.Size(28, 27);
            this.lockTrackBarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockTrackBarButton.TabIndex = 21;
            this.lockTrackBarButton.TabStop = false;
            this.lockTrackBarButton.Click += new System.EventHandler(this.lockTrackBarButton_Click_1);
            // 
            // tireInfoButton
            // 
            this.tireInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tireInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireInfoButton.Location = new System.Drawing.Point(276, 428);
            this.tireInfoButton.Name = "tireInfoButton";
            this.tireInfoButton.Size = new System.Drawing.Size(122, 130);
            this.tireInfoButton.TabIndex = 5;
            this.tireInfoButton.Text = "Tire Info";
            this.tireInfoButton.UseVisualStyleBackColor = true;
            this.tireInfoButton.Click += new System.EventHandler(this.tireInfoButton_Click);
            // 
            // otherInfoButton
            // 
            this.otherInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otherInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherInfoButton.Location = new System.Drawing.Point(12, 428);
            this.otherInfoButton.Name = "otherInfoButton";
            this.otherInfoButton.Size = new System.Drawing.Size(122, 130);
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
            this.progressBar1.Size = new System.Drawing.Size(386, 43);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 24;
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.BackColor = System.Drawing.SystemColors.Control;
            this.percentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLbl.Location = new System.Drawing.Point(12, 83);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(23, 20);
            this.percentLbl.TabIndex = 27;
            this.percentLbl.Text = "%";
            this.percentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commentButton
            // 
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.Location = new System.Drawing.Point(140, 428);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(130, 130);
            this.commentButton.TabIndex = 28;
            this.commentButton.Text = "Comments";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // setBtn
            // 
            this.setBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBtn.Location = new System.Drawing.Point(11, 367);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(387, 43);
            this.setBtn.TabIndex = 29;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // tireMilLbl
            // 
            this.tireMilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireMilLbl.Location = new System.Drawing.Point(95, 283);
            this.tireMilLbl.Name = "tireMilLbl";
            this.tireMilLbl.Size = new System.Drawing.Size(138, 28);
            this.tireMilLbl.TabIndex = 31;
            this.tireMilLbl.Text = "Tire Milage:";
            this.tireMilLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TireOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(410, 667);
            this.Controls.Add(this.tireMilLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.milageTrackBar);
            this.Controls.Add(this.installLbl);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.sldLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.installDateTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sliderValueLbl);
            this.Controls.Add(this.otherInfoButton);
            this.Controls.Add(this.lockTrackBarButton);
            this.Controls.Add(this.tireInfoButton);
            this.Controls.Add(this.saveValuesButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.milesLbl);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tireOptionsFormLBL);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(432, 723);
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
        private System.Windows.Forms.Label installLbl;
        private System.Windows.Forms.Label sldLbl;
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
        private System.Windows.Forms.Label percentLbl;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tireMilLbl;
    }
}