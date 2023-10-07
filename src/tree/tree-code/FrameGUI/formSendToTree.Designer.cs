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
            listBox1 = new ListBox();
            btnSend = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(272, 261);
            listBox1.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.Location = new Point(278, 12);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(194, 102);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send: ";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
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
            // formSendToTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnBack);
            Controls.Add(btnSend);
            Controls.Add(listBox1);
            Name = "formSendToTree";
            Text = "formSendToTree";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnSend;
        private Button btnBack;
    }
}