namespace Deepser_Desktop
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label5 = new Label();
            label1 = new Label();
            selectEntity = new ComboBoxPlus();
            buttonCreate = new CustomControls.RJControls.RJButton();
            dataGrid = new DataGridView();
            ColumnAttribute = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(573, 244);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 28;
            label5.Text = "Fill the table";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aristotelica Display Trial", 64.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 36, 71);
            label1.Location = new Point(445, 61);
            label1.Name = "label1";
            label1.Size = new Size(403, 103);
            label1.TabIndex = 29;
            label1.Text = "Create";
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(526, 183);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 30;
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
            buttonCreate.Location = new Point(550, 645);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Padding = new Padding(25, 0, 25, 0);
            buttonCreate.Size = new Size(163, 56);
            buttonCreate.TabIndex = 102;
            buttonCreate.Text = "Create";
            buttonCreate.TextAlign = ContentAlignment.MiddleLeft;
            buttonCreate.TextColor = Color.White;
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnAttribute, ColumnValue });
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.White;
            dataGrid.Location = new Point(445, 283);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(365, 331);
            dataGrid.TabIndex = 103;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 105;
            pictureBox2.TabStop = false;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dataGrid);
            Controls.Add(buttonCreate);
            Controls.Add(selectEntity);
            Controls.Add(label1);
            Controls.Add(label5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create";
            Text = "Create";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label1;
        private ComboBoxPlus selectEntity;
        private CustomControls.RJControls.RJButton buttonCreate;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn ColumnAttribute;
        private DataGridViewTextBoxColumn ColumnValue;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}