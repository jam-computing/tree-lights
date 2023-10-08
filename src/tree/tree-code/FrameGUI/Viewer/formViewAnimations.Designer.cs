namespace TreeGUI {
    partial class formViewAnimations {
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
            listBox1 = new ListBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(257, 125);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(170, 154);
            listBox1.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(23, 378);
            buttonBack.Margin = new Padding(14, 15, 14, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(111, 33);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // formViewAnimations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 435);
            Controls.Add(buttonBack);
            Controls.Add(listBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formViewAnimations";
            Text = "formViewAnimations";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonBack;
    }
}