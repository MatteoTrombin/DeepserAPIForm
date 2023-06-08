using Deepser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class LoginUser : Form
    {
        internal Deepser_Desktop.User user;
        public Authentication authentication;
        public LoginUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += LoginUser_Load;

            modalEffect.Tick += ModalEffect_Tick;
            buttonClose.Click += ButtonClose_Click;
            FillUser();
            buttonLogin.Click += ButtonLogin_Click;
            selectUser.SelectedIndexChanged += SelectUser_SelectedIndexChanged;
        }
        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("Do you want to close deepser?", "Close", buttons);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void ButtonLogin_Click(object? sender, EventArgs e)
        {

            try
            {
                string username = (string)selectUser.SelectedItem;

                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("Please select a sector and an user");
                }

                user = SqliteDataAccess.Login(username);
                authentication = new Authentication(user.Host, user.Token);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SelectUser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (selectUser.SelectedIndex != -1)
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void FillUser()
        {
            List<string> userList = SqliteDataAccess.Users();
            selectUser.DataSource = userList;
        }

        int i;
        private void LoginUser_Load(object? sender, EventArgs e)
        {
            i = Dashboard.parentY + 100;
            this.Location = new Point(Dashboard.parentX + 350, Dashboard.parentY);
        }
        private void ModalEffect_Tick(object sender, EventArgs e)
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
