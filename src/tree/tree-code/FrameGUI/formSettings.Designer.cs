namespace TreeGUI
{
    partial class formSettings
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
            btnMincraftConfig = new Button();
            btnIpConfig = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnMincraftConfig
            // 
            btnMincraftConfig.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMincraftConfig.Location = new Point(12, 189);
            btnMincraftConfig.Name = "btnMincraftConfig";
            btnMincraftConfig.Size = new Size(660, 165);
            btnMincraftConfig.TabIndex = 0;
            btnMincraftConfig.Text = "Minecraft Config File";
            btnMincraftConfig.UseVisualStyleBackColor = true;
            btnMincraftConfig.Click += btnMincraftConfig_Click;
            // 
            // btnIpConfig
            // 
            btnIpConfig.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIpConfig.Location = new Point(12, 12);
            btnIpConfig.Name = "btnIpConfig";
            btnIpConfig.Size = new Size(660, 171);
            btnIpConfig.TabIndex = 1;
            btnIpConfig.Text = "IP Config File";
            btnIpConfig.UseVisualStyleBackColor = true;
            btnIpConfig.Click += btnIpConfig_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 360);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(660, 89);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnBack);
            Controls.Add(btnIpConfig);
            Controls.Add(btnMincraftConfig);
            Name = "formSettings";
            Text = "formSettings";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMincraftConfig;
        private Button btnIpConfig;
        private Button btnBack;
    }
}