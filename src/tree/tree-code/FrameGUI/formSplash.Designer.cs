namespace TreeGUI {
    partial class formSplash {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSplash));
            pictureBox1 = new PictureBox();
            pnlProgress = new Panel();
            pnlProgressBack = new Panel();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlProgressBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox1.Image = Properties.Images.Circuit_Side_Icon;
            pictureBox1.Location = new Point(0, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 358);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnlProgress
            // 
            pnlProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlProgress.BackColor = Color.Black;
            pnlProgress.Location = new Point(7, 7);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(300, 26);
            pnlProgress.TabIndex = 0;
            // 
            // pnlProgressBack
            // 
            pnlProgressBack.Anchor = AnchorStyles.Bottom;
            pnlProgressBack.BackColor = Color.White;
            pnlProgressBack.Controls.Add(pnlProgress);
            pnlProgressBack.Location = new Point(215, 382);
            pnlProgressBack.Name = "pnlProgressBack";
            pnlProgressBack.Padding = new Padding(4);
            pnlProgressBack.Size = new Size(700, 40);
            pnlProgressBack.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Black;
            lblTitle.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(412, 254);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 67);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Tree Lights";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(791, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox3.Image = Properties.Images.Circuit_Side_Icon;
            pictureBox3.Location = new Point(9, 433);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(300, 300);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(pnlProgressBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formSplash";
            Text = "formSplash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlProgressBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel pnlProgress;
        private Panel pnlProgressBack;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}