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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfo));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            buttonNext = new Button();
            richTextBox2 = new RichTextBox();
            radioButton1 = new RadioButton();
            buttonBack = new Button();
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
            richTextBox1.Size = new Size(930, 219);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(347, 54);
            label1.TabIndex = 1;
            label1.Text = "Before you begin";
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
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Control;
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(24, 291);
            richTextBox2.Margin = new Padding(15);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox2.Size = new Size(930, 464);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 808);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(327, 29);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "I agree to the above terms of service\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(24, 886);
            buttonBack.Margin = new Padding(15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // formInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(buttonBack);
            Controls.Add(radioButton1);
            Controls.Add(richTextBox2);
            Controls.Add(buttonNext);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "formInfo";
            Text = "formWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonNext;
        private RichTextBox richTextBox2;
        private RadioButton radioButton1;
        private Button buttonBack;
    }
}