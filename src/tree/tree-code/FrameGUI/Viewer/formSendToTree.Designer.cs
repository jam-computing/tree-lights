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
            txtBoxSend.Location = new Point(187, 101);
            txtBoxSend.Name = "txtBoxSend";
            txtBoxSend.Size = new Size(117, 23);
            txtBoxSend.TabIndex = 3;
            txtBoxSend.Text = "Your message here";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(206, 130);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // formSendToTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
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
    }
}