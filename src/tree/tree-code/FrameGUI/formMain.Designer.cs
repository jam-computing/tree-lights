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
            btnViewAnimations = new Button();
            btnViewFrames = new Button();
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
            label1.Location = new Point(273, 12);
            label1.Name = "label1";
            label1.Size = new Size(300, 62);
            label1.TabIndex = 0;
            label1.Text = "Tree Lights!";
            label1.Click += label1_Click;
            // 
            // btnViewAnimations
            // 
            btnViewAnimations.Location = new Point(56, 316);
            btnViewAnimations.Margin = new Padding(3, 4, 3, 4);
            btnViewAnimations.Name = "btnViewAnimations";
            btnViewAnimations.Size = new Size(312, 100);
            btnViewAnimations.TabIndex = 1;
            btnViewAnimations.Text = "View Animations";
            btnViewAnimations.UseVisualStyleBackColor = true;
            btnViewAnimations.Click += btnViewAnimations_Click;
            // 
            // btnViewFrames
            // 
            btnViewFrames.Location = new Point(56, 207);
            btnViewFrames.Margin = new Padding(3, 4, 3, 4);
            btnViewFrames.Name = "btnViewFrames";
            btnViewFrames.Size = new Size(312, 101);
            btnViewFrames.TabIndex = 2;
            btnViewFrames.Text = "View Frames";
            btnViewFrames.UseVisualStyleBackColor = true;
            btnViewFrames.Click += btnViewFrames_Click;
            // 
            // btnSetupTree
            // 
            btnSetupTree.Location = new Point(422, 99);
            btnSetupTree.Margin = new Padding(3, 4, 3, 4);
            btnSetupTree.Name = "btnSetupTree";
            btnSetupTree.Size = new Size(320, 100);
            btnSetupTree.TabIndex = 3;
            btnSetupTree.Text = "Setup Tree";
            btnSetupTree.UseVisualStyleBackColor = true;
            btnSetupTree.Click += button1_Click;
            // 
            // btnSendToTree
            // 
            btnSendToTree.Location = new Point(56, 100);
            btnSendToTree.Margin = new Padding(2, 3, 2, 3);
            btnSendToTree.Name = "btnSendToTree";
            btnSendToTree.Size = new Size(312, 100);
            btnSendToTree.TabIndex = 4;
            btnSendToTree.Text = "Send To Tree";
            btnSendToTree.UseVisualStyleBackColor = true;
            btnSendToTree.Click += btnSendToTree_Click;
            // 
            // btnViewMinecraft
            // 
            btnViewMinecraft.Location = new Point(422, 207);
            btnViewMinecraft.Margin = new Padding(3, 4, 3, 4);
            btnViewMinecraft.Name = "btnViewMinecraft";
            btnViewMinecraft.Size = new Size(320, 101);
            btnViewMinecraft.TabIndex = 5;
            btnViewMinecraft.Text = "View Minecraft Image";
            btnViewMinecraft.UseVisualStyleBackColor = true;
            btnViewMinecraft.Click += btnViewMinecraft_Click;
            // 
            // btnOpenConfig
            // 
            btnOpenConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenConfig.Location = new Point(709, 12);
            btnOpenConfig.Margin = new Padding(3, 4, 3, 4);
            btnOpenConfig.Name = "btnOpenConfig";
            btnOpenConfig.Size = new Size(101, 31);
            btnOpenConfig.TabIndex = 6;
            btnOpenConfig.Text = "Settings";
            btnOpenConfig.UseVisualStyleBackColor = true;
            btnOpenConfig.Click += btnOpenConfig_Click;
            // 
            // btnConnecToTree
            // 
            btnConnecToTree.Location = new Point(422, 316);
            btnConnecToTree.Margin = new Padding(3, 4, 3, 4);
            btnConnecToTree.Name = "btnConnecToTree";
            btnConnecToTree.Size = new Size(320, 100);
            btnConnecToTree.TabIndex = 7;
            btnConnecToTree.Text = "Connect To Tree";
            btnConnecToTree.UseVisualStyleBackColor = true;
            btnConnecToTree.Click += btnConnecToTree_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(56, 457);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 37);
            lblInfo.TabIndex = 8;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(447, 476);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 37);
            lblMessage.TabIndex = 9;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 479);
            Controls.Add(lblMessage);
            Controls.Add(lblInfo);
            Controls.Add(btnConnecToTree);
            Controls.Add(btnOpenConfig);
            Controls.Add(btnViewMinecraft);
            Controls.Add(btnSendToTree);
            Controls.Add(btnSetupTree);
            Controls.Add(btnViewFrames);
            Controls.Add(btnViewAnimations);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formMain";
            Text = "formMain";
            Load += formMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewAnimations;
        private Button btnViewFrames;
        private Button btnSetupTree;
        private Button btnSendToTree;
        private Button btnViewMinecraft;
        private Button btnOpenConfig;
        private Button btnConnecToTree;
        private Label lblInfo;
        private Label lblMessage;
    }
}