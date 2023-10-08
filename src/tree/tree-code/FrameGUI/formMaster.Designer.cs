using TreeGUI.Properties;

namespace TreeGUI {
    partial class formMaster {
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
            panelMaster = new Panel();
            SuspendLayout();
            // 
            // panelMaster
            // 
            panelMaster.Dock = DockStyle.Fill;
            panelMaster.Location = new Point(0, 0);
            panelMaster.Margin = new Padding(4, 5, 4, 5);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(978, 944);
            panelMaster.TabIndex = 0;
            // 
            // formMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(panelMaster);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1000, 1000);
            Name = "formMaster";
            Text = "Tree GUI";
            MaximizeBox = false;
            Icon = Properties.Images.vim_logo;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMaster;
    }
}