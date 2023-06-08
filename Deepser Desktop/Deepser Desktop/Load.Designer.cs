namespace Deepser_Desktop
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            textField = new TextBox();
            textSingle = new TextBox();
            textResult = new TextBox();
            buttonDelete = new CustomControls.RJControls.RJButton();
            buttonBack = new CustomControls.RJControls.RJButton();
            selectEntity = new ComboBoxPlus();
            buttonSearch = new CustomControls.RJControls.RJButton();
            textId = new TextBox();
            dataGridJson = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonHistory = new CustomControls.RJControls.RJButton();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridJson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textField
            // 
            textField.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textField.Location = new Point(762, 260);
            textField.Name = "textField";
            textField.PlaceholderText = "Field (optional)";
            textField.Size = new Size(230, 32);
            textField.TabIndex = 4;
            // 
            // textSingle
            // 
            textSingle.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textSingle.Location = new Point(507, 260);
            textSingle.Name = "textSingle";
            textSingle.PlaceholderText = "Get single data";
            textSingle.Size = new Size(230, 32);
            textSingle.TabIndex = 8;
            // 
            // textResult
            // 
            textResult.BorderStyle = BorderStyle.FixedSingle;
            textResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textResult.Location = new Point(123, 399);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.ScrollBars = ScrollBars.Vertical;
            textResult.Size = new Size(1003, 304);
            textResult.TabIndex = 10;
            textResult.WordWrap = false;
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
            buttonDelete.Location = new Point(623, 322);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(163, 56);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.TextColor = Color.White;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
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
            buttonBack.Location = new Point(454, 322);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(163, 56);
            buttonBack.TabIndex = 27;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(517, 185);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 29;
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
            buttonSearch.Location = new Point(538, 322);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Padding = new Padding(25, 0, 25, 0);
            buttonSearch.Size = new Size(163, 56);
            buttonSearch.TabIndex = 30;
            buttonSearch.Text = "Search";
            buttonSearch.TextAlign = ContentAlignment.MiddleLeft;
            buttonSearch.TextColor = Color.White;
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textId
            // 
            textId.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(241, 260);
            textId.Name = "textId";
            textId.PlaceholderText = "Id or Value (only with Field)";
            textId.Size = new Size(242, 32);
            textId.TabIndex = 32;
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
            dataGridJson.Location = new Point(123, 399);
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
            dataGridJson.TabIndex = 90;
            dataGridJson.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 92;
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
            buttonHistory.Location = new Point(538, 711);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Padding = new Padding(22, 0, 28, 0);
            buttonHistory.Size = new Size(163, 56);
            buttonHistory.TabIndex = 119;
            buttonHistory.Text = "History";
            buttonHistory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistory.TextColor = Color.Gainsboro;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Aristotelica Display Trial", 55.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(11, 36, 71);
            labelTitle.Location = new Point(495, 61);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(246, 103);
            labelTitle.TabIndex = 28;
            labelTitle.Text = "Load";
            // 
            // Load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(textResult);
            Controls.Add(dataGridJson);
            Controls.Add(buttonHistory);
            Controls.Add(labelTitle);
            Controls.Add(textId);
            Controls.Add(buttonSearch);
            Controls.Add(selectEntity);
            Controls.Add(textSingle);
            Controls.Add(textField);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Load";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Load";
            ((System.ComponentModel.ISupportInitialize)dataGridJson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal TextBox textField;
        internal ComboBoxPlus selectEntity;
        internal TextBox textSingle;
        private TextBox textResult;
        private CustomControls.RJControls.RJButton buttonDelete;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonSearch;
        internal TextBox textId;
        private DataGridView dataGridJson;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton buttonHistory;
        private Label labelTitle;
    }
}