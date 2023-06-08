using Deepser;
using Deepser.Framework.Data.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Deepser_Desktop
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            this.buttonSearch.Click += ButtonSearch_Click;
            dataGridJson.CellClick += DataGridJson_CellClick;
            buttonDelete.Click += ButtonDelete_Click;
            buttonBack.Click += ButtonBack_Click;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.entityDictionary));

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
                        MessageBox.Show(await entity.Delete(dataGridJson.Rows[0].Cells[0].Value.ToString()));
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
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());

                    if (string.IsNullOrEmpty(textSingle.Text))
                    {
                        dataGridJson.Visible = true;
                        textResult.Visible = false;
                        if (string.IsNullOrEmpty(textField.Text))
                        {
                            SqliteDataAccess.InsertLoadHistory((string)selectEntity.SelectedItem, textId.Text);
                            await entity.Load(textId.Text);
                        }
                        else
                        {
                            SqliteDataAccess.InsertLoadHistory((string)selectEntity.SelectedItem, textId.Text, textField.Text);
                            await entity.Load(textId.Text, textField.Text);
                        }

                        var alldata = entity.getAllData();

                        if (alldata.Count > 0)
                        {
                            foreach (var item in alldata)
                            {
                                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                                string key = item.Key;
                                column.HeaderText = key;
                                dataGridJson.Columns.Add(column);
                            }

                            var row = new DataGridViewRow();
                            row.CreateCells(dataGridJson);
                            int i = 0;

                            foreach (var item in alldata)
                            {
                                DataGridViewCell cell = new DataGridViewTextBoxCell();
                                cell.Value = item.Value;
                                row.Cells[i].Value = cell.Value;

                                i++;
                            }

                            dataGridJson.Rows.Add(row);
                        }
                        else
                        {
                            throw new Exception("Load did not find anything.");
                        }

                        buttonSearch.Visible = false;
                        buttonDelete.Visible = true;
                        buttonBack.Visible = true;
                        textId.Text = "";
                        textField.Text = "";
                        textSingle.Text = "";
                    }
                    else if (!string.IsNullOrEmpty(textField.Text))
                    {
                        dataGridJson.Visible = false;
                        textResult.Visible = true;
                        SqliteDataAccess.InsertLoadHistory((string)selectEntity.SelectedItem, textId.Text, textField.Text, textSingle.Text);
                        await entity.Load(textId.Text, textField.Text);
                        string text = (string)entity.getData(textSingle.Text);

                        if (!String.IsNullOrEmpty(text))
                        {
                            textResult.Text = text;
                            textResult.Visible = true;
                            dataGridJson.Visible = false;
                        }
                        else
                        {
                            throw new Exception("The attribute searched in the single get does not exist.");
                        }
                    }
                    else
                    {
                        SqliteDataAccess.InsertLoadHistory((string)selectEntity.SelectedItem, textId.Text, null, textSingle.Text);
                        await entity.Load(textId.Text);
                        string text = (string)entity.getData(textSingle.Text);

                        if (!String.IsNullOrEmpty(text))
                        {
                            textResult.Text = text;
                        }
                        else
                        {
                            throw new Exception("The attribute searched in the single get does not exist.");
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
            bool isComboBoxEmpty = selectEntity.SelectedIndex == -1;

            if (isTextIdEmpty && isComboBoxEmpty)
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