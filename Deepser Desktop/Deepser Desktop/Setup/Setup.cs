using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();

            CheckAndCreateDatabase();
            buttonNext.Click += ButtonNext_Click;
            buttonSkip.Click += ButtonSkip_Click;
            buttonOk.Click += ButtonOk_Click;
            buttonBack.Click += ButtonBack_Click;
            buttonFinish.Click += ButtonFinish_Click;
            this.FormClosing += Setup_FormClosing;
            buttonClose.Click += ButtonClose_Click;

        }


        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            if (main.Controls.Count > 0)
            {
                Control control = main.Controls[0];
                if (control is SectorRequest)
                {
                    buttonBack.Visible = false;
                    buttonSkip.Visible = false;
                    buttonNext.Visible = true;
                    buttonOk.Visible = false;
                    ShowForm(new UserSetup());

                }
            }
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && e.CloseReason != CloseReason.FormOwnerClosing && e.CloseReason != CloseReason.WindowsShutDown)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialog = MessageBox.Show("Are you sure you want to close the setup page? Doing so will result in the deletion of all the data you have provided so far and you will have to start over from scratch", "Alert", buttons);

                if (dialog == DialogResult.Yes)
                {
                    SqliteDataAccess.DeleteDatabase();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        private void ButtonFinish_Click(object? sender, EventArgs e)
        {
            if (main.Controls.Count > 0)
            {
                Control control = main.Controls[0];
                if (control is DepartmentSetup)
                {
                    ShowForm(new SetupEnd());
                }
                else if (control is SetupEnd)
                {
                    Application.Restart();
                }
            }
        }

        private void CheckAndCreateDatabase()
        {
            if (SqliteDataAccess.CheckDatabase() == false)
            {
                SqliteDataAccess.CreateDatabase();
            }
        }

        private void ButtonOk_Click(object? sender, EventArgs e)
        {
            SqliteDataAccess.CreateDepartment();
            SqliteDataAccess.CreateDepartmentUser();

            ShowForm(new DepartmentSetup());
            buttonFinish.Visible = true;
            buttonBack.Visible = false;
            buttonSkip.Visible = false;
        }

        private void ButtonSkip_Click(object? sender, EventArgs e)
        {
            if (main.Controls.Count > 0)
            {
                Control control = main.Controls[0];
                if (control is SectorRequest)
                {
                    ShowForm(new SetupEnd());
                    buttonOk.Visible = false;
                    buttonFinish.Visible = true;
                    buttonSkip.Visible = false;
                }
            }
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            main.Visible = true;
            if (main.Controls.Count > 0)
            {
                Control control = main.Controls[0];

                if (control is AdminSetup adminSetup)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(adminSetup.textHost.Text) || !string.IsNullOrEmpty(adminSetup.textUsername.Text) || !string.IsNullOrEmpty(adminSetup.textPassword.Text) || !string.IsNullOrEmpty(adminSetup.textToken.Text))
                        {
                            byte[] convertprofile = ConvertProfileImage(adminSetup.profilePicture.Image);
                            SqliteDataAccess.AddUser(adminSetup.textHost.Text, adminSetup.textUsername.Text, adminSetup.textPassword.Text, adminSetup.textToken.Text, "Admin", convertprofile);
                            ShowForm(new UserSetup());
                        }
                        else
                        {
                            throw new Exception("Before you press the next button make sure you fill in all the required fields");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (control is UserSetup)
                {
                    buttonOk.Visible = true;
                    buttonSkip.Visible = true;
                    buttonNext.Visible = false;
                    buttonBack.Visible = true;
                    ShowForm(new SectorRequest());
                }
            }
            else
            {
                ShowForm(new AdminSetup());
                buttonClose.Visible = false;
                buttonNext.Visible = true;
            }
        }

        private byte[] ConvertProfileImage(Image image)
        {
            if (image != Properties.Resources.avatar)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }

        private void ShowForm(Form form)
        {
            if (main.Controls.Count > 0)
            {
                main.Controls.RemoveAt(0);
            }
            main.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            main.Controls.Add(form);
            form.Show();
        }


        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            SqliteDataAccess.DeleteDatabase();
            this.Close();
            Application.Exit();
        }
    }
}
