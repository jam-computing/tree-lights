using System.Windows.Forms;

namespace Tree_Scanner {
    partial class formTreePhoto {
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
            buttonTakePhoto = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureboxTreePhoto).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(24, 94);
            richTextBox1.Margin = new Padding(15);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(930, 61);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Please take a photograph of the tree, with the lights on, then select the three corners of the tree by clicking the resulting image.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(342, 54);
            label1.TabIndex = 1;
            label1.Text = "Initial tree photo";
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(842, 886);
            buttonNext.Margin = new Padding(15);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(112, 34);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureboxTreePhoto
            // 
            pictureboxTreePhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureboxTreePhoto.Location = new Point(24, 185);
            pictureboxTreePhoto.Margin = new Padding(15);
            pictureboxTreePhoto.Name = "pictureboxTreePhoto";
            pictureboxTreePhoto.Size = new Size(650, 650);
            pictureboxTreePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxTreePhoto.TabIndex = 3;
            pictureboxTreePhoto.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(24, 886);
            buttonBack.Margin = new Padding(15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonTakePhoto
            // 
            buttonTakePhoto.Location = new Point(700, 385);
            buttonTakePhoto.Margin = new Padding(15);
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
            buttonReset.Margin = new Padding(15);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(250, 100);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // formTreePhoto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
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
    }
}