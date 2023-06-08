using Deepser.Framework.Data.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class Update : Form
    {
        private readonly Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

        public Update()
        {
            InitializeComponent();
            buttonUpdate.Click += ButtonUpdate_Click;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.entityDictionary));
        }

        private async void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            try
            {

                if (ValidateInput())
                {
                    dataDictionary.Clear();
                    var fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());

                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        var cellvalue = row.Cells[1].Value;
                        if (cellvalue != null && row.Cells[0].Value != null)
                        {
                            var value = cellvalue.ToString().ToLower();
                            var key = row.Cells[0].Value.ToString().ToLower();
                            dataDictionary.Add(key, value);
                            entity.setData(key, value);
                        }
                    }

                    var id = textId.Text;
                    var attribute = textField.Text;

                    if (string.IsNullOrEmpty(attribute))
                    {
                        await entity.Update(id);
                    }
                    else
                    {
                        await entity.Update(id, attribute);
                    }

                    var success = true;
                    foreach (var kvp in dataDictionary)
                    {
                        var key = kvp.Key;
                        var value = kvp.Value;

                        try
                        {
                            if (String.IsNullOrEmpty(textField.Text))
                            {
                                await entity.Load(id);
                            }
                            else
                            {
                                if (key == attribute)
                                {
                                    await entity.Load(value, attribute);
                                }
                                else
                                {
                                    await entity.Load(id, attribute);
                                }

                            }
                            var result = entity.getData(key);
                            if (result == null)
                            {
                                throw new Exception($"the attribute {key} does not exist");
                            }
                            else if (result.ToString().ToLower() != value)
                            {
                                throw new Exception($"the value of the attribute {key} was not updated correctly");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.Message}");
                            success = false;
                        }
                    }

                    if (success)
                    {
                        MessageBox.Show("Update completed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }

        public bool ValidateInput()
        {
            bool isTextIdEmpty = string.IsNullOrEmpty(textId.Text);
            bool isComboBoxEmpty = selectEntity.SelectedIndex == -1;
            bool isDataGridEmpty = dataGrid.Rows.Count == 1;

            if ((isTextIdEmpty && isComboBoxEmpty && isDataGridEmpty) ||
                (isTextIdEmpty && isComboBoxEmpty) ||
                (isComboBoxEmpty && isDataGridEmpty) ||
                (isTextIdEmpty && isDataGridEmpty))
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
            else if (isDataGridEmpty)
            {
                throw new Exception("Update data is empty");
            }

            return true;
        }
    }
}