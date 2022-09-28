namespace CryptoExchanger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gImageCoin = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gImageFiat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gImageExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 533);
            this.panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 57;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 56;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.gImageExit);
            this.guna2Panel1.Controls.Add(this.gImageFiat);
            this.guna2Panel1.Controls.Add(this.gImageCoin);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.guna2Panel1.Location = new System.Drawing.Point(23, 23);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(94, 448);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gImageCoin
            // 
            this.gImageCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.gImageCoin.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageCoin.CheckedState.Parent = this.gImageCoin;
            this.gImageCoin.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.gImageCoin.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageCoin.HoverState.Parent = this.gImageCoin;
            this.gImageCoin.Image = ((System.Drawing.Image)(resources.GetObject("gImageCoin.Image")));
            this.gImageCoin.ImageRotate = 0F;
            this.gImageCoin.Location = new System.Drawing.Point(3, 42);
            this.gImageCoin.Name = "gImageCoin";
            this.gImageCoin.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageCoin.PressedState.Parent = this.gImageCoin;
            this.gImageCoin.Size = new System.Drawing.Size(88, 72);
            this.gImageCoin.TabIndex = 1;
            this.gImageCoin.Click += new System.EventHandler(this.gImageCoin_Click);
            // 
            // gImageFiat
            // 
            this.gImageFiat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.gImageFiat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageFiat.CheckedState.Parent = this.gImageFiat;
            this.gImageFiat.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.HoverState.Image")));
            this.gImageFiat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageFiat.HoverState.Parent = this.gImageFiat;
            this.gImageFiat.Image = ((System.Drawing.Image)(resources.GetObject("gImageFiat.Image")));
            this.gImageFiat.ImageRotate = 0F;
            this.gImageFiat.Location = new System.Drawing.Point(3, 177);
            this.gImageFiat.Name = "gImageFiat";
            this.gImageFiat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageFiat.PressedState.Parent = this.gImageFiat;
            this.gImageFiat.Size = new System.Drawing.Size(88, 72);
            this.gImageFiat.TabIndex = 2;
            this.gImageFiat.Click += new System.EventHandler(this.gImageFiat_Click);
            // 
            // gImageExit
            // 
            this.gImageExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.gImageExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageExit.CheckedState.Parent = this.gImageExit;
            this.gImageExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.HoverState.Image")));
            this.gImageExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageExit.HoverState.Parent = this.gImageExit;
            this.gImageExit.Image = ((System.Drawing.Image)(resources.GetObject("gImageExit.Image")));
            this.gImageExit.ImageRotate = 0F;
            this.gImageExit.Location = new System.Drawing.Point(3, 326);
            this.gImageExit.Name = "gImageExit";
            this.gImageExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gImageExit.PressedState.Parent = this.gImageExit;
            this.gImageExit.Size = new System.Drawing.Size(88, 72);
            this.gImageExit.TabIndex = 3;
            this.gImageExit.Click += new System.EventHandler(this.gImageExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(144, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 533);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1249, 543);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton gImageCoin;
        private Guna.UI2.WinForms.Guna2ImageButton gImageExit;
        private Guna.UI2.WinForms.Guna2ImageButton gImageFiat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

