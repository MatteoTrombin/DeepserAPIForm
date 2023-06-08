using Deepser;
using Deepser.Framework.Data.Entity;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using Microsoft.VisualBasic;

namespace Deepser_Desktop
{
    public partial class Login : Form
    {
        public Authentication authentication;
        internal User user;
        public string role;


        public Login()
        {
            InitializeComponent();
            InitializeEventHandlers();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Login_Load;
            buttonClose.Click += ButtonClose_Click;

        }

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

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("Do you want to close deepser?", "Close", buttons);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void InitializeEventHandlers()
        {
            selectDepartment.SelectedIndexChanged += SelectSector_SelectedIndexChanged;
            selectUser.SelectedIndexChanged += SelectUser_SelectedIndexChanged;
            buttonLogin.Click += ButtonLogin_Click;
            FillSector();
        }

        private void SelectUser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (selectDepartment.SelectedIndex != -1 && selectUser.SelectedIndex != -1)
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void SelectSector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectUser.Items.Clear();
            if (selectDepartment.SelectedIndex != -1)
            {
                FillUser();
            }
            if (selectDepartment.SelectedIndex != -1 && selectUser.SelectedIndex != -1)
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }

        }

        internal void ButtonLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    string sector = (string)selectDepartment.SelectedItem;
                    string username = (string)selectUser.SelectedItem;

                    if (string.IsNullOrEmpty(sector) || string.IsNullOrEmpty(username))
                    {
                        throw new Exception("Please select a sector and an user");
                    }

                    user = SqliteDataAccess.Login(username, sector);
                    authentication = new Authentication(user.Host, user.Token);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillSector()
        {
            try
            {
                selectDepartment.Items.Clear();
                List<string> sectorId = SqliteDataAccess.GetDepartments();
                object[] obj = sectorId.ToArray();
                selectDepartment.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillUser()
        {
            selectUser.Items.Clear();
            string department = (string)selectDepartment.SelectedItem;

            if (string.IsNullOrEmpty(department))
            {
                throw new Exception("Please select a department");
            }

            var list = SqliteDataAccess.GetUsers(department);
            selectUser.Items.AddRange(list.ToArray());
        }


        public bool ValidateInput()
        {
            if (selectDepartment.SelectedIndex == -1 && selectUser.SelectedIndex == -1)
            {
                throw new Exception("Please select a department and an user");
            }
            else if (selectDepartment.SelectedIndex == -1)
            {
                throw new Exception("Please select a department");
            }
            else if (selectUser.SelectedIndex == -1)
            {
                throw new Exception("Please select an user");
            }
            return true;
        }

        int i;
        private void Login_Load(object? sender, EventArgs e)
        {
            i = Dashboard.parentY + 100;
            this.Location = new Point(Dashboard.parentX + 350, Dashboard.parentY);
        }
        private void modalEffect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect.Stop();
            }
            else
            {
                Opacity += .04;
            }

            int y = Dashboard.parentY += 3;
            this.Location = new Point(Dashboard.parentX + 380, y);
            if (y >= i)
            {
                modalEffect.Stop();
            }
        }
    }
}