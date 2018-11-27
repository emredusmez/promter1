namespace prompter1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.BaslatButon = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtMetin = new LiveSwitch.TextControl.Editor();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // BaslatButon
            // 
            this.BaslatButon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BaslatButon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BaslatButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BaslatButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslatButon.Location = new System.Drawing.Point(0, 496);
            this.BaslatButon.Name = "BaslatButon";
            this.BaslatButon.Size = new System.Drawing.Size(1109, 38);
            this.BaslatButon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BaslatButon.TabIndex = 4;
            this.BaslatButon.Text = "Başlat";
            this.BaslatButon.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtMetin
            // 
            this.txtMetin.BodyBackgroundColor = System.Drawing.Color.White;
            this.txtMetin.BodyHtml = null;
            this.txtMetin.BodyText = null;
            this.txtMetin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMetin.DocumentText = resources.GetString("txtMetin.DocumentText");
            this.txtMetin.EditorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMetin.EditorForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMetin.FontName = null;
            this.txtMetin.FontSize = LiveSwitch.TextControl.FontSize.NA;
            this.txtMetin.Html = null;
            this.txtMetin.Location = new System.Drawing.Point(0, 0);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(1109, 496);
            this.txtMetin.TabIndex = 5;
            this.txtMetin.Tick += new LiveSwitch.TextControl.Editor.TickDelegate(this.txtMetin_Tick);
            this.txtMetin.Load += new System.EventHandler(this.txtMetin_Load);
            this.txtMetin.Click += new System.EventHandler(this.txtMetin_Click);
            this.txtMetin.Move += new System.EventHandler(this.txtMetin_Move);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yardım";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.BaslatButon);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Prompter düzenleyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX BaslatButon;
        private System.Windows.Forms.Timer timer1;
        private LiveSwitch.TextControl.Editor txtMetin;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}

