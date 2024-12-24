namespace RSA_WinFormsApp
{
    partial class Form1
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblThongtin = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblModulus = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.lblDQ = new System.Windows.Forms.Label();
            this.lblInverseQ = new System.Windows.Forms.Label();
            this.lblExponent = new System.Windows.Forms.Label();
            this.lblFilebandau = new System.Windows.Forms.Label();
            this.lblFilemahoa = new System.Windows.Forms.Label();
            this.btnNap = new Krypton.Toolkit.KryptonButton();
            this.btnLuu = new Krypton.Toolkit.KryptonButton();
            this.btnSinh = new Krypton.Toolkit.KryptonButton();
            this.txtP = new Krypton.Toolkit.KryptonTextBox();
            this.txtQ = new Krypton.Toolkit.KryptonTextBox();
            this.txtModulus = new Krypton.Toolkit.KryptonTextBox();
            this.txtD = new Krypton.Toolkit.KryptonTextBox();
            this.txtDP = new Krypton.Toolkit.KryptonTextBox();
            this.txtDQ = new Krypton.Toolkit.KryptonTextBox();
            this.txtInverseQ = new Krypton.Toolkit.KryptonTextBox();
            this.txtExponent = new Krypton.Toolkit.KryptonTextBox();
            this.btnGiaima = new Krypton.Toolkit.KryptonButton();
            this.btnMahoa = new Krypton.Toolkit.KryptonButton();
            this.btnChonFileMaHoa = new Krypton.Toolkit.KryptonButton();
            this.btnChonFileBanDau = new Krypton.Toolkit.KryptonButton();
            this.txtFileBanDau = new Krypton.Toolkit.KryptonTextBox();
            this.txtFileMaHoa = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.richtxtFileBanDau = new Krypton.Toolkit.KryptonRichTextBox();
            this.richtxtFileMaHoa = new Krypton.Toolkit.KryptonRichTextBox();
            this.btnPublicKey = new Krypton.Toolkit.KryptonButton();
            this.btnPrivateKey = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongtin.Location = new System.Drawing.Point(910, 23);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(262, 42);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "MÃ HÓA RSA";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblP.Location = new System.Drawing.Point(63, 461);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(30, 29);
            this.lblP.TabIndex = 1;
            this.lblP.Text = "P";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQ.Location = new System.Drawing.Point(62, 512);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(33, 29);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Q";
            // 
            // lblModulus
            // 
            this.lblModulus.AutoSize = true;
            this.lblModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblModulus.Location = new System.Drawing.Point(18, 567);
            this.lblModulus.Name = "lblModulus";
            this.lblModulus.Size = new System.Drawing.Size(112, 29);
            this.lblModulus.TabIndex = 3;
            this.lblModulus.Text = "Modulus";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblD.Location = new System.Drawing.Point(62, 615);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(31, 29);
            this.lblD.TabIndex = 4;
            this.lblD.Text = "D";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDP.Location = new System.Drawing.Point(62, 674);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(48, 29);
            this.lblDP.TabIndex = 5;
            this.lblDP.Text = "DP";
            // 
            // lblDQ
            // 
            this.lblDQ.AutoSize = true;
            this.lblDQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDQ.Location = new System.Drawing.Point(62, 730);
            this.lblDQ.Name = "lblDQ";
            this.lblDQ.Size = new System.Drawing.Size(51, 29);
            this.lblDQ.TabIndex = 6;
            this.lblDQ.Text = "DQ";
            // 
            // lblInverseQ
            // 
            this.lblInverseQ.AutoSize = true;
            this.lblInverseQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInverseQ.Location = new System.Drawing.Point(18, 787);
            this.lblInverseQ.Name = "lblInverseQ";
            this.lblInverseQ.Size = new System.Drawing.Size(118, 29);
            this.lblInverseQ.TabIndex = 7;
            this.lblInverseQ.Text = "InverseQ";
            // 
            // lblExponent
            // 
            this.lblExponent.AutoSize = true;
            this.lblExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblExponent.Location = new System.Drawing.Point(18, 846);
            this.lblExponent.Name = "lblExponent";
            this.lblExponent.Size = new System.Drawing.Size(122, 29);
            this.lblExponent.TabIndex = 8;
            this.lblExponent.Text = "Exponent";
            // 
            // lblFilebandau
            // 
            this.lblFilebandau.AutoSize = true;
            this.lblFilebandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFilebandau.Location = new System.Drawing.Point(1097, 82);
            this.lblFilebandau.Name = "lblFilebandau";
            this.lblFilebandau.Size = new System.Drawing.Size(131, 25);
            this.lblFilebandau.TabIndex = 20;
            this.lblFilebandau.Text = "File ban đầu";
            // 
            // lblFilemahoa
            // 
            this.lblFilemahoa.AutoSize = true;
            this.lblFilemahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFilemahoa.Location = new System.Drawing.Point(1097, 490);
            this.lblFilemahoa.Name = "lblFilemahoa";
            this.lblFilemahoa.Size = new System.Drawing.Size(124, 25);
            this.lblFilemahoa.TabIndex = 21;
            this.lblFilemahoa.Text = "File mã hóa";
            // 
            // btnNap
            // 
            this.btnNap.Location = new System.Drawing.Point(152, 904);
            this.btnNap.Name = "btnNap";
            this.btnNap.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnNap.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNap.OverrideDefault.Back.ColorAngle = 45F;
            this.btnNap.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnNap.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNap.OverrideDefault.Border.ColorAngle = 45F;
            this.btnNap.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNap.OverrideDefault.Border.Rounding = 18F;
            this.btnNap.OverrideDefault.Border.Width = 1;
            this.btnNap.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnNap.Size = new System.Drawing.Size(111, 47);
            this.btnNap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNap.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNap.StateCommon.Back.ColorAngle = 45F;
            this.btnNap.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNap.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNap.StateCommon.Border.ColorAngle = 45F;
            this.btnNap.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNap.StateCommon.Border.Rounding = 18F;
            this.btnNap.StateCommon.Border.Width = 1;
            this.btnNap.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNap.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNap.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnNap.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnNap.StatePressed.Back.ColorAngle = 130F;
            this.btnNap.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnNap.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnNap.StatePressed.Border.ColorAngle = 130F;
            this.btnNap.StatePressed.Border.Rounding = 18F;
            this.btnNap.StatePressed.Border.Width = 1;
            this.btnNap.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnNap.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnNap.StateTracking.Back.ColorAngle = 45F;
            this.btnNap.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnNap.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNap.StateTracking.Border.ColorAngle = 45F;
            this.btnNap.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNap.StateTracking.Border.Rounding = 18F;
            this.btnNap.StateTracking.Border.Width = 1;
            this.btnNap.TabIndex = 28;
            this.btnNap.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNap.Values.Text = "Nạp";
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(310, 904);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnLuu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLuu.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLuu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnLuu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLuu.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLuu.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLuu.OverrideDefault.Border.Rounding = 18F;
            this.btnLuu.OverrideDefault.Border.Width = 1;
            this.btnLuu.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLuu.Size = new System.Drawing.Size(111, 47);
            this.btnLuu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLuu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLuu.StateCommon.Back.ColorAngle = 45F;
            this.btnLuu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLuu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLuu.StateCommon.Border.ColorAngle = 45F;
            this.btnLuu.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLuu.StateCommon.Border.Rounding = 18F;
            this.btnLuu.StateCommon.Border.Width = 1;
            this.btnLuu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLuu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLuu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnLuu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnLuu.StatePressed.Back.ColorAngle = 130F;
            this.btnLuu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnLuu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnLuu.StatePressed.Border.ColorAngle = 130F;
            this.btnLuu.StatePressed.Border.Rounding = 18F;
            this.btnLuu.StatePressed.Border.Width = 1;
            this.btnLuu.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnLuu.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnLuu.StateTracking.Back.ColorAngle = 45F;
            this.btnLuu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnLuu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLuu.StateTracking.Border.ColorAngle = 45F;
            this.btnLuu.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLuu.StateTracking.Border.Rounding = 18F;
            this.btnLuu.StateTracking.Border.Width = 1;
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLuu.Values.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Location = new System.Drawing.Point(471, 904);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnSinh.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSinh.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSinh.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnSinh.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSinh.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSinh.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSinh.OverrideDefault.Border.Rounding = 18F;
            this.btnSinh.OverrideDefault.Border.Width = 1;
            this.btnSinh.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSinh.Size = new System.Drawing.Size(111, 47);
            this.btnSinh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSinh.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSinh.StateCommon.Back.ColorAngle = 45F;
            this.btnSinh.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSinh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSinh.StateCommon.Border.ColorAngle = 45F;
            this.btnSinh.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSinh.StateCommon.Border.Rounding = 18F;
            this.btnSinh.StateCommon.Border.Width = 1;
            this.btnSinh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSinh.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSinh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSinh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSinh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSinh.StatePressed.Back.ColorAngle = 130F;
            this.btnSinh.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnSinh.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnSinh.StatePressed.Border.ColorAngle = 130F;
            this.btnSinh.StatePressed.Border.Rounding = 18F;
            this.btnSinh.StatePressed.Border.Width = 1;
            this.btnSinh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnSinh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnSinh.StateTracking.Back.ColorAngle = 45F;
            this.btnSinh.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnSinh.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSinh.StateTracking.Border.ColorAngle = 45F;
            this.btnSinh.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSinh.StateTracking.Border.Rounding = 18F;
            this.btnSinh.StateTracking.Border.Width = 1;
            this.btnSinh.TabIndex = 30;
            this.btnSinh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSinh.Values.Text = "Sinh";
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(152, 840);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(875, 35);
            this.txtP.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtP.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtP.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtP.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtP.StateCommon.Border.Rounding = 18F;
            this.txtP.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtP.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtP.TabIndex = 32;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(152, 506);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(872, 35);
            this.txtQ.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtQ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtQ.StateCommon.Border.Rounding = 18F;
            this.txtQ.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtQ.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQ.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtQ.TabIndex = 33;
            // 
            // txtModulus
            // 
            this.txtModulus.Location = new System.Drawing.Point(152, 561);
            this.txtModulus.Name = "txtModulus";
            this.txtModulus.Size = new System.Drawing.Size(872, 35);
            this.txtModulus.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtModulus.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtModulus.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtModulus.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtModulus.StateCommon.Border.Rounding = 18F;
            this.txtModulus.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtModulus.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtModulus.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtModulus.TabIndex = 34;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(152, 615);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(872, 35);
            this.txtD.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtD.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtD.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtD.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtD.StateCommon.Border.Rounding = 18F;
            this.txtD.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtD.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtD.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtD.TabIndex = 35;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(152, 668);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(872, 35);
            this.txtDP.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDP.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDP.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDP.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDP.StateCommon.Border.Rounding = 18F;
            this.txtDP.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDP.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDP.TabIndex = 36;
            // 
            // txtDQ
            // 
            this.txtDQ.Location = new System.Drawing.Point(152, 724);
            this.txtDQ.Name = "txtDQ";
            this.txtDQ.Size = new System.Drawing.Size(872, 35);
            this.txtDQ.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDQ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDQ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDQ.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDQ.StateCommon.Border.Rounding = 18F;
            this.txtDQ.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDQ.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDQ.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDQ.TabIndex = 37;
            // 
            // txtInverseQ
            // 
            this.txtInverseQ.Location = new System.Drawing.Point(152, 781);
            this.txtInverseQ.Name = "txtInverseQ";
            this.txtInverseQ.Size = new System.Drawing.Size(872, 35);
            this.txtInverseQ.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtInverseQ.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInverseQ.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInverseQ.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtInverseQ.StateCommon.Border.Rounding = 18F;
            this.txtInverseQ.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtInverseQ.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInverseQ.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInverseQ.TabIndex = 38;
            // 
            // txtExponent
            // 
            this.txtExponent.Location = new System.Drawing.Point(152, 455);
            this.txtExponent.Name = "txtExponent";
            this.txtExponent.Size = new System.Drawing.Size(872, 35);
            this.txtExponent.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtExponent.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExponent.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExponent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtExponent.StateCommon.Border.Rounding = 18F;
            this.txtExponent.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtExponent.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtExponent.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtExponent.TabIndex = 39;
            // 
            // btnGiaima
            // 
            this.btnGiaima.Location = new System.Drawing.Point(1500, 904);
            this.btnGiaima.Name = "btnGiaima";
            this.btnGiaima.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnGiaima.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGiaima.OverrideDefault.Back.ColorAngle = 45F;
            this.btnGiaima.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnGiaima.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGiaima.OverrideDefault.Border.ColorAngle = 45F;
            this.btnGiaima.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGiaima.OverrideDefault.Border.Rounding = 18F;
            this.btnGiaima.OverrideDefault.Border.Width = 1;
            this.btnGiaima.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnGiaima.Size = new System.Drawing.Size(111, 47);
            this.btnGiaima.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGiaima.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGiaima.StateCommon.Back.ColorAngle = 45F;
            this.btnGiaima.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGiaima.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGiaima.StateCommon.Border.ColorAngle = 45F;
            this.btnGiaima.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGiaima.StateCommon.Border.Rounding = 18F;
            this.btnGiaima.StateCommon.Border.Width = 1;
            this.btnGiaima.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGiaima.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGiaima.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaima.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnGiaima.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnGiaima.StatePressed.Back.ColorAngle = 130F;
            this.btnGiaima.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnGiaima.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnGiaima.StatePressed.Border.ColorAngle = 130F;
            this.btnGiaima.StatePressed.Border.Rounding = 18F;
            this.btnGiaima.StatePressed.Border.Width = 1;
            this.btnGiaima.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnGiaima.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnGiaima.StateTracking.Back.ColorAngle = 45F;
            this.btnGiaima.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnGiaima.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGiaima.StateTracking.Border.ColorAngle = 45F;
            this.btnGiaima.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGiaima.StateTracking.Border.Rounding = 18F;
            this.btnGiaima.StateTracking.Border.Width = 1;
            this.btnGiaima.TabIndex = 40;
            this.btnGiaima.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGiaima.Values.Text = "Giải mã";
            this.btnGiaima.Click += new System.EventHandler(this.btnGiaima_Click);
            // 
            // btnMahoa
            // 
            this.btnMahoa.Location = new System.Drawing.Point(1222, 904);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnMahoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMahoa.OverrideDefault.Back.ColorAngle = 45F;
            this.btnMahoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnMahoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMahoa.OverrideDefault.Border.ColorAngle = 45F;
            this.btnMahoa.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMahoa.OverrideDefault.Border.Rounding = 18F;
            this.btnMahoa.OverrideDefault.Border.Width = 1;
            this.btnMahoa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnMahoa.Size = new System.Drawing.Size(111, 47);
            this.btnMahoa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMahoa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMahoa.StateCommon.Back.ColorAngle = 45F;
            this.btnMahoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnMahoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMahoa.StateCommon.Border.ColorAngle = 45F;
            this.btnMahoa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMahoa.StateCommon.Border.Rounding = 18F;
            this.btnMahoa.StateCommon.Border.Width = 1;
            this.btnMahoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnMahoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnMahoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMahoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnMahoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMahoa.StatePressed.Back.ColorAngle = 130F;
            this.btnMahoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnMahoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnMahoa.StatePressed.Border.ColorAngle = 130F;
            this.btnMahoa.StatePressed.Border.Rounding = 18F;
            this.btnMahoa.StatePressed.Border.Width = 1;
            this.btnMahoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnMahoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnMahoa.StateTracking.Back.ColorAngle = 45F;
            this.btnMahoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnMahoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnMahoa.StateTracking.Border.ColorAngle = 45F;
            this.btnMahoa.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMahoa.StateTracking.Border.Rounding = 18F;
            this.btnMahoa.StateTracking.Border.Width = 1;
            this.btnMahoa.TabIndex = 41;
            this.btnMahoa.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMahoa.Values.Text = "Mã hóa";
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // btnChonFileMaHoa
            // 
            this.btnChonFileMaHoa.Location = new System.Drawing.Point(1756, 519);
            this.btnChonFileMaHoa.Name = "btnChonFileMaHoa";
            this.btnChonFileMaHoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileMaHoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileMaHoa.OverrideDefault.Back.ColorAngle = 45F;
            this.btnChonFileMaHoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileMaHoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileMaHoa.OverrideDefault.Border.ColorAngle = 45F;
            this.btnChonFileMaHoa.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileMaHoa.OverrideDefault.Border.Rounding = 18F;
            this.btnChonFileMaHoa.OverrideDefault.Border.Width = 1;
            this.btnChonFileMaHoa.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnChonFileMaHoa.Size = new System.Drawing.Size(142, 47);
            this.btnChonFileMaHoa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileMaHoa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileMaHoa.StateCommon.Back.ColorAngle = 45F;
            this.btnChonFileMaHoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileMaHoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileMaHoa.StateCommon.Border.ColorAngle = 45F;
            this.btnChonFileMaHoa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileMaHoa.StateCommon.Border.Rounding = 18F;
            this.btnChonFileMaHoa.StateCommon.Border.Width = 1;
            this.btnChonFileMaHoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChonFileMaHoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnChonFileMaHoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonFileMaHoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnChonFileMaHoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnChonFileMaHoa.StatePressed.Back.ColorAngle = 130F;
            this.btnChonFileMaHoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnChonFileMaHoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnChonFileMaHoa.StatePressed.Border.ColorAngle = 130F;
            this.btnChonFileMaHoa.StatePressed.Border.Rounding = 18F;
            this.btnChonFileMaHoa.StatePressed.Border.Width = 1;
            this.btnChonFileMaHoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileMaHoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileMaHoa.StateTracking.Back.ColorAngle = 45F;
            this.btnChonFileMaHoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileMaHoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileMaHoa.StateTracking.Border.ColorAngle = 45F;
            this.btnChonFileMaHoa.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileMaHoa.StateTracking.Border.Rounding = 18F;
            this.btnChonFileMaHoa.StateTracking.Border.Width = 1;
            this.btnChonFileMaHoa.TabIndex = 42;
            this.btnChonFileMaHoa.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnChonFileMaHoa.Values.Text = "Chọn file";
            this.btnChonFileMaHoa.Click += new System.EventHandler(this.btnChonFileMaHoa_Click);
            // 
            // btnChonFileBanDau
            // 
            this.btnChonFileBanDau.Location = new System.Drawing.Point(1756, 108);
            this.btnChonFileBanDau.Name = "btnChonFileBanDau";
            this.btnChonFileBanDau.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileBanDau.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileBanDau.OverrideDefault.Back.ColorAngle = 45F;
            this.btnChonFileBanDau.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileBanDau.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileBanDau.OverrideDefault.Border.ColorAngle = 45F;
            this.btnChonFileBanDau.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileBanDau.OverrideDefault.Border.Rounding = 18F;
            this.btnChonFileBanDau.OverrideDefault.Border.Width = 1;
            this.btnChonFileBanDau.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnChonFileBanDau.Size = new System.Drawing.Size(142, 47);
            this.btnChonFileBanDau.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileBanDau.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileBanDau.StateCommon.Back.ColorAngle = 45F;
            this.btnChonFileBanDau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnChonFileBanDau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileBanDau.StateCommon.Border.ColorAngle = 45F;
            this.btnChonFileBanDau.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileBanDau.StateCommon.Border.Rounding = 18F;
            this.btnChonFileBanDau.StateCommon.Border.Width = 1;
            this.btnChonFileBanDau.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChonFileBanDau.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnChonFileBanDau.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonFileBanDau.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnChonFileBanDau.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnChonFileBanDau.StatePressed.Back.ColorAngle = 130F;
            this.btnChonFileBanDau.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnChonFileBanDau.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnChonFileBanDau.StatePressed.Border.ColorAngle = 130F;
            this.btnChonFileBanDau.StatePressed.Border.Rounding = 18F;
            this.btnChonFileBanDau.StatePressed.Border.Width = 1;
            this.btnChonFileBanDau.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileBanDau.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileBanDau.StateTracking.Back.ColorAngle = 45F;
            this.btnChonFileBanDau.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnChonFileBanDau.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnChonFileBanDau.StateTracking.Border.ColorAngle = 45F;
            this.btnChonFileBanDau.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChonFileBanDau.StateTracking.Border.Rounding = 18F;
            this.btnChonFileBanDau.StateTracking.Border.Width = 1;
            this.btnChonFileBanDau.TabIndex = 43;
            this.btnChonFileBanDau.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnChonFileBanDau.Values.Text = "Chọn file";
            this.btnChonFileBanDau.Click += new System.EventHandler(this.btnChonFileBanDau_Click);
            // 
            // txtFileBanDau
            // 
            this.txtFileBanDau.Location = new System.Drawing.Point(1093, 120);
            this.txtFileBanDau.Name = "txtFileBanDau";
            this.txtFileBanDau.Size = new System.Drawing.Size(647, 35);
            this.txtFileBanDau.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtFileBanDau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFileBanDau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFileBanDau.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFileBanDau.StateCommon.Border.Rounding = 18F;
            this.txtFileBanDau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtFileBanDau.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFileBanDau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFileBanDau.TabIndex = 44;
            // 
            // txtFileMaHoa
            // 
            this.txtFileMaHoa.Location = new System.Drawing.Point(1093, 531);
            this.txtFileMaHoa.Name = "txtFileMaHoa";
            this.txtFileMaHoa.Size = new System.Drawing.Size(647, 35);
            this.txtFileMaHoa.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtFileMaHoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFileMaHoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFileMaHoa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFileMaHoa.StateCommon.Border.Rounding = 18F;
            this.txtFileMaHoa.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtFileMaHoa.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFileMaHoa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFileMaHoa.TabIndex = 45;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(352, 145);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(618, 160);
            this.kryptonPictureBox1.TabIndex = 46;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // richtxtFileBanDau
            // 
            this.richtxtFileBanDau.Location = new System.Drawing.Point(1093, 173);
            this.richtxtFileBanDau.Name = "richtxtFileBanDau";
            this.richtxtFileBanDau.Size = new System.Drawing.Size(647, 287);
            this.richtxtFileBanDau.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.richtxtFileBanDau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richtxtFileBanDau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richtxtFileBanDau.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richtxtFileBanDau.StateCommon.Border.Rounding = 18F;
            this.richtxtFileBanDau.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.richtxtFileBanDau.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richtxtFileBanDau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richtxtFileBanDau.TabIndex = 47;
            this.richtxtFileBanDau.Text = "";
            // 
            // richtxtFileMaHoa
            // 
            this.richtxtFileMaHoa.Location = new System.Drawing.Point(1093, 588);
            this.richtxtFileMaHoa.Name = "richtxtFileMaHoa";
            this.richtxtFileMaHoa.Size = new System.Drawing.Size(647, 287);
            this.richtxtFileMaHoa.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.richtxtFileMaHoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richtxtFileMaHoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richtxtFileMaHoa.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.richtxtFileMaHoa.StateCommon.Border.Rounding = 18F;
            this.richtxtFileMaHoa.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.richtxtFileMaHoa.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richtxtFileMaHoa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.richtxtFileMaHoa.TabIndex = 48;
            this.richtxtFileMaHoa.Text = "";
            // 
            // btnPublicKey
            // 
            this.btnPublicKey.Location = new System.Drawing.Point(629, 904);
            this.btnPublicKey.Name = "btnPublicKey";
            this.btnPublicKey.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPublicKey.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPublicKey.OverrideDefault.Back.ColorAngle = 45F;
            this.btnPublicKey.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPublicKey.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPublicKey.OverrideDefault.Border.ColorAngle = 45F;
            this.btnPublicKey.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPublicKey.OverrideDefault.Border.Rounding = 18F;
            this.btnPublicKey.OverrideDefault.Border.Width = 1;
            this.btnPublicKey.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPublicKey.Size = new System.Drawing.Size(194, 47);
            this.btnPublicKey.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPublicKey.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPublicKey.StateCommon.Back.ColorAngle = 45F;
            this.btnPublicKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPublicKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPublicKey.StateCommon.Border.ColorAngle = 45F;
            this.btnPublicKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPublicKey.StateCommon.Border.Rounding = 18F;
            this.btnPublicKey.StateCommon.Border.Width = 1;
            this.btnPublicKey.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPublicKey.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPublicKey.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPublicKey.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnPublicKey.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPublicKey.StatePressed.Back.ColorAngle = 130F;
            this.btnPublicKey.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnPublicKey.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPublicKey.StatePressed.Border.ColorAngle = 130F;
            this.btnPublicKey.StatePressed.Border.Rounding = 18F;
            this.btnPublicKey.StatePressed.Border.Width = 1;
            this.btnPublicKey.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPublicKey.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPublicKey.StateTracking.Back.ColorAngle = 45F;
            this.btnPublicKey.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPublicKey.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPublicKey.StateTracking.Border.ColorAngle = 45F;
            this.btnPublicKey.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPublicKey.StateTracking.Border.Rounding = 18F;
            this.btnPublicKey.StateTracking.Border.Width = 1;
            this.btnPublicKey.TabIndex = 49;
            this.btnPublicKey.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPublicKey.Values.Text = "Khóa công khai";
            this.btnPublicKey.Click += new System.EventHandler(this.btnPublicKey_Click);
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(862, 904);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPrivateKey.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPrivateKey.OverrideDefault.Back.ColorAngle = 45F;
            this.btnPrivateKey.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPrivateKey.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPrivateKey.OverrideDefault.Border.ColorAngle = 45F;
            this.btnPrivateKey.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrivateKey.OverrideDefault.Border.Rounding = 18F;
            this.btnPrivateKey.OverrideDefault.Border.Width = 1;
            this.btnPrivateKey.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrivateKey.Size = new System.Drawing.Size(162, 47);
            this.btnPrivateKey.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPrivateKey.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPrivateKey.StateCommon.Back.ColorAngle = 45F;
            this.btnPrivateKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPrivateKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPrivateKey.StateCommon.Border.ColorAngle = 45F;
            this.btnPrivateKey.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrivateKey.StateCommon.Border.Rounding = 18F;
            this.btnPrivateKey.StateCommon.Border.Width = 1;
            this.btnPrivateKey.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPrivateKey.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPrivateKey.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrivateKey.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnPrivateKey.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPrivateKey.StatePressed.Back.ColorAngle = 130F;
            this.btnPrivateKey.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(146)))), ((int)(((byte)(197)))));
            this.btnPrivateKey.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
            this.btnPrivateKey.StatePressed.Border.ColorAngle = 130F;
            this.btnPrivateKey.StatePressed.Border.Rounding = 18F;
            this.btnPrivateKey.StatePressed.Border.Width = 1;
            this.btnPrivateKey.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPrivateKey.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPrivateKey.StateTracking.Back.ColorAngle = 45F;
            this.btnPrivateKey.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            this.btnPrivateKey.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPrivateKey.StateTracking.Border.ColorAngle = 45F;
            this.btnPrivateKey.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrivateKey.StateTracking.Border.Rounding = 18F;
            this.btnPrivateKey.StateTracking.Border.Width = 1;
            this.btnPrivateKey.TabIndex = 50;
            this.btnPrivateKey.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPrivateKey.Values.Text = "Khóa riêng";
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1053);
            this.Controls.Add(this.btnPrivateKey);
            this.Controls.Add(this.btnPublicKey);
            this.Controls.Add(this.richtxtFileMaHoa);
            this.Controls.Add(this.richtxtFileBanDau);
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.txtFileMaHoa);
            this.Controls.Add(this.txtFileBanDau);
            this.Controls.Add(this.btnChonFileBanDau);
            this.Controls.Add(this.btnChonFileMaHoa);
            this.Controls.Add(this.btnMahoa);
            this.Controls.Add(this.btnGiaima);
            this.Controls.Add(this.txtExponent);
            this.Controls.Add(this.txtInverseQ);
            this.Controls.Add(this.txtDQ);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtModulus);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnNap);
            this.Controls.Add(this.lblFilemahoa);
            this.Controls.Add(this.lblFilebandau);
            this.Controls.Add(this.lblExponent);
            this.Controls.Add(this.lblInverseQ);
            this.Controls.Add(this.lblDQ);
            this.Controls.Add(this.lblDP);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblModulus);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblThongtin);
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblModulus;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Label lblDQ;
        private System.Windows.Forms.Label lblInverseQ;
        private System.Windows.Forms.Label lblExponent;
        private System.Windows.Forms.Label lblFilebandau;
        private System.Windows.Forms.Label lblFilemahoa;
        private Krypton.Toolkit.KryptonButton btnNap;
        private Krypton.Toolkit.KryptonButton btnLuu;
        private Krypton.Toolkit.KryptonButton btnSinh;
        private Krypton.Toolkit.KryptonTextBox txtP;
        private Krypton.Toolkit.KryptonTextBox txtQ;
        private Krypton.Toolkit.KryptonTextBox txtModulus;
        private Krypton.Toolkit.KryptonTextBox txtD;
        private Krypton.Toolkit.KryptonTextBox txtDP;
        private Krypton.Toolkit.KryptonTextBox txtDQ;
        private Krypton.Toolkit.KryptonTextBox txtInverseQ;
        private Krypton.Toolkit.KryptonTextBox txtExponent;
        private Krypton.Toolkit.KryptonButton btnGiaima;
        private Krypton.Toolkit.KryptonButton btnMahoa;
        private Krypton.Toolkit.KryptonButton btnChonFileMaHoa;
        private Krypton.Toolkit.KryptonButton btnChonFileBanDau;
        private Krypton.Toolkit.KryptonTextBox txtFileBanDau;
        private Krypton.Toolkit.KryptonTextBox txtFileMaHoa;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonRichTextBox richtxtFileBanDau;
        private Krypton.Toolkit.KryptonRichTextBox richtxtFileMaHoa;
        private Krypton.Toolkit.KryptonButton btnPublicKey;
        private Krypton.Toolkit.KryptonButton btnPrivateKey;
    }
}

