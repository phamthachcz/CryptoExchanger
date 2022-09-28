using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchanger
{
    public partial class UcCrypto : UserControl
    {
        public UcCrypto()
        {
            InitializeComponent();
        }

        public Image CryptoLogo
        {
            get => picCrypto.Image;

            set
            {
                picCrypto.Image = value;
            }
        }
        public string CryptoTitle
        {
            get => lbTitle.Text;
            set
            {
                lbTitle.Text = value;
            }
        }
        public string CryptoName
        {
            get => lbName.Text;
            set
            {
                lbName.Text = value;
            }
        }
        public string CryptoValue
        {
            get => lbPrice.Text;
            set
            {
                lbPrice.Text = value;
            }
        }
    }
}
