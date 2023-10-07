using System.Windows.Forms;

namespace Tree_Scanner
{
    partial class formTreePhoto
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            buttonNext = new Button();
            pictureboxTreePhoto = new PictureBox();
            buttonBack = new Button();
            buttonTakePhoto = new Button();
            buttonReset = new Button();
            button1 = new Button();
            label2 = new Label();
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
            richTextBox1.Text = "Please take a photograph of the tree, with the lights on, then select the three corners of the tree by clicking the resulting image.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(342, 54);
            label1.TabIndex = 1;
            label1.Text = "Initial tree photo";
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(841, 887);
            buttonNext.Margin = new Padding(14, 15, 14, 15);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(111, 33);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureboxTreePhoto
            // 
            pictureboxTreePhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureboxTreePhoto.Location = new Point(24, 185);
            pictureboxTreePhoto.Margin = new Padding(14, 15, 14, 15);
            pictureboxTreePhoto.Name = "pictureboxTreePhoto";
            pictureboxTreePhoto.Size = new Size(650, 650);
            pictureboxTreePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxTreePhoto.TabIndex = 3;
            pictureboxTreePhoto.TabStop = false;
            pictureboxTreePhoto.Click += pictureboxTreePhoto_Click;
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
            // buttonTakePhoto
            // 
            buttonTakePhoto.Location = new Point(700, 385);
            buttonTakePhoto.Margin = new Padding(14, 15, 14, 15);
            buttonTakePhoto.Name = "buttonTakePhoto";
            buttonTakePhoto.Size = new Size(250, 100);
            buttonTakePhoto.TabIndex = 7;
            buttonTakePhoto.Text = "Take photo";
            buttonTakePhoto.UseVisualStyleBackColor = true;
            buttonTakePhoto.Click += buttonTakePhoto_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(700, 500);
            buttonReset.Margin = new Padding(14, 15, 14, 15);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(250, 100);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(700, 615);
            button1.Margin = new Padding(14, 15, 14, 15);
            button1.Name = "button1";
            button1.Size = new Size(250, 100);
            button1.TabIndex = 9;
            button1.Text = "View Minecraft Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 765);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 10;
            // 
            // formTreePhoto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 943);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonReset);
            Controls.Add(buttonTakePhoto);
            Controls.Add(buttonBack);
            Controls.Add(pictureboxTreePhoto);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "formTreePhoto";
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
        private Button buttonTakePhoto;
        private Button buttonReset;
        private Button button1;
        private Label label2;
    }
}