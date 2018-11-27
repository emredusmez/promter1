namespace prompter1
{
    partial class OynatmaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch (System.Exception)
            {

               
            }
           
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlAna = new DevComponents.DotNetBar.PanelEx();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlOrta = new DevComponents.DotNetBar.PanelEx();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.slHiz = new DevComponents.DotNetBar.Controls.Slider();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMetin = new prompter1.Browser1();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlAna.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAna
            // 
            this.pnlAna.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlAna.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlAna.Controls.Add(this.buttonX3);
            this.pnlAna.Controls.Add(this.checkBox1);
            this.pnlAna.Controls.Add(this.pnlOrta);
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAna.Location = new System.Drawing.Point(0, 345);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(1014, 55);
            this.pnlAna.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlAna.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlAna.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlAna.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlAna.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlAna.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlAna.Style.GradientAngle = 90;
            this.pnlAna.TabIndex = 0;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonX3.Location = new System.Drawing.Point(534, 7);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(112, 45);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "Çıkış";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(462, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Yansıma";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnlOrta
            // 
            this.pnlOrta.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOrta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOrta.Controls.Add(this.radioButton2);
            this.pnlOrta.Controls.Add(this.radioButton1);
            this.pnlOrta.Controls.Add(this.slHiz);
            this.pnlOrta.Controls.Add(this.buttonX2);
            this.pnlOrta.Controls.Add(this.buttonX1);
            this.pnlOrta.Location = new System.Drawing.Point(2, 4);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(454, 51);
            this.pnlOrta.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOrta.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOrta.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlOrta.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOrta.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOrta.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOrta.Style.GradientAngle = 90;
            this.pnlOrta.TabIndex = 0;
            this.pnlOrta.Click += new System.EventHandler(this.pnlOrta_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Aşağı";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(337, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yukarı";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // slHiz
            // 
            this.slHiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.slHiz.BackgroundStyle.Class = "";
            this.slHiz.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slHiz.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Top;
            this.slHiz.LabelVisible = false;
            this.slHiz.LabelWidth = 20;
            this.slHiz.Location = new System.Drawing.Point(118, 5);
            this.slHiz.Name = "slHiz";
            this.slHiz.Size = new System.Drawing.Size(199, 43);
            this.slHiz.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slHiz.TabIndex = 1;
            this.slHiz.Value = 0;
            this.slHiz.ValueChanged += new System.EventHandler(this.slHiz_ValueChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonX2.Location = new System.Drawing.Point(77, 3);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(35, 45);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = ";";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonX1.Location = new System.Drawing.Point(36, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(35, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "4";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 345);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prompter1.Properties.Resources.Actions_arrow_right_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMetin.HorizontalPosition = 0;
            this.txtMetin.Location = new System.Drawing.Point(73, 0);
            this.txtMetin.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(941, 345);
            this.txtMetin.TabIndex = 2;
            this.txtMetin.VerticalPosition = 0;
            this.txtMetin.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.txtMetin_DocumentCompleted);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // OynatmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 400);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OynatmaForm";
            this.Text = "OynatmaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OynatmaForm_FormClosing);
            this.Load += new System.EventHandler(this.OynatmaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OynatmaForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OynatmaForm_KeyPress);
            this.pnlAna.ResumeLayout(false);
            this.pnlAna.PerformLayout();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlAna;
        private DevComponents.DotNetBar.PanelEx pnlOrta;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.Slider slHiz;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Browser1 txtMetin;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}