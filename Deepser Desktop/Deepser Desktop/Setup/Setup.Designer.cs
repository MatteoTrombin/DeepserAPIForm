namespace Deepser_Desktop
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            main = new Panel();
            bottom = new Panel();
            buttonFinish = new CustomControls.RJControls.RJButton();
            buttonNext = new CustomControls.RJControls.RJButton();
            buttonBack = new CustomControls.RJControls.RJButton();
            buttonSkip = new CustomControls.RJControls.RJButton();
            buttonOk = new CustomControls.RJControls.RJButton();
            buttonClose = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // main
            // 
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.Size = new Size(1262, 600);
            main.TabIndex = 4;
            main.Visible = false;
            // 
            // bottom
            // 
            bottom.Controls.Add(buttonFinish);
            bottom.Controls.Add(buttonNext);
            bottom.Controls.Add(buttonBack);
            bottom.Controls.Add(buttonSkip);
            bottom.Controls.Add(buttonOk);
            bottom.Controls.Add(buttonClose);
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(0, 600);
            bottom.Name = "bottom";
            bottom.Size = new Size(1262, 73);
            bottom.TabIndex = 0;
            // 
            // buttonFinish
            // 
            buttonFinish.BackColor = Color.FromArgb(11, 36, 71);
            buttonFinish.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonFinish.BorderColor = Color.FromArgb(11, 36, 71);
            buttonFinish.BorderRadius = 5;
            buttonFinish.BorderSize = 0;
            buttonFinish.FlatAppearance.BorderSize = 0;
            buttonFinish.FlatStyle = FlatStyle.Flat;
            buttonFinish.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFinish.ForeColor = Color.White;
            buttonFinish.Location = new Point(1091, 15);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(158, 46);
            buttonFinish.TabIndex = 16;
            buttonFinish.Text = "Finish";
            buttonFinish.TextColor = Color.White;
            buttonFinish.UseVisualStyleBackColor = false;
            buttonFinish.Visible = false;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(11, 36, 71);
            buttonNext.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonNext.BorderColor = Color.FromArgb(11, 36, 71);
            buttonNext.BorderRadius = 5;
            buttonNext.BorderSize = 0;
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.ForeColor = Color.White;
            buttonNext.Location = new Point(1091, 15);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(158, 46);
            buttonNext.TabIndex = 14;
            buttonNext.Text = "Next";
            buttonNext.TextColor = Color.White;
            buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(11, 36, 71);
            buttonBack.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderRadius = 5;
            buttonBack.BorderSize = 0;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(926, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(158, 46);
            buttonBack.TabIndex = 13;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            // 
            // buttonSkip
            // 
            buttonSkip.BackColor = Color.FromArgb(11, 36, 71);
            buttonSkip.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonSkip.BorderColor = Color.FromArgb(11, 36, 71);
            buttonSkip.BorderRadius = 5;
            buttonSkip.BorderSize = 0;
            buttonSkip.FlatAppearance.BorderSize = 0;
            buttonSkip.FlatStyle = FlatStyle.Flat;
            buttonSkip.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSkip.ForeColor = Color.White;
            buttonSkip.Location = new Point(761, 15);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(158, 46);
            buttonSkip.TabIndex = 12;
            buttonSkip.Text = "Skip";
            buttonSkip.TextColor = Color.White;
            buttonSkip.UseVisualStyleBackColor = false;
            buttonSkip.Visible = false;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(11, 36, 71);
            buttonOk.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonOk.BorderColor = Color.FromArgb(11, 36, 71);
            buttonOk.BorderRadius = 5;
            buttonOk.BorderSize = 0;
            buttonOk.FlatAppearance.BorderSize = 0;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.ForeColor = Color.White;
            buttonOk.Location = new Point(1091, 15);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(158, 46);
            buttonOk.TabIndex = 17;
            buttonOk.Text = "Ok";
            buttonOk.TextColor = Color.White;
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Visible = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(11, 36, 71);
            buttonClose.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonClose.BorderColor = Color.FromArgb(11, 36, 71);
            buttonClose.BorderRadius = 5;
            buttonClose.BorderSize = 0;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(926, 15);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(158, 46);
            buttonClose.TabIndex = 15;
            buttonClose.Text = "Close";
            buttonClose.TextColor = Color.White;
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 117);
            label1.Name = "label1";
            label1.Size = new Size(758, 441);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 34);
            label2.Name = "label2";
            label2.Size = new Size(670, 83);
            label2.TabIndex = 6;
            label2.Text = "Welcome to our software!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(897, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(main);
            Controls.Add(bottom);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Setup";
            Text = "Setup";
            bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel main;
        private Panel bottom;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton buttonFinish;
        private CustomControls.RJControls.RJButton buttonNext;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonSkip;
        private CustomControls.RJControls.RJButton buttonOk;
        private CustomControls.RJControls.RJButton buttonClose;
    }
}