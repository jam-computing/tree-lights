namespace Tree_Scanner
{
    partial class formWelcome
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
            pictureBox1 = new PictureBox();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            richTextBox1.Text = "Welcome to the tree setup wizard. You will be walked through the steps to scan the Christmas Tree. Press the next button to continue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(590, 464);
            buttonNext.Margin = new Padding(10, 9, 10, 9);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(78, 20);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = TreeGUI.Properties.Images.Cursed_Tree;
            pictureBox1.Location = new Point(175, 150);
            pictureBox1.Margin = new Padding(10, 9, 10, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(17, 464);
            buttonBack.Margin = new Padding(10, 9, 10, 9);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(78, 20);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // formWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 572);
            Controls.Add(buttonBack);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "formWelcome";
            Text = "formWelcome";
            Load += formWelcome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonNext;
        private PictureBox pictureBox1;
        private Button buttonBack;
    }
}