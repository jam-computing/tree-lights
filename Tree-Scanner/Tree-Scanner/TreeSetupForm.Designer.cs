namespace Tree_Scanner
{
    partial class TreeSetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBoxTreeDisplay = new PictureBox();
            RichTextBoxDialogue = new RichTextBox();
            BtnRetakePhoto = new Button();
            BtnPrevious = new Button();
            BtnNext = new Button();
            RichTextBoxErrors = new RichTextBox();
            BtnRegisterCorners = new Button();
            BtnMapLEDs = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTreeDisplay).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxTreeDisplay
            // 
            PictureBoxTreeDisplay.Location = new Point(0, 0);
            PictureBoxTreeDisplay.Name = "PictureBoxTreeDisplay";
            PictureBoxTreeDisplay.Size = new Size(740, 498);
            PictureBoxTreeDisplay.TabIndex = 0;
            PictureBoxTreeDisplay.TabStop = false;
            // 
            // RichTextBoxDialogue
            // 
            RichTextBoxDialogue.Anchor = AnchorStyles.None;
            RichTextBoxDialogue.BackColor = Color.DarkGray;
            RichTextBoxDialogue.Location = new Point(821, 12);
            RichTextBoxDialogue.Name = "RichTextBoxDialogue";
            RichTextBoxDialogue.Size = new Size(410, 141);
            RichTextBoxDialogue.TabIndex = 1;
            RichTextBoxDialogue.Text = "";
            // 
            // BtnRetakePhoto
            // 
            BtnRetakePhoto.Anchor = AnchorStyles.None;
            BtnRetakePhoto.Location = new Point(938, 258);
            BtnRetakePhoto.Name = "BtnRetakePhoto";
            BtnRetakePhoto.Size = new Size(156, 53);
            BtnRetakePhoto.TabIndex = 3;
            BtnRetakePhoto.Text = "Take Initial Photo";
            BtnRetakePhoto.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Anchor = AnchorStyles.None;
            BtnPrevious.Location = new Point(821, 176);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(122, 42);
            BtnPrevious.TabIndex = 4;
            BtnPrevious.Text = "Previous";
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.None;
            BtnNext.Location = new Point(1109, 176);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(122, 42);
            BtnNext.TabIndex = 5;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // RichTextBoxErrors
            // 
            RichTextBoxErrors.Anchor = AnchorStyles.None;
            RichTextBoxErrors.BackColor = Color.Black;
            RichTextBoxErrors.ForeColor = Color.White;
            RichTextBoxErrors.Location = new Point(821, 369);
            RichTextBoxErrors.Name = "RichTextBoxErrors";
            RichTextBoxErrors.Size = new Size(410, 176);
            RichTextBoxErrors.TabIndex = 6;
            RichTextBoxErrors.Text = "";
            // 
            // BtnRegisterCorners
            // 
            BtnRegisterCorners.Anchor = AnchorStyles.None;
            BtnRegisterCorners.Location = new Point(74, 534);
            BtnRegisterCorners.Name = "BtnRegisterCorners";
            BtnRegisterCorners.Size = new Size(130, 55);
            BtnRegisterCorners.TabIndex = 7;
            BtnRegisterCorners.Text = "Register corners";
            BtnRegisterCorners.UseVisualStyleBackColor = true;
            // 
            // BtnMapLEDs
            // 
            BtnMapLEDs.Anchor = AnchorStyles.None;
            BtnMapLEDs.Location = new Point(514, 534);
            BtnMapLEDs.Name = "BtnMapLEDs";
            BtnMapLEDs.Size = new Size(130, 55);
            BtnMapLEDs.TabIndex = 8;
            BtnMapLEDs.Text = "Map LEDs";
            BtnMapLEDs.UseVisualStyleBackColor = true;
            // 
            // TreeSetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1261, 601);
            Controls.Add(BtnMapLEDs);
            Controls.Add(BtnRegisterCorners);
            Controls.Add(RichTextBoxErrors);
            Controls.Add(BtnNext);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnRetakePhoto);
            Controls.Add(RichTextBoxDialogue);
            Controls.Add(PictureBoxTreeDisplay);
            Name = "TreeSetupForm";
            Text = "Tree setup wizard";
            ((System.ComponentModel.ISupportInitialize)PictureBoxTreeDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBoxTreeDisplay;
        private RichTextBox RichTextBoxDialogue;
        private Button BtnRetakePhoto;
        private Button BtnPrevious;
        private Button BtnNext;
        private RichTextBox RichTextBoxErrors;
        private Button BtnRegisterCorners;
        private Button BtnMapLEDs;
    }
}