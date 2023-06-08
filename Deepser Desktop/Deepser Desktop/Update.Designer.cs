namespace Deepser_Desktop
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            label5 = new Label();
            selectEntity = new ComboBoxPlus();
            textField = new TextBox();
            textId = new TextBox();
            dataGrid = new DataGridView();
            ColumnAttribute = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            label1 = new Label();
            buttonUpdate = new CustomControls.RJControls.RJButton();
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
            label5.Location = new Point(567, 264);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 21;
            label5.Text = "Update data table";
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(538, 198);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 30;
            // 
            // textField
            // 
            textField.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textField.Location = new Point(850, 213);
            textField.Name = "textField";
            textField.PlaceholderText = "Field (optional)";
            textField.Size = new Size(242, 32);
            textField.TabIndex = 33;
            // 
            // textId
            // 
            textId.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(183, 213);
            textId.Name = "textId";
            textId.PlaceholderText = "Id or Value (only with Field)";
            textId.Size = new Size(242, 32);
            textId.TabIndex = 34;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnAttribute, ColumnValue });
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.White;
            dataGrid.Location = new Point(458, 307);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            ColumnValue.HeaderText = "New Value";
            ColumnValue.MinimumWidth = 6;
            ColumnValue.Name = "ColumnValue";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aristotelica Display Trial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 36, 71);
            label1.Location = new Point(446, 55);
            label1.Name = "label1";
            label1.Size = new Size(377, 103);
            label1.TabIndex = 106;
            label1.Text = "Update";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BorderColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BorderRadius = 12;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.ImageAlign = ContentAlignment.MiddleRight;
            buttonUpdate.Location = new Point(558, 663);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Padding = new Padding(25, 0, 25, 0);
            buttonUpdate.Size = new Size(163, 56);
            buttonUpdate.TabIndex = 105;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.TextColor = Color.White;
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 483);
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-34, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 575);
            pictureBox2.TabIndex = 108;
            pictureBox2.TabStop = false;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGrid);
            Controls.Add(textId);
            Controls.Add(textField);
            Controls.Add(selectEntity);
            Controls.Add(label5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Update";
            Text = "Update";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        internal ComboBoxPlus selectEntity;
        private TextBox textField;
        internal TextBox textId;
        internal DataGridView dataGrid;
        private DataGridViewTextBoxColumn ColumnAttribute;
        private DataGridViewTextBoxColumn ColumnValue;
        private Label label1;
        private CustomControls.RJControls.RJButton buttonUpdate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}