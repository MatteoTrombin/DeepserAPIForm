namespace Deepser_Desktop
{
    partial class Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collection));
            labelCollection = new Label();
            labelFil = new Label();
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            listOr = new ListBox();
            textValueFil = new TextBox();
            textAttribute = new TextBox();
            label2 = new Label();
            labelPar = new Label();
            textValuePar = new TextBox();
            label3 = new Label();
            selectEntity = new ComboBoxPlus();
            selectFilter = new ComboBoxPlus();
            SelectParameter = new ComboBoxPlus();
            buttonCollection = new CustomControls.RJControls.RJButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonRemoveAllFil = new CustomControls.RJControls.RJButton();
            buttonFil = new CustomControls.RJControls.RJButton();
            buttonPar = new CustomControls.RJControls.RJButton();
            buttonRemoveAllPar = new CustomControls.RJControls.RJButton();
            buttonAddFilter = new CustomControls.RJControls.RJButton();
            buttonAddPar = new CustomControls.RJControls.RJButton();
            buttonAdd = new CustomControls.RJControls.RJButton();
            buttonRemove = new CustomControls.RJControls.RJButton();
            buttonBack = new CustomControls.RJControls.RJButton();
            buttonUpdate = new CustomControls.RJControls.RJButton();
            buttonDelete = new CustomControls.RJControls.RJButton();
            buttonDeleteAll = new CustomControls.RJControls.RJButton();
            dataGridResult = new DataGridView();
            columnEntity_id = new DataGridViewTextBoxColumn();
            ColumnJson = new DataGridViewTextBoxColumn();
            buttonHistory = new CustomControls.RJControls.RJButton();
            buttonFavorites = new CustomControls.RJControls.RJButton();
            buttonAddFav = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).BeginInit();
            SuspendLayout();
            // 
            // labelCollection
            // 
            labelCollection.AutoSize = true;
            labelCollection.BackColor = Color.Transparent;
            labelCollection.Font = new Font("Aristotelica Display Trial", 49.7999954F, FontStyle.Bold, GraphicsUnit.Point);
            labelCollection.ForeColor = Color.FromArgb(11, 36, 71);
            labelCollection.Location = new Point(437, 34);
            labelCollection.Name = "labelCollection";
            labelCollection.Size = new Size(413, 93);
            labelCollection.TabIndex = 51;
            labelCollection.Text = "Collection";
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
            labelFil.TabIndex = 78;
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
            textBoxFrom.TabIndex = 77;
            textBoxFrom.Visible = false;
            // 
            // textBoxTo
            // 
            textBoxTo.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTo.Location = new Point(219, 243);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.PlaceholderText = "To value";
            textBoxTo.Size = new Size(98, 26);
            textBoxTo.TabIndex = 76;
            textBoxTo.Visible = false;
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
            listOr.TabIndex = 73;
            listOr.Visible = false;
            // 
            // textValueFil
            // 
            textValueFil.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textValueFil.Location = new Point(91, 243);
            textValueFil.Name = "textValueFil";
            textValueFil.PlaceholderText = "Attribute value";
            textValueFil.Size = new Size(236, 26);
            textValueFil.TabIndex = 71;
            textValueFil.Visible = false;
            // 
            // textAttribute
            // 
            textAttribute.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textAttribute.Location = new Point(91, 176);
            textAttribute.Name = "textAttribute";
            textAttribute.PlaceholderText = "Set filter attribute";
            textAttribute.Size = new Size(236, 26);
            textAttribute.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 153);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 68;
            label2.Text = "Filter";
            // 
            // labelPar
            // 
            labelPar.AutoSize = true;
            labelPar.BackColor = Color.Transparent;
            labelPar.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPar.Location = new Point(923, 465);
            labelPar.MaximumSize = new Size(341, 164);
            labelPar.Name = "labelPar";
            labelPar.Size = new Size(151, 21);
            labelPar.TabIndex = 90;
            labelPar.Text = "Parameter added: \r\n";
            labelPar.Visible = false;
            // 
            // textValuePar
            // 
            textValuePar.Font = new Font("Bahnschrift SemiLight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textValuePar.Location = new Point(979, 219);
            textValuePar.Name = "textValuePar";
            textValuePar.PlaceholderText = "Set parameter attribute";
            textValuePar.Size = new Size(236, 26);
            textValuePar.TabIndex = 87;
            textValuePar.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiLight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1059, 155);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 86;
            label3.Text = "Parameter";
            // 
            // selectEntity
            // 
            selectEntity.DropDownStyle = ComboBoxStyle.DropDownList;
            selectEntity.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectEntity.FormattingEnabled = true;
            selectEntity.Location = new Point(541, 180);
            selectEntity.Name = "selectEntity";
            selectEntity.Placeholder = "Select an entity";
            selectEntity.Size = new Size(200, 34);
            selectEntity.TabIndex = 98;
            // 
            // selectFilter
            // 
            selectFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            selectFilter.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            selectFilter.FormattingEnabled = true;
            selectFilter.Items.AddRange(new object[] { "Equal to", "Not equal to", "Equals any of", "From to", "Greater than", "Less than", "Like", "Not like" });
            selectFilter.Location = new Point(116, 205);
            selectFilter.Name = "selectFilter";
            selectFilter.Placeholder = "Select a filter";
            selectFilter.Size = new Size(200, 34);
            selectFilter.TabIndex = 99;
            // 
            // SelectParameter
            // 
            SelectParameter.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectParameter.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectParameter.FormattingEnabled = true;
            SelectParameter.Items.AddRange(new object[] { "Descending Order", "Ascending Order", "Limit", "Page " });
            SelectParameter.Location = new Point(998, 180);
            SelectParameter.Name = "SelectParameter";
            SelectParameter.Placeholder = "Select a parameter";
            SelectParameter.Size = new Size(200, 34);
            SelectParameter.TabIndex = 100;
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
            buttonCollection.Location = new Point(561, 240);
            buttonCollection.Name = "buttonCollection";
            buttonCollection.Padding = new Padding(25, 0, 25, 0);
            buttonCollection.Size = new Size(163, 56);
            buttonCollection.TabIndex = 101;
            buttonCollection.Text = "Search";
            buttonCollection.TextAlign = ContentAlignment.MiddleLeft;
            buttonCollection.TextColor = Color.White;
            buttonCollection.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-123, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.line2;
            pictureBox2.Location = new Point(856, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(547, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 103;
            pictureBox2.TabStop = false;
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
            buttonRemoveAllFil.TabIndex = 104;
            buttonRemoveAllFil.Text = "Remove all filter";
            buttonRemoveAllFil.TextAlign = ContentAlignment.MiddleLeft;
            buttonRemoveAllFil.TextColor = Color.Gainsboro;
            buttonRemoveAllFil.UseVisualStyleBackColor = false;
            buttonRemoveAllFil.Visible = false;
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
            buttonFil.TabIndex = 105;
            buttonFil.TextAlign = ContentAlignment.MiddleLeft;
            buttonFil.TextColor = Color.Gainsboro;
            buttonFil.UseVisualStyleBackColor = false;
            buttonFil.Visible = false;
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
            buttonPar.Location = new Point(953, 715);
            buttonPar.Name = "buttonPar";
            buttonPar.Padding = new Padding(20, 0, 23, 0);
            buttonPar.Size = new Size(62, 42);
            buttonPar.TabIndex = 106;
            buttonPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonPar.TextColor = Color.Gainsboro;
            buttonPar.UseVisualStyleBackColor = false;
            buttonPar.Visible = false;
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
            buttonRemoveAllPar.Location = new Point(1021, 715);
            buttonRemoveAllPar.Name = "buttonRemoveAllPar";
            buttonRemoveAllPar.Padding = new Padding(10, 0, 10, 0);
            buttonRemoveAllPar.Size = new Size(211, 42);
            buttonRemoveAllPar.TabIndex = 107;
            buttonRemoveAllPar.Text = "Remove all parameter";
            buttonRemoveAllPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonRemoveAllPar.TextColor = Color.Gainsboro;
            buttonRemoveAllPar.UseVisualStyleBackColor = false;
            buttonRemoveAllPar.Visible = false;
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
            buttonAddFilter.TabIndex = 108;
            buttonAddFilter.Text = "Add filter";
            buttonAddFilter.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddFilter.TextColor = Color.White;
            buttonAddFilter.UseVisualStyleBackColor = false;
            buttonAddFilter.Visible = false;
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
            buttonAddPar.Location = new Point(998, 251);
            buttonAddPar.Name = "buttonAddPar";
            buttonAddPar.Padding = new Padding(10, 0, 10, 0);
            buttonAddPar.Size = new Size(190, 45);
            buttonAddPar.TabIndex = 109;
            buttonAddPar.Text = "Add parameter";
            buttonAddPar.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddPar.TextColor = Color.White;
            buttonAddPar.UseVisualStyleBackColor = false;
            buttonAddPar.Visible = false;
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
            buttonAdd.TabIndex = 110;
            buttonAdd.TextColor = Color.White;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Visible = false;
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
            buttonRemove.TabIndex = 111;
            buttonRemove.TextColor = Color.White;
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Visible = false;
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
            buttonBack.Location = new Point(923, 341);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(145, 36);
            buttonBack.TabIndex = 112;
            buttonBack.Text = "Back";
            buttonBack.TextColor = Color.Gainsboro;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Visible = false;
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
            buttonUpdate.Location = new Point(923, 383);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(145, 36);
            buttonUpdate.TabIndex = 113;
            buttonUpdate.Text = "Update";
            buttonUpdate.TextColor = Color.Gainsboro;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Visible = false;
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
            buttonDelete.Location = new Point(923, 425);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(145, 36);
            buttonDelete.TabIndex = 114;
            buttonDelete.Text = "Delete";
            buttonDelete.TextColor = Color.Gainsboro;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
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
            buttonDeleteAll.ImageAlign = ContentAlignment.MiddleRight;
            buttonDeleteAll.Location = new Point(923, 341);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Padding = new Padding(10, 0, 15, 0);
            buttonDeleteAll.Size = new Size(145, 36);
            buttonDeleteAll.TabIndex = 115;
            buttonDeleteAll.Text = "Delete all";
            buttonDeleteAll.TextAlign = ContentAlignment.MiddleLeft;
            buttonDeleteAll.TextColor = Color.Gainsboro;
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Visible = false;
            // 
            // dataGridResult
            // 
            dataGridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResult.Columns.AddRange(new DataGridViewColumn[] { columnEntity_id, ColumnJson });
            dataGridResult.Location = new Point(381, 341);
            dataGridResult.Name = "dataGridResult";
            dataGridResult.RowHeadersWidth = 51;
            dataGridResult.RowTemplate.Height = 29;
            dataGridResult.Size = new Size(536, 319);
            dataGridResult.TabIndex = 116;
            // 
            // columnEntity_id
            // 
            columnEntity_id.HeaderText = "Entity_id";
            columnEntity_id.MinimumWidth = 6;
            columnEntity_id.Name = "columnEntity_id";
            columnEntity_id.Width = 125;
            // 
            // ColumnJson
            // 
            ColumnJson.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnJson.HeaderText = "Json";
            ColumnJson.MinimumWidth = 6;
            ColumnJson.Name = "ColumnJson";
            ColumnJson.Width = 24;
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
            buttonHistory.Location = new Point(659, 707);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Padding = new Padding(22, 0, 28, 0);
            buttonHistory.Size = new Size(163, 56);
            buttonHistory.TabIndex = 117;
            buttonHistory.Text = "History";
            buttonHistory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistory.TextColor = Color.Gainsboro;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += ButtonHistory_Click;
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
            buttonFavorites.Location = new Point(490, 707);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Padding = new Padding(12, 0, 20, 0);
            buttonFavorites.Size = new Size(163, 56);
            buttonFavorites.TabIndex = 118;
            buttonFavorites.Text = "Favorites";
            buttonFavorites.TextAlign = ContentAlignment.MiddleLeft;
            buttonFavorites.TextColor = Color.Gainsboro;
            buttonFavorites.UseVisualStyleBackColor = false;
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
            buttonAddFav.Location = new Point(619, 124);
            buttonAddFav.Name = "buttonAddFav";
            buttonAddFav.Size = new Size(42, 42);
            buttonAddFav.TabIndex = 119;
            buttonAddFav.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddFav.TextColor = Color.Gainsboro;
            buttonAddFav.UseVisualStyleBackColor = false;
            buttonAddFav.Visible = false;
            buttonAddFav.Click += buttonAddFav_Click;
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_05_16_151727;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 779);
            Controls.Add(buttonAddFav);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonFavorites);
            Controls.Add(buttonHistory);
            Controls.Add(dataGridResult);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAddPar);
            Controls.Add(buttonAddFilter);
            Controls.Add(buttonRemoveAllPar);
            Controls.Add(buttonPar);
            Controls.Add(buttonFil);
            Controls.Add(buttonRemoveAllFil);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonCollection);
            Controls.Add(SelectParameter);
            Controls.Add(selectFilter);
            Controls.Add(selectEntity);
            Controls.Add(labelPar);
            Controls.Add(textValuePar);
            Controls.Add(label3);
            Controls.Add(labelFil);
            Controls.Add(textBoxFrom);
            Controls.Add(textBoxTo);
            Controls.Add(listOr);
            Controls.Add(textValueFil);
            Controls.Add(textAttribute);
            Controls.Add(label2);
            Controls.Add(labelCollection);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Collection";
            Text = "Collection";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCollection;
        private Label labelFil;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private ListBox listOr;
        private TextBox textValueFil;
        private TextBox textAttribute;
        private Label label2;
        private Label labelPar;
        private TextBox textValuePar;
        private Label label3;
        internal ComboBoxPlus selectEntity;
        private ComboBoxPlus selectFilter;
        private ComboBoxPlus SelectParameter;
        private CustomControls.RJControls.RJButton buttonCollection;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton buttonRemoveAllFil;
        private CustomControls.RJControls.RJButton buttonFil;
        private CustomControls.RJControls.RJButton buttonPar;
        private CustomControls.RJControls.RJButton buttonRemoveAllPar;
        private CustomControls.RJControls.RJButton buttonAddFilter;
        private CustomControls.RJControls.RJButton buttonAddPar;
        private CustomControls.RJControls.RJButton buttonAdd;
        private CustomControls.RJControls.RJButton buttonRemove;
        private CustomControls.RJControls.RJButton buttonBack;
        private CustomControls.RJControls.RJButton buttonUpdate;
        private CustomControls.RJControls.RJButton buttonDelete;
        private CustomControls.RJControls.RJButton buttonDeleteAll;
        private DataGridView dataGridResult;
        private DataGridViewTextBoxColumn columnEntity_id;
        private DataGridViewTextBoxColumn ColumnJson;
        private CustomControls.RJControls.RJButton buttonHistory;
        private CustomControls.RJControls.RJButton buttonFavorites;
        internal CustomControls.RJControls.RJButton buttonAddFav;
    }
}