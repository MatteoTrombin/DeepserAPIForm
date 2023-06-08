using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            modalEffect.Tick += modalEffect_Tick;
            buttonClose.Click += ButtonClose_Click;
            buttonUserMan.Click += ButtonUserMan_Click;
            buttonSectorMan.Click += ButtonSectorMan_Click;
            buttonResetAll.Click += ButtonResetAll_Click;
            ShowForm(new UserSetting());
            SettingsAllowed();

        }

        // ROUND EDGE
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        bool department = false;
        private void SettingsAllowed()
        {
            if (SqliteDataAccess.Table() == 10)
            {

                department = true;
            }
            else
            {
                department = false;
            }
        }

        private void ButtonResetAll_Click(object? sender, EventArgs e)
        {
            ShowForm(new ResetSetting());
        }

        private void ButtonSectorMan_Click(object? sender, EventArgs e)
        {
            if (department == true)
            {
                ShowForm(new DepartmentSetting());
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want do add department to your software?", "Department", buttons);
                if(result == DialogResult.Yes)
                {
                    SqliteDataAccess.CreateDepartment();
                    SqliteDataAccess.CreateDepartmentUser();
                    SettingsAllowed();
                    ShowForm(new DepartmentSetting());
                }
            }
        }

        private void ButtonUserMan_Click(object? sender, EventArgs e)
        {
            ShowForm(new UserSetting());
        }

        private void ShowForm(Form form)
        {
            if (mainSetting.Controls.Count > 0)
            {
                mainSetting.Controls.RemoveAt(0);
            }
            mainSetting.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainSetting.Controls.Add(form);
            form.Show();
        }



        //========================================================================================================================================================================

        int i;
        private void Setting_Load(object? sender, EventArgs e)
        {
            i = Dashboard.parentY + 100;
            this.Location = new Point(Dashboard.parentX + 350, Dashboard.parentY + 100);
        }

        private void modalEffect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect.Stop();
            }
            Opacity += .03;

            int y = Dashboard.parentY += 3;
            this.Location = new Point(Dashboard.parentX + 180, y);
            if (y >= i)
            {
                modalEffect.Stop();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
