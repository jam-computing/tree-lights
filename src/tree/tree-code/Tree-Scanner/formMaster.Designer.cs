namespace Tree_Scanner {
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
            panelForm = new Panel();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(978, 944);
            panelForm.TabIndex = 0;
            // 
            // formMaster
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(panelForm);
            Name = "formMaster";
            Text = "Tree Setup Wizard";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
    }
}