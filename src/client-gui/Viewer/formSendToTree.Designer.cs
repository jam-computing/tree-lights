namespace TreeGUI
{
    partial class formSendToTree
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
            btnBack = new Button();
            txtBoxSend = new TextBox();
            btnSend = new Button();
            comboFrameList = new ComboBox();
            lblOr = new Label();
            btnSendFrame = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSendAnimation = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(404, 221);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 28);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtBoxSend
            // 
            txtBoxSend.Location = new Point(131, 139);
            txtBoxSend.Name = "txtBoxSend";
            txtBoxSend.Size = new Size(139, 23);
            txtBoxSend.TabIndex = 3;
            txtBoxSend.Text = "Your message here";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(276, 139);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // comboFrameList
            // 
            comboFrameList.FormattingEnabled = true;
            comboFrameList.Location = new Point(131, 51);
            comboFrameList.Name = "comboFrameList";
            comboFrameList.Size = new Size(139, 23);
            comboFrameList.TabIndex = 5;
            comboFrameList.Text = "Your Frame Here";
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Location = new Point(234, 77);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(23, 15);
            lblOr.TabIndex = 6;
            lblOr.Text = "OR";
            // 
            // btnSendFrame
            // 
            btnSendFrame.Location = new Point(276, 51);
            btnSendFrame.Name = "btnSendFrame";
            btnSendFrame.Size = new Size(75, 23);
            btnSendFrame.TabIndex = 7;
            btnSendFrame.Text = "Send";
            btnSendFrame.UseVisualStyleBackColor = true;
            btnSendFrame.Click += btnSendFrame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 121);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 8;
            label1.Text = "OR";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Your Animation Here";
            // 
            // btnSendAnimation
            // 
            btnSendAnimation.Location = new Point(276, 94);
            btnSendAnimation.Name = "btnSendAnimation";
            btnSendAnimation.Size = new Size(75, 23);
            btnSendAnimation.TabIndex = 10;
            btnSendAnimation.Text = "Send";
            btnSendAnimation.UseVisualStyleBackColor = true;
            btnSendAnimation.Click += btnSendAnimation_Click;
            // 
            // formSendToTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnSendAnimation);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnSendFrame);
            Controls.Add(lblOr);
            Controls.Add(comboFrameList);
            Controls.Add(btnSend);
            Controls.Add(txtBoxSend);
            Controls.Add(btnBack);
            Name = "formSendToTree";
            Text = "formSendToTree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private TextBox txtBoxSend;
        private Button btnSend;
        private ComboBox comboFrameList;
        private Label lblOr;
        private Button btnSendFrame;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnSendAnimation;
    }
}