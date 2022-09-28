namespace CryptoExchanger
{
    partial class UcHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picCryptoForm = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picCyptoTo = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.gTbCryptoFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTbCryptoTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucCryptoXRP = new CryptoExchanger.UcCrypto();
            this.ucCryptoUSDT = new CryptoExchanger.UcCrypto();
            this.ucCryptoBNB = new CryptoExchanger.UcCrypto();
            this.ucCryptoETH = new CryptoExchanger.UcCrypto();
            this.ucCryptoBTC = new CryptoExchanger.UcCrypto();
            this.gCbCryptoFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gCbCryptoTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCryptoForm)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCyptoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucCryptoXRP);
            this.panel1.Controls.Add(this.ucCryptoUSDT);
            this.panel1.Controls.Add(this.ucCryptoBNB);
            this.panel1.Controls.Add(this.ucCryptoETH);
            this.panel1.Controls.Add(this.ucCryptoBTC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnConvert);
            this.panel2.Controls.Add(this.gTbCryptoTo);
            this.panel2.Controls.Add(this.gTbCryptoFrom);
            this.panel2.Controls.Add(this.picRefresh);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(363, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 367);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.gCbCryptoFrom);
            this.panel3.Controls.Add(this.picCryptoForm);
            this.panel3.Location = new System.Drawing.Point(38, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 74);
            this.panel3.TabIndex = 0;
            // 
            // picCryptoForm
            // 
            this.picCryptoForm.Location = new System.Drawing.Point(141, 17);
            this.picCryptoForm.Name = "picCryptoForm";
            this.picCryptoForm.Size = new System.Drawing.Size(71, 43);
            this.picCryptoForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCryptoForm.TabIndex = 1;
            this.picCryptoForm.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.gCbCryptoTo);
            this.panel4.Controls.Add(this.picCyptoTo);
            this.panel4.Location = new System.Drawing.Point(446, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 74);
            this.panel4.TabIndex = 2;
            // 
            // picCyptoTo
            // 
            this.picCyptoTo.Location = new System.Drawing.Point(141, 17);
            this.picCyptoTo.Name = "picCyptoTo";
            this.picCyptoTo.Size = new System.Drawing.Size(71, 43);
            this.picCyptoTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCyptoTo.TabIndex = 1;
            this.picCyptoTo.TabStop = false;
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(320, 152);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(71, 43);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 2;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // gTbCryptoFrom
            // 
            this.gTbCryptoFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gTbCryptoFrom.BorderRadius = 16;
            this.gTbCryptoFrom.BorderThickness = 2;
            this.gTbCryptoFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTbCryptoFrom.DefaultText = "";
            this.gTbCryptoFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTbCryptoFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTbCryptoFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTbCryptoFrom.DisabledState.Parent = this.gTbCryptoFrom;
            this.gTbCryptoFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTbCryptoFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTbCryptoFrom.FocusedState.Parent = this.gTbCryptoFrom;
            this.gTbCryptoFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTbCryptoFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTbCryptoFrom.HoverState.Parent = this.gTbCryptoFrom;
            this.gTbCryptoFrom.Location = new System.Drawing.Point(38, 139);
            this.gTbCryptoFrom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gTbCryptoFrom.Name = "gTbCryptoFrom";
            this.gTbCryptoFrom.PasswordChar = '\0';
            this.gTbCryptoFrom.PlaceholderText = "1.000232";
            this.gTbCryptoFrom.SelectedText = "";
            this.gTbCryptoFrom.ShadowDecoration.Parent = this.gTbCryptoFrom;
            this.gTbCryptoFrom.Size = new System.Drawing.Size(229, 56);
            this.gTbCryptoFrom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gTbCryptoFrom.TabIndex = 3;
            // 
            // gTbCryptoTo
            // 
            this.gTbCryptoTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gTbCryptoTo.BorderRadius = 16;
            this.gTbCryptoTo.BorderThickness = 2;
            this.gTbCryptoTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTbCryptoTo.DefaultText = "";
            this.gTbCryptoTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTbCryptoTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTbCryptoTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTbCryptoTo.DisabledState.Parent = this.gTbCryptoTo;
            this.gTbCryptoTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTbCryptoTo.Enabled = false;
            this.gTbCryptoTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTbCryptoTo.FocusedState.Parent = this.gTbCryptoTo;
            this.gTbCryptoTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTbCryptoTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTbCryptoTo.HoverState.Parent = this.gTbCryptoTo;
            this.gTbCryptoTo.Location = new System.Drawing.Point(446, 152);
            this.gTbCryptoTo.Name = "gTbCryptoTo";
            this.gTbCryptoTo.PasswordChar = '\0';
            this.gTbCryptoTo.PlaceholderText = "1.000232";
            this.gTbCryptoTo.SelectedText = "";
            this.gTbCryptoTo.ShadowDecoration.Parent = this.gTbCryptoTo;
            this.gTbCryptoTo.Size = new System.Drawing.Size(229, 41);
            this.gTbCryptoTo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gTbCryptoTo.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Black;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(471, 284);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(204, 47);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert Now";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = " Crypto Currency Convertor";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(906, 33);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(165, 72);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conversion Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "1 BTC = 31.38 ETH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "100000000";
            // 
            // ucCryptoXRP
            // 
            this.ucCryptoXRP.CryptoLogo = ((System.Drawing.Image)(resources.GetObject("ucCryptoXRP.CryptoLogo")));
            this.ucCryptoXRP.CryptoName = "XRP";
            this.ucCryptoXRP.CryptoTitle = "XRP";
            this.ucCryptoXRP.CryptoValue = "$62000";
            this.ucCryptoXRP.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCryptoXRP.Location = new System.Drawing.Point(3, 344);
            this.ucCryptoXRP.Name = "ucCryptoXRP";
            this.ucCryptoXRP.Size = new System.Drawing.Size(341, 121);
            this.ucCryptoXRP.TabIndex = 5;
            // 
            // ucCryptoUSDT
            // 
            this.ucCryptoUSDT.CryptoLogo = ((System.Drawing.Image)(resources.GetObject("ucCryptoUSDT.CryptoLogo")));
            this.ucCryptoUSDT.CryptoName = "Tether";
            this.ucCryptoUSDT.CryptoTitle = "USDT";
            this.ucCryptoUSDT.CryptoValue = "$62000";
            this.ucCryptoUSDT.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCryptoUSDT.Location = new System.Drawing.Point(3, 258);
            this.ucCryptoUSDT.Name = "ucCryptoUSDT";
            this.ucCryptoUSDT.Size = new System.Drawing.Size(341, 121);
            this.ucCryptoUSDT.TabIndex = 4;
            // 
            // ucCryptoBNB
            // 
            this.ucCryptoBNB.CryptoLogo = ((System.Drawing.Image)(resources.GetObject("ucCryptoBNB.CryptoLogo")));
            this.ucCryptoBNB.CryptoName = "Binance Coin";
            this.ucCryptoBNB.CryptoTitle = "BNB";
            this.ucCryptoBNB.CryptoValue = "$62000";
            this.ucCryptoBNB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCryptoBNB.Location = new System.Drawing.Point(3, 172);
            this.ucCryptoBNB.Name = "ucCryptoBNB";
            this.ucCryptoBNB.Size = new System.Drawing.Size(341, 121);
            this.ucCryptoBNB.TabIndex = 3;
            // 
            // ucCryptoETH
            // 
            this.ucCryptoETH.CryptoLogo = ((System.Drawing.Image)(resources.GetObject("ucCryptoETH.CryptoLogo")));
            this.ucCryptoETH.CryptoName = "Ethereum";
            this.ucCryptoETH.CryptoTitle = "ETH";
            this.ucCryptoETH.CryptoValue = "$62000";
            this.ucCryptoETH.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCryptoETH.Location = new System.Drawing.Point(3, 86);
            this.ucCryptoETH.Name = "ucCryptoETH";
            this.ucCryptoETH.Size = new System.Drawing.Size(341, 121);
            this.ucCryptoETH.TabIndex = 2;
            // 
            // ucCryptoBTC
            // 
            this.ucCryptoBTC.CryptoLogo = ((System.Drawing.Image)(resources.GetObject("ucCryptoBTC.CryptoLogo")));
            this.ucCryptoBTC.CryptoName = "Bitcoin";
            this.ucCryptoBTC.CryptoTitle = "BTC";
            this.ucCryptoBTC.CryptoValue = "$62000";
            this.ucCryptoBTC.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCryptoBTC.Location = new System.Drawing.Point(3, 0);
            this.ucCryptoBTC.Name = "ucCryptoBTC";
            this.ucCryptoBTC.Size = new System.Drawing.Size(341, 121);
            this.ucCryptoBTC.TabIndex = 1;
            // 
            // gCbCryptoFrom
            // 
            this.gCbCryptoFrom.BackColor = System.Drawing.Color.Transparent;
            this.gCbCryptoFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCbCryptoFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCbCryptoFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gCbCryptoFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gCbCryptoFrom.FocusedState.Parent = this.gCbCryptoFrom;
            this.gCbCryptoFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCbCryptoFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCbCryptoFrom.HoverState.Parent = this.gCbCryptoFrom;
            this.gCbCryptoFrom.ItemHeight = 30;
            this.gCbCryptoFrom.ItemsAppearance.Parent = this.gCbCryptoFrom;
            this.gCbCryptoFrom.Location = new System.Drawing.Point(1, 21);
            this.gCbCryptoFrom.Name = "gCbCryptoFrom";
            this.gCbCryptoFrom.ShadowDecoration.Parent = this.gCbCryptoFrom;
            this.gCbCryptoFrom.Size = new System.Drawing.Size(135, 36);
            this.gCbCryptoFrom.TabIndex = 2;
            this.gCbCryptoFrom.SelectedIndexChanged += new System.EventHandler(this.gCbCryptoFrom_SelectedIndexChanged);
            // 
            // gCbCryptoTo
            // 
            this.gCbCryptoTo.BackColor = System.Drawing.Color.Transparent;
            this.gCbCryptoTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCbCryptoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCbCryptoTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gCbCryptoTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gCbCryptoTo.FocusedState.Parent = this.gCbCryptoTo;
            this.gCbCryptoTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCbCryptoTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCbCryptoTo.HoverState.Parent = this.gCbCryptoTo;
            this.gCbCryptoTo.ItemHeight = 30;
            this.gCbCryptoTo.ItemsAppearance.Parent = this.gCbCryptoTo;
            this.gCbCryptoTo.Location = new System.Drawing.Point(3, 21);
            this.gCbCryptoTo.Name = "gCbCryptoTo";
            this.gCbCryptoTo.ShadowDecoration.Parent = this.gCbCryptoTo;
            this.gCbCryptoTo.Size = new System.Drawing.Size(132, 36);
            this.gCbCryptoTo.TabIndex = 3;
            this.gCbCryptoTo.SelectedIndexChanged += new System.EventHandler(this.gCbCryptoTo_SelectedIndexChanged);
            // 
            // UcHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(1092, 520);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCryptoForm)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCyptoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
        private Guna.UI2.WinForms.Guna2TextBox gTbCryptoTo;
        private Guna.UI2.WinForms.Guna2TextBox gTbCryptoFrom;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picCyptoTo;
        private System.Windows.Forms.PictureBox picCryptoForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public Guna.UI2.WinForms.Guna2ComboBox gCbCryptoTo;
        private UcCrypto ucCryptoBTC;
        private UcCrypto ucCryptoXRP;
        private UcCrypto ucCryptoUSDT;
        private UcCrypto ucCryptoBNB;
        private UcCrypto ucCryptoETH;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox gCbCryptoFrom;
    }
}
