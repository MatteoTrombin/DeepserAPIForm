namespace Deepser_Desktop
{
    partial class UserSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetup));
            label3 = new Label();
            label2 = new Label();
            buttonUploadImage = new CustomControls.RJControls.RJButton();
            buttonAddUser = new CustomControls.RJControls.RJButton();
            profilePicture = new OvalPictureBox();
            textRole = new TextBox();
            textToken = new TextBox();
            textPassword = new TextBox();
            textUsername = new TextBox();
            textHost = new TextBox();
            labelUpload = new Label();
            selectDelUser = new ComboBoxPlus();
            buttonDelUser = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 23);
            label3.Name = "label3";
            label3.Size = new Size(143, 83);
            label3.TabIndex = 19;
            label3.Text = "User";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 106);
            label2.Name = "label2";
            label2.Size = new Size(585, 276);
            label2.TabIndex = 18;
            label2.Text = resources.GetString("label2.Text");
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
            buttonUploadImage.Location = new Point(983, 394);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Padding = new Padding(3, 0, 3, 0);
            buttonUploadImage.Size = new Size(107, 36);
            buttonUploadImage.TabIndex = 52;
            buttonUploadImage.Text = "Upload";
            buttonUploadImage.TextAlign = ContentAlignment.BottomRight;
            buttonUploadImage.TextColor = Color.FromArgb(25, 55, 109);
            buttonUploadImage.UseVisualStyleBackColor = false;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BorderRadius = 15;
            buttonAddUser.BorderSize = 0;
            buttonAddUser.Enabled = false;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Location = new Point(901, 453);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(163, 56);
            buttonAddUser.TabIndex = 51;
            buttonAddUser.Text = "Add User";
            buttonAddUser.TextColor = Color.White;
            buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.Image = Properties.Resources.avatar;
            profilePicture.Location = new Point(883, 344);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(90, 90);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 50;
            profilePicture.TabStop = false;
            // 
            // textRole
            // 
            textRole.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textRole.Location = new Point(850, 290);
            textRole.Name = "textRole";
            textRole.PlaceholderText = "Role";
            textRole.Size = new Size(289, 32);
            textRole.TabIndex = 49;
            // 
            // textToken
            // 
            textToken.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textToken.Location = new Point(850, 243);
            textToken.Name = "textToken";
            textToken.PlaceholderText = "Token";
            textToken.Size = new Size(289, 32);
            textToken.TabIndex = 48;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(850, 195);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(289, 32);
            textPassword.TabIndex = 47;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUsername.Location = new Point(850, 148);
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(289, 32);
            textUsername.TabIndex = 46;
            // 
            // textHost
            // 
            textHost.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textHost.Location = new Point(850, 101);
            textHost.Name = "textHost";
            textHost.PlaceholderText = "Host (http://host.deepser.com)";
            textHost.Size = new Size(289, 32);
            textHost.TabIndex = 45;
            // 
            // labelUpload
            // 
            labelUpload.AutoSize = true;
            labelUpload.BackColor = Color.Transparent;
            labelUpload.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpload.Location = new Point(979, 341);
            labelUpload.Name = "labelUpload";
            labelUpload.Size = new Size(115, 52);
            labelUpload.TabIndex = 44;
            labelUpload.Text = "Profile Picture\r\n (Optional)";
            labelUpload.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectDelUser
            // 
            selectDelUser.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDelUser.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDelUser.FormattingEnabled = true;
            selectDelUser.Location = new Point(225, 423);
            selectDelUser.Name = "selectDelUser";
            selectDelUser.Placeholder = "Select a user";
            selectDelUser.Size = new Size(238, 38);
            selectDelUser.TabIndex = 54;
            // 
            // buttonDelUser
            // 
            buttonDelUser.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BorderRadius = 15;
            buttonDelUser.BorderSize = 0;
            buttonDelUser.Enabled = false;
            buttonDelUser.FlatStyle = FlatStyle.Flat;
            buttonDelUser.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelUser.ForeColor = Color.White;
            buttonDelUser.Location = new Point(262, 467);
            buttonDelUser.Name = "buttonDelUser";
            buttonDelUser.Size = new Size(163, 56);
            buttonDelUser.TabIndex = 53;
            buttonDelUser.Text = "Delete User";
            buttonDelUser.TextColor = Color.White;
            buttonDelUser.UseVisualStyleBackColor = false;
            // 
            // UserSetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 600);
            Controls.Add(selectDelUser);
            Controls.Add(buttonDelUser);
            Controls.Add(buttonUploadImage);
            Controls.Add(buttonAddUser);
            Controls.Add(profilePicture);
            Controls.Add(textRole);
            Controls.Add(textToken);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(textHost);
            Controls.Add(labelUpload);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSetup";
            Text = "UserSetupp";
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private CustomControls.RJControls.RJButton buttonUploadImage;
        private CustomControls.RJControls.RJButton buttonAddUser;
        private OvalPictureBox profilePicture;
        private TextBox textRole;
        private TextBox textToken;
        private TextBox textPassword;
        private TextBox textUsername;
        private TextBox textHost;
        private Label labelUpload;
        private ComboBoxPlus selectDelUser;
        private CustomControls.RJControls.RJButton buttonDelUser;
    }
}