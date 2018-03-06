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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.setMilageLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tireSizeTextBox = new System.Windows.Forms.TextBox();
            this.installDateTextBox = new System.Windows.Forms.TextBox();
            this.tireBrandTextBox = new System.Windows.Forms.TextBox();
            this.prevRotateDateTextBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.sliderValueLbl = new System.Windows.Forms.Label();
            this.milageTrackBar = new System.Windows.Forms.TrackBar();
            this.storeValuesButton = new System.Windows.Forms.Button();
            this.storeLbl = new System.Windows.Forms.Label();
            this.milesLbl = new System.Windows.Forms.Label();
            this.lockTrackBarButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.milageTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockTrackBarButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tireOptionsFormLBL
            // 
            this.tireOptionsFormLBL.AutoSize = true;
            this.tireOptionsFormLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireOptionsFormLBL.Location = new System.Drawing.Point(118, 9);
            this.tireOptionsFormLBL.Name = "tireOptionsFormLBL";
            this.tireOptionsFormLBL.Size = new System.Drawing.Size(186, 25);
            this.tireOptionsFormLBL.TabIndex = 9;
            this.tireOptionsFormLBL.Text = "Tire Options Form";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(232, 590);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(34, 590);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 45);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter tire size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter tire brand:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last rotation date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Installed date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // setMilageLbl
            // 
            this.setMilageLbl.AutoSize = true;
            this.setMilageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMilageLbl.Location = new System.Drawing.Point(86, 239);
            this.setMilageLbl.Name = "setMilageLbl";
            this.setMilageLbl.Size = new System.Drawing.Size(233, 29);
            this.setMilageLbl.TabIndex = 16;
            this.setMilageLbl.Text = "Set rotation milage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Adjust slider to set rotation milage";
            // 
            // tireSizeTextBox
            // 
            this.tireSizeTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tireSizeTextBox.Location = new System.Drawing.Point(230, 41);
            this.tireSizeTextBox.Name = "tireSizeTextBox";
            this.tireSizeTextBox.Size = new System.Drawing.Size(135, 26);
            this.tireSizeTextBox.TabIndex = 0;
            this.tireSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // installDateTextBox
            // 
            this.installDateTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.installDateTextBox.Location = new System.Drawing.Point(230, 105);
            this.installDateTextBox.Name = "installDateTextBox";
            this.installDateTextBox.Size = new System.Drawing.Size(135, 26);
            this.installDateTextBox.TabIndex = 2;
            this.installDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tireBrandTextBox
            // 
            this.tireBrandTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tireBrandTextBox.Location = new System.Drawing.Point(230, 73);
            this.tireBrandTextBox.Name = "tireBrandTextBox";
            this.tireBrandTextBox.Size = new System.Drawing.Size(135, 26);
            this.tireBrandTextBox.TabIndex = 1;
            this.tireBrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prevRotateDateTextBox
            // 
            this.prevRotateDateTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.prevRotateDateTextBox.Location = new System.Drawing.Point(230, 137);
            this.prevRotateDateTextBox.Name = "prevRotateDateTextBox";
            this.prevRotateDateTextBox.Size = new System.Drawing.Size(135, 26);
            this.prevRotateDateTextBox.TabIndex = 3;
            this.prevRotateDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLbl
            // 
            this.infoLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(12, 421);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(383, 126);
            this.infoLbl.TabIndex = 15;
            this.infoLbl.Text = "Info";
            this.infoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderValueLbl
            // 
            this.sliderValueLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sliderValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sliderValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValueLbl.Location = new System.Drawing.Point(103, 273);
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
            this.milageTrackBar.Location = new System.Drawing.Point(62, 338);
            this.milageTrackBar.Maximum = 10000;
            this.milageTrackBar.Name = "milageTrackBar";
            this.milageTrackBar.Size = new System.Drawing.Size(279, 40);
            this.milageTrackBar.SmallChange = 100;
            this.milageTrackBar.TabIndex = 5;
            this.milageTrackBar.TickFrequency = 100;
            this.milageTrackBar.Value = 5000;
            this.milageTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // storeValuesButton
            // 
            this.storeValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeValuesButton.Location = new System.Drawing.Point(230, 169);
            this.storeValuesButton.Name = "storeValuesButton";
            this.storeValuesButton.Size = new System.Drawing.Size(135, 41);
            this.storeValuesButton.TabIndex = 4;
            this.storeValuesButton.Text = "Enter";
            this.storeValuesButton.UseVisualStyleBackColor = true;
            this.storeValuesButton.Click += new System.EventHandler(this.storeValuesButton_Click);
            // 
            // storeLbl
            // 
            this.storeLbl.BackColor = System.Drawing.Color.White;
            this.storeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storeLbl.Location = new System.Drawing.Point(24, 181);
            this.storeLbl.Name = "storeLbl";
            this.storeLbl.Size = new System.Drawing.Size(200, 22);
            this.storeLbl.TabIndex = 14;
            this.storeLbl.Text = "Press to store values:";
            this.storeLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // milesLbl
            // 
            this.milesLbl.BackColor = System.Drawing.SystemColors.Control;
            this.milesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLbl.Location = new System.Drawing.Point(216, 273);
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
            this.lockTrackBarButton.Location = new System.Drawing.Point(347, 338);
            this.lockTrackBarButton.Name = "lockTrackBarButton";
            this.lockTrackBarButton.Size = new System.Drawing.Size(33, 40);
            this.lockTrackBarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockTrackBarButton.TabIndex = 21;
            this.lockTrackBarButton.TabStop = false;
            this.lockTrackBarButton.Click += new System.EventHandler(this.lockTrackBarButton_Click_1);
            // 
            // TireOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(407, 667);
            this.Controls.Add(this.lockTrackBarButton);
            this.Controls.Add(this.milesLbl);
            this.Controls.Add(this.storeLbl);
            this.Controls.Add(this.storeValuesButton);
            this.Controls.Add(this.milageTrackBar);
            this.Controls.Add(this.sliderValueLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.prevRotateDateTextBox);
            this.Controls.Add(this.tireBrandTextBox);
            this.Controls.Add(this.installDateTextBox);
            this.Controls.Add(this.tireSizeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setMilageLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label setMilageLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tireSizeTextBox;
        private System.Windows.Forms.TextBox installDateTextBox;
        private System.Windows.Forms.TextBox tireBrandTextBox;
        private System.Windows.Forms.TextBox prevRotateDateTextBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label sliderValueLbl;
        private System.Windows.Forms.TrackBar milageTrackBar;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button storeValuesButton;
        private System.Windows.Forms.Label storeLbl;
        private System.Windows.Forms.Label milesLbl;
        private System.Windows.Forms.PictureBox lockTrackBarButton;
    }
}