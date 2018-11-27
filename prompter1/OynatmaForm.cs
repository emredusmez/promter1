using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prompter1
{
   
    public partial class OynatmaForm : Form
    {

        string metin = "";
        Color arkaplan;
        public OynatmaForm(string txtMetin)
        {
            CheckForIllegalCrossThreadCalls =false;
            this.metin = txtMetin;
         
            InitializeComponent();
           



        }
        
      
       
        Thread thread2;
        string normal = "";
        string yansima="";
        int uzunluk = 0;
        private void OynatmaForm_Load(object sender, EventArgs e)
        {
            
           
            pnlAna.Visible = false;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            Key.Close();

            // string s="<p style=\"font-size:200px;\">"+metin+"</p>";
            normal = metin;
            StringBuilder sb = new StringBuilder();
            sb.Append(File.ReadAllText("html.html"));
            sb.Append(metin);
            sb.Append("</body>");
            sb.Append("</html>");
            yansima = sb.ToString();
            txtMetin.DocumentText =normal;
          
            //  sf.FormatFlconags = StringFormatFlags.FitBlackBox;
            //  g.ScaleTransform(-1, 1);
            //g.DrawString(txtMetin.Text, txtMetin.Font, Brushes.Blue, new PointF(10, 10),txtMetin. sf);
            thread2 = new Thread(HareketEt);
            thread2.IsBackground = true;
            radioButton2.Select();

           // this.Controls.Add(txtMetin);
            slHiz.Value = 50;
            this.WindowState = FormWindowState.Maximized;
            txtMetin.Height = pnlAna.Top-3;
            timer1.Start();
            Form1.timerstart = true;
            Form1.oynat = true;
         // uzunluk = txtMetin.Document.Window.Size.Height;
           
            // pnlOrta.Left = (this.Width / 2)-pnlOrta.Width;
            while (true)
            {
                Application.DoEvents();
                try
                {
                    txtMetin.Document.Window.ScrollTo(0, Form1.scrollkonum);
                }
                catch (Exception)
                {

                    
                }
               
            }
            
        }
        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        public enum Message : uint
        {
            WM_VSCROLL = 0x0115
        }

        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }
        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
        private void slHiz_DecreaseButtonClick(object sender, EventArgs e)
        {
            slHiz.Value = 0;
            
        }

        private void slHiz_IncreaseButtonClick(object sender, EventArgs e)
        {
            slHiz.Value = 100;
        }
        public static Bitmap RtbToBitmap(RichTextBox rtb)
        {
            rtb.Update(); // Ensure RTB fully painted
            Bitmap bmp = new Bitmap(rtb.Width, rtb.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(rtb.PointToScreen(Point.Empty), Point.Empty, rtb.Size);
            }
            return bmp;
        }
        string yon = "asagi";
        int beklemesure=1;
        
        
        void HareketEt()
        {
           
         
            // Browser1 wb = new Browser1();
            //wb.Dock = DockStyle.Fill;
            //wb.DocumentText = metin;
            //  this.Controls.Add(wb);
            while (true)
            {

               
                Thread.Sleep(beklemesure);
                try
                {
                    


                    // txtMetin.Document.Window.ScrollTo(0, Form1.scrollkonum);
                    if (yon == "asagi")
                    {

                        //if (uzunluk> Form1.scrollkonum)
                        //{
                            Form1.scrollkonum += 1;
                        //}
                       
                     //  wb.Document.Window.ScrollTo(scrollkonum, scrollkonum);
                       
                       

                    }
                    else
                    {
                        //if (0 < Form1.scrollkonum)
                        //{
                            Form1.scrollkonum -= 1;
                        //}

                       
                      //  wb.Document.Window.ScrollTo(scrollkonum, scrollkonum);
                    }
                }
                catch (Exception)
                {

                   
                }
           
               
            }
        }
        void Oynat()
        {
            Form1.timerstart = true;
            Form1.oynat = true;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Oynat();
            //RichTextBoxScrollBars rs = txtMetin.ScrollBars;
            //r

            //HScrollProperties hp = new HScrollProperties();
            ////txtMetin.Select(txtMetin.TextLength - 1, txtMetin.TextLength);
            //pictureBox1.Visible = false;
            //pictureBox1.Image = RtbToBitmap(txtMetin);
            //pictureBox1.BackColor = txtMetin.BackColor;
            //txtMetin.Visible = false;
            //pictureBox1.Visible = true;

        }
        void Duraklat()
        {
            Form1.timerstart = false;
            timer2.Stop();
            Form1.oynat = false;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Duraklat();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void slHiz_ValueChanged(object sender, EventArgs e)
        {
            if (slHiz.Value>2)
            {
                Form1.beklemsuresi = slHiz.Value;
            }
            
        }
        void YonYukari()
        {
            Form1.yon = "yukari";

            yon = "yukari";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            YonYukari();  
        }
        void YonAsagi()
        {
            Form1.yon = "asagi";
            yon = "asagi";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            YonAsagi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Form1.acik==false)
            {
                this.Close();
            }
            if (Form1.timerstart == true)
            {
                try
                {
                  
                }
                catch (Exception)
                {

                 
                }
            }
            else
	{
                try
                {
                   
                }
                catch (Exception)
                {


                }
            }
            if (Form1.oynat==true)
            {
                try
                {
                    thread2.Start();

                }
                catch (Exception)
                {


                }

            }
            else
            {
                try
                {
                    thread2.Abort();
                    thread2 = new Thread(HareketEt);
                }
                catch (Exception)
                {

                  
                }
               
            }
           // slHiz.Value = beklemesure;
            beklemesure = Form1.beklemsuresi;
            yon = Form1.yon;
        }

        private void OynatmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread2.Abort();

            Form1.acik = false;
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);

            //string text = txtMetin.Text;

            //e.Graphics.ScaleTransform(-1, 1);
            //float w = e.Graphics.MeasureString(text, txtMetin.Font).Width;
            //e.Graphics.DrawString(text, txtMetin.Font, Brushes.Aqua, -w, 0);

        }
        // Convert the unit used by the .NET framework (1/100 inch) 
        // and the unit used by Win32 API calls (twips 1/1440 inch)
        private const double anInch = 14.4;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CHARRANGE
        {
            public int cpMin;               // First character of range (0 for start of doc)
            public int cpMax;               // Last character of range (-1 for end of doc)
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct FORMATRANGE
        {
            public IntPtr hdc;           // Actual DC to draw on
            public IntPtr hdcTarget;     // Target DC for determining text formatting
            public RECT rc;            // Region of the DC to draw to (in twips)
            public RECT rcPage;        // Region of the whole DC (page size) (in twips)
            public CHARRANGE chrg;          // Range of text to draw (see earlier declaration)
        }

        private const int WM_USER = 0x0400;
        private const int EM_FORMATRANGE = WM_USER + 57;

        [DllImport("USER32.dll")] private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        /// <summary>
        /// Render the specified RichTextBox onto the specified bitmap
        /// </summary>
        /// <param name="textBox">RichTextBox to render</param>
        /// <param name="bitmap">Bitmap to render the RichTextBox onto</param>
        public void RenderToBitmap(RichTextBox textBox, Bitmap bitmap)
        {
            // Set area to render to be entire bitmap
            RECT rect;
            rect.Left = 0;
            rect.Top = 0;
            rect.Right = (int)(bitmap.Width * anInch);
            rect.Bottom = (int)(bitmap.Height * anInch);

            Graphics g = Graphics.FromImage(bitmap);
            IntPtr hdc = g.GetHdc();

            FORMATRANGE fmtRange;
            fmtRange.chrg.cpMin = textBox.GetCharIndexFromPosition(new Point(0, 0));
            fmtRange.chrg.cpMax = textBox.GetCharIndexFromPosition(new Point(bitmap.Width, bitmap.Height));
            fmtRange.hdc = hdc;                  // Use the same DC for measuring and rendering
            fmtRange.hdcTarget = hdc;
            fmtRange.rc = rect;
            fmtRange.rcPage = rect;

            IntPtr lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
            Marshal.StructureToPtr(fmtRange, lparam, false);

            // Render the control to the bitmap
            SendMessage(textBox.Handle, EM_FORMATRANGE, new IntPtr(1), lparam);

            // Clean up
            Marshal.FreeCoTaskMem(lparam);
            g.ReleaseHdc(hdc);
         
          
        }
        Bitmap bt;
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMetin.Document.Window.Size.Height.ToString());
            txtMetin.Document.Window.ScrollTo(Form1.scrollkonum, 500);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
           Form1.scrollkonum += 1;
            txtMetin.Document.Window.ScrollTo(Form1.scrollkonum, Form1.scrollkonum);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
               
            
            
            try
            {
               // txtMetin.Document.Window.ScrollTo(0, Form1.scrollkonum);
            }
            catch (Exception)
            {

               
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        void Yansit()
        {
            if (checkBox1.Checked)
            {

                txtMetin.DocumentText = yansima;
            }
            else
            {
                txtMetin.DocumentText = normal;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMetin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        
        private void OynatmaForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void OynatmaForm_KeyDown(object sender, KeyEventArgs e)
        {
            
           
            if (e.KeyCode == Keys.Escape)
            {
                Form1.deneme = 23;
       Form1.yon = "asagi";
                Form1.beklemsuresi = 1;
                Form1.oynat = false;
                Form1.acik = false;
                Form1.scrollkonum = 0;
                Form1.timerstart = false;
                Form1.uzunluk = 1;
                
                this.Close();

            }
            if (e.KeyCode == Keys.Down)
            {
                YonAsagi();

            }
            if (e.KeyCode == Keys.Up)
            {
                YonYukari();

            }
            if (e.KeyCode == Keys.Space)
            {
               
                if (Form1.oynat == true)
                {
                    Duraklat();
                }
                else
                {
                    Oynat();
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                checkBox1.Checked = true;
                Yansit();

            }
            if (e.KeyCode == Keys.Right)
            {
                checkBox1.Checked = false;
                Yansit();

            }
            if (e.KeyCode == Keys.Add)
            {

                if (slHiz.Value != 100)
                {
                    slHiz.Value++;
                    Form1.beklemsuresi = slHiz.Value;
                    
                }

            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (slHiz.Value!=3)
                {
                    slHiz.Value--;
                    Form1.beklemsuresi = slHiz.Value;
                }
             

            }
        }

        private void pnlOrta_Click(object sender, EventArgs e)
        {

        }
    }
}
