using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Deepser_Desktop
{
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();
            buttonUploadImage.Click += ButtonUploadImage_Click;
            buttonAddUser.Click += ButtonAddUser_Click;
            buttonDelUser.Click += ButtonDelUser_Click;
            selectDelUser.SelectedIndexChanged += SelectDelUser_SelectedIndexChanged;
            buttonManagment.Click += ButtonManagment_Click;
            buttonBack.Click += ButtonBack_Click;

            textHost.TextChanged += TextHost_TextChanged;
            textUsername.TextChanged += TextUsername_TextChanged;
            textPassword.TextChanged += TextPassword_TextChanged;
            textToken.TextChanged += TextToken_TextChanged;
            textRole.TextChanged += TextRole_TextChanged;

            FillUser();
        }

        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            textHost.Visible = false;
            textUsername.Visible = false;
            textPassword.Visible = false;
            textToken.Visible = false;
            textRole.Visible = false;
            buttonAddUser.Visible = false;
            buttonDelUser.Visible = false;
            selectDelUser.Visible = false;
            labelUpload.Visible = false;
            buttonUploadImage.Visible = false;
            profilePicture.Visible = false;
            dataGridUser.Visible = true;
            buttonManagment.Visible = true;
            buttonBack.Visible = false;
        }

        private void ButtonManagment_Click(object? sender, EventArgs e)
        {
            textHost.Visible = true;
            textUsername.Visible = true;
            textPassword.Visible = true;
            textToken.Visible = true;
            textRole.Visible = true;
            buttonAddUser.Visible = true;
            buttonDelUser.Visible = true;
            selectDelUser.Visible = true;
            labelUpload.Visible = true;
            buttonUploadImage.Visible = true;
            profilePicture.Visible = true;
            dataGridUser.Visible = false;
            buttonManagment.Visible = false;
            buttonBack.Visible = true;
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
                var allUsers = SqliteDataAccess.AllUsers();
                var selectedUser = (string)selectDelUser.SelectedItem;
                var confirmDeleteMessage = "Are you sure you want to delete this user and all their possible links to various sectors?\r\nThis is an irreversible operation.";
                var confirmDeleteTitle = "Delete User";
                var confirmLastUserDeleteMessage = "If you delete the last user, you will have to reconfigure the application from the beginning. Are you sure you want to proceed?";
                var confirmLastUserDeleteTitle = "Delete Last User";

                if (allUsers.Count == 1)
                {
                    var confirmDialogResult = MessageBox.Show(confirmDeleteMessage, confirmDeleteTitle, MessageBoxButtons.YesNo);
                    if (confirmDialogResult == DialogResult.Yes)
                    {
                        var confirmLastUserDialogResult = MessageBox.Show(confirmLastUserDeleteMessage, confirmLastUserDeleteTitle, MessageBoxButtons.YesNo);
                        if (confirmLastUserDialogResult == DialogResult.Yes)
                        {
                            SqliteDataAccess.DeleteUser(selectedUser);
                            SqliteDataAccess.DeleteDatabase();
                            System.Windows.Forms.Application.Restart();
                        }
                    }
                }
                else
                {
                    var confirmDialogResult = MessageBox.Show(confirmDeleteMessage, confirmDeleteTitle, MessageBoxButtons.YesNo);
                    if (confirmDialogResult == DialogResult.Yes)
                    {
                        SqliteDataAccess.DeleteUser(selectedUser);
                        FillUser();
                    }
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
                List<string> list = SqliteDataAccess.Users();
                Object[] listobj = list.ToArray();
                selectDelUser.Items.AddRange(listobj);

                dataGridUser.Rows.Clear();
                var users = SqliteDataAccess.AllUsers();
                foreach (var user in users)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = user.Host;
                    row.Cells.Add(cell);

                    DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                    cell1.Value = user.Username;
                    row.Cells.Add(cell1);


                    DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = user.Role;
                    row.Cells.Add(cell2);

                    dataGridUser.Rows.Add(row);
                }

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

        private byte[] ConvertProfileImage(System.Drawing.Image image)
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

        private System.Drawing.Image CastByteToImage(Byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(byteArray))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);

                    // Utilizza l'oggetto Image come desiderato
                    // Ad esempio, puoi assegnarlo a una PictureBox
                    return image;
                }
            }
            return null;
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
