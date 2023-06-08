using Deepser.Framework.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class LoadActivity : Form
    {
        public LoadActivity()
        {
            InitializeComponent();
            buttonSearch.Click += ButtonSearch_Click;
            textId.PlaceholderText = "Entity Id";
            textActivity.PlaceholderText = "Activity id";
            textSingle.PlaceholderText = "Get single data";
            buttonBack.Click += ButtonBack_Click;
            buttonDelete.Click += ButtonDelete_Click;
            dataGridJson.CellClick += DataGridJson_CellClick;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.activityEntity));
        }


        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            buttonSearch.Visible = true;
            buttonDelete.Visible = false;
            buttonBack.Visible = false;
            textResult.Text = "";
            textResult.Visible = true;
            dataGridJson.Visible = false;
            dataGridJson.Rows.Clear();
        }

        private async void ButtonDelete_Click(object? sender, EventArgs e)
        {

            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Would you like to delete this item", "Delete", button);
            if (result == DialogResult.OK)
            {
                try
                {
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());
                    if (dataGridJson.Rows[0].Cells[0].Value != null)
                    {
                        MessageBox.Show(await entity.DeleteActivity(Int32.Parse(textId.Text), Int32.Parse(textActivity.Text)));
                    }
                    buttonBack.PerformClick();
                    textResult.Text = "";
                    textResult.Visible = true;
                    dataGridJson.Visible = false;
                    dataGridJson.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DataGridJson_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewCell cell = dataGridJson.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString();

                        Clipboard.SetText(cellValue);
                        MessageBox.Show($"Text copied in clipboard : {cellValue}");
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

        private async void ButtonSearch_Click(object? sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    if (string.IsNullOrEmpty(textSingle.Text))
                    {
                        textResult.Visible = false;
                        dataGridJson.Visible = true;
                        Factory fact = new Factory();
                        var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());
                        if (string.IsNullOrEmpty(textSingle.Text))
                        {
                            SqliteDataAccess.InsertLoadActivityHistory((string)selectEntity.SelectedItem, Int32.Parse(textId.Text), Int32.Parse(textActivity.Text));
                        }
                        else
                        {
                            SqliteDataAccess.InsertLoadActivityHistory((string)selectEntity.SelectedItem, Int32.Parse(textId.Text), Int32.Parse(textActivity.Text), textSingle.Text);
                        }
                        await entity.LoadActivity(textId.Text, textActivity.Text);
                        var alldata = entity.getAllData();
                        if (alldata.Count > 0)
                        {
                            int i = 0;
                            foreach (var item in alldata)
                            {
                                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                                string key = item.Key;
                                column.HeaderText = key;
                                dataGridJson.Columns.Add(column);
                                if (dataGridJson.Rows.Count == 0)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    dataGridJson.Rows.Add(row);
                                }
                                DataGridViewCell cell = new DataGridViewTextBoxCell();
                                cell.Value = item.Value;
                                dataGridJson.Rows[0].Cells[i] = cell;
                                i++;
                            }
                        }
                        else
                        {
                            throw new Exception("Load do not found nothing");
                        }
                        buttonSearch.Visible = false;
                        buttonDelete.Visible = true;
                        buttonBack.Visible = true;
                        textResult.Visible = false;
                    }
                    else
                    {
                        Factory fact = new Factory();
                        var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());

                        await entity.LoadActivity(textId.Text, textActivity.Text);
                        string text = (string)entity.getData(textSingle.Text);
                        if (!String.IsNullOrEmpty(text))
                        {
                            textResult.Text = text;
                        }
                        else
                        {
                            throw new Exception("The attribute searched in the single get does not exist");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidateInput()
        {
            bool isTextIdEmpty = string.IsNullOrEmpty(textId.Text);
            bool isTextActivityEmpty = string.IsNullOrEmpty(textActivity.Text);
            bool isComboBoxEmpty = selectEntity.SelectedIndex == -1;

            if (isTextIdEmpty && isComboBoxEmpty && isTextActivityEmpty || isComboBoxEmpty && isTextActivityEmpty || isTextIdEmpty && isTextActivityEmpty || isComboBoxEmpty && isTextIdEmpty)
            {
                throw new Exception("Required fields are empty");
            }
            else if (isTextIdEmpty)
            {
                throw new Exception("Id is empty");
            }
            else if (isComboBoxEmpty)
            {
                throw new Exception("Select an entity before update");
            }

            return true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var dash = Dashboard.GetIstance();
            dash.OpenHistory(this);
        }
    }
}
