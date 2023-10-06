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
            richTextBox1.Location = new Point(17, 56);
            richTextBox1.Margin = new Padding(10, 9, 10, 9);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(651, 37);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Please take a photograph of the tree, with the lights on, then select the three corners of the tree by clicking the resulting image.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 1;
            label1.Text = "Initial tree photo";
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(589, 532);
            buttonNext.Margin = new Padding(10, 9, 10, 9);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(78, 20);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureboxTreePhoto
            // 
            pictureboxTreePhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureboxTreePhoto.Location = new Point(17, 111);
            pictureboxTreePhoto.Margin = new Padding(10, 9, 10, 9);
            pictureboxTreePhoto.Name = "pictureboxTreePhoto";
            pictureboxTreePhoto.Size = new Size(456, 391);
            pictureboxTreePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxTreePhoto.TabIndex = 3;
            pictureboxTreePhoto.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(17, 532);
            buttonBack.Margin = new Padding(10, 9, 10, 9);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(78, 20);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonTakePhoto
            // 
            buttonTakePhoto.Location = new Point(490, 231);
            buttonTakePhoto.Margin = new Padding(10, 9, 10, 9);
            buttonTakePhoto.Name = "buttonTakePhoto";
            buttonTakePhoto.Size = new Size(175, 60);
            buttonTakePhoto.TabIndex = 7;
            buttonTakePhoto.Text = "Take photo";
            buttonTakePhoto.UseVisualStyleBackColor = true;
            buttonTakePhoto.Click += buttonTakePhoto_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(490, 300);
            buttonReset.Margin = new Padding(10, 9, 10, 9);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(175, 60);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(490, 369);
            button1.Margin = new Padding(10, 9, 10, 9);
            button1.Name = "button1";
            button1.Size = new Size(175, 60);
            button1.TabIndex = 9;
            button1.Text = "View Minecraft Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 10;
            label2.Click += label2_Click;
            // 
            // formTreePhoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 566);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonReset);
            Controls.Add(buttonTakePhoto);
            Controls.Add(buttonBack);
            Controls.Add(pictureboxTreePhoto);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Margin = new Padding(2);
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