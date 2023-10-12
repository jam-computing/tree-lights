using TreeGUI.Properties;

namespace TreeGUI
{
    partial class formMaster
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
            panelMaster = new Panel();
            SuspendLayout();
            // 
            // panelMaster
            // 
            panelMaster.Dock = DockStyle.Fill;
            panelMaster.Location = new Point(0, 0);
            panelMaster.Margin = new Padding(3, 4, 3, 4);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(786, 554);
            panelMaster.TabIndex = 0;
            // 
            // formMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 554);
            Controls.Add(panelMaster);
            Icon = Images.vim_logo;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "formMaster";
            Text = "Tree GUI";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMaster;
    }
}