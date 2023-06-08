using System.Drawing;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public class ComboBoxPlus : System.Windows.Forms.ComboBox
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(System.IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        private string placeholder = string.Empty;
        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                SendMessage(Handle, CB_SETCUEBANNER, 0, Placeholder);
            }
        }
    }
}
