using System.Windows.Forms;

namespace Tree_Scanner {
    partial class formInfo {
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
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(24, 94);
            richTextBox1.Margin = new Padding(15);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(930, 61);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Welcome to the tree setup wizard. You will be walked through the steps to scan the Christmas Tree. Press the next button to continue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(197, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(842, 886);
            buttonNext.Margin = new Padding(15);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(112, 34);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // formInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "formWelcome";
            Text = "formWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonNext;
    }
}