namespace Deepser_Desktop
{
    partial class DepartmentSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentSetup));
            label1 = new Label();
            label3 = new Label();
            selectDelDepartment = new ComboBoxPlus();
            buttonDelDep = new CustomControls.RJControls.RJButton();
            buttonAddDep = new CustomControls.RJControls.RJButton();
            textDepartment = new TextBox();
            panel1 = new Panel();
            buttonRemFromDep = new CustomControls.RJControls.RJButton();
            selectUserRemove = new ComboBoxPlus();
            selectDepartmentRemove = new ComboBoxPlus();
            panelAddToSector = new Panel();
            buttonAddToDep = new CustomControls.RJControls.RJButton();
            selectDepartment = new ComboBoxPlus();
            selectUser = new ComboBoxPlus();
            panel1.SuspendLayout();
            panelAddToSector.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 110);
            label1.Name = "label1";
            label1.Size = new Size(962, 117);
            label1.TabIndex = 15;
            label1.Text = "To create a new department type in the name you would like to give the departmentand press the 'Add Department' button, a table will appear below where you can manage your departments";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(25, 55, 109);
            label3.Location = new Point(356, 36);
            label3.Name = "label3";
            label3.Size = new Size(642, 83);
            label3.TabIndex = 18;
            label3.Text = "Department Managment";
            // 
            // selectDelDepartment
            // 
            selectDelDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDelDepartment.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDelDepartment.FormattingEnabled = true;
            selectDelDepartment.Location = new Point(767, 253);
            selectDelDepartment.Name = "selectDelDepartment";
            selectDelDepartment.Placeholder = "Select Department";
            selectDelDepartment.Size = new Size(270, 38);
            selectDelDepartment.TabIndex = 47;
            // 
            // buttonDelDep
            // 
            buttonDelDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelDep.BorderRadius = 8;
            buttonDelDep.BorderSize = 0;
            buttonDelDep.Enabled = false;
            buttonDelDep.FlatStyle = FlatStyle.Flat;
            buttonDelDep.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelDep.ForeColor = Color.White;
            buttonDelDep.Location = new Point(798, 297);
            buttonDelDep.Name = "buttonDelDep";
            buttonDelDep.Size = new Size(209, 45);
            buttonDelDep.TabIndex = 46;
            buttonDelDep.Text = "Delete Department";
            buttonDelDep.TextColor = Color.White;
            buttonDelDep.UseVisualStyleBackColor = false;
            // 
            // buttonAddDep
            // 
            buttonAddDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddDep.BorderRadius = 8;
            buttonAddDep.BorderSize = 0;
            buttonAddDep.Enabled = false;
            buttonAddDep.FlatStyle = FlatStyle.Flat;
            buttonAddDep.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddDep.ForeColor = Color.White;
            buttonAddDep.Location = new Point(316, 291);
            buttonAddDep.Name = "buttonAddDep";
            buttonAddDep.Size = new Size(209, 45);
            buttonAddDep.TabIndex = 45;
            buttonAddDep.Text = "Add Department";
            buttonAddDep.TextColor = Color.White;
            buttonAddDep.UseVisualStyleBackColor = false;
            // 
            // textDepartment
            // 
            textDepartment.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textDepartment.Location = new Point(285, 253);
            textDepartment.Name = "textDepartment";
            textDepartment.PlaceholderText = "Department name";
            textDepartment.Size = new Size(270, 32);
            textDepartment.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonRemFromDep);
            panel1.Controls.Add(selectUserRemove);
            panel1.Controls.Add(selectDepartmentRemove);
            panel1.Location = new Point(748, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 214);
            panel1.TabIndex = 43;
            // 
            // buttonRemFromDep
            // 
            buttonRemFromDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonRemFromDep.BorderRadius = 8;
            buttonRemFromDep.BorderSize = 0;
            buttonRemFromDep.Enabled = false;
            buttonRemFromDep.FlatStyle = FlatStyle.Flat;
            buttonRemFromDep.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemFromDep.ForeColor = Color.White;
            buttonRemFromDep.Location = new Point(19, 143);
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
            selectUserRemove.Placeholder = "Select user";
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
            panelAddToSector.Controls.Add(selectDepartment);
            panelAddToSector.Controls.Add(selectUser);
            panelAddToSector.Location = new Point(268, 348);
            panelAddToSector.Name = "panelAddToSector";
            panelAddToSector.Size = new Size(306, 220);
            panelAddToSector.TabIndex = 42;
            // 
            // buttonAddToDep
            // 
            buttonAddToDep.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddToDep.BorderRadius = 8;
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
            // selectDepartment
            // 
            selectDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDepartment.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectDepartment.FormattingEnabled = true;
            selectDepartment.Location = new Point(17, 97);
            selectDepartment.Name = "selectDepartment";
            selectDepartment.Placeholder = "Select Department";
            selectDepartment.Size = new Size(270, 38);
            selectDepartment.TabIndex = 43;
            // 
            // selectUser
            // 
            selectUser.DropDownStyle = ComboBoxStyle.DropDownList;
            selectUser.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectUser.FormattingEnabled = true;
            selectUser.Location = new Point(17, 40);
            selectUser.Name = "selectUser";
            selectUser.Placeholder = "Select user";
            selectUser.Size = new Size(270, 38);
            selectUser.TabIndex = 42;
            // 
            // DepartmentSetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 600);
            Controls.Add(selectDelDepartment);
            Controls.Add(buttonDelDep);
            Controls.Add(buttonAddDep);
            Controls.Add(textDepartment);
            Controls.Add(panel1);
            Controls.Add(panelAddToSector);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DepartmentSetup";
            Text = "SectorSetup";
            panel1.ResumeLayout(false);
            panelAddToSector.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private ComboBoxPlus selectDelDepartment;
        private CustomControls.RJControls.RJButton buttonDelDep;
        private CustomControls.RJControls.RJButton buttonAddDep;
        private TextBox textDepartment;
        private Panel panel1;
        private CustomControls.RJControls.RJButton buttonRemFromDep;
        private ComboBoxPlus selectUserRemove;
        private ComboBoxPlus selectDepartmentRemove;
        private Panel panelAddToSector;
        private CustomControls.RJControls.RJButton buttonAddToDep;
        private ComboBoxPlus selectDepartment;
        private ComboBoxPlus selectUser;
    }
}