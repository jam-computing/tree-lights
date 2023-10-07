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
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 0;
            label1.Text = "Tree Lights!";
            label1.Click += label1_Click;
            // 
            // btnViewAnimations
            // 
            btnViewAnimations.Anchor = AnchorStyles.None;
            btnViewAnimations.Location = new Point(163, 144);
            btnViewAnimations.Name = "btnViewAnimations";
            btnViewAnimations.Size = new Size(130, 30);
            btnViewAnimations.TabIndex = 1;
            btnViewAnimations.Text = "View Animations";
            btnViewAnimations.UseVisualStyleBackColor = true;
            btnViewAnimations.Click += btnViewAnimations_Click;
            // 
            // btnViewFrames
            // 
            btnViewFrames.Anchor = AnchorStyles.None;
            btnViewFrames.Location = new Point(163, 180);
            btnViewFrames.Name = "btnViewFrames";
            btnViewFrames.Size = new Size(130, 25);
            btnViewFrames.TabIndex = 2;
            btnViewFrames.Text = "View Frames";
            btnViewFrames.UseVisualStyleBackColor = true;
            btnViewFrames.Click += btnViewFrames_Click;
            // 
            // btnSetupTree
            // 
            btnSetupTree.Anchor = AnchorStyles.None;
            btnSetupTree.Location = new Point(368, 212);
            btnSetupTree.Name = "btnSetupTree";
            btnSetupTree.Size = new Size(104, 37);
            btnSetupTree.TabIndex = 3;
            btnSetupTree.Text = "Setup Tree";
            btnSetupTree.UseVisualStyleBackColor = true;
            btnSetupTree.Click += button1_Click;
            // 
            // btnSendToTree
            // 
            btnSendToTree.Location = new Point(135, 80);
            btnSendToTree.Margin = new Padding(2);
            btnSendToTree.Name = "btnSendToTree";
            btnSendToTree.Size = new Size(191, 59);
            btnSendToTree.TabIndex = 4;
            btnSendToTree.Text = "Send To Tree";
            btnSendToTree.UseVisualStyleBackColor = true;
            btnSendToTree.Click += btnSendToTree_Click;
            // 
            // btnViewMinecraft
            // 
            btnViewMinecraft.Anchor = AnchorStyles.None;
            btnViewMinecraft.Location = new Point(12, 219);
            btnViewMinecraft.Name = "btnViewMinecraft";
            btnViewMinecraft.Size = new Size(130, 30);
            btnViewMinecraft.TabIndex = 5;
            btnViewMinecraft.Text = "View Minecraft Image";
            btnViewMinecraft.UseVisualStyleBackColor = true;
            btnViewMinecraft.Click += btnViewMinecraft_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnViewMinecraft);
            Controls.Add(btnSendToTree);
            Controls.Add(btnSetupTree);
            Controls.Add(btnViewFrames);
            Controls.Add(btnViewAnimations);
            Controls.Add(label1);
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