using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prompter1
{
    public class Browser1 : WebBrowser
    {
      
        #region API Stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        private const int SB_HORZ = 0x0;
        private const int SB_VERT = 0x1;
        #endregion
        public int HorizontalPosition
        {
            get { return GetScrollPos((IntPtr)this.Handle, SB_HORZ); }
            set { SetScrollPos((IntPtr)this.Handle, SB_HORZ, value, true); }
        }

        public int VerticalPosition
        {
            get { return GetScrollPos((IntPtr)this.Handle, SB_VERT); }
            set { SetScrollPos((IntPtr)this.Handle, SB_VERT, value, true); }
        }
    } 
}
