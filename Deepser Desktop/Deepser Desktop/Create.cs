using Deepser.Framework.Data.Entity;
using Deepser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace Deepser_Desktop
{
    public partial class Create : Form
    {
        internal Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

        public Create()
        {
            InitializeComponent();
            buttonCreate.Click += ButtonCreate;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.entityDictionary));
            selectEntity.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            if (selectEntity.SelectedIndex == 37)
            {
                dataGrid.Rows.Add("type_id", 1);
                dataGrid.Rows.Add("title", "title_value");
                dataGrid.Rows.Add("description", "description_value");
                dataGrid.Rows.Add("priority_id", 0);
                dataGrid.Rows.Add("urgency_id", 0);
                dataGrid.Rows.Add("status", 1);
            }
        }

        private async void ButtonCreate(object? sender, EventArgs e)
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

                    await entity.Create();

                    var success = true;
                    foreach (var kvp in dataDictionary)
                    {
                        var key = kvp.Key;
                        var value = kvp.Value;

                        try
                        {
                            string id = (string)entity.getData("entity_id");
                            await entity.Load(id);
                            var result = entity.getData(key);
                            if (result == null)
                            {
                                throw new Exception($"The attribute {key} does not exist");
                            }
                            else if (result.ToString().ToLower() != value)
                            {
                                throw new Exception($"The value of the attribute {key} was not updated correctly");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    MessageBox.Show("Creation was successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateInput()
        {
            bool isComboBoxEmpty = selectEntity.SelectedIndex == -1;
            bool isDataGridEmpty = dataGrid.Rows.Count == 1;

            if (isComboBoxEmpty && isDataGridEmpty)
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
            return true;
        }
    }
}
