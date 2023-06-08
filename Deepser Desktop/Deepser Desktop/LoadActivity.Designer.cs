namespace Deepser_Desktop
{
    partial class LoadActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadActivity));
            label1 = new Label();
            textId = new TextBox();
            buttonSearch = new CustomControls.RJControls.RJButton();
            selectEntity = new ComboBoxPlus();
            textActivity = new TextBox();
            textSingle = new TextBox();
            buttonBack = new CustomControls.RJControls.RJButton();
            buttonDelete = new CustomControls.RJControls.RJButton();
            textResult = new TextBox();
            dataGridJson = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonHistory = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dataGridJson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aristotelica Display Trial", 58.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 36, 71);
            label1.Location = new Point(331, 69);
            label1.Name = "label1";
            label1.Size = new Size(623, 103);
            label1.TabIndex = 43;
            label1.Text = "Load activity";
            // 
            // textId
            // 
            textId.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(256, 242);
            textId.Name = "textId";
            textId.PlaceholderText = "Id or Value (only with Field)";
            textId.Size = new Size(242, 32);
            textId.TabIndex = 46;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(11, 36, 71);
            buttonSearch.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonSearch.BorderColor = Color.FromArgb(11, 36, 71);
            buttonSearch.BorderRadius = 12;
            buttonSearch.BorderSize = 0;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = Properties.Resources.search1;
            buttonSearch.ImageAlign = ContentAlignment.MiddleRight;
            buttonSearch.Location = new Point(553, 304);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Padding = new Padding(25, 0, 25, 0);
            buttonSearch.Size = new Size(163, 56);
            buttonSearch.TabIndex = 45;
            buttonSearch.Text = "Search";
            buttonSearch.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearch.TextColor = Color.White;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(532, 184);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 44;
            // 
            // textActivity
            // 
            textActivity.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textActivity.Location = new Point(522, 242);
            textActivity.Name = "textActivity";
            textActivity.PlaceholderText = "Activity id";
            textActivity.Size = new Size(230, 32);
            textActivity.TabIndex = 40;
            // 
            // textSingle
            // 
            textSingle.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textSingle.Location = new Point(777, 242);
            textSingle.Name = "textSingle";
            textSingle.PlaceholderText = "Single value";
            textSingle.Size = new Size(230, 32);
            textSingle.TabIndex = 39;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(11, 36, 71);
            buttonBack.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderRadius = 12;
            buttonBack.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(469, 304);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(163, 56);
            buttonBack.TabIndex = 42;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderRadius = 12;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(638, 304);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(163, 56);
            buttonDelete.TabIndex = 41;
            buttonDelete.Text = "Delete";
            buttonDelete.TextColor = Color.White;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            // 
            // textResult
            // 
            textResult.BorderStyle = BorderStyle.FixedSingle;
            textResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textResult.Location = new Point(128, 392);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.ScrollBars = ScrollBars.Vertical;
            textResult.Size = new Size(1003, 304);
            textResult.TabIndex = 47;
            textResult.WordWrap = false;
            // 
            // dataGridJson
            // 
            dataGridJson.AllowUserToAddRows = false;
            dataGridJson.AllowUserToDeleteRows = false;
            dataGridJson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridJson.BackgroundColor = Color.White;
            dataGridJson.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridJson.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridJson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridJson.ColumnHeadersHeight = 50;
            dataGridJson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridJson.EnableHeadersVisualStyles = false;
            dataGridJson.GridColor = Color.White;
            dataGridJson.Location = new Point(128, 392);
            dataGridJson.MultiSelect = false;
            dataGridJson.Name = "dataGridJson";
            dataGridJson.ReadOnly = true;
            dataGridJson.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridJson.RowHeadersVisible = false;
            dataGridJson.RowHeadersWidth = 51;
            dataGridJson.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridJson.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridJson.RowTemplate.Height = 29;
            dataGridJson.Size = new Size(1003, 304);
            dataGridJson.TabIndex = 91;
            dataGridJson.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 93;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.FromArgb(11, 36, 71);
            buttonHistory.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonHistory.BorderColor = Color.FromArgb(11, 36, 71);
            buttonHistory.BorderRadius = 10;
            buttonHistory.BorderSize = 0;
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistory.ForeColor = Color.Gainsboro;
            buttonHistory.Image = (Image)resources.GetObject("buttonHistory.Image");
            buttonHistory.ImageAlign = ContentAlignment.MiddleRight;
            buttonHistory.Location = new Point(553, 711);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Padding = new Padding(22, 0, 28, 0);
            buttonHistory.Size = new Size(163, 56);
            buttonHistory.TabIndex = 121;
            buttonHistory.Text = "History";
            buttonHistory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistory.TextColor = Color.Gainsboro;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // LoadActivity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(buttonHistory);
            Controls.Add(label1);
            Controls.Add(textId);
            Controls.Add(buttonSearch);
            Controls.Add(selectEntity);
            Controls.Add(textActivity);
            Controls.Add(textSingle);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(textResult);
            Controls.Add(dataGridJson);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadActivity";
            Text = "LoadActivity";
            ((System.ComponentModel.ISupportInitialize)dataGridJson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        internal TextBox textId;
        private CustomControls.RJControls.RJButton buttonSearch;
        internal ComboBoxPlus selectEntity;
        internal TextBox textActivity;
        internal TextBox textSingle;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonDelete;
        private TextBox textResult;
        private DataGridView dataGridJson;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton buttonHistory;
    }
}