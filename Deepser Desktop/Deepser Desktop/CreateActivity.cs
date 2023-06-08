using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deepser;
using Deepser.Framework.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Deepser_Desktop
{
    public partial class CreateActivity : Form
    {
        private readonly Dictionary<string, string> dataDictionary = new Dictionary<string, string>();
        public CreateActivity()
        {
            InitializeComponent();
            textId.PlaceholderText = "Entity ID";
            buttonCreate.Click += ButtonCreate_Click;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.activityEntity));
        }

        private async void ButtonCreate_Click(object? sender, EventArgs e)
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
                    await entity.CreateActivity(Int32.Parse(textId.Text));

                    var success = true;
                    foreach (var kvp in dataDictionary)
                    {
                        var key = kvp.Key;
                        var value = kvp.Value;

                        try
                        {
                            string id = (string)entity.getData("entity_id");
                            await entity.LoadActivity(textId.Text, id);
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
                        MessageBox.Show("Create completed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private bool ValidateInput()
        {
            bool isComboBoxEmpty = selectEntity.SelectedIndex == -1;
            bool isDataGridEmpty = dataGrid.Rows.Count == 1;
            bool isTextIdEmpty = string.IsNullOrEmpty(textId.Text);

            if (isComboBoxEmpty && isDataGridEmpty && isTextIdEmpty || isComboBoxEmpty && isDataGridEmpty || isComboBoxEmpty && isTextIdEmpty || isDataGridEmpty && isTextIdEmpty)
            {
                throw new Exception("Required fields are empty");
            }
            else if (isComboBoxEmpty)
            {
                throw new Exception("Select an entity before creating");
            }
            else if (isDataGridEmpty)
            {
                throw new Exception("Create data is empty");
            }
            else if (isTextIdEmpty)
            {
                throw new Exception("Id is empty");
            }
            return true;
        }
    }
}
