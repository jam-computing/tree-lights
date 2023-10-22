namespace TreeGUI
{
    partial class formMain
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
            label1 = new Label();
            btnSetupTree = new Button();
            btnSendToTree = new Button();
            btnViewMinecraft = new Button();
            btnOpenConfig = new Button();
            btnConnecToTree = new Button();
            lblInfo = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 50);
            label1.TabIndex = 0;
            label1.Text = "Tree Lights!";
            label1.Click += label1_Click;
            // 
            // btnSetupTree
            // 
            btnSetupTree.Location = new Point(216, 176);
            btnSetupTree.Name = "btnSetupTree";
            btnSetupTree.Size = new Size(280, 75);
            btnSetupTree.TabIndex = 3;
            btnSetupTree.Text = "Setup Tree";
            btnSetupTree.UseVisualStyleBackColor = true;
            btnSetupTree.Click += button1_Click;
            // 
            // btnSendToTree
            // 
            btnSendToTree.Location = new Point(216, 96);
            btnSendToTree.Margin = new Padding(2);
            btnSendToTree.Name = "btnSendToTree";
            btnSendToTree.Size = new Size(280, 75);
            btnSendToTree.TabIndex = 4;
            btnSendToTree.Text = "Send To Tree";
            btnSendToTree.UseVisualStyleBackColor = true;
            btnSendToTree.Click += btnSendToTree_Click;
            // 
            // btnViewMinecraft
            // 
            btnViewMinecraft.Location = new Point(216, 257);
            btnViewMinecraft.Name = "btnViewMinecraft";
            btnViewMinecraft.Size = new Size(280, 76);
            btnViewMinecraft.TabIndex = 5;
            btnViewMinecraft.Text = "View Minecraft Image";
            btnViewMinecraft.UseVisualStyleBackColor = true;
            btnViewMinecraft.Click += btnViewMinecraft_Click;
            // 
            // btnOpenConfig
            // 
            btnOpenConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenConfig.Location = new Point(216, 62);
            btnOpenConfig.Name = "btnOpenConfig";
            btnOpenConfig.Size = new Size(144, 29);
            btnOpenConfig.TabIndex = 6;
            btnOpenConfig.Text = "Settings";
            btnOpenConfig.UseVisualStyleBackColor = true;
            btnOpenConfig.Click += btnOpenConfig_Click;
            // 
            // btnConnecToTree
            // 
            btnConnecToTree.Location = new Point(366, 62);
            btnConnecToTree.Name = "btnConnecToTree";
            btnConnecToTree.Size = new Size(130, 29);
            btnConnecToTree.TabIndex = 7;
            btnConnecToTree.Text = "Connect To Tree";
            btnConnecToTree.UseVisualStyleBackColor = true;
            btnConnecToTree.Click += btnConnecToTree_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(49, 343);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 30);
            lblInfo.TabIndex = 8;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(391, 357);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 30);
            lblMessage.TabIndex = 9;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 386);
            Controls.Add(lblMessage);
            Controls.Add(lblInfo);
            Controls.Add(btnConnecToTree);
            Controls.Add(btnOpenConfig);
            Controls.Add(btnViewMinecraft);
            Controls.Add(btnSendToTree);
            Controls.Add(btnSetupTree);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMain";
            Text = "formMain";
            Load += formMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSetupTree;
        private Button btnSendToTree;
        private Button btnViewMinecraft;
        private Button btnOpenConfig;
        private Button btnConnecToTree;
        private Label lblInfo;
        private Label lblMessage;
    }
}