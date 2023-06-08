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
    public partial class ResetSetting : Form
    {
        public ResetSetting()
        {
            InitializeComponent();
            buttonReset.Click += ButtonReset_Click;
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure to reset everything? You will have to start the configuration all over again, it is an irreversible operation!", "Reset", buttons);
            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteDatabase();
                Application.Restart();
            }

        }
    }
}
