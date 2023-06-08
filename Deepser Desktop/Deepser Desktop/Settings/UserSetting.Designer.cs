namespace Deepser_Desktop
{
    partial class UserSetting
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelUpload = new Label();
            textHost = new TextBox();
            textUsername = new TextBox();
            textPassword = new TextBox();
            textToken = new TextBox();
            textRole = new TextBox();
            profilePicture = new OvalPictureBox();
            buttonAddUser = new CustomControls.RJControls.RJButton();
            buttonUploadImage = new CustomControls.RJControls.RJButton();
            buttonDelUser = new CustomControls.RJControls.RJButton();
            selectDelUser = new ComboBoxPlus();
            buttonManagment = new CustomControls.RJControls.RJButton();
            dataGridUser = new DataGridView();
            ColumnHost = new DataGridViewTextBoxColumn();
            ColumnUsername = new DataGridViewTextBoxColumn();
            columnRole = new DataGridViewTextBoxColumn();
            buttonBack = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            SuspendLayout();
            // 
            // labelUpload
            // 
            labelUpload.AutoSize = true;
            labelUpload.BackColor = Color.Transparent;
            labelUpload.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpload.Location = new Point(270, 281);
            labelUpload.Name = "labelUpload";
            labelUpload.Size = new Size(115, 52);
            labelUpload.TabIndex = 31;
            labelUpload.Text = "Profile Picture\r\n (Optional)";
            labelUpload.TextAlign = ContentAlignment.MiddleCenter;
            labelUpload.Visible = false;
            // 
            // textHost
            // 
            textHost.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textHost.Location = new Point(141, 41);
            textHost.Name = "textHost";
            textHost.PlaceholderText = "Host (http://host.deepser.com)";
            textHost.Size = new Size(289, 32);
            textHost.TabIndex = 36;
            textHost.Visible = false;
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textUsername.Location = new Point(141, 88);
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(289, 32);
            textUsername.TabIndex = 37;
            textUsername.Visible = false;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(141, 135);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(289, 32);
            textPassword.TabIndex = 38;
            textPassword.Visible = false;
            // 
            // textToken
            // 
            textToken.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textToken.Location = new Point(141, 183);
            textToken.Name = "textToken";
            textToken.PlaceholderText = "Token";
            textToken.Size = new Size(289, 32);
            textToken.TabIndex = 39;
            textToken.Visible = false;
            // 
            // textRole
            // 
            textRole.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textRole.Location = new Point(141, 230);
            textRole.Name = "textRole";
            textRole.PlaceholderText = "Role";
            textRole.Size = new Size(289, 32);
            textRole.TabIndex = 40;
            textRole.Visible = false;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.Image = Properties.Resources.avatar;
            profilePicture.Location = new Point(174, 284);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(90, 90);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 41;
            profilePicture.TabStop = false;
            profilePicture.Visible = false;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddUser.BorderRadius = 10;
            buttonAddUser.BorderSize = 0;
            buttonAddUser.Enabled = false;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Location = new Point(201, 400);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(163, 56);
            buttonAddUser.TabIndex = 42;
            buttonAddUser.Text = "Add User";
            buttonAddUser.TextColor = Color.White;
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Visible = false;
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
            buttonUploadImage.Location = new Point(274, 334);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Padding = new Padding(3, 0, 3, 0);
            buttonUploadImage.Size = new Size(107, 36);
            buttonUploadImage.TabIndex = 43;
            buttonUploadImage.Text = "Upload";
            buttonUploadImage.TextAlign = ContentAlignment.BottomRight;
            buttonUploadImage.TextColor = Color.FromArgb(25, 55, 109);
            buttonUploadImage.UseVisualStyleBackColor = false;
            buttonUploadImage.Visible = false;
            // 
            // buttonDelUser
            // 
            buttonDelUser.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelUser.BorderRadius = 10;
            buttonDelUser.BorderSize = 0;
            buttonDelUser.Enabled = false;
            buttonDelUser.FlatStyle = FlatStyle.Flat;
            buttonDelUser.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelUser.ForeColor = Color.White;
            buttonDelUser.Location = new Point(627, 277);
            buttonDelUser.Name = "buttonDelUser";
            buttonDelUser.Size = new Size(163, 56);
            buttonDelUser.TabIndex = 44;
            buttonDelUser.Text = "Delete User";
            buttonDelUser.TextColor = Color.White;
            buttonDelUser.UseVisualStyleBackColor = false;
            buttonDelUser.Visible = false;
            // 
            // selectDelUser
            // 
            selectDelUser.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDelUser.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDelUser.FormattingEnabled = true;
            selectDelUser.Location = new Point(585, 224);
            selectDelUser.Name = "selectDelUser";
            selectDelUser.Placeholder = "Select an entity";
            selectDelUser.Size = new Size(238, 38);
            selectDelUser.TabIndex = 45;
            selectDelUser.Visible = false;
            // 
            // buttonManagment
            // 
            buttonManagment.BackColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BorderColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BorderRadius = 10;
            buttonManagment.BorderSize = 0;
            buttonManagment.FlatStyle = FlatStyle.Flat;
            buttonManagment.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManagment.ForeColor = Color.White;
            buttonManagment.Location = new Point(389, 491);
            buttonManagment.Name = "buttonManagment";
            buttonManagment.Size = new Size(163, 63);
            buttonManagment.TabIndex = 46;
            buttonManagment.Text = "User managment";
            buttonManagment.TextColor = Color.White;
            buttonManagment.UseVisualStyleBackColor = false;
            // 
            // dataGridUser
            // 
            dataGridUser.AllowUserToAddRows = false;
            dataGridUser.AllowUserToDeleteRows = false;
            dataGridUser.BackgroundColor = Color.White;
            dataGridUser.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridUser.ColumnHeadersHeight = 50;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridUser.Columns.AddRange(new DataGridViewColumn[] { ColumnHost, ColumnUsername, columnRole });
            dataGridUser.EnableHeadersVisualStyles = false;
            dataGridUser.GridColor = Color.White;
            dataGridUser.Location = new Point(20, 53);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridUser.RowHeadersVisible = false;
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridUser.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridUser.RowTemplate.Height = 29;
            dataGridUser.Size = new Size(879, 417);
            dataGridUser.TabIndex = 47;
            // 
            // ColumnHost
            // 
            ColumnHost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnHost.HeaderText = "Host";
            ColumnHost.MinimumWidth = 6;
            ColumnHost.Name = "ColumnHost";
            ColumnHost.ReadOnly = true;
            // 
            // ColumnUsername
            // 
            ColumnUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnUsername.HeaderText = "Username";
            ColumnUsername.MinimumWidth = 6;
            ColumnUsername.Name = "ColumnUsername";
            ColumnUsername.ReadOnly = true;
            // 
            // columnRole
            // 
            columnRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnRole.HeaderText = "Role";
            columnRole.MinimumWidth = 6;
            columnRole.Name = "columnRole";
            columnRole.ReadOnly = true;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(11, 36, 71);
            buttonBack.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderRadius = 10;
            buttonBack.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(389, 491);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(163, 63);
            buttonBack.TabIndex = 48;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            // 
            // UserSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 566);
            Controls.Add(buttonBack);
            Controls.Add(dataGridUser);
            Controls.Add(buttonManagment);
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
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSetting";
            Text = "UserSetting";
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelUpload;
        private TextBox textHost;
        private TextBox textUsername;
        private TextBox textPassword;
        private TextBox textToken;
        private TextBox textRole;
        private OvalPictureBox profilePicture;
        private CustomControls.RJControls.RJButton buttonAddUser;
        private CustomControls.RJControls.RJButton buttonUploadImage;
        private CustomControls.RJControls.RJButton buttonDelUser;
        private ComboBoxPlus selectDelUser;
        private CustomControls.RJControls.RJButton buttonManagment;
        private DataGridView dataGridUser;
        private DataGridViewTextBoxColumn ColumnHost;
        private DataGridViewTextBoxColumn ColumnUsername;
        private DataGridViewTextBoxColumn columnRole;
        private CustomControls.RJControls.RJButton buttonBack;
    }
}