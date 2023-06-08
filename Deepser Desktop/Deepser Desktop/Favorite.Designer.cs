namespace Deepser_Desktop
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelHistory = new Label();
            buttonClose = new PictureBox();
            dataGridFav = new DataGridView();
            headerSetting = new Panel();
            modalEffect = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFav).BeginInit();
            headerSetting.SuspendLayout();
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
            labelHistory.Text = "Favorite";
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
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridFav
            // 
            dataGridFav.AllowUserToAddRows = false;
            dataGridFav.AllowUserToDeleteRows = false;
            dataGridFav.BackgroundColor = Color.White;
            dataGridFav.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridFav.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridFav.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridFav.ColumnHeadersHeight = 50;
            dataGridFav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridFav.EnableHeadersVisualStyles = false;
            dataGridFav.GridColor = Color.White;
            dataGridFav.Location = new Point(83, 99);
            dataGridFav.Name = "dataGridFav";
            dataGridFav.ReadOnly = true;
            dataGridFav.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridFav.RowHeadersVisible = false;
            dataGridFav.RowHeadersWidth = 51;
            dataGridFav.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridFav.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridFav.RowTemplate.Height = 29;
            dataGridFav.Size = new Size(1014, 491);
            dataGridFav.TabIndex = 118;
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
            headerSetting.TabIndex = 117;
            // 
            // modalEffect
            // 
            modalEffect.Enabled = true;
            modalEffect.Interval = 1;
            // 
            // Favorite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(dataGridFav);
            Controls.Add(headerSetting);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Favorite";
            Opacity = 0D;
            Text = "Favorite";
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFav).EndInit();
            headerSetting.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelHistory;
        private PictureBox buttonClose;
        public DataGridView dataGridFav;
        private Panel headerSetting;
        private System.Windows.Forms.Timer modalEffect;
    }
}