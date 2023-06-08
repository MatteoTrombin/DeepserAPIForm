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
    public partial class UserSetup : Form
    {
        public UserSetup()
        {
            InitializeComponent();
            buttonUploadImage.Click += ButtonUploadImage_Click;
            buttonAddUser.Click += ButtonAddUser_Click;
            buttonDelUser.Click += ButtonDelUser_Click;
            selectDelUser.SelectedIndexChanged += SelectDelUser_SelectedIndexChanged;

            textHost.TextChanged += TextHost_TextChanged;
            textUsername.TextChanged += TextUsername_TextChanged;
            textPassword.TextChanged += TextPassword_TextChanged;
            textToken.TextChanged += TextToken_TextChanged;
            textRole.TextChanged += TextRole_TextChanged;

            FillUser();
        }

        private void TextRole_TextChanged(object? sender, EventArgs e)
        {
            bool isAnyFieldEmpty = string.IsNullOrEmpty(textHost.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textToken.Text) || string.IsNullOrEmpty(textRole.Text);
            buttonAddUser.Enabled = !isAnyFieldEmpty;
        }

        private void TextToken_TextChanged(object? sender, EventArgs e)
        {
            bool isAnyFieldEmpty = string.IsNullOrEmpty(textHost.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textToken.Text) || string.IsNullOrEmpty(textRole.Text);
            buttonAddUser.Enabled = !isAnyFieldEmpty;
        }

        private void TextUsername_TextChanged(object? sender, EventArgs e)
        {
            bool isAnyFieldEmpty = string.IsNullOrEmpty(textHost.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textToken.Text) || string.IsNullOrEmpty(textRole.Text);
            buttonAddUser.Enabled = !isAnyFieldEmpty;
        }

        private void TextPassword_TextChanged(object? sender, EventArgs e)
        {
            bool isAnyFieldEmpty = string.IsNullOrEmpty(textHost.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textToken.Text) || string.IsNullOrEmpty(textRole.Text);
            buttonAddUser.Enabled = !isAnyFieldEmpty;
        }

        private void TextHost_TextChanged(object? sender, EventArgs e)
        {
            bool isAnyFieldEmpty = string.IsNullOrEmpty(textHost.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPassword.Text) || string.IsNullOrEmpty(textToken.Text) || string.IsNullOrEmpty(textRole.Text);
            buttonAddUser.Enabled = !isAnyFieldEmpty;
        }

        private void SelectDelUser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonDelUser.Enabled = selectDelUser.SelectedIndex != -1;
        }

        private void ButtonDelUser_Click(object? sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"Are you sure to delete {selectDelUser.SelectedItem}? It is an irreversible operation", "User Delete", buttons);
                if (result == DialogResult.Yes)
                {
                    SqliteDataAccess.DeleteUser((string)selectDelUser.SelectedItem);
                    FillUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillUser()
        {
            try
            {
                selectDelUser.Items.Clear();
                List<string> list = SqliteDataAccess.UsersWithoutAdmin();
                Object[] listobj = list.ToArray();
                selectDelUser.Items.AddRange(listobj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonAddUser_Click(object? sender, EventArgs e)
        {
            try
            {
                if (ValidateInput() == true)
                {
                    byte[] convertprofile = ConvertProfileImage(profilePicture.Image);
                    SqliteDataAccess.AddUser(textHost.Text, textUsername.Text, textPassword.Text, textToken.Text, textRole.Text, convertprofile);
                    textHost.Text = string.Empty;
                    textUsername.Text = string.Empty;
                    textPassword.Text = string.Empty;
                    textToken.Text = string.Empty;
                    textRole.Text = string.Empty;

                    profilePicture.Image = Properties.Resources.avatar;

                    FillUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] ConvertProfileImage(Image image)
        {
            if (image != Deepser_Desktop.Properties.Resources.avatar)
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

        internal bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textHost.Text) || string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(textPassword.Text) || string.IsNullOrWhiteSpace(textToken.Text) || string.IsNullOrWhiteSpace(textRole.Text))
            {
                throw new Exception("Required field are empty or null");
            }
            else
            {
                return true;
            }
        }

        private void ButtonUploadImage_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = Bitmap.FromFile(openFileDialog.FileName);
            }
        }
    }
}
