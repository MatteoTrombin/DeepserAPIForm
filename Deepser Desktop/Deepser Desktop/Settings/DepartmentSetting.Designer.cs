namespace Deepser_Desktop
{
    partial class DepartmentSetting
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
            selectDelDepartment = new ComboBoxPlus();
            buttonDelDepartment = new CustomControls.RJControls.RJButton();
            buttonAddSector = new CustomControls.RJControls.RJButton();
            textDepartment = new TextBox();
            panel1 = new Panel();
            buttonRemFromDep = new CustomControls.RJControls.RJButton();
            selectUserRemove = new ComboBoxPlus();
            selectDepartmentRemove = new ComboBoxPlus();
            panelAddToSector = new Panel();
            buttonAddToDep = new CustomControls.RJControls.RJButton();
            selectSector = new ComboBoxPlus();
            selectUser = new ComboBoxPlus();
            buttonBack = new CustomControls.RJControls.RJButton();
            buttonManagment = new CustomControls.RJControls.RJButton();
            dataGridDepartment = new DataGridView();
            ColumnHost = new DataGridViewTextBoxColumn();
            ColumnUser = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelAddToSector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDepartment).BeginInit();
            SuspendLayout();
            // 
            // selectDelDepartment
            // 
            selectDelDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDelDepartment.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDelDepartment.FormattingEnabled = true;
            selectDelDepartment.Location = new Point(569, 134);
            selectDelDepartment.Name = "selectDelDepartment";
            selectDelDepartment.Placeholder = "Select Department";
            selectDelDepartment.Size = new Size(270, 38);
            selectDelDepartment.TabIndex = 53;
            // 
            // buttonDelDepartment
            // 
            buttonDelDepartment.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelDepartment.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelDepartment.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelDepartment.BorderRadius = 15;
            buttonDelDepartment.BorderSize = 0;
            buttonDelDepartment.Enabled = false;
            buttonDelDepartment.FlatStyle = FlatStyle.Flat;
            buttonDelDepartment.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelDepartment.ForeColor = Color.White;
            buttonDelDepartment.Location = new Point(600, 178);
            buttonDelDepartment.Name = "buttonDelDepartment";
            buttonDelDepartment.Size = new Size(209, 45);
            buttonDelDepartment.TabIndex = 52;
            buttonDelDepartment.Text = "Delete Department";
            buttonDelDepartment.TextColor = Color.White;
            buttonDelDepartment.UseVisualStyleBackColor = false;
            // 
            // buttonAddSector
            // 
            buttonAddSector.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddSector.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddSector.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddSector.BorderRadius = 15;
            buttonAddSector.BorderSize = 0;
            buttonAddSector.Enabled = false;
            buttonAddSector.FlatStyle = FlatStyle.Flat;
            buttonAddSector.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddSector.ForeColor = Color.White;
            buttonAddSector.Location = new Point(118, 172);
            buttonAddSector.Name = "buttonAddSector";
            buttonAddSector.Size = new Size(209, 45);
            buttonAddSector.TabIndex = 51;
            buttonAddSector.Text = "Add Department";
            buttonAddSector.TextColor = Color.White;
            buttonAddSector.UseVisualStyleBackColor = false;
            // 
            // textDepartment
            // 
            textDepartment.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textDepartment.Location = new Point(87, 134);
            textDepartment.Name = "textDepartment";
            textDepartment.PlaceholderText = "Department name";
            textDepartment.Size = new Size(270, 32);
            textDepartment.TabIndex = 50;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonRemFromDep);
            panel1.Controls.Add(selectUserRemove);
            panel1.Controls.Add(selectDepartmentRemove);
            panel1.Location = new Point(550, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 214);
            panel1.TabIndex = 49;
            // 
            // buttonRemFromDep
            // 
            buttonRemFromDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BorderRadius = 15;
            buttonRemFromDep.BorderSize = 0;
            buttonRemFromDep.Enabled = false;
            buttonRemFromDep.FlatStyle = FlatStyle.Flat;
            buttonRemFromDep.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemFromDep.ForeColor = Color.White;
            buttonRemFromDep.Location = new Point(19, 141);
            buttonRemFromDep.Name = "buttonRemFromDep";
            buttonRemFromDep.Size = new Size(270, 45);
            buttonRemFromDep.TabIndex = 43;
            buttonRemFromDep.Text = "Remove From Department";
            buttonRemFromDep.TextColor = Color.White;
            buttonRemFromDep.UseVisualStyleBackColor = false;
            // 
            // selectUserRemove
            // 
            selectUserRemove.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUserRemove.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectUserRemove.FormattingEnabled = true;
            selectUserRemove.Location = new Point(19, 91);
            selectUserRemove.Name = "selectUserRemove";
            selectUserRemove.Placeholder = "Select User";
            selectUserRemove.Size = new Size(270, 38);
            selectUserRemove.TabIndex = 45;
            // 
            // selectDepartmentRemove
            // 
            selectDepartmentRemove.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDepartmentRemove.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDepartmentRemove.FormattingEnabled = true;
            selectDepartmentRemove.Location = new Point(19, 34);
            selectDepartmentRemove.Name = "selectDepartmentRemove";
            selectDepartmentRemove.Placeholder = "Select Department";
            selectDepartmentRemove.Size = new Size(270, 38);
            selectDepartmentRemove.TabIndex = 44;
            // 
            // panelAddToSector
            // 
            panelAddToSector.BackColor = Color.Transparent;
            panelAddToSector.Controls.Add(buttonAddToDep);
            panelAddToSector.Controls.Add(selectSector);
            panelAddToSector.Controls.Add(selectUser);
            panelAddToSector.Location = new Point(70, 250);
            panelAddToSector.Name = "panelAddToSector";
            panelAddToSector.Size = new Size(306, 220);
            panelAddToSector.TabIndex = 48;
            // 
            // buttonAddToDep
            // 
            buttonAddToDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BorderRadius = 15;
            buttonAddToDep.BorderSize = 0;
            buttonAddToDep.Enabled = false;
            buttonAddToDep.FlatStyle = FlatStyle.Flat;
            buttonAddToDep.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToDep.ForeColor = Color.White;
            buttonAddToDep.Location = new Point(44, 149);
            buttonAddToDep.Name = "buttonAddToDep";
            buttonAddToDep.Size = new Size(209, 45);
            buttonAddToDep.TabIndex = 42;
            buttonAddToDep.Text = "Add to Department";
            buttonAddToDep.TextColor = Color.White;
            buttonAddToDep.UseVisualStyleBackColor = false;
            // 
            // selectSector
            // 
            selectSector.DropDownStyle = ComboBoxStyle.DropDownList;
            selectSector.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectSector.FormattingEnabled = true;
            selectSector.Location = new Point(17, 97);
            selectSector.Name = "selectSector";
            selectSector.Placeholder = "Select Department";
            selectSector.Size = new Size(270, 38);
            selectSector.TabIndex = 43;
            // 
            // selectUser
            // 
            selectUser.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUser.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectUser.FormattingEnabled = true;
            selectUser.Location = new Point(17, 40);
            selectUser.Name = "selectUser";
            selectUser.Placeholder = "Select User";
            selectUser.Size = new Size(270, 38);
            selectUser.TabIndex = 42;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(11, 36, 71);
            buttonBack.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderRadius = 10;
            buttonBack.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(387, 491);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(163, 63);
            buttonBack.TabIndex = 55;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.White;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            // 
            // buttonManagment
            // 
            buttonManagment.BackColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BorderColor = Color.FromArgb(11, 36, 71);
            buttonManagment.BorderRadius = 10;
            buttonManagment.BorderSize = 0;
            buttonManagment.FlatStyle = FlatStyle.Flat;
            buttonManagment.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManagment.ForeColor = Color.White;
            buttonManagment.Location = new Point(387, 491);
            buttonManagment.Name = "buttonManagment";
            buttonManagment.Size = new Size(163, 63);
            buttonManagment.TabIndex = 54;
            buttonManagment.Text = "Department managment";
            buttonManagment.TextColor = Color.White;
            buttonManagment.UseVisualStyleBackColor = false;
            // 
            // dataGridDepartment
            // 
            dataGridDepartment.AllowUserToAddRows = false;
            dataGridDepartment.AllowUserToDeleteRows = false;
            dataGridDepartment.BackgroundColor = Color.White;
            dataGridDepartment.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridDepartment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridDepartment.ColumnHeadersHeight = 50;
            dataGridDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridDepartment.Columns.AddRange(new DataGridViewColumn[] { ColumnHost, ColumnUser });
            dataGridDepartment.EnableHeadersVisualStyles = false;
            dataGridDepartment.GridColor = Color.White;
            dataGridDepartment.Location = new Point(20, 53);
            dataGridDepartment.Name = "dataGridDepartment";
            dataGridDepartment.ReadOnly = true;
            dataGridDepartment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridDepartment.RowHeadersVisible = false;
            dataGridDepartment.RowHeadersWidth = 51;
            dataGridDepartment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridDepartment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridDepartment.RowTemplate.Height = 29;
            dataGridDepartment.Size = new Size(879, 417);
            dataGridDepartment.TabIndex = 56;
            // 
            // ColumnHost
            // 
            ColumnHost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnHost.HeaderText = "Department Name";
            ColumnHost.MinimumWidth = 6;
            ColumnHost.Name = "ColumnHost";
            ColumnHost.ReadOnly = true;
            ColumnHost.ToolTipText = "Name of the department";
            // 
            // ColumnUser
            // 
            ColumnUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnUser.HeaderText = "User";
            ColumnUser.MinimumWidth = 6;
            ColumnUser.Name = "ColumnUser";
            ColumnUser.ReadOnly = true;
            // 
            // DepartmentSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 566);
            Controls.Add(dataGridDepartment);
            Controls.Add(buttonManagment);
            Controls.Add(selectDelDepartment);
            Controls.Add(buttonDelDepartment);
            Controls.Add(buttonAddSector);
            Controls.Add(textDepartment);
            Controls.Add(panel1);
            Controls.Add(panelAddToSector);
            Controls.Add(buttonBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DepartmentSetting";
            Text = "SectorSetting";
            panel1.ResumeLayout(false);
            panelAddToSector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBoxPlus selectDelDepartment;
        private CustomControls.RJControls.RJButton buttonDelDepartment;
        private CustomControls.RJControls.RJButton buttonAddSector;
        private TextBox textDepartment;
        private Panel panel1;
        private CustomControls.RJControls.RJButton buttonRemFromDep;
        private ComboBoxPlus selectUserRemove;
        private ComboBoxPlus selectDepartmentRemove;
        private Panel panelAddToSector;
        private CustomControls.RJControls.RJButton buttonAddToDep;
        private ComboBoxPlus selectSector;
        private ComboBoxPlus selectUser;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonManagment;
        private DataGridView dataGridDepartment;
        private DataGridViewTextBoxColumn ColumnHost;
        private DataGridViewTextBoxColumn ColumnUser;
    }
}