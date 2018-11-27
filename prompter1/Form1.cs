using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prompter1
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public static int deneme = 23;
        public static string yon = "asagi";
        public static int beklemsuresi = 1;
        public static bool oynat = false;
        public static bool acik=false;
        public static  int scrollkonum = 0;
        public static bool timerstart = false;
        public static int uzunluk=1;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtMetin.DocumentText = "BURAYA METİN GİRİN. BURAYA METİN GİRİN.  BURAYA METİN GİRİN.  BURAYA METİN GİRİN. BURAYA METİN GİRİN. BURAYA METİN GİRİN. ";
            
           
            this.WindowState = FormWindowState.Maximized;
            FontBoyutuListele();
           
            timer1.Start();
            timer2.Start();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {


           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
          
        }

        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {

      
        }

        private void CArkaplanRenk_SelectedColorChanged(object sender, EventArgs e)
        {
        
        }

        private void CYaziArkaplanRenk_SelectedColorChanged(object sender, EventArgs e)
        {
 
        }
        void FontBoyutuListele()
        {
        
        }
        private void cmbYaziBoyutu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbYaziBoyutu_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnSolaYasla_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
       
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
          
        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {
            acik = true;
         
            string metin=txtMetin.DocumentText;
            OynatmaForm form = new OynatmaForm(metin);
            
            form.Show();
            OynatmaForm form2 = new OynatmaForm(metin);

            form2.Show();

        }
       
        private void Form1_Resize(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.acik==false)
            {
                BaslatButon.Enabled = true;
            }
            else
            {
                BaslatButon.Enabled = false;
            }
        }

        private void editor1_Load(object sender, EventArgs e)
        {

        }

        private void txtMetin_Load(object sender, EventArgs e)
        {
         
        }

        private void txtMetin_Tick()
        {

        }

        private void txtMetin_Click(object sender, EventArgs e)
        {
        }

        private void txtMetin_Move(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtMetin.Document.Body.Style = "font-size:170px;";
           
            txtMetin.BodyBackgroundColor = Color.Black;
            txtMetin.SelectAll();
            txtMetin.EditorForeColor= Color.White;
            timer2.Stop();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            yardim yd = new yardim();
            yd.ShowDialog();
        }
    }
}
