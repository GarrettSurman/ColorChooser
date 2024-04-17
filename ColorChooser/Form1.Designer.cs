namespace ColorChooser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            randomColorBtn = new Button();
            panel1 = new Panel();
            myColorLabel = new Label();
            lblRed = new Label();
            lblRedNumber = new Label();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            lblGreenNumber = new Label();
            lblGreen = new Label();
            trackBarBlue = new TrackBar();
            lblBlueNumber = new Label();
            lblBlue = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // randomColorBtn
            // 
            randomColorBtn.Location = new Point(39, 42);
            randomColorBtn.Name = "randomColorBtn";
            randomColorBtn.Size = new Size(116, 38);
            randomColorBtn.TabIndex = 0;
            randomColorBtn.Text = "Random Color";
            randomColorBtn.UseVisualStyleBackColor = true;
            randomColorBtn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(myColorLabel);
            panel1.Location = new Point(233, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 426);
            panel1.TabIndex = 1;
            // 
            // myColorLabel
            // 
            myColorLabel.AutoSize = true;
            myColorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myColorLabel.Location = new Point(57, 372);
            myColorLabel.Name = "myColorLabel";
            myColorLabel.Size = new Size(74, 37);
            myColorLabel.TabIndex = 0;
            myColorLabel.Text = "0.0.0";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(39, 116);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(31, 17);
            lblRed.TabIndex = 2;
            lblRed.Text = "Red";
            // 
            // lblRedNumber
            // 
            lblRedNumber.AutoSize = true;
            lblRedNumber.Location = new Point(102, 116);
            lblRedNumber.Name = "lblRedNumber";
            lblRedNumber.Size = new Size(0, 17);
            lblRedNumber.TabIndex = 3;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(40, 163);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(171, 45);
            trackBarRed.TabIndex = 4;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(41, 258);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(171, 45);
            trackBarGreen.TabIndex = 7;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // lblGreenNumber
            // 
            lblGreenNumber.AutoSize = true;
            lblGreenNumber.Location = new Point(103, 211);
            lblGreenNumber.Name = "lblGreenNumber";
            lblGreenNumber.Size = new Size(0, 17);
            lblGreenNumber.TabIndex = 6;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(40, 211);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(43, 17);
            lblGreen.TabIndex = 5;
            lblGreen.Text = "Green";
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(42, 353);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(171, 45);
            trackBarBlue.TabIndex = 10;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // lblBlueNumber
            // 
            lblBlueNumber.AutoSize = true;
            lblBlueNumber.Location = new Point(104, 306);
            lblBlueNumber.Name = "lblBlueNumber";
            lblBlueNumber.Size = new Size(0, 17);
            lblBlueNumber.TabIndex = 9;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(41, 306);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(32, 17);
            lblBlue.TabIndex = 8;
            lblBlue.Text = "Blue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(trackBarBlue);
            Controls.Add(lblBlueNumber);
            Controls.Add(lblBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(lblGreenNumber);
            Controls.Add(lblGreen);
            Controls.Add(trackBarRed);
            Controls.Add(lblRedNumber);
            Controls.Add(lblRed);
            Controls.Add(panel1);
            Controls.Add(randomColorBtn);
            Name = "Form1";
            Text = "Color Chooser";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button randomColorBtn;
        private Panel panel1;
        private Label lblRed;
        private Label lblRedNumber;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private Label lblGreenNumber;
        private Label lblGreen;
        private TrackBar trackBarBlue;
        private Label lblBlueNumber;
        private Label lblBlue;
        private Label myColorLabel;
    }
}
