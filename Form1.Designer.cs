namespace HorseRacingGame
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
            components = new System.ComponentModel.Container();
            pictureBoxHorse1 = new PictureBox();
            pictureBoxHorse2 = new PictureBox();
            pictureBoxHorse3 = new PictureBox();
            buttonStart = new Button();
            labelLeader = new Label();
            labelFinishLine = new Label();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxHorse1
            // 
            pictureBoxHorse1.Image = Properties.Resources.Horse1;
            pictureBoxHorse1.Location = new Point(24, 37);
            pictureBoxHorse1.Name = "pictureBoxHorse1";
            pictureBoxHorse1.Size = new Size(125, 62);
            pictureBoxHorse1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHorse1.TabIndex = 0;
            pictureBoxHorse1.TabStop = false;
            pictureBoxHorse1.Click += pictureBoxHorse1_Click;
            // 
            // pictureBoxHorse2
            // 
            pictureBoxHorse2.Image = Properties.Resources.Horse;
            pictureBoxHorse2.Location = new Point(24, 105);
            pictureBoxHorse2.Name = "pictureBoxHorse2";
            pictureBoxHorse2.Size = new Size(125, 62);
            pictureBoxHorse2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHorse2.TabIndex = 1;
            pictureBoxHorse2.TabStop = false;
            // 
            // pictureBoxHorse3
            // 
            pictureBoxHorse3.Image = Properties.Resources.Lion;
            pictureBoxHorse3.Location = new Point(24, 173);
            pictureBoxHorse3.Name = "pictureBoxHorse3";
            pictureBoxHorse3.Size = new Size(125, 62);
            pictureBoxHorse3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHorse3.TabIndex = 2;
            pictureBoxHorse3.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(39, 31);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(166, 60);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelLeader
            // 
            labelLeader.AutoSize = true;
            labelLeader.Location = new Point(36, 407);
            labelLeader.Name = "labelLeader";
            labelLeader.Size = new Size(50, 20);
            labelLeader.TabIndex = 4;
            labelLeader.Text = "label1";
            // 
            // labelFinishLine
            // 
            labelFinishLine.AutoSize = true;
            labelFinishLine.Location = new Point(602, 407);
            labelFinishLine.Name = "labelFinishLine";
            labelFinishLine.Size = new Size(50, 20);
            labelFinishLine.TabIndex = 5;
            labelFinishLine.Text = "label1";
            labelFinishLine.Click += labelFinishLine_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxHorse2);
            panel1.Controls.Add(pictureBoxHorse1);
            panel1.Controls.Add(pictureBoxHorse3);
            panel1.Location = new Point(46, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 271);
            panel1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(panel1);
            Controls.Add(labelFinishLine);
            Controls.Add(labelLeader);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHorse3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHorse1;
        private PictureBox pictureBoxHorse2;
        private PictureBox pictureBoxHorse3;
        private Button buttonStart;
        private Label labelLeader;
        private Label labelFinishLine;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
