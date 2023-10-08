namespace TreeGUI {
    partial class formMain {
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
            btnViewAnimations = new Button();
            btnViewFrames = new Button();
            btnSetupTree = new Button();
            helpProvider1 = new HelpProvider();
            btnSendToTree = new Button();
            btnViewMinecraft = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(357, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 56);
            label1.TabIndex = 0;
            label1.Text = "Tree Lights!";
            label1.Click += label1_Click;
            // 
            // btnViewAnimations
            // 
            btnViewAnimations.Anchor = AnchorStyles.None;
            btnViewAnimations.Location = new Point(180, 340);
            btnViewAnimations.Margin = new Padding(4, 5, 4, 5);
            btnViewAnimations.Name = "btnViewAnimations";
            btnViewAnimations.Size = new Size(300, 80);
            btnViewAnimations.TabIndex = 1;
            btnViewAnimations.Text = "View Animations";
            btnViewAnimations.UseVisualStyleBackColor = true;
            btnViewAnimations.Click += btnViewAnimations_Click;
            // 
            // btnViewFrames
            // 
            btnViewFrames.Anchor = AnchorStyles.None;
            btnViewFrames.Location = new Point(499, 243);
            btnViewFrames.Margin = new Padding(4, 5, 4, 5);
            btnViewFrames.Name = "btnViewFrames";
            btnViewFrames.Size = new Size(300, 80);
            btnViewFrames.TabIndex = 2;
            btnViewFrames.Text = "View Frames";
            btnViewFrames.UseVisualStyleBackColor = true;
            btnViewFrames.Click += btnViewFrames_Click;
            // 
            // btnSetupTree
            // 
            btnSetupTree.Anchor = AnchorStyles.None;
            btnSetupTree.Location = new Point(499, 340);
            btnSetupTree.Margin = new Padding(4, 5, 4, 5);
            btnSetupTree.Name = "btnSetupTree";
            btnSetupTree.Size = new Size(300, 80);
            btnSetupTree.TabIndex = 3;
            btnSetupTree.Text = "Setup Tree";
            btnSetupTree.UseVisualStyleBackColor = true;
            btnSetupTree.Click += button1_Click;
            // 
            // btnSendToTree
            // 
            btnSendToTree.Location = new Point(180, 243);
            btnSendToTree.Name = "btnSendToTree";
            btnSendToTree.Size = new Size(300, 80);
            btnSendToTree.TabIndex = 4;
            btnSendToTree.Text = "Send To Tree";
            btnSendToTree.UseVisualStyleBackColor = true;
            btnSendToTree.Click += btnSendToTree_Click;
            // 
            // btnViewMinecraft
            // 
            btnViewMinecraft.Anchor = AnchorStyles.None;
            btnViewMinecraft.Location = new Point(343, 442);
            btnViewMinecraft.Margin = new Padding(4, 5, 4, 5);
            btnViewMinecraft.Name = "btnViewMinecraft";
            btnViewMinecraft.Size = new Size(300, 80);
            btnViewMinecraft.TabIndex = 5;
            btnViewMinecraft.Text = "View Minecraft Image";
            btnViewMinecraft.UseVisualStyleBackColor = true;
            btnViewMinecraft.Click += btnViewMinecraft_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(btnViewMinecraft);
            Controls.Add(btnSendToTree);
            Controls.Add(btnSetupTree);
            Controls.Add(btnViewFrames);
            Controls.Add(btnViewAnimations);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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
        private HelpProvider helpProvider1;
        private Button btnSendToTree;
        private Button btnViewMinecraft;
    }
}