namespace Deepser_Desktop
{
    partial class LoginUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            panel1 = new Panel();
            buttonClose = new PictureBox();
            labelActivity = new Label();
            pictureBox1 = new PictureBox();
            selectUser = new ComboBox();
            labelSector = new Label();
            modalEffect = new System.Windows.Forms.Timer(components);
            buttonLogin = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 36, 71);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(labelActivity);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 241);
            panel1.TabIndex = 14;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(749, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(54, 27);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 11;
            buttonClose.TabStop = false;
            // 
            // labelActivity
            // 
            labelActivity.AutoSize = true;
            labelActivity.BackColor = Color.Transparent;
            labelActivity.Font = new Font("Aristotelica Display Trial", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            labelActivity.ForeColor = Color.White;
            labelActivity.Location = new Point(523, 129);
            labelActivity.Name = "labelActivity";
            labelActivity.Size = new Size(131, 52);
            labelActivity.TabIndex = 1;
            labelActivity.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // selectUser
            // 
            selectUser.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUser.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectUser.FormattingEnabled = true;
            selectUser.Location = new Point(258, 401);
            selectUser.Name = "selectUser";
            selectUser.Size = new Size(262, 40);
            selectUser.TabIndex = 11;
            // 
            // labelSector
            // 
            labelSector.AutoSize = true;
            labelSector.BackColor = Color.Transparent;
            labelSector.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSector.Location = new Point(294, 354);
            labelSector.Name = "labelSector";
            labelSector.Size = new Size(199, 49);
            labelSector.TabIndex = 15;
            labelSector.Text = "Select a user";
            // 
            // modalEffect
            // 
            modalEffect.Enabled = true;
            modalEffect.Interval = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(11, 36, 71);
            buttonLogin.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonLogin.BorderColor = Color.FromArgb(11, 36, 71);
            buttonLogin.BorderRadius = 15;
            buttonLogin.BorderSize = 0;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(301, 454);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(190, 49);
            buttonLogin.TabIndex = 12;
            buttonLogin.Text = "Login";
            buttonLogin.TextColor = Color.White;
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 695);
            Controls.Add(buttonLogin);
            Controls.Add(panel1);
            Controls.Add(selectUser);
            Controls.Add(labelSector);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginUser";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox buttonClose;
        private Label labelActivity;
        private PictureBox pictureBox1;
        private ComboBox selectUser;
        private Label labelSector;
        private System.Windows.Forms.Timer modalEffect;
        private CustomControls.RJControls.RJButton buttonLogin;
    }
}