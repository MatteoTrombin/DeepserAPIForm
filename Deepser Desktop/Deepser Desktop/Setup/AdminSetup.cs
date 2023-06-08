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
    public partial class AdminSetup : Form
    {
        public AdminSetup()
        {
            InitializeComponent();
            buttonUploadImage.Click += ButtonUploadImage_Click;
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