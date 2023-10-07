namespace TreeGUI.Scanner {
    partial class formScan {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            buttonNext = new Button();
            pictureboxTreePhoto = new PictureBox();
            buttonBack = new Button();
            buttonStartScan = new Button();
            buttonReset = new Button();
            tbPort = new TextBox();
            tbIP = new TextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureboxTreePhoto).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(24, 93);
            richTextBox1.Margin = new Padding(14, 15, 14, 15);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(930, 62);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Turn off the lights, input the Raspberry Pi's Ip and Port, then click Start Scan to begin to scan the whole tree. This may take some time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(325, 54);
            label1.TabIndex = 1;
            label1.Text = "Whole tree scan";
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(841, 887);
            buttonNext.Margin = new Padding(14, 15, 14, 15);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(111, 33);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Finish";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureboxTreePhoto
            // 
            pictureboxTreePhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureboxTreePhoto.Location = new Point(24, 185);
            pictureboxTreePhoto.Margin = new Padding(14, 15, 14, 15);
            pictureboxTreePhoto.Name = "pictureboxTreePhoto";
            pictureboxTreePhoto.Size = new Size(651, 650);
            pictureboxTreePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxTreePhoto.TabIndex = 3;
            pictureboxTreePhoto.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(24, 887);
            buttonBack.Margin = new Padding(14, 15, 14, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 33);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonStartScan
            // 
            buttonStartScan.Location = new Point(702, 605);
            buttonStartScan.Margin = new Padding(14, 15, 14, 15);
            buttonStartScan.Name = "buttonStartScan";
            buttonStartScan.Size = new Size(250, 100);
            buttonStartScan.TabIndex = 7;
            buttonStartScan.Text = "Start Scan";
            buttonStartScan.UseVisualStyleBackColor = true;
            buttonStartScan.Click += buttonStartScan_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(703, 735);
            buttonReset.Margin = new Padding(14, 15, 14, 15);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(250, 100);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(701, 469);
            tbPort.Margin = new Padding(15, 3, 15, 15);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(250, 31);
            tbPort.TabIndex = 10;
            tbPort.TextChanged += tbPort_TextChanged;
            // 
            // tbIP
            // 
            tbIP.Location = new Point(702, 385);
            tbIP.Margin = new Padding(15, 3, 15, 15);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(250, 31);
            tbIP.TabIndex = 11;
            tbIP.TextChanged += tbIP_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.Control;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(703, 434);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(172, 29);
            richTextBox3.TabIndex = 13;
            richTextBox3.Text = "Port";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.Control;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Location = new Point(703, 350);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(172, 29);
            richTextBox4.TabIndex = 14;
            richTextBox4.Text = "IP";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 850);
            progressBar1.Margin = new Padding(1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(929, 21);
            progressBar1.TabIndex = 15;
            // 
            // formScan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 943);
            Controls.Add(progressBar1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(tbIP);
            Controls.Add(tbPort);
            Controls.Add(buttonReset);
            Controls.Add(buttonStartScan);
            Controls.Add(buttonBack);
            Controls.Add(pictureboxTreePhoto);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "formScan";
            Text = "formWelcome";
            ((System.ComponentModel.ISupportInitialize)pictureboxTreePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonNext;
        private PictureBox pictureboxTreePhoto;
        private Button buttonBack;
        private Button buttonStartScan;
        private Button buttonReset;
        private TextBox textBox1;
        private TextBox tbPort;
        private TextBox tbIP;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private ProgressBar progressBar1;
    }
}