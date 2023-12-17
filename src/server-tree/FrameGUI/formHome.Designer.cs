namespace TreeGUI {
    partial class formHome {
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
            label1 = new Label();
            btnSetupTree = new Button();
            btnSendToTree = new Button();
            btnViewMinecraft = new Button();
            btnOpenConfig = new Button();
            btnConnecToTree = new Button();
            lblInfo = new Label();
            lblMessage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(449, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 67);
            label1.TabIndex = 0;
            label1.Text = "Tree Lights";
            label1.Click += label1_Click;
            // 
            // btnSetupTree
            // 
            btnSetupTree.Location = new Point(386, 341);
            btnSetupTree.Margin = new Padding(4, 5, 4, 5);
            btnSetupTree.Name = "btnSetupTree";
            btnSetupTree.Size = new Size(400, 125);
            btnSetupTree.TabIndex = 3;
            btnSetupTree.Text = "Setup Tree";
            btnSetupTree.UseVisualStyleBackColor = true;
            btnSetupTree.Click += button1_Click;
            // 
            // btnSendToTree
            // 
            btnSendToTree.Location = new Point(386, 208);
            btnSendToTree.Name = "btnSendToTree";
            btnSendToTree.Size = new Size(400, 125);
            btnSendToTree.TabIndex = 4;
            btnSendToTree.Text = "Send To Tree";
            btnSendToTree.UseVisualStyleBackColor = true;
            btnSendToTree.Click += btnSendToTree_Click;
            // 
            // btnViewMinecraft
            // 
            btnViewMinecraft.Location = new Point(386, 476);
            btnViewMinecraft.Margin = new Padding(4, 5, 4, 5);
            btnViewMinecraft.Name = "btnViewMinecraft";
            btnViewMinecraft.Size = new Size(400, 127);
            btnViewMinecraft.TabIndex = 5;
            btnViewMinecraft.Text = "View Minecraft Image";
            btnViewMinecraft.UseVisualStyleBackColor = true;
            btnViewMinecraft.Click += btnViewMinecraft_Click;
            // 
            // btnOpenConfig
            // 
            btnOpenConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenConfig.Location = new Point(559, 151);
            btnOpenConfig.Margin = new Padding(4, 5, 4, 5);
            btnOpenConfig.Name = "btnOpenConfig";
            btnOpenConfig.Size = new Size(206, 48);
            btnOpenConfig.TabIndex = 6;
            btnOpenConfig.Text = "Settings";
            btnOpenConfig.UseVisualStyleBackColor = true;
            btnOpenConfig.Click += btnOpenConfig_Click;
            // 
            // btnConnecToTree
            // 
            btnConnecToTree.Location = new Point(600, 151);
            btnConnecToTree.Margin = new Padding(4, 5, 4, 5);
            btnConnecToTree.Name = "btnConnecToTree";
            btnConnecToTree.Size = new Size(186, 48);
            btnConnecToTree.TabIndex = 7;
            btnConnecToTree.Text = "Connect To Tree";
            btnConnecToTree.UseVisualStyleBackColor = true;
            btnConnecToTree.Click += btnConnecToTree_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(70, 572);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 45);
            lblInfo.TabIndex = 8;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(559, 595);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 45);
            lblMessage.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(900, 500);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBox1);
            Controls.Add(lblMessage);
            Controls.Add(lblInfo);
            Controls.Add(btnConnecToTree);
            Controls.Add(btnOpenConfig);
            Controls.Add(btnViewMinecraft);
            Controls.Add(btnSendToTree);
            Controls.Add(btnSetupTree);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "formHome";
            Text = "formMain";
            Load += formMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}