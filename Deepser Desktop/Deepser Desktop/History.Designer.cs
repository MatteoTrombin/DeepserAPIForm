namespace Deepser_Desktop
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelHistory = new Label();
            buttonClose = new PictureBox();
            headerSetting = new Panel();
            dataGridHistory = new DataGridView();
            modalEffect = new System.Windows.Forms.Timer(components);
            buttonDeleteAll = new CustomControls.RJControls.RJButton();
            fadeOutTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            headerSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            SuspendLayout();
            // 
            // labelHistory
            // 
            labelHistory.Font = new Font("Aristotelica Display Trial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelHistory.ForeColor = Color.Gainsboro;
            labelHistory.Location = new Point(10, 6);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(132, 27);
            labelHistory.TabIndex = 2;
            labelHistory.Text = "History";
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
            // 
            // headerSetting
            // 
            headerSetting.BackColor = Color.FromArgb(11, 36, 71);
            headerSetting.Controls.Add(labelHistory);
            headerSetting.Controls.Add(buttonClose);
            headerSetting.Dock = DockStyle.Top;
            headerSetting.Location = new Point(0, 0);
            headerSetting.Name = "headerSetting";
            headerSetting.Size = new Size(1182, 40);
            headerSetting.TabIndex = 2;
            // 
            // dataGridHistory
            // 
            dataGridHistory.AllowUserToAddRows = false;
            dataGridHistory.AllowUserToDeleteRows = false;
            dataGridHistory.BackgroundColor = Color.White;
            dataGridHistory.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHistory.ColumnHeadersHeight = 50;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridHistory.EnableHeadersVisualStyles = false;
            dataGridHistory.GridColor = Color.White;
            dataGridHistory.Location = new Point(83, 92);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.ReadOnly = true;
            dataGridHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridHistory.RowHeadersVisible = false;
            dataGridHistory.RowHeadersWidth = 51;
            dataGridHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridHistory.RowTemplate.Height = 29;
            dataGridHistory.Size = new Size(1014, 477);
            dataGridHistory.TabIndex = 48;
            // 
            // modalEffect
            // 
            modalEffect.Enabled = true;
            modalEffect.Interval = 1;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BorderRadius = 6;
            buttonDeleteAll.BorderSize = 0;
            buttonDeleteAll.Enabled = false;
            buttonDeleteAll.FlatAppearance.BorderSize = 0;
            buttonDeleteAll.FlatStyle = FlatStyle.Flat;
            buttonDeleteAll.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteAll.ForeColor = Color.Gainsboro;
            buttonDeleteAll.Image = (Image)resources.GetObject("buttonDeleteAll.Image");
            buttonDeleteAll.ImageAlign = ContentAlignment.MiddleRight;
            buttonDeleteAll.Location = new Point(530, 584);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Padding = new Padding(10, 0, 15, 0);
            buttonDeleteAll.Size = new Size(151, 55);
            buttonDeleteAll.TabIndex = 116;
            buttonDeleteAll.Text = "Delete all";
            buttonDeleteAll.TextAlign = ContentAlignment.MiddleLeft;
            buttonDeleteAll.TextColor = Color.Gainsboro;
            buttonDeleteAll.UseVisualStyleBackColor = false;
            // 
            // fadeOutTimer
            // 
            fadeOutTimer.Interval = 20;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            ClientSize = new Size(1182, 653);
            Controls.Add(buttonDeleteAll);
            Controls.Add(dataGridHistory);
            Controls.Add(headerSetting);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "History";
            Opacity = 0D;
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            headerSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelHistory;
        private PictureBox buttonClose;
        private Panel headerSetting;
        public DataGridView dataGridHistory;
        private System.Windows.Forms.Timer modalEffect;
        private CustomControls.RJControls.RJButton buttonDeleteAll;
        private System.Windows.Forms.Timer fadeOutTimer;
    }
}