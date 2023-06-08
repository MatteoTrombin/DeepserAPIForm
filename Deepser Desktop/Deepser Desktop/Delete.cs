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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            this.buttonDelete.Click += ButtonDelete_Click;
            textId.PlaceholderText = "Id or Value (only with Field)";
            textField.PlaceholderText = "Field (optional)";
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.entityDictionary));
        }

        private async void ButtonDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());

                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult dialog = MessageBox.Show($"Are you sure to delete the {entity} {textId}?", "Delete", button);
                    if (dialog == DialogResult.Yes)
                    {
                        if (String.IsNullOrEmpty(textField.Text))
                        {
                            MessageBox.Show(await entity.Delete(textId.Text));
                        }
                        else
                        {
                            MessageBox.Show(await entity.Delete(textId.Text, textField.Text));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool ValidateInput()
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
    }
}
