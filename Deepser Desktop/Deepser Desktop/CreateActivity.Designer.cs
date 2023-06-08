namespace Deepser_Desktop
{
    partial class CreateActivity
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateActivity));
            label1 = new Label();
            selectEntity = new ComboBoxPlus();
            textId = new TextBox();
            dataGrid = new DataGridView();
            ColumnAttribute = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            buttonCreate = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aristotelica Display Trial", 58.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 36, 71);
            label1.Location = new Point(294, 85);
            label1.Name = "label1";
            label1.Size = new Size(711, 103);
            label1.TabIndex = 44;
            label1.Text = "Create activity";
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(528, 207);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 45;
            // 
            // textId
            // 
            textId.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(505, 256);
            textId.Name = "textId";
            textId.PlaceholderText = "Id ";
            textId.Size = new Size(242, 32);
            textId.TabIndex = 47;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnAttribute, ColumnValue });
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.White;
            dataGrid.Location = new Point(448, 316);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(365, 331);
            dataGrid.TabIndex = 104;
            // 
            // ColumnAttribute
            // 
            ColumnAttribute.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnAttribute.HeaderText = "Attribute";
            ColumnAttribute.MinimumWidth = 6;
            ColumnAttribute.Name = "ColumnAttribute";
            // 
            // ColumnValue
            // 
            ColumnValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnValue.HeaderText = "Value";
            ColumnValue.MinimumWidth = 6;
            ColumnValue.Name = "ColumnValue";
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(11, 36, 71);
            buttonCreate.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonCreate.BorderColor = Color.FromArgb(11, 36, 71);
            buttonCreate.BorderRadius = 12;
            buttonCreate.BorderSize = 0;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Image = (Image)resources.GetObject("buttonCreate.Image");
            buttonCreate.ImageAlign = ContentAlignment.MiddleRight;
            buttonCreate.Location = new Point(545, 675);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Padding = new Padding(25, 0, 25, 0);
            buttonCreate.Size = new Size(163, 56);
            buttonCreate.TabIndex = 105;
            buttonCreate.Text = "Create";
            buttonCreate.TextAlign = ContentAlignment.MiddleLeft;
            buttonCreate.TextColor = Color.White;
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 106;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 107;
            pictureBox2.TabStop = false;
            // 
            // CreateActivity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonCreate);
            Controls.Add(dataGrid);
            Controls.Add(textId);
            Controls.Add(selectEntity);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateActivity";
            Text = "CreateActivity";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBoxPlus selectEntity;
        private TextBox textId;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn ColumnAttribute;
        private DataGridViewTextBoxColumn ColumnValue;
        private CustomControls.RJControls.RJButton buttonCreate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}