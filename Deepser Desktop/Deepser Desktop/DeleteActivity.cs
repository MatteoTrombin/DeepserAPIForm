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
    public partial class DeleteActivity : Form
    {
        public DeleteActivity()
        {
            InitializeComponent();
            textActivity.PlaceholderText = "Activity ID";
            textId.PlaceholderText = "Entity ID";
            buttonDelete.Click += ButtonDelete_Click;
            Factory fact = new Factory();
            selectEntity.Items.AddRange(fact.GetFormattedKeys(fact.activityEntity));
        }

        private async void ButtonDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    Factory fact = new Factory();
                    var entity = fact.CreateEntity(selectEntity.SelectedItem.ToString());
                    MessageBox.Show(await entity.DeleteActivity(Int32.Parse(textId.Text), Int32.Parse(textActivity.Text)));
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
            bool isTextActivityEmpty = string.IsNullOrEmpty(textActivity.Text);

            if (isTextIdEmpty && isComboBoxEmpty && isTextActivityEmpty || isTextIdEmpty && isComboBoxEmpty || isTextIdEmpty && isTextActivityEmpty || isTextActivityEmpty && isComboBoxEmpty)
            {
                throw new Exception("Required fields are empty");
            }
            else if (isTextIdEmpty)
            {
                throw new Exception("Entity ID is empty");
            }
            else if (isTextActivityEmpty)
            {
                throw new Exception("Activity ID is empty");
            }
            else if (isComboBoxEmpty)
            {
                throw new Exception("Select an entity before update");
            }

            return true;
        }
    }
}
