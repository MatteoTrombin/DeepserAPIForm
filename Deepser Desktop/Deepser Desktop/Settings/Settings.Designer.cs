namespace Deepser_Desktop
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            modalEffect = new System.Windows.Forms.Timer(components);
            sideBarSetting = new Panel();
            buttonResetAll = new CustomControls.RJControls.RJButton();
            buttonSectorMan = new CustomControls.RJControls.RJButton();
            buttonUserMan = new CustomControls.RJControls.RJButton();
            headerSetting = new Panel();
            label1 = new Label();
            buttonClose = new PictureBox();
            mainSetting = new Panel();
            sideBarSetting.SuspendLayout();
            headerSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            SuspendLayout();
            // 
            // modalEffect
            // 
            modalEffect.Enabled = true;
            modalEffect.Interval = 1;
            // 
            // sideBarSetting
            // 
            sideBarSetting.BackColor = Color.FromArgb(25, 55, 109);
            sideBarSetting.Controls.Add(buttonResetAll);
            sideBarSetting.Controls.Add(buttonSectorMan);
            sideBarSetting.Controls.Add(buttonUserMan);
            sideBarSetting.Dock = DockStyle.Left;
            sideBarSetting.Location = new Point(0, 40);
            sideBarSetting.Name = "sideBarSetting";
            sideBarSetting.Size = new Size(250, 613);
            sideBarSetting.TabIndex = 0;
            // 
            // buttonResetAll
            // 
            buttonResetAll.Anchor = AnchorStyles.None;
            buttonResetAll.BackColor = Color.FromArgb(25, 55, 109);
            buttonResetAll.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonResetAll.BorderColor = Color.FromArgb(25, 55, 109);
            buttonResetAll.BorderRadius = 15;
            buttonResetAll.BorderSize = 0;
            buttonResetAll.FlatAppearance.BorderSize = 0;
            buttonResetAll.FlatStyle = FlatStyle.Flat;
            buttonResetAll.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResetAll.ForeColor = Color.Salmon;
            buttonResetAll.Location = new Point(10, 501);
            buttonResetAll.Name = "buttonResetAll";
            buttonResetAll.Size = new Size(230, 100);
            buttonResetAll.TabIndex = 12;
            buttonResetAll.Text = "Reset";
            buttonResetAll.TextColor = Color.Salmon;
            buttonResetAll.UseVisualStyleBackColor = false;
            // 
            // buttonSectorMan
            // 
            buttonSectorMan.BackColor = Color.FromArgb(25, 55, 109);
            buttonSectorMan.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonSectorMan.BorderColor = Color.FromArgb(25, 55, 109);
            buttonSectorMan.BorderRadius = 15;
            buttonSectorMan.BorderSize = 0;
            buttonSectorMan.FlatAppearance.BorderSize = 0;
            buttonSectorMan.FlatStyle = FlatStyle.Flat;
            buttonSectorMan.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSectorMan.ForeColor = Color.Gainsboro;
            buttonSectorMan.Image = (Image)resources.GetObject("buttonSectorMan.Image");
            buttonSectorMan.ImageAlign = ContentAlignment.MiddleRight;
            buttonSectorMan.Location = new Point(10, 120);
            buttonSectorMan.Name = "buttonSectorMan";
            buttonSectorMan.Padding = new Padding(5, 0, 20, 0);
            buttonSectorMan.Size = new Size(230, 100);
            buttonSectorMan.TabIndex = 2;
            buttonSectorMan.Text = "Department";
            buttonSectorMan.TextAlign = ContentAlignment.MiddleLeft;
            buttonSectorMan.TextColor = Color.Gainsboro;
            buttonSectorMan.UseVisualStyleBackColor = false;
            // 
            // buttonUserMan
            // 
            buttonUserMan.BackColor = Color.FromArgb(25, 55, 109);
            buttonUserMan.BackgroundColor = Color.FromArgb(25, 55, 109);
            buttonUserMan.BorderColor = Color.FromArgb(25, 55, 109);
            buttonUserMan.BorderRadius = 15;
            buttonUserMan.BorderSize = 0;
            buttonUserMan.FlatAppearance.BorderSize = 0;
            buttonUserMan.FlatStyle = FlatStyle.Flat;
            buttonUserMan.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUserMan.ForeColor = Color.Gainsboro;
            buttonUserMan.Image = (Image)resources.GetObject("buttonUserMan.Image");
            buttonUserMan.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserMan.Location = new Point(10, 14);
            buttonUserMan.Name = "buttonUserMan";
            buttonUserMan.Padding = new Padding(30, 0, 30, 0);
            buttonUserMan.Size = new Size(230, 100);
            buttonUserMan.TabIndex = 1;
            buttonUserMan.Text = "User";
            buttonUserMan.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserMan.TextColor = Color.Gainsboro;
            buttonUserMan.UseVisualStyleBackColor = false;
            // 
            // headerSetting
            // 
            headerSetting.BackColor = Color.FromArgb(11, 36, 71);
            headerSetting.Controls.Add(label1);
            headerSetting.Controls.Add(buttonClose);
            headerSetting.Dock = DockStyle.Top;
            headerSetting.Location = new Point(0, 0);
            headerSetting.Name = "headerSetting";
            headerSetting.Size = new Size(1182, 40);
            headerSetting.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Aristotelica Display Trial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 2;
            label1.Text = "Settings";
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1125, 6);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(54, 27);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 4;
            buttonClose.TabStop = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // mainSetting
            // 
            mainSetting.BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            mainSetting.BackgroundImageLayout = ImageLayout.Stretch;
            mainSetting.Dock = DockStyle.Fill;
            mainSetting.Location = new Point(250, 40);
            mainSetting.Name = "mainSetting";
            mainSetting.Size = new Size(932, 613);
            mainSetting.TabIndex = 2;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(mainSetting);
            Controls.Add(sideBarSetting);
            Controls.Add(headerSetting);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            Opacity = 0D;
            Text = "Setting";
            Load += Setting_Load;
            sideBarSetting.ResumeLayout(false);
            headerSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer modalEffect;
        private Panel sideBarSetting;
        private Panel headerSetting;
        private PictureBox buttonClose;
        private Label label1;
        private Panel mainSetting;
        private CustomControls.RJControls.RJButton buttonResetAll;
        private CustomControls.RJControls.RJButton buttonSectorMan;
        private CustomControls.RJControls.RJButton buttonUserMan;
    }
}