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
    public partial class UpdateActivity : Form
    {
        private readonly Dictionary<string, string> dataDictionary = new Dictionary<string, string>();
        public UpdateActivity()
        {
            InitializeComponent();
            buttonUpdate.Click += ButtonUpdate_Click; ;
            textId.PlaceholderText = "Entity Id";
            textActivityID.PlaceholderText = "Activity Id";
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.activityEntity));
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
                        var cellvalue = row.Cells[0].Value;
                        if (cellvalue != null && row.Cells[1].Value != null)
                        {
                            var key = cellvalue.ToString().ToLower();
                            var value = row.Cells[1].Value.ToString().ToLower();
                            dataDictionary.Add(key, value);
                            entity.setData(key, value);
                        }
                    }

                    await entity.UpdateActivity(textId.Text, textActivityID.Text);

                    var success = true;
                    foreach (var kvp in dataDictionary)
                    {
                        var key = kvp.Key;
                        var value = kvp.Value;

                        try
                        {
                            await entity.LoadActivity(textId.Text, textActivityID.Text);
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
            bool isTextActivityIdEmpty = string.IsNullOrEmpty(textActivityID.Text);

            if ((isTextIdEmpty && isComboBoxEmpty && isDataGridEmpty && isTextActivityIdEmpty) ||
                (isTextIdEmpty && isComboBoxEmpty && isTextActivityIdEmpty) ||
                (isComboBoxEmpty && isDataGridEmpty && isTextActivityIdEmpty) ||
                (isTextIdEmpty && isDataGridEmpty && isTextActivityIdEmpty))
            {
                throw new Exception("Required fields are empty");
            }
            else if (isTextIdEmpty)
            {
                throw new Exception("Id is empty");
            }
            else if (isTextActivityIdEmpty)
            {
                throw new Exception("Activity ID is empty");
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
