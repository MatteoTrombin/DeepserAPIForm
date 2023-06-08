namespace Deepser_Desktop
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sideBar = new Panel();
            dropdownContainer = new Panel();
            buttonActivity = new Button();
            buttonCollActivity = new Button();
            buttonUpdateAct = new Button();
            buttonLoadAct = new Button();
            buttonCreateAct = new Button();
            buttonDeleteAct = new Button();
            buttonCollection = new CustomControls.RJControls.RJButton();
            buttonDelete = new CustomControls.RJControls.RJButton();
            buttonUpdate = new CustomControls.RJControls.RJButton();
            buttonCreate = new CustomControls.RJControls.RJButton();
            buttonLoad = new CustomControls.RJControls.RJButton();
            buttonSettings = new Button();
            profilePicture = new OvalPictureBox();
            separatorSetting = new Panel();
            panelUserInfo = new Panel();
            labelUsername = new Label();
            buttonLogOut = new CustomControls.RJControls.RJButton();
            labelRole = new Label();
            main = new Panel();
            label1 = new Label();
            timerActivity = new System.Windows.Forms.Timer(components);
            header = new Panel();
            buttonMinimize = new PictureBox();
            buttonMazimize = new PictureBox();
            buttonClose = new PictureBox();
            deepserLogo = new PictureBox();
            toolTipLoad = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTipCreate = new ToolTip(components);
            toolTipUpdate = new ToolTip(components);
            toolTipDelete = new ToolTip(components);
            toolTipCollection = new ToolTip(components);
            toolTipLoadAct = new ToolTip(components);
            toolTipCreateAct = new ToolTip(components);
            toolTipUpdateAct = new ToolTip(components);
            toolTipDelAct = new ToolTip(components);
            toolTipCollAct = new ToolTip(components);
            timerFadeIn = new System.Windows.Forms.Timer(components);
            timerFadeOut = new System.Windows.Forms.Timer(components);
            sideBar.SuspendLayout();
            dropdownContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panelUserInfo.SuspendLayout();
            main.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMazimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deepserLogo).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(25, 55, 109);
            sideBar.Controls.Add(dropdownContainer);
            sideBar.Controls.Add(buttonCollection);
            sideBar.Controls.Add(buttonDelete);
            sideBar.Controls.Add(buttonUpdate);
            sideBar.Controls.Add(buttonCreate);
            sideBar.Controls.Add(buttonLoad);
            sideBar.Controls.Add(buttonSettings);
            sideBar.Controls.Add(profilePicture);
            sideBar.Controls.Add(separatorSetting);
            sideBar.Controls.Add(panelUserInfo);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 32);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(264, 779);
            sideBar.TabIndex = 0;
            // 
            // dropdownContainer
            // 
            dropdownContainer.BackColor = Color.Transparent;
            dropdownContainer.Controls.Add(buttonActivity);
            dropdownContainer.Controls.Add(buttonCollActivity);
            dropdownContainer.Controls.Add(buttonUpdateAct);
            dropdownContainer.Controls.Add(buttonLoadAct);
            dropdownContainer.Controls.Add(buttonCreateAct);
            dropdownContainer.Controls.Add(buttonDeleteAct);
            dropdownContainer.Location = new Point(0, 387);
            dropdownContainer.MaximumSize = new Size(264, 324);
            dropdownContainer.MinimumSize = new Size(264, 54);
            dropdownContainer.Name = "dropdownContainer";
            dropdownContainer.Size = new Size(264, 54);
            dropdownContainer.TabIndex = 2;
            // 
            // buttonActivity
            // 
            buttonActivity.BackColor = Color.FromArgb(25, 55, 109);
            buttonActivity.FlatAppearance.BorderSize = 0;
            buttonActivity.FlatStyle = FlatStyle.Flat;
            buttonActivity.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActivity.ForeColor = Color.Gainsboro;
            buttonActivity.Image = (Image)resources.GetObject("buttonActivity.Image");
            buttonActivity.ImageAlign = ContentAlignment.MiddleRight;
            buttonActivity.Location = new Point(0, 0);
            buttonActivity.Name = "buttonActivity";
            buttonActivity.Padding = new Padding(30, 0, 40, 0);
            buttonActivity.Size = new Size(264, 54);
            buttonActivity.TabIndex = 21;
            buttonActivity.Text = "Activity";
            buttonActivity.TextAlign = ContentAlignment.MiddleLeft;
            buttonActivity.UseVisualStyleBackColor = false;
            // 
            // buttonCollActivity
            // 
            buttonCollActivity.BackColor = Color.FromArgb(157, 178, 191);
            buttonCollActivity.FlatAppearance.BorderSize = 0;
            buttonCollActivity.FlatStyle = FlatStyle.Flat;
            buttonCollActivity.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCollActivity.ForeColor = Color.FromArgb(11, 36, 71);
            buttonCollActivity.Location = new Point(0, 270);
            buttonCollActivity.Name = "buttonCollActivity";
            buttonCollActivity.Size = new Size(264, 54);
            buttonCollActivity.TabIndex = 27;
            buttonCollActivity.Text = "Collection Activity";
            buttonCollActivity.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateAct
            // 
            buttonUpdateAct.BackColor = Color.FromArgb(157, 178, 191);
            buttonUpdateAct.FlatAppearance.BorderSize = 0;
            buttonUpdateAct.FlatStyle = FlatStyle.Flat;
            buttonUpdateAct.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdateAct.ForeColor = Color.FromArgb(11, 36, 71);
            buttonUpdateAct.Location = new Point(0, 162);
            buttonUpdateAct.Name = "buttonUpdateAct";
            buttonUpdateAct.Size = new Size(264, 54);
            buttonUpdateAct.TabIndex = 25;
            buttonUpdateAct.Text = "Update Activity";
            buttonUpdateAct.UseVisualStyleBackColor = false;
            // 
            // buttonLoadAct
            // 
            buttonLoadAct.BackColor = Color.FromArgb(157, 178, 191);
            buttonLoadAct.FlatAppearance.BorderSize = 0;
            buttonLoadAct.FlatStyle = FlatStyle.Flat;
            buttonLoadAct.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoadAct.ForeColor = Color.FromArgb(11, 36, 71);
            buttonLoadAct.ImageAlign = ContentAlignment.MiddleRight;
            buttonLoadAct.Location = new Point(0, 54);
            buttonLoadAct.Name = "buttonLoadAct";
            buttonLoadAct.Size = new Size(264, 54);
            buttonLoadAct.TabIndex = 23;
            buttonLoadAct.Text = "Load Activity";
            buttonLoadAct.UseVisualStyleBackColor = false;
            // 
            // buttonCreateAct
            // 
            buttonCreateAct.BackColor = Color.FromArgb(157, 178, 191);
            buttonCreateAct.FlatAppearance.BorderSize = 0;
            buttonCreateAct.FlatStyle = FlatStyle.Flat;
            buttonCreateAct.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateAct.ForeColor = Color.FromArgb(11, 36, 71);
            buttonCreateAct.ImageAlign = ContentAlignment.MiddleRight;
            buttonCreateAct.Location = new Point(0, 108);
            buttonCreateAct.Name = "buttonCreateAct";
            buttonCreateAct.Size = new Size(264, 54);
            buttonCreateAct.TabIndex = 24;
            buttonCreateAct.Text = "Create Activity";
            buttonCreateAct.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteAct
            // 
            buttonDeleteAct.BackColor = Color.FromArgb(157, 178, 191);
            buttonDeleteAct.FlatAppearance.BorderSize = 0;
            buttonDeleteAct.FlatStyle = FlatStyle.Flat;
            buttonDeleteAct.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteAct.ForeColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAct.ImageAlign = ContentAlignment.MiddleRight;
            buttonDeleteAct.Location = new Point(0, 216);
            buttonDeleteAct.Name = "buttonDeleteAct";
            buttonDeleteAct.Size = new Size(264, 54);
            buttonDeleteAct.TabIndex = 26;
            buttonDeleteAct.Text = "Delete Activity";
            buttonDeleteAct.UseVisualStyleBackColor = false;
            // 
            // buttonCollection
            // 
            buttonCollection.BackColor = Color.FromArgb(25, 55, 109);
            buttonCollection.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonCollection.BorderColor = Color.FromArgb(25, 55, 109);
            buttonCollection.BorderRadius = 15;
            buttonCollection.BorderSize = 0;
            buttonCollection.FlatAppearance.BorderSize = 0;
            buttonCollection.FlatStyle = FlatStyle.Flat;
            buttonCollection.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCollection.ForeColor = Color.Gainsboro;
            buttonCollection.Image = (Image)resources.GetObject("buttonCollection.Image");
            buttonCollection.ImageAlign = ContentAlignment.MiddleRight;
            buttonCollection.Location = new Point(12, 333);
            buttonCollection.Name = "buttonCollection";
            buttonCollection.Padding = new Padding(17, 0, 21, 0);
            buttonCollection.Size = new Size(241, 54);
            buttonCollection.TabIndex = 27;
            buttonCollection.Text = "Collection";
            buttonCollection.TextAlign = ContentAlignment.MiddleLeft;
            buttonCollection.TextColor = Color.Gainsboro;
            buttonCollection.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(25, 55, 109);
            buttonDelete.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonDelete.BorderColor = Color.FromArgb(25, 55, 109);
            buttonDelete.BorderRadius = 15;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Gainsboro;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonDelete.Location = new Point(12, 279);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(17, 0, 25, 0);
            buttonDelete.Size = new Size(241, 54);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonDelete.TextColor = Color.Gainsboro;
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(25, 55, 109);
            buttonUpdate.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonUpdate.BorderColor = Color.FromArgb(25, 55, 109);
            buttonUpdate.BorderRadius = 15;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Gainsboro;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.ImageAlign = ContentAlignment.MiddleRight;
            buttonUpdate.Location = new Point(12, 225);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Padding = new Padding(17, 0, 25, 0);
            buttonUpdate.Size = new Size(241, 54);
            buttonUpdate.TabIndex = 25;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.TextColor = Color.Gainsboro;
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(25, 55, 109);
            buttonCreate.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonCreate.BorderColor = Color.FromArgb(25, 55, 109);
            buttonCreate.BorderRadius = 15;
            buttonCreate.BorderSize = 0;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.Gainsboro;
            buttonCreate.Image = (Image)resources.GetObject("buttonCreate.Image");
            buttonCreate.ImageAlign = ContentAlignment.MiddleRight;
            buttonCreate.Location = new Point(12, 171);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Padding = new Padding(17, 0, 25, 0);
            buttonCreate.Size = new Size(241, 54);
            buttonCreate.TabIndex = 24;
            buttonCreate.Text = "Create";
            buttonCreate.TextAlign = ContentAlignment.MiddleLeft;
            buttonCreate.TextColor = Color.Gainsboro;
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.FromArgb(25, 55, 109);
            buttonLoad.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonLoad.BorderColor = Color.FromArgb(25, 55, 109);
            buttonLoad.BorderRadius = 15;
            buttonLoad.BorderSize = 0;
            buttonLoad.FlatAppearance.BorderSize = 0;
            buttonLoad.FlatStyle = FlatStyle.Flat;
            buttonLoad.Font = new Font("Poppins", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoad.ForeColor = Color.Gainsboro;
            buttonLoad.Image = (Image)resources.GetObject("buttonLoad.Image");
            buttonLoad.ImageAlign = ContentAlignment.MiddleRight;
            buttonLoad.Location = new Point(11, 117);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Padding = new Padding(17, 0, 22, 0);
            buttonLoad.Size = new Size(241, 54);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Load";
            buttonLoad.TextAlign = ContentAlignment.MiddleLeft;
            buttonLoad.TextColor = Color.Gainsboro;
            buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSettings.BackColor = Color.FromArgb(25, 55, 109);
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.Gainsboro;
            buttonSettings.Image = (Image)resources.GetObject("buttonSettings.Image");
            buttonSettings.ImageAlign = ContentAlignment.MiddleRight;
            buttonSettings.Location = new Point(0, 711);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(65, 0, 75, 0);
            buttonSettings.Size = new Size(264, 68);
            buttonSettings.TabIndex = 23;
            buttonSettings.Text = "Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.Cursor = Cursors.Hand;
            profilePicture.Image = Properties.Resources.avatar;
            profilePicture.Location = new Point(15, 12);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(90, 90);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // separatorSetting
            // 
            separatorSetting.BackColor = Color.Gainsboro;
            separatorSetting.Location = new Point(0, 709);
            separatorSetting.Name = "separatorSetting";
            separatorSetting.Size = new Size(270, 1);
            separatorSetting.TabIndex = 0;
            // 
            // panelUserInfo
            // 
            panelUserInfo.Controls.Add(labelUsername);
            panelUserInfo.Controls.Add(buttonLogOut);
            panelUserInfo.Controls.Add(labelRole);
            panelUserInfo.Location = new Point(111, 12);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(145, 90);
            panelUserInfo.TabIndex = 7;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Gainsboro;
            labelUsername.Location = new Point(0, -1);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(145, 32);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Anchor = AnchorStyles.None;
            buttonLogOut.AutoSize = true;
            buttonLogOut.BackColor = Color.FromArgb(157, 178, 191);
            buttonLogOut.BackgroundColor = Color.FromArgb(157, 178, 191);
            buttonLogOut.BorderColor = Color.FromArgb(157, 178, 191);
            buttonLogOut.BorderRadius = 7;
            buttonLogOut.BorderSize = 0;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.FromArgb(25, 55, 109);
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(18, 52);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Padding = new Padding(3, 0, 3, 0);
            buttonLogOut.Size = new Size(107, 36);
            buttonLogOut.TabIndex = 6;
            buttonLogOut.Text = "Log out";
            buttonLogOut.TextAlign = ContentAlignment.BottomRight;
            buttonLogOut.TextColor = Color.FromArgb(25, 55, 109);
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.None;
            labelRole.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelRole.ForeColor = Color.Gainsboro;
            labelRole.Location = new Point(0, 22);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(145, 35);
            labelRole.TabIndex = 5;
            labelRole.Text = "Role";
            labelRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            main.BackColor = Color.Gainsboro;
            main.BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            main.BackgroundImageLayout = ImageLayout.Stretch;
            main.Controls.Add(label1);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(264, 32);
            main.Name = "main";
            main.Size = new Size(1259, 779);
            main.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(25, 55, 109);
            label1.Location = new Point(312, 244);
            label1.Name = "label1";
            label1.Size = new Size(655, 286);
            label1.TabIndex = 0;
            label1.Text = "Welcome back to Deepser Desktop !";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerActivity
            // 
            timerActivity.Interval = 1;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(11, 36, 71);
            header.Controls.Add(buttonMinimize);
            header.Controls.Add(buttonMazimize);
            header.Controls.Add(buttonClose);
            header.Controls.Add(deepserLogo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1523, 32);
            header.TabIndex = 3;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Image = (Image)resources.GetObject("buttonMinimize.Image");
            buttonMinimize.Location = new Point(1420, 6);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(20, 20);
            buttonMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            buttonMinimize.TabIndex = 3;
            buttonMinimize.TabStop = false;
            // 
            // buttonMazimize
            // 
            buttonMazimize.Image = (Image)resources.GetObject("buttonMazimize.Image");
            buttonMazimize.Location = new Point(1452, 6);
            buttonMazimize.Name = "buttonMazimize";
            buttonMazimize.Size = new Size(20, 20);
            buttonMazimize.SizeMode = PictureBoxSizeMode.Zoom;
            buttonMazimize.TabIndex = 2;
            buttonMazimize.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Image = Properties.Resources.red;
            buttonClose.Location = new Point(1484, 6);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(20, 20);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 1;
            buttonClose.TabStop = false;
            // 
            // deepserLogo
            // 
            deepserLogo.Image = (Image)resources.GetObject("deepserLogo.Image");
            deepserLogo.Location = new Point(9, -7);
            deepserLogo.Name = "deepserLogo";
            deepserLogo.Size = new Size(93, 48);
            deepserLogo.SizeMode = PictureBoxSizeMode.Zoom;
            deepserLogo.TabIndex = 0;
            deepserLogo.TabStop = false;
            // 
            // timerFadeIn
            // 
            timerFadeIn.Enabled = true;
            timerFadeIn.Interval = 25;
            timerFadeIn.Tick += TimerFadeIn;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Interval = 25;
            timerFadeOut.Tick += TimerFadeOut;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 811);
            Controls.Add(main);
            Controls.Add(sideBar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Opacity = 0D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deepser";
            sideBar.ResumeLayout(false);
            dropdownContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            main.ResumeLayout(false);
            header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMazimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)deepserLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        internal Panel main;
        private Label labelRole;
        private Label labelUsername;
        private Button buttonCollActivity;
        private Button buttonLoadAct;
        private Button buttonCreateAct;
        private Button buttonDeleteAct;
        private Button buttonUpdateAct;
        private Button buttonActivity;
        private System.Windows.Forms.Timer timerActivity;
        private Button buttonSettings;
        private Panel panelUserInfo;
        private Panel header;
        private PictureBox buttonMinimize;
        private PictureBox buttonMazimize;
        private PictureBox buttonClose;
        private PictureBox deepserLogo;
        private Panel separatorSetting;
        private OvalPictureBox profilePicture;
        private Label label1;
        private CustomControls.RJControls.RJButton buttonLogOut;
        private CustomControls.RJControls.RJButton buttonLoad;
        private CustomControls.RJControls.RJButton buttonCollection;
        private CustomControls.RJControls.RJButton buttonDelete;
        private CustomControls.RJControls.RJButton buttonUpdate;
        private CustomControls.RJControls.RJButton buttonCreate;
        private Panel dropdownContainer;
        private ToolTip toolTipLoad;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTipCreate;
        private ToolTip toolTipUpdate;
        private ToolTip toolTipDelete;
        private ToolTip toolTipCollection;
        private ToolTip toolTipLoadAct;
        private ToolTip toolTipCreateAct;
        private ToolTip toolTipUpdateAct;
        private ToolTip toolTipDelAct;
        private ToolTip toolTipCollAct;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
    }
}