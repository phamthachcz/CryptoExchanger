using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchanger
{
    public partial class Form1 : Form
    {
        private UcHome ucHome1;
        private UserHomeFiat ucFiat;
        public Form1()
        {
            InitializeComponent();


            //Console.WriteLine(lib.ExchangerCurrency("1", "2781", 1));

            //LoadCurrency();
            this.ucHome1 = new UcHome();
            this.ucHome1.Dock = DockStyle.Fill;
            this.ucFiat = new UserHomeFiat();
            this.ucFiat.Dock = DockStyle.Fill;
            this.ucFiat.Hide();
            
            panel3.Controls.Add(this.ucFiat);
            panel3.Controls.Add(this.ucHome1);

            

        }

        


        

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }

        private void gImageFiat_Click(object sender, EventArgs e)
        {
            this.ucHome1.Hide();
            this.ucFiat.Show();
        }

        private void gImageCoin_Click(object sender, EventArgs e)
        {
            this.ucHome1.Show();
            this.ucFiat.Hide();
        }

        private void gImageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
