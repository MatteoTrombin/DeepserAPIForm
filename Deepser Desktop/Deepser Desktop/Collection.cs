using Deepser;
using Deepser.Entity.Service;
using Deepser.Framework.Data;
using Deepser.Framework.Data.Entity;
using Deepser.Framework.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using static Deepser_Desktop.Collection;
using Deepser.Entity.Contract;
using Deepser.Entity.Crm;
using Deepser.Entity.Kb;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;
using Deepser.Entity.Asset;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Deepser_Desktop
{
    public partial class Collection : Form
    {
        public Parameter parameter;
        public Filter filter;
        public System.Type MainModel = null;
        public Deepser.Framework.Data.Collection collection = new Deepser.Framework.Data.Collection();
        public static Dictionary<string, string> dictoperation = new Dictionary<string, string>
            {
                { "EqualTo", "eq" },
                { "NotEqualTo", "neq" },
                { "EqualsAnyOf", "in" },
                { "NotEqualsAnyOf", "nin"},
                { "GreaterThan", "gt"},
                { "LessThan", "lt" },
                { "Like", "like" },
                { "NotLike", "nlike" }
            };
        public Dictionary<string, object> dict = new Dictionary<string, object>();

        internal List<object> listvalue { get; set; } = new List<object>();
        internal Dashboard dash;
        public Collection()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeObjects();
        }

        private void InitializeEventHandlers()
        {
            buttonAdd.Click += ButtonAdd_Click;
            buttonAddFilter.Click += ButtonAddFilter_Click;
            buttonAddPar.Click += ButtonAddPar_Click;
            buttonBack.Click += ButtonBack_Click;
            buttonCollection.Click += ButtonCollection_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonDeleteAll.Click += ButtonDeleteAll_Click;
            buttonFil.Click += ButtonFil_Click;
            buttonPar.Click += ButtonPar_Click;
            buttonRemove.Click += ButtonRemove_Click;
            buttonRemoveAllFil.Click += ButtonRemoveAllFil_Click;
            buttonRemoveAllPar.Click += ButtonRemoveAllPar_Click;
            buttonFavorites.Click += ButtonFavorites_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
            dataGridResult.CellClick += DataGridResult_CellClick;
            selectFilter.SelectedIndexChanged += SelectFilter_SelectedIndexChanged;
            SelectParameter.SelectedIndexChanged += SelectParameter_SelectedIndexChanged;
            textAttribute.TextChanged += TextAttribute_TextChanged;
            textBoxFrom.TextChanged += TextBoxFrom_TextChanged;
            textBoxTo.TextChanged += TextBoxTo_TextChanged;
            textValuePar.TextChanged += TextValuePar_TextChanged;

        }


        private void ButtonAddPar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textValuePar.Text))
            {
                MessageBox.Show("Parameter text is empty");
                return;
            }

            labelPar.Visible = true;
            buttonPar.Visible = true;
            buttonRemoveAllPar.Visible = true;

            try
            {
                if (SelectParameter.SelectedIndex == 0 || SelectParameter.SelectedIndex == 1)
                {
                    if (SelectParameter.SelectedIndex == 1)
                    {
                        parameter.SetOrder(textValuePar.Text, Parameter.Ascending);

                    }
                    else
                    {
                        parameter.SetOrder(textValuePar.Text, Parameter.Descending);
                    }
                }
                else if (SelectParameter.SelectedIndex == 2)
                {
                    parameter.SetLimit((int)long.Parse(textValuePar.Text));
                }
                else if (SelectParameter.SelectedIndex == 3)
                {
                    parameter.SetPage((int)long.Parse(textValuePar.Text));
                }
                UpdateParameter();
                ResetParSetting();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeObjects()
        {
            Factory fact = new Factory();
            System.Type entity = fact.CreateFilter().GetType();
            MainModel = entity;
            this.parameter = collection.GetParameter();
            this.filter = collection.GetFilter();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.entityDictionary));
        }

        internal void UpdateParameter()
        {
            if (parameter.parameters.Count != 0)
            {
                labelPar.Text = "Parameter added: \r\n";
                labelPar.Visible = true;
                buttonRemoveAllPar.Visible = true;
                buttonPar.Visible = true;
                foreach (var par in parameter.parameters)
                {
                    if (par.Key == "limit")
                    {
                        labelPar.Text += $"Limit {par.Value} record\r\n";
                    }
                    else if (par.Key == "page")
                    {
                        labelPar.Text += $"Page {par.Value} \r\n";
                    }
                    else if ((string)par.Value == "desc")
                    {
                        labelPar.Text += $"{par.Key} in descending order \r\n";
                    }
                    else
                    {
                        labelPar.Text += $"{par.Key} in ascending order \r\n";
                    }
                }
            }
            else
            {
                labelPar.Text = "";
                labelPar.Visible = false;
                buttonRemoveAllPar.Visible = false;
                buttonPar.Visible = false;
            }
        }

        internal void UpdateFilter()
        {
            if (filter.filters.Count != 0)
            {
                labelFil.Text = "Filter added: \r\n";
                labelFil.Visible = true;
                buttonFil.Visible = true;
                buttonRemoveAllFil.Visible = true;
                labelFil.Text = FilterToString(filter.filters);
            }
            else
            {
                labelFil.Text = "";
                buttonFil.Visible = false;
                buttonRemoveAllFil.Visible = false;
            }
        }

        internal static string FullOperator(object _operator)
        {
            switch (_operator.ToString())
            {
                case "eq":
                    return "equal to";

                case "neq":
                    return "not equal to";

                case "in":
                    return "equals any of";

                case "nin":
                    return "not equals any of";

                case "gt":
                    return "greater than";

                case "lt":
                    return "less than";

                case "like":
                    return "like";

                case "nlike":
                    return "not like";

                default:
                    return "unknown operator";
            }
        }
        private async void ButtonDeleteAll_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            var rows = dataGridResult.Rows.Count - 1;
            DialogResult result = MessageBox.Show($"Are you sure to delete {rows} items? This is an irreversible operation, items will be deleted permanently", "Delete all", button);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());
                    foreach (DataGridViewRow row in dataGridResult.Rows)
                    {
                        if (row.Cells.Count > 0)
                        {
                            var value = row.Cells[0].Value;
                            if (value != null)
                            {
                                await entity.Delete(value);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    MessageBox.Show($"Deletion done, {rows} items eliminated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private async void ButtonBack_Click(object? sender, EventArgs e)
        {
            try
            {
                OldGridSetting();
                filter.filters.Clear();
                parameter.parameters.Clear();

                var list = SqliteDataAccess.GetLastInsertColl();

                if (!string.IsNullOrEmpty(list.Filters))
                {
                    var lastFilter = JsonConvert.DeserializeObject<Dictionary<string, object>>(list.Filters);
                    if (lastFilter != null && lastFilter.Count > 0)
                    {
                        filter.filters = lastFilter;
                    }
                }

                if (!string.IsNullOrEmpty(list.Parameters))
                {
                    var lastParameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(list.Parameters);
                    if (lastParameters != null && lastParameters.Count > 0)
                    {
                        parameter.parameters = lastParameters;
                    }
                }

                buttonCollection.PerformClick();
                ItemsSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            try
            {
                var id = dataGridResult.Rows[0].Cells[0].Value.ToString();
                Update update = new Update();
                update.selectEntity.SelectedItem = selectEntity.SelectedItem;
                update.textId.Text = id;

                var data = update.dataGrid;
                int i = 0;

                while (data.Rows.Count != 7 && i < dict.Count)
                {
                    var item = dict.ElementAt(i);
                    if (item.Key != null && item.Key != "entity_id")
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(data, item.Key, item.Value);
                        data.Rows.Add(row);
                    }
                    i++;
                }



                Dashboard dashboard = Dashboard.GetIstance();
                dashboard.ShowForm(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void ButtonDelete_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure to delete this item? This is an irreversible operation, item will be deleted permanently", "Delete", button);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.Text);
                    if (dataGridResult.Rows[0].Cells[0].Value != null)
                    {
                        MessageBox.Show(await entity.Delete(dataGridResult.Rows[0].Cells[0].Value.ToString()));
                    }
                    else
                    {
                        throw new Exception("Entity_id is null");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ItemsSetting()
        {
            buttonBack.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonDeleteAll.Visible = true;
        }

        public void SingleItemSetting()
        {
            buttonBack.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            buttonDeleteAll.Visible = false;
            buttonAddFav.Visible = false;
        }

        public void ResetParSetting()
        {
            SelectParameter.SelectedIndex = -1;
            textValuePar.Text = string.Empty;
            textValuePar.Visible = false;
        }

        public void ResetFilterSetting()
        {
            textBoxFrom.Visible = false;
            textBoxTo.Visible = false;
            textBoxFrom.Text = string.Empty;
            textBoxTo.Text = string.Empty;
            textValueFil.Text = string.Empty;
            buttonAddFilter.Visible = false;
            selectFilter.SelectedIndex = -1;
            textAttribute.Text = string.Empty;
        }

        public void OldGridSetting()
        {
            dataGridResult.Columns.Clear();
            dataGridResult.Rows.Clear();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Entity_id";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Json";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridResult.Columns.Add(column1);
            dataGridResult.Columns.Add(column2);

            dataGridResult.DataSource = null;
        }

        private static bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void ButtonFil_Click(object? sender, EventArgs e)
        {
            if (filter.filters.Count > 0)
            {
                filter.filters.Remove(filter.filters.Keys.Last());
                UpdateFilter();
            }
        }

        //================================================================================Filter===================================================================================================

        private void TextAttribute_TextChanged(object? sender, EventArgs e)
        {
            UpdateFilterButtonVisibility();
        }

        private void TextBoxTo_TextChanged(object? sender, EventArgs e)
        {
            UpdateFilterButtonVisibility();
        }

        private void TextBoxFrom_TextChanged(object? sender, EventArgs e)
        {
            UpdateFilterButtonVisibility();
        }

        private void UpdateFilterButtonVisibility()
        {
            buttonAddFilter.Visible = selectFilter.SelectedIndex == 3 && !string.IsNullOrEmpty(textBoxFrom.Text) && !string.IsNullOrEmpty(textBoxTo.Text) && !string.IsNullOrEmpty(textAttribute.Text);
        }

        private void SelectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOr.Items.Clear();
            textBoxFrom.Text = string.Empty;
            textBoxTo.Text = string.Empty;
            textAttribute.Visible = true;
            switch (selectFilter.SelectedIndex)
            {
                case -1:
                    textValueFil.Visible = false;
                    listOr.Visible = false;
                    buttonAdd.Visible = false;
                    textBoxFrom.Visible = false;
                    textBoxTo.Visible = false;
                    buttonAddFilter.Visible = false;
                    buttonRemove.Visible = false;
                    buttonAddFilter.Location = new Point(123, 362);
                    break;
                case 3:
                    textValueFil.Visible = false;
                    listOr.Visible = false;
                    buttonAdd.Visible = false;
                    textBoxFrom.Visible = true;
                    textBoxTo.Visible = true;
                    buttonAddFilter.Visible = false;
                    buttonRemove.Visible = false;
                    buttonAddFilter.Location = new Point(123, 275);
                    break;
                default:
                    textValueFil.Visible = true;
                    listOr.Visible = true;
                    buttonAdd.Visible = true;
                    textBoxFrom.Visible = false;
                    textBoxTo.Visible = false;
                    buttonAddFilter.Visible = true;
                    buttonRemove.Visible = true;
                    buttonAddFilter.Location = new Point(123, 362);
                    break;
            }
        }
        private void ButtonAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                if (listOr.Items.Contains(textValueFil.Text))
                {
                    throw new ArgumentException("You already added this value.");
                }
                if (string.IsNullOrWhiteSpace(textValueFil.Text))
                {
                    throw new ArgumentException("You can't add an empty value.");
                }

                listOr.Items.Add(textValueFil.Text);
                listvalue.Add(textValueFil.Text);
                if (listOr.Items.Count > 0)
                {
                    buttonAddFilter.Visible = true;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ButtonRemove_Click(object? sender, EventArgs e)
        {
            try
            {
                if (listOr.Items.Count == 0)
                {
                    throw new InvalidOperationException("The list is empty, you can't remove anything.");
                }
                listOr.Items.RemoveAt(listOr.Items.Count - 1);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ButtonRemoveAllFil_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Are you sure you want to remove all filters?", "Remove all filters", button);
            if (result == DialogResult.Yes)
            {
                filter.filters.Clear();
                UpdateFilter();
            }
        }

        private void ButtonAddFilter_Click(object? sender, EventArgs e)
        {
            buttonRemoveAllFil.Visible = true;
            buttonFil.Visible = true;
            string testo = "";
            if (selectFilter.SelectedIndex == 3)
            {
                labelFil.Visible = true;
                buttonRemoveAllFil.Visible = true;
                buttonFil.Visible = true;
            }
            else if (selectFilter.SelectedIndex != 3 && selectFilter.SelectedIndex != -1)
            {
                labelFil.Visible = true;
                buttonRemoveAllFil.Visible = true;
                buttonFil.Visible = true;
            }

            if (listOr.Items.Count > 1 && selectFilter.SelectedIndex != -1)
            {
                List<object> listvalue = new List<object>();
                foreach (var item in listOr.Items)
                {
                    listvalue.Add(item);
                }
                string _operator = selectFilter.SelectedItem.ToString();
                filter.addFilter(textAttribute.Text, _operator, listvalue);

                listOr.Items.Clear();
                listvalue.Clear();
            }
            else if (listOr.Items.Count == 1 && selectFilter.SelectedIndex != 3)
            {
                string condition = selectFilter.SelectedItem.ToString();
                string[] words = condition.Split(' ');
                string output = "";
                string _operator = "";

                foreach (string word in words)
                {
                    output += word.Substring(0, 1).ToUpper() + word.Substring(1);
                }
                if (dictoperation.ContainsKey(output))
                {
                    _operator = dictoperation[output];
                }

                filter.addFilter(textAttribute.Text, _operator, listOr.Items[0].ToString());
                listOr.Items.Clear();
            }
            else if (selectFilter.SelectedIndex == 3 && !string.IsNullOrEmpty(textBoxFrom.Text) && !string.IsNullOrEmpty(textBoxTo.Text))
            {
                filter.addRange(textAttribute.Text, textBoxFrom.Text, textBoxTo.Text);
            }
            ResetFilterSetting();
            UpdateFilter();
        }

        //================================================================================Parameter===================================================================================================
        private void TextValuePar_TextChanged(object? sender, EventArgs e)
        {
            buttonAddPar.Visible = !string.IsNullOrEmpty(textValuePar.Text);
        }

        private void ButtonPar_Click(object sender, EventArgs e)
        {
            if (parameter.parameters.Count > 0)
            {
                var lastKey = parameter.parameters.Keys.Last();
                parameter.parameters.Remove(lastKey);
            }
            UpdateParameter();
        }

        private void ButtonRemoveAllPar_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Are you sure you want to remove all parameters?", "Remove all parameters", button);
            if (result == DialogResult.Yes)
            {
                UpdateParameter();
                parameter.parameters.Clear();
                labelPar.Text = "Parameter added:\r\n";
                labelPar.Visible = false;
                buttonRemoveAllPar.Visible = false;
                buttonPar.Visible = false;

            }
        }


        private void SelectParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textValuePar.Visible = SelectParameter.SelectedIndex < 4;
            buttonAddPar.Visible = SelectParameter.SelectedIndex < 4;
            textValuePar.PlaceholderText = SelectParameter.SelectedIndex switch
            {
                0 => "Attribute to which the order should be set",
                1 => "Attribute to which the order should be set",
                2 => "Set number of items",
                3 => "Set the number of pages",
                _ => "",
            };

        }

        //================================================================================Collection===================================================================================================

        private async void ButtonCollection_Click(object sender, EventArgs e)
        {
            if (selectEntity.SelectedIndex != -1)
            {
                if (selectEntity.SelectedItem != null)
                {
                    if (dataGridResult.Columns.Count > 2)
                    {
                        OldGridSetting();
                        ItemsSetting();
                    }
                    dataGridResult.Rows.Clear();

                    try
                    {
                        string selectedClassName = selectEntity.SelectedItem.ToString();
                        Factory fact = new Factory();
                        System.Type entity = fact.CreateEntity(selectedClassName).GetType();

                        if (entity != null)
                        {
                            collection.SetMainModel(entity);
                            InsertCollectionHistory((string)selectEntity.SelectedItem, filter.filters, parameter.parameters);

                            await collection.Load();

                            FavSetting();

                            filter.filters.Clear();
                            parameter.parameters.Clear();

                            UpdateFilter();
                            UpdateParameter();

                            var dictCollection = collection.GetCollection();

                            if (dictCollection.Count > 0)
                            {
                                foreach (var item in dictCollection)
                                {
                                    DataGridViewRow row = (DataGridViewRow)dataGridResult.Rows[0].Clone();
                                    row.Cells[0].Value = item.Key.ToString();
                                    row.Cells[1].Value = item.Value.ToString();
                                    dataGridResult.Rows.Add(row);
                                }

                                if (dataGridResult.Rows.Count == 2)
                                {
                                    DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(1, 0);
                                    DataGridResult_CellClick(dataGridResult, args);
                                }
                                else
                                {
                                    buttonDeleteAll.Visible = true;
                                }
                            }
                            else
                            {
                                throw new Exception("Not found");
                            }
                        }
                        else
                        {
                            throw new Exception("Error entity is equal to null");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an entity!");
            }
        }

        internal void FavSetting()
        {
            buttonAddFav.Visible = true;
            if (SqliteDataAccess.CheckIsFav() == true)
            {
                buttonAddFav.Image = Properties.Resources.isFav;
                buttonAddFav.Enabled = true;
            }
            else
            {
                buttonAddFav.Image = Properties.Resources.isNotFav;
                buttonAddFav.Enabled = true;
            }
        }

        private void InsertCollectionHistory(string entity, Dictionary<string, object> filters, Dictionary<string, object> parameters)
        {
            string jsonParameters = parameters.Count > 0 ? JsonConvert.SerializeObject(parameters) : null;
            string jsonFilters = filters.Count > 0 ? JsonConvert.SerializeObject(filters) : null;

            SqliteDataAccess.InsertCollectionHistory(entity, jsonFilters, jsonParameters);
        }


        private void DataGridResult_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewCell cell = dataGridResult.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString();
                        if (IsValidJson(cellValue) && cellValue != "null")
                        {
                            dataGridResult.Rows.Clear();
                            dataGridResult.Columns.Clear();
                            dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(cellValue);
                            int i = 0;

                            foreach (var item in dict)
                            {
                                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                                string key = item.Key;
                                column.HeaderText = key;
                                dataGridResult.Columns.Add(column);
                                if (dataGridResult.Rows.Count == 0)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    dataGridResult.Rows.Add(row);
                                }
                                DataGridViewCell newCell = new DataGridViewTextBoxCell();
                                newCell.Value = item.Value;
                                dataGridResult.Rows[0].Cells[i] = newCell;
                                i++;
                            }
                        }
                        else
                        {
                            Clipboard.SetText(cellValue.ToString());
                            MessageBox.Show($"Text copied in clipboard : {cellValue.ToString()}");
                        }
                        SingleItemSetting();
                    }
                    else
                    {
                        throw new Exception("Cell value is null");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            var dash = Dashboard.GetIstance();
            dash.OpenHistory(this);
        }
        private void ButtonFavorites_Click(object? sender, EventArgs e)
        {
            var dash = Dashboard.GetIstance();
            dash.OpenFav(this);
        }

        internal static string FilterToString(Dictionary<string, object> filters)
        {
            string text = "";
            foreach (var filter in filters)
            {
                if (filter.Value is Filter.FilterFromTo filterFromTo)
                {
                    text += $"{filter.Key} From {filterFromTo.From} To {filterFromTo.To} \r\n";
                }
                else if (filter.Value is Filter.OtherFilter otherFilter)
                {
                    text += $"{filter.Key} {Collection.FullOperator(otherFilter.Operator)} {otherFilter.Value} \r\n";
                }
                else if (filter.Value is Filter.FilterOr orFilter)
                {
                    text += $"{filter.Key} {orFilter.Values[0].Operator.ToString().ToLower()} ";
                    foreach (var value in orFilter.Values)
                    {
                        text += $"{value.Value}, ";
                    }
                    text = text.TrimEnd(',', ' ') + "\r\n";
                }
            }
            return text;
        }


        internal static string ParameterToString(Dictionary<string, string> parameters)
        {
            string text = "";
            foreach (var par in parameters)
            {
                if (par.Key == "limit")
                {
                    text += $"Limit {par.Value} \r\n";
                }
                else if (par.Key == "page")
                {
                    text += $"Page {par.Value} \r\n";
                }
                else if (par.Value == "desc")
                {
                    text += $"{par.Key} in descending order \r\n";
                }
                else
                {
                    text += $"{par.Key} in ascending order \r\n";
                }
            }
            return text;
        }

        private void buttonAddFav_Click(object sender, EventArgs e)
        {
            byte[] bytes1 = ImageToByteArray(buttonAddFav.Image);
            byte[] bytes2 = ImageToByteArray(Properties.Resources.isNotFav);

            bool areEqual = ByteArrayEquals(bytes1, bytes2);

            if (areEqual)
            {
                var last = SqliteDataAccess.GetLastInsertColl();
                SqliteDataAccess.InsertCollectionFav(last.Entity, last.Filters, last.Parameters);
                buttonAddFav.Image = Properties.Resources.isFav;
            }
            else
            {
                var last = SqliteDataAccess.GetLastInsertColl();
                SqliteDataAccess.DeleteFromFavColl(last.Entity, last.Filters, last.Parameters);
                buttonAddFav.Image = Properties.Resources.isNotFav;
            }
        }

        internal byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        internal bool ByteArrayEquals(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

    }
}