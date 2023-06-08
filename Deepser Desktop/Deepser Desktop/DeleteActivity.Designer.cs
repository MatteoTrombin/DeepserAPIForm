namespace Deepser_Desktop
{
    partial class DeleteActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteActivity));
            labelDelete = new Label();
            selectEntity = new ComboBoxPlus();
            textId = new TextBox();
            buttonDelete = new CustomControls.RJControls.RJButton();
            textActivity = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelDelete
            // 
            labelDelete.BackColor = Color.Transparent;
            labelDelete.Font = new Font("Aristotelica Display Trial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            labelDelete.ForeColor = Color.FromArgb(11, 36, 71);
            labelDelete.Location = new Point(280, 78);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(722, 103);
            labelDelete.TabIndex = 108;
            labelDelete.Text = "Delete activity";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(504, 281);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 109;
            // 
            // textId
            // 
            textId.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(257, 352);
            textId.Name = "textId";
            textId.PlaceholderText = "Entity ID";
            textId.Size = new Size(242, 32);
            textId.TabIndex = 110;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderRadius = 12;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Gainsboro;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonDelete.Location = new Point(528, 412);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(25, 0, 25, 0);
            buttonDelete.Size = new Size(163, 56);
            buttonDelete.TabIndex = 111;
            buttonDelete.Text = "Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonDelete.TextColor = Color.Gainsboro;
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // textActivity
            // 
            textActivity.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textActivity.Location = new Point(708, 352);
            textActivity.Name = "textActivity";
            textActivity.PlaceholderText = "Activity ID";
            textActivity.Size = new Size(242, 32);
            textActivity.TabIndex = 112;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 114;
            pictureBox2.TabStop = false;
            // 
            // DeleteActivity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(textActivity);
            Controls.Add(buttonDelete);
            Controls.Add(textId);
            Controls.Add(selectEntity);
            Controls.Add(labelDelete);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteActivity";
            Text = "DeleteActivity";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelDelete;
        internal ComboBoxPlus selectEntity;
        internal TextBox textId;
        private CustomControls.RJControls.RJButton buttonDelete;
        private TextBox textActivity;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}