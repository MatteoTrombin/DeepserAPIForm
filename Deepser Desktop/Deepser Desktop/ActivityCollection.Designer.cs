namespace Deepser_Desktop
{
    partial class ActivityCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityCollection));
            buttonRemove = new CustomControls.RJControls.RJButton();
            buttonAdd = new CustomControls.RJControls.RJButton();
            buttonAddFilter = new CustomControls.RJControls.RJButton();
            buttonFil = new CustomControls.RJControls.RJButton();
            buttonRemoveAllFil = new CustomControls.RJControls.RJButton();
            SelectFilter = new ComboBoxPlus();
            labelFil = new Label();
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            listOr = new ListBox();
            textValueFil = new TextBox();
            textAttribute = new TextBox();
            label2 = new Label();
            buttonAddPar = new CustomControls.RJControls.RJButton();
            buttonRemoveAllPar = new CustomControls.RJControls.RJButton();
            buttonPar = new CustomControls.RJControls.RJButton();
            SelectParameter = new ComboBoxPlus();
            labelPar = new Label();
            textValuePar = new TextBox();
            label3 = new Label();
            buttonDelete = new CustomControls.RJControls.RJButton();
            buttonUpdate = new CustomControls.RJControls.RJButton();
            buttonBack = new CustomControls.RJControls.RJButton();
            buttonDeleteAll = new CustomControls.RJControls.RJButton();
            dataGridResult = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            buttonCollection = new CustomControls.RJControls.RJButton();
            selectEntity = new ComboBoxPlus();
            textIdField = new TextBox();
            labelCollection = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFavorites = new CustomControls.RJControls.RJButton();
            buttonHistory = new CustomControls.RJControls.RJButton();
            buttonAddFav = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(11, 36, 71);
            buttonRemove.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonRemove.BorderColor = Color.FromArgb(11, 36, 71);
            buttonRemove.BorderRadius = 8;
            buttonRemove.BorderSize = 0;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Image = (Image)resources.GetObject("buttonRemove.Image");
            buttonRemove.Location = new Point(110, 319);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(41, 35);
            buttonRemove.TabIndex = 124;
            buttonRemove.TextColor = Color.White;
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Visible = false;
            buttonRemove.Click += ButtonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(11, 36, 71);
            buttonAdd.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAdd.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAdd.BorderRadius = 8;
            buttonAdd.BorderSize = 0;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(110, 280);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(41, 35);
            buttonAdd.TabIndex = 123;
            buttonAdd.TextColor = Color.White;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Visible = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonAddFilter
            // 
            buttonAddFilter.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddFilter.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddFilter.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddFilter.BorderRadius = 8;
            buttonAddFilter.BorderSize = 0;
            buttonAddFilter.FlatAppearance.BorderSize = 0;
            buttonAddFilter.FlatStyle = FlatStyle.Flat;
            buttonAddFilter.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddFilter.ForeColor = Color.White;
            buttonAddFilter.Image = (Image)resources.GetObject("buttonAddFilter.Image");
            buttonAddFilter.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddFilter.Location = new Point(123, 362);
            buttonAddFilter.Name = "buttonAddFilter";
            buttonAddFilter.Padding = new Padding(25, 0, 25, 0);
            buttonAddFilter.Size = new Size(174, 45);
            buttonAddFilter.TabIndex = 122;
            buttonAddFilter.Text = "Add filter";
            buttonAddFilter.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddFilter.TextColor = Color.White;
            buttonAddFilter.UseVisualStyleBackColor = false;
            buttonAddFilter.Visible = false;
            buttonAddFilter.Click += ButtonAddFilter_Click;
            // 
            // buttonFil
            // 
            buttonFil.BackColor = Color.FromArgb(11, 36, 71);
            buttonFil.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonFil.BorderColor = Color.FromArgb(11, 36, 71);
            buttonFil.BorderRadius = 12;
            buttonFil.BorderSize = 0;
            buttonFil.FlatAppearance.BorderSize = 0;
            buttonFil.FlatStyle = FlatStyle.Flat;
            buttonFil.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFil.ForeColor = Color.Gainsboro;
            buttonFil.Image = (Image)resources.GetObject("buttonFil.Image");
            buttonFil.Location = new Point(83, 715);
            buttonFil.Name = "buttonFil";
            buttonFil.Padding = new Padding(20, 0, 23, 0);
            buttonFil.Size = new Size(62, 42);
            buttonFil.TabIndex = 121;
            buttonFil.TextAlign = ContentAlignment.MiddleLeft;
            buttonFil.TextColor = Color.Gainsboro;
            buttonFil.UseVisualStyleBackColor = false;
            buttonFil.Visible = false;
            buttonFil.Click += ButtonFil_Click;
            // 
            // buttonRemoveAllFil
            // 
            buttonRemoveAllFil.BackColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllFil.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllFil.BorderColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllFil.BorderRadius = 12;
            buttonRemoveAllFil.BorderSize = 0;
            buttonRemoveAllFil.FlatAppearance.BorderSize = 0;
            buttonRemoveAllFil.FlatStyle = FlatStyle.Flat;
            buttonRemoveAllFil.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveAllFil.ForeColor = Color.Gainsboro;
            buttonRemoveAllFil.ImageAlign = ContentAlignment.MiddleRight;
            buttonRemoveAllFil.Location = new Point(151, 715);
            buttonRemoveAllFil.Name = "buttonRemoveAllFil";
            buttonRemoveAllFil.Padding = new Padding(10, 0, 10, 0);
            buttonRemoveAllFil.Size = new Size(165, 42);
            buttonRemoveAllFil.TabIndex = 120;
            buttonRemoveAllFil.Text = "Remove all filter";
            buttonRemoveAllFil.TextAlign = ContentAlignment.MiddleLeft;
            buttonRemoveAllFil.TextColor = Color.Gainsboro;
            buttonRemoveAllFil.UseVisualStyleBackColor = false;
            buttonRemoveAllFil.Visible = false;
            buttonRemoveAllFil.Click += ButtonRemoveAllFil_Click;
            // 
            // SelectFilter
            // 
            SelectFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectFilter.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectFilter.FormattingEnabled = true;
            SelectFilter.Items.AddRange(new object[] { "Equal to", "Not equal to", "Equals any of", "From to", "Greater than", "Less than", "Like", "Not like" });
            SelectFilter.Location = new Point(116, 205);
            SelectFilter.Name = "SelectFilter";
            SelectFilter.Placeholder = "Select a filter";
            SelectFilter.Size = new Size(200, 34);
            SelectFilter.TabIndex = 119;
            SelectFilter.SelectedIndexChanged += SelectFilter_SelectedIndexChanged;
            // 
            // labelFil
            // 
            labelFil.AutoSize = true;
            labelFil.BackColor = Color.Transparent;
            labelFil.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFil.Location = new Point(19, 452);
            labelFil.MaximumSize = new Size(341, 164);
            labelFil.Name = "labelFil";
            labelFil.Size = new Size(110, 21);
            labelFil.TabIndex = 118;
            labelFil.Text = "Filter added: \r\n";
            labelFil.Visible = false;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFrom.Location = new Point(101, 243);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.PlaceholderText = "From value";
            textBoxFrom.Size = new Size(98, 26);
            textBoxFrom.TabIndex = 117;
            textBoxFrom.Visible = false;
            textBoxFrom.TextChanged += TextBoxFrom_TextChanged;
            // 
            // textBoxTo
            // 
            textBoxTo.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTo.Location = new Point(219, 243);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.PlaceholderText = "To value";
            textBoxTo.Size = new Size(98, 26);
            textBoxTo.TabIndex = 116;
            textBoxTo.Visible = false;
            textBoxTo.TextChanged += TextBoxTo_TextChanged;
            // 
            // listOr
            // 
            listOr.BackColor = Color.WhiteSmoke;
            listOr.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listOr.FormattingEnabled = true;
            listOr.ItemHeight = 18;
            listOr.Location = new Point(157, 278);
            listOr.Name = "listOr";
            listOr.Size = new Size(140, 76);
            listOr.TabIndex = 115;
            listOr.Visible = false;
            // 
            // textValueFil
            // 
            textValueFil.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textValueFil.Location = new Point(91, 243);
            textValueFil.Name = "textValueFil";
            textValueFil.PlaceholderText = "Attribute value";
            textValueFil.Size = new Size(236, 26);
            textValueFil.TabIndex = 114;
            textValueFil.Visible = false;


            // 
            // textAttribute
            // 
            textAttribute.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textAttribute.Location = new Point(91, 176);
            textAttribute.Name = "textAttribute";
            textAttribute.PlaceholderText = "Set filter attribute";
            textAttribute.Size = new Size(236, 26);
            textAttribute.TabIndex = 113;
            textAttribute.TextChanged += TextAttribute_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 153);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 112;
            label2.Text = "Filter";
            // 
            // buttonAddPar
            // 
            buttonAddPar.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddPar.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddPar.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddPar.BorderRadius = 8;
            buttonAddPar.BorderSize = 0;
            buttonAddPar.FlatAppearance.BorderSize = 0;
            buttonAddPar.FlatStyle = FlatStyle.Flat;
            buttonAddPar.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPar.ForeColor = Color.White;
            buttonAddPar.Image = (Image)resources.GetObject("buttonAddPar.Image");
            buttonAddPar.ImageAlign = ContentAlignment.MiddleRight;
            buttonAddPar.Location = new Point(999, 251);
            buttonAddPar.Name = "buttonAddPar";
            buttonAddPar.Padding = new Padding(10, 0, 10, 0);
            buttonAddPar.Size = new Size(190, 45);
            buttonAddPar.TabIndex = 131;
            buttonAddPar.Text = "Add parameter";
            buttonAddPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddPar.TextColor = Color.White;
            buttonAddPar.UseVisualStyleBackColor = false;
            buttonAddPar.Visible = false;
            buttonAddPar.Click += ButtonAddPar_Click;
            // 
            // buttonRemoveAllPar
            // 
            buttonRemoveAllPar.BackColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllPar.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllPar.BorderColor = Color.FromArgb(11, 36, 71);
            buttonRemoveAllPar.BorderRadius = 12;
            buttonRemoveAllPar.BorderSize = 0;
            buttonRemoveAllPar.FlatAppearance.BorderSize = 0;
            buttonRemoveAllPar.FlatStyle = FlatStyle.Flat;
            buttonRemoveAllPar.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveAllPar.ForeColor = Color.Gainsboro;
            buttonRemoveAllPar.ImageAlign = ContentAlignment.MiddleRight;
            buttonRemoveAllPar.Location = new Point(1022, 715);
            buttonRemoveAllPar.Name = "buttonRemoveAllPar";
            buttonRemoveAllPar.Padding = new Padding(10, 0, 10, 0);
            buttonRemoveAllPar.Size = new Size(211, 42);
            buttonRemoveAllPar.TabIndex = 130;
            buttonRemoveAllPar.Text = "Remove all parameter";
            buttonRemoveAllPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonRemoveAllPar.TextColor = Color.Gainsboro;
            buttonRemoveAllPar.UseVisualStyleBackColor = false;
            buttonRemoveAllPar.Visible = false;
            buttonRemoveAllPar.Click += ButtonRemoveAllPar_Click;
            // 
            // buttonPar
            // 
            buttonPar.BackColor = Color.FromArgb(11, 36, 71);
            buttonPar.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonPar.BorderColor = Color.FromArgb(11, 36, 71);
            buttonPar.BorderRadius = 12;
            buttonPar.BorderSize = 0;
            buttonPar.FlatAppearance.BorderSize = 0;
            buttonPar.FlatStyle = FlatStyle.Flat;
            buttonPar.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPar.ForeColor = Color.Gainsboro;
            buttonPar.Image = (Image)resources.GetObject("buttonPar.Image");
            buttonPar.Location = new Point(954, 715);
            buttonPar.Name = "buttonPar";
            buttonPar.Padding = new Padding(20, 0, 23, 0);
            buttonPar.Size = new Size(62, 42);
            buttonPar.TabIndex = 129;
            buttonPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonPar.TextColor = Color.Gainsboro;
            buttonPar.UseVisualStyleBackColor = false;
            buttonPar.Visible = false;
            buttonPar.Click += ButtonPar_Click;
            // 
            // SelectParameter
            // 
            SelectParameter.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectParameter.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectParameter.FormattingEnabled = true;
            SelectParameter.Items.AddRange(new object[] { "Descending Order", "Ascending Order", "Limit", "Page " });
            SelectParameter.Location = new Point(999, 180);
            SelectParameter.Name = "SelectParameter";
            SelectParameter.Placeholder = "Select a parameter";
            SelectParameter.Size = new Size(200, 34);
            SelectParameter.TabIndex = 128;
            SelectParameter.SelectedIndexChanged += SelectParameter_SelectedIndexChanged;
            // 
            // labelPar
            // 
            labelPar.AutoSize = true;
            labelPar.BackColor = Color.Transparent;
            labelPar.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPar.Location = new Point(924, 465);
            labelPar.MaximumSize = new Size(341, 164);
            labelPar.Name = "labelPar";
            labelPar.Size = new Size(151, 21);
            labelPar.TabIndex = 127;
            labelPar.Text = "Parameter added: \r\n";
            labelPar.Visible = false;
            // 
            // textValuePar
            // 
            textValuePar.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textValuePar.Location = new Point(980, 219);
            textValuePar.Name = "textValuePar";
            textValuePar.PlaceholderText = "Set parameter attribute";
            textValuePar.Size = new Size(236, 26);
            textValuePar.TabIndex = 126;
            textValuePar.Visible = false;
            textValuePar.TextChanged += TextValuePar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1060, 155);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 125;
            label3.Text = "Parameter";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDelete.BorderRadius = 6;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Gainsboro;
            buttonDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonDelete.Location = new Point(924, 425);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 36);
            buttonDelete.TabIndex = 134;
            buttonDelete.Text = "Delete";
            buttonDelete.TextColor = Color.Gainsboro;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BorderColor = Color.FromArgb(11, 36, 71);
            buttonUpdate.BorderRadius = 6;
            buttonUpdate.BorderSize = 0;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Gainsboro;
            buttonUpdate.ImageAlign = ContentAlignment.MiddleRight;
            buttonUpdate.Location = new Point(924, 383);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 36);
            buttonUpdate.TabIndex = 133;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextColor = Color.Gainsboro;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Visible = false;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(11, 36, 71);
            buttonBack.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderColor = Color.FromArgb(11, 36, 71);
            buttonBack.BorderRadius = 6;
            buttonBack.BorderSize = 0;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.Gainsboro;
            buttonBack.ImageAlign = ContentAlignment.MiddleRight;
            buttonBack.Location = new Point(924, 341);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(145, 36);
            buttonBack.TabIndex = 132;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.Gainsboro;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
            buttonBack.Click += ButtonBack_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BorderColor = Color.FromArgb(11, 36, 71);
            buttonDeleteAll.BorderRadius = 6;
            buttonDeleteAll.BorderSize = 0;
            buttonDeleteAll.FlatAppearance.BorderSize = 0;
            buttonDeleteAll.FlatStyle = FlatStyle.Flat;
            buttonDeleteAll.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteAll.ForeColor = Color.Gainsboro;
            buttonDeleteAll.Image = (Image)resources.GetObject("buttonDeleteAll.Image");
            buttonDeleteAll.ImageAlign = ContentAlignment.BottomCenter;
            buttonDeleteAll.Location = new Point(924, 341);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Padding = new Padding(0, 28, 0, 25);
            buttonDeleteAll.Size = new Size(145, 121);
            buttonDeleteAll.TabIndex = 135;
            buttonDeleteAll.Text = "Delete all";
            buttonDeleteAll.TextAlign = ContentAlignment.TopCenter;
            buttonDeleteAll.TextColor = Color.Gainsboro;
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Visible = false;
            buttonDeleteAll.Click += ButtonDeleteAll_Click;
            // 
            // dataGridResult
            // 
            dataGridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResult.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridResult.Location = new Point(381, 341);
            dataGridResult.Name = "dataGridResult";
            dataGridResult.RowHeadersWidth = 51;
            dataGridResult.RowTemplate.Height = 29;
            dataGridResult.Size = new Size(536, 319);
            dataGridResult.TabIndex = 136;
            dataGridResult.CellClick += DataGridResult_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Entity_id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewTextBoxColumn2.HeaderText = "Json";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 24;
            // 
            // buttonCollection
            // 
            buttonCollection.BackColor = Color.FromArgb(11, 36, 71);
            buttonCollection.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonCollection.BorderColor = Color.FromArgb(11, 36, 71);
            buttonCollection.BorderRadius = 10;
            buttonCollection.BorderSize = 0;
            buttonCollection.FlatAppearance.BorderSize = 0;
            buttonCollection.FlatStyle = FlatStyle.Flat;
            buttonCollection.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCollection.ForeColor = Color.White;
            buttonCollection.Image = Properties.Resources.search1;
            buttonCollection.ImageAlign = ContentAlignment.MiddleRight;
            buttonCollection.Location = new Point(558, 265);
            buttonCollection.Name = "buttonCollection";
            buttonCollection.Padding = new Padding(25, 0, 25, 0);
            buttonCollection.Size = new Size(163, 56);
            buttonCollection.TabIndex = 137;
            buttonCollection.Text = "Search";
            buttonCollection.TextAlign = ContentAlignment.MiddleLeft;
            buttonCollection.TextColor = Color.White;
            buttonCollection.UseVisualStyleBackColor = false;
            buttonCollection.Click += ButtonCollection_Click;
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(541, 179);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 138;
            // 
            // textIdField
            // 
            textIdField.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textIdField.Location = new Point(521, 225);
            textIdField.Name = "textIdField";
            textIdField.PlaceholderText = "Activity ID";
            textIdField.Size = new Size(236, 26);
            textIdField.TabIndex = 139;
            // 
            // labelCollection
            // 
            labelCollection.AutoSize = true;
            labelCollection.BackColor = Color.Transparent;
            labelCollection.Font = new Font("Aristotelica Display Trial", 49.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            labelCollection.ForeColor = Color.FromArgb(11, 36, 71);
            labelCollection.Location = new Point(432, 9);
            labelCollection.Name = "labelCollection";
            labelCollection.Size = new Size(413, 93);
            labelCollection.TabIndex = 140;
            labelCollection.Text = "Collection";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Aristotelica Display Trial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 36, 71);
            label1.Location = new Point(521, 74);
            label1.Name = "label1";
            label1.Size = new Size(232, 66);
            label1.TabIndex = 141;
            label1.Text = "Activity";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-122, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 142;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.line2;
            pictureBox2.Location = new Point(857, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(547, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 143;
            pictureBox2.TabStop = false;
            // 
            // buttonFavorites
            // 
            buttonFavorites.BackColor = Color.FromArgb(11, 36, 71);
            buttonFavorites.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonFavorites.BorderColor = Color.FromArgb(11, 36, 71);
            buttonFavorites.BorderRadius = 10;
            buttonFavorites.BorderSize = 0;
            buttonFavorites.FlatAppearance.BorderSize = 0;
            buttonFavorites.FlatStyle = FlatStyle.Flat;
            buttonFavorites.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFavorites.ForeColor = Color.Gainsboro;
            buttonFavorites.Image = (Image)resources.GetObject("buttonFavorites.Image");
            buttonFavorites.ImageAlign = ContentAlignment.MiddleRight;
            buttonFavorites.Location = new Point(480, 701);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Padding = new Padding(12, 0, 20, 0);
            buttonFavorites.Size = new Size(163, 56);
            buttonFavorites.TabIndex = 145;
            buttonFavorites.Text = "Favorites";
            buttonFavorites.TextAlign = ContentAlignment.MiddleLeft;
            buttonFavorites.TextColor = Color.Gainsboro;
            buttonFavorites.UseVisualStyleBackColor = false;
            buttonFavorites.Click += buttonFavorites_Click;
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
            buttonHistory.Location = new Point(649, 701);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Padding = new Padding(22, 0, 28, 0);
            buttonHistory.Size = new Size(163, 56);
            buttonHistory.TabIndex = 144;
            buttonHistory.Text = "History";
            buttonHistory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistory.TextColor = Color.Gainsboro;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonAddFav
            // 
            buttonAddFav.BackColor = Color.FromArgb(11, 36, 71);
            buttonAddFav.BackgroundColor = Color.FromArgb(11, 36, 71);
            buttonAddFav.BorderColor = Color.FromArgb(11, 36, 71);
            buttonAddFav.BorderRadius = 6;
            buttonAddFav.BorderSize = 0;
            buttonAddFav.FlatAppearance.BorderSize = 0;
            buttonAddFav.FlatStyle = FlatStyle.Flat;
            buttonAddFav.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddFav.ForeColor = Color.Gainsboro;
            buttonAddFav.Image = Properties.Resources.isNotFav;
            buttonAddFav.Location = new Point(616, 128);
            buttonAddFav.Name = "buttonAddFav";
            buttonAddFav.Size = new Size(42, 42);
            buttonAddFav.TabIndex = 146;
            buttonAddFav.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddFav.TextColor = Color.Gainsboro;
            buttonAddFav.UseVisualStyleBackColor = false;
            buttonAddFav.Visible = false;
            buttonAddFav.Click += buttonAddFav_Click_1;
            // 
            // ActivityCollection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(buttonAddFav);
            Controls.Add(buttonFavorites);
            Controls.Add(buttonHistory);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(labelCollection);
            Controls.Add(textIdField);
            Controls.Add(selectEntity);
            Controls.Add(buttonCollection);
            Controls.Add(dataGridResult);
            Controls.Add(buttonAddPar);
            Controls.Add(buttonRemoveAllPar);
            Controls.Add(buttonPar);
            Controls.Add(SelectParameter);
            Controls.Add(labelPar);
            Controls.Add(textValuePar);
            Controls.Add(label3);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonBack);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAddFilter);
            Controls.Add(buttonFil);
            Controls.Add(buttonRemoveAllFil);
            Controls.Add(SelectFilter);
            Controls.Add(labelFil);
            Controls.Add(textBoxFrom);
            Controls.Add(textBoxTo);
            Controls.Add(listOr);
            Controls.Add(textValueFil);
            Controls.Add(textAttribute);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivityCollection";
            Text = "ActivityCollection";
            ((System.ComponentModel.ISupportInitialize)dataGridResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RJControls.RJButton buttonRemove;
        private CustomControls.RJControls.RJButton buttonAdd;
        private CustomControls.RJControls.RJButton buttonAddFilter;
        private CustomControls.RJControls.RJButton buttonFil;
        private CustomControls.RJControls.RJButton buttonRemoveAllFil;
        private ComboBoxPlus SelectFilter;
        private Label labelFil;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private ListBox listOr;
        private TextBox textValueFil;
        private TextBox textAttribute;
        private Label label2;
        private CustomControls.RJControls.RJButton buttonAddPar;
        private CustomControls.RJControls.RJButton buttonRemoveAllPar;
        private CustomControls.RJControls.RJButton buttonPar;
        private ComboBoxPlus SelectParameter;
        private Label labelPar;
        private TextBox textValuePar;
        private Label label3;
        private CustomControls.RJControls.RJButton buttonDelete;
        private CustomControls.RJControls.RJButton buttonUpdate;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonDeleteAll;
        private DataGridView dataGridResult;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CustomControls.RJControls.RJButton buttonCollection;
        internal ComboBoxPlus selectEntity;
        internal TextBox textIdField;
        private Label labelCollection;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton buttonFavorites;
        private CustomControls.RJControls.RJButton buttonHistory;
        internal CustomControls.RJControls.RJButton buttonAddFav;
    }
}