namespace Deepser_Desktop
{
    partial class AdminSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSetup));
            label1 = new Label();
            label3 = new Label();
            buttonUploadImage = new CustomControls.RJControls.RJButton();
            profilePicture = new OvalPictureBox();
            textToken = new TextBox();
            textPassword = new TextBox();
            textUsername = new TextBox();
            textHost = new TextBox();
            labelUpload = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 122);
            label1.Name = "label1";
            label1.Size = new Size(585, 410);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 39);
            label3.Name = "label3";
            label3.Size = new Size(378, 83);
            label3.TabIndex = 17;
            label3.Text = "Administrator";
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.Anchor = AnchorStyles.None;
            buttonUploadImage.AutoSize = true;
            buttonUploadImage.BackColor = Color.FromArgb(157, 178, 191);
            buttonUploadImage.BackgroundColor = Color.FromArgb(157, 178, 191);
            buttonUploadImage.BorderColor = Color.FromArgb(157, 178, 191);
            buttonUploadImage.BorderRadius = 7;
            buttonUploadImage.BorderSize = 0;
            buttonUploadImage.Cursor = Cursors.Hand;
            buttonUploadImage.FlatAppearance.BorderSize = 0;
            buttonUploadImage.FlatStyle = FlatStyle.Flat;
            buttonUploadImage.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUploadImage.ForeColor = Color.FromArgb(25, 55, 109);
            buttonUploadImage.Image = Properties.Resources.upload;
            buttonUploadImage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUploadImage.Location = new Point(966, 398);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Padding = new Padding(3, 0, 3, 0);
            buttonUploadImage.Size = new Size(107, 36);
            buttonUploadImage.TabIndex = 61;
            buttonUploadImage.Text = "Upload";
            buttonUploadImage.TextAlign = ContentAlignment.BottomRight;
            buttonUploadImage.TextColor = Color.FromArgb(25, 55, 109);
            buttonUploadImage.UseVisualStyleBackColor = false;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.Image = Properties.Resources.avatar;
            profilePicture.Location = new Point(866, 348);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(90, 90);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 59;
            profilePicture.TabStop = false;
            // 
            // textToken
            // 
            textToken.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textToken.Location = new Point(833, 284);
            textToken.Name = "textToken";
            textToken.PlaceholderText = "Token";
            textToken.Size = new Size(289, 32);
            textToken.TabIndex = 57;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(833, 234);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(289, 32);
            textPassword.TabIndex = 56;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUsername.Location = new Point(833, 184);
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(289, 32);
            textUsername.TabIndex = 55;
            // 
            // textHost
            // 
            textHost.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textHost.Location = new Point(833, 134);
            textHost.Name = "textHost";
            textHost.PlaceholderText = "Host (https://host.deepser.net)";
            textHost.Size = new Size(289, 32);
            textHost.TabIndex = 54;
            // 
            // labelUpload
            // 
            labelUpload.AutoSize = true;
            labelUpload.BackColor = Color.Transparent;
            labelUpload.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpload.Location = new Point(962, 345);
            labelUpload.Name = "labelUpload";
            labelUpload.Size = new Size(115, 52);
            labelUpload.TabIndex = 53;
            labelUpload.Text = "Profile Picture\r\n (Optional)";
            labelUpload.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminSetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 600);
            Controls.Add(buttonUploadImage);
            Controls.Add(profilePicture);
            Controls.Add(textToken);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(textHost);
            Controls.Add(labelUpload);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminSetup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserSetup";
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private CustomControls.RJControls.RJButton buttonUploadImage;
        internal OvalPictureBox profilePicture;
        internal TextBox textToken;
        internal TextBox textPassword;
        internal TextBox textUsername;
        internal TextBox textHost;
        private Label labelUpload;
    }
}