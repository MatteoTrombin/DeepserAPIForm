using Deepser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.Drawing.Drawing2D;
using Transitions;

namespace Deepser_Desktop
{
    public partial class Dashboard : Form
    {
        public static int parentX, parentY;
        // drag panel

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private static Dashboard currentDashboard;

        public Dashboard()
        {
            InitializeComponent();
            currentDashboard = this;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeButtons();
            RoundProfilePicture();
            SetToolTips();
        }

        public static Dashboard GetIstance()
        {
            return currentDashboard;
        }

        private void InitializeButtons()
        {
            buttonLoad.Click += ButtonLoad_Click;
            buttonCreate.Click += ButtonCreate_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
            buttonDelete.Click += ButtonDelete_Click;
            timerActivity.Tick += TimerActivity_Tick;
            buttonCollection.Click += ButtonCollection_Click;
            buttonActivity.Click += ButtonActivity_Click;
            buttonLoadAct.Click += ButtonLoadAct_Click;
            buttonCreateAct.Click += ButtonCreateAct_Click;
            buttonUpdateAct.Click += ButtonUpdateAct_Click;
            buttonDeleteAct.Click += ButtonDeleteAct_Click;
            buttonCollActivity.Click += ButtonCollActivity_Click;
            buttonSettings.Click += ButtonSettings_Click;
            buttonLogOut.Click += ButtonLogOut_Click;
            buttonMinimize.Click += ButtonMinimize_Click;
            buttonClose.Click += ButtonClose_Click;
            header.MouseDown += Header_MouseDown;
            buttonClose.MouseHover += ButtonClose_MouseHover;
            buttonClose.MouseLeave += ButtonClose_MouseLeave;
        }

        private void SetToolTips()
        {
            toolTipLoad.SetToolTip(buttonLoad, "Click to load data");
            toolTipCreate.SetToolTip(buttonCreate, "Click to create data");
            toolTipUpdate.SetToolTip(buttonUpdate, "Click to update data");
            toolTipDelete.SetToolTip(buttonDelete, "Click to delete data");
            toolTipCollection.SetToolTip(buttonCollection, "Click to load multiple data");
            toolTipLoadAct.SetToolTip(buttonLoadAct, "Click to load activity data");
            toolTipLoadAct.SetToolTip(buttonCreateAct, "Click to create activity data");
            toolTipLoadAct.SetToolTip(buttonUpdateAct, "Click to update activity data");
            toolTipLoadAct.SetToolTip(buttonDeleteAct, "Click to delete activity data");
            toolTipLoadAct.SetToolTip(buttonCollActivity, "Click to load data from multiple activities");
        }

        private void RoundProfilePicture()
        {
            Rectangle r = new Rectangle(0, 0, profilePicture.Width, profilePicture.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            profilePicture.Region = new Region(gp);
        }

        private void ButtonMinimize_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ButtonClose_MouseLeave(object? sender, EventArgs e)
        {
            buttonClose.Image = Properties.Resources.red;
        }

        private void ButtonClose_MouseHover(object? sender, EventArgs e)
        {
            buttonClose.Image = Properties.Resources.close;
        }



        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            timerFadeOut.Start();
        }


        private void ButtonSettings_Click(object? sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (Settings modal = new Settings())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }

        internal void OpenHistory(Form form)
        {
            Form modalBackground = new Form();
            using (History modal = new History())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                if (form is Load)
                {
                    modal.LoadGrid();
                }
                else if (form is Collection)
                {
                    modal.CollectionGrid();
                }
                else if (form is LoadActivity)
                {
                    modal.LoadActivityGrid();
                }
                else
                {
                    modal.CollectionActivityGrid();
                }

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }

        internal void OpenFav(Form form)
        {
            Form modalBackground = new Form();
            using (Favorite modal = new Favorite())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                if (form is Collection)
                {
                    modal.CollectionGrid();
                }
                else
                {
                    modal.CollectionActivityGrid();
                }
                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }


        private void ButtonLogOut_Click(object? sender, EventArgs e)
        {
            labelUsername.Text = "Username";
            labelRole.Text = "Role";
            if (main.Controls.Count > 0)
            {
                main.Controls.RemoveAt(0);
            }
            profilePicture.Image = Deepser_Desktop.Properties.Resources.avatar;
            Login();
        }


        private void Login()
        {

            if (SqliteDataAccess.AllUsers().Count != 0 && SqliteDataAccess.Table() == 8)
            {
                Form modalBackground = new Form();
                using (LoginUser modal = new LoginUser())
                {
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = 0.50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = this.Size;
                    modalBackground.Location = this.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;

                    parentX = this.Location.X;
                    parentY = this.Location.Y;

                    modal.ShowDialog();
                    modalBackground.Dispose();

                    if (modal.authentication != null)
                    {
                        labelUsername.Text = modal.user.Username;
                        labelRole.Text = modal.user.Role;
                        profilePicture.Image = CastByteToImage(modal.user.ProfilePicture);
                    }
                }
            }
            else if (SqliteDataAccess.GetDepartments().Count != 0 && SqliteDataAccess.AllRelation() != 0)
            {
                Form modalBackground = new Form();
                using (Login modal = new Deepser_Desktop.Login())
                {
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = 0.50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = this.Size;
                    modalBackground.Location = this.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;

                    parentX = this.Location.X;
                    parentY = this.Location.Y;

                    modal.ShowDialog();
                    modalBackground.Dispose();

                    if (modal.authentication != null)
                    {
                        labelUsername.Text = modal.user.Username;
                        labelRole.Text = modal.user.Role;
                        profilePicture.Image = CastByteToImage(modal.user.ProfilePicture);
                    }
                }
            }
            else if (SqliteDataAccess.AllRelation() == 0 && SqliteDataAccess.AllUsers().Count > 0)
            {
                Form modalBackground = new Form();
                using (LoginUser modal = new LoginUser())
                {
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = 0.50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = this.Size;
                    modalBackground.Location = this.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;

                    parentX = this.Location.X;
                    parentY = this.Location.Y;

                    modal.ShowDialog();
                    modalBackground.Dispose();

                    if (modal.authentication != null)
                    {
                        labelUsername.Text = modal.user.Username;
                        labelRole.Text = modal.user.Role;
                        profilePicture.Image = CastByteToImage(modal.user.ProfilePicture);
                    }
                }
            }
            else
            {
                buttonSettings.PerformClick();
            }
        }

        private Image? CastByteToImage(Byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(memoryStream);

                    // Utilizza l'oggetto Image come desiderato
                    // Ad esempio, puoi assegnarlo a una PictureBox
                    return image;
                }
            }
            return null;
        }

        private void ButtonActivity_Click(object? sender, EventArgs e)
        {
            timerActivity.Start();
        }

        bool expand = false;
        private void TimerActivity_Tick(object? sender, EventArgs e)
        {
            if (expand == false)
            {
                dropdownContainer.Height += 15;
                if (dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    RotateFlipType rotate = RotateFlipType.Rotate180FlipNone;
                    buttonActivity.Image.RotateFlip(rotate);
                    buttonActivity.Invalidate(); // Aggiungi questo per forzare il ridisegno del pulsante
                    timerActivity.Stop();
                    expand = true;
                }
            }
            else
            {
                dropdownContainer.Height -= 15;
                if (dropdownContainer.Height <= dropdownContainer.MinimumSize.Height)
                {
                    RotateFlipType rotate = RotateFlipType.Rotate180FlipNone;
                    buttonActivity.Image.RotateFlip(rotate);
                    buttonActivity.Invalidate(); // Aggiungi questo per forzare il ridisegno del pulsante
                    timerActivity.Stop();
                    expand = false;
                }
            }
        }

        private void ButtonCollActivity_Click(object? sender, EventArgs e)
        {
            ShowForm(new ActivityCollection());
        }

        private void ButtonDeleteAct_Click(object? sender, EventArgs e)
        {
            ShowForm(new DeleteActivity());
        }

        private void ButtonUpdateAct_Click(object? sender, EventArgs e)
        {
            ShowForm(new UpdateActivity());
        }

        private void ButtonCreateAct_Click(object? sender, EventArgs e)
        {
            ShowForm(new CreateActivity());
        }

        private void ButtonLoadAct_Click(object? sender, EventArgs e)
        {
            ShowForm(new LoadActivity());
        }

        private void ButtonCollection_Click(object? sender, EventArgs e)
        {
            ShowForm(new Collection());
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            ShowForm(new Delete());
        }

        private void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            ShowForm(new Update());
        }

        private void ButtonCreate_Click(object? sender, EventArgs e)
        {
            ShowForm(new Create());
        }

        private void ButtonLoad_Click(object? sender, EventArgs e)
        {
            ShowForm(new Load());
        }

        internal void ShowForm(Form form)
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

        private void TimerFadeIn(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timerFadeIn.Stop();
                Login();
            }
            Opacity += .2;
        }

        private void TimerFadeOut(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Close();
            }
            Opacity -= .2;
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
    }
}
