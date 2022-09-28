using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace CryptoExchanger
{
    public partial class UcHome : UserControl
    {
        

        private string symbolCryptoFrom = "";
        private Assembly lib;
        private Type CryptoType;
        private MethodInfo exchangerCurrencyMethod;
        private MethodInfo getImageMethod;

        private object Crypto;

        private string symbolCryptoTo = "";
        public UcHome()
        {
            InitializeComponent();

            Debug.Listeners.Add(new MyTraceListener());

            LoadLib();
            LoadListCrypto();
        }

        public void LoadLib()
        {
            this.lib = Assembly.LoadFile(Path.GetFullPath("../../../CryptoLib/bin/Debug/CryptoLib.dll"));
            this.CryptoType = this.lib.GetType("CryptoLib.CryptoExLib");
            this.Crypto = Activator.CreateInstance(this.CryptoType);

            MethodInfo readCurrencyMethod = this.CryptoType.GetMethod("ReadCurrencyID");
            readCurrencyMethod.Invoke(this.Crypto, new object[0]);

            this.exchangerCurrencyMethod = this.CryptoType.GetMethod("ExchangerCurrency");

            this.getImageMethod = this.CryptoType.GetMethod("GetImage");
        }

        public void UpdateCurrency()
        {
            new Thread((ThreadStart)(() =>
            {
                while (true)
                {
                    LoadCurrency();
                    Thread.Sleep(60000);
                }

            }
            ))
            {
                IsBackground = true
            }.Start();
        }
        private void LoadListCrypto()
        {
            MethodInfo getKeyCoinMethod = this.CryptoType.GetMethod("getCoinKeys");
            object lsKeysFrom = getKeyCoinMethod.Invoke(this.Crypto, new object[0]);
            object lsKeysTo = getKeyCoinMethod.Invoke(this.Crypto, new object[0]);
            gCbCryptoFrom.DataSource = lsKeysFrom;
            gCbCryptoTo.DataSource = lsKeysTo;
            gCbCryptoTo.SelectedIndex = 4;
        }

        private void LoadCurrency()
        {
            this.Invoke(new Action(() =>
            {
                ucCryptoBTC.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { "1", "2781", 1 }).ToString();
                ucCryptoETH.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { "1027", "2781", 1 }).ToString();
                ucCryptoBNB.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { "1839", "2781", 1 }).ToString();
                ucCryptoUSDT.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { "825", "2781", 1 }).ToString();
                ucCryptoXRP.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { "52", "2781", 1 }).ToString();

                ucCryptoBTC.picCrypto.Image = (Bitmap) this.getImageMethod.Invoke(this.Crypto, new object[] { "1" });
                ucCryptoETH.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto, new object[] { "1027" });
                ucCryptoBNB.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto, new object[] { "1839" });
                ucCryptoUSDT.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto, new object[] { "825" });
                ucCryptoXRP.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto, new object[] { "52" });
            }));

        }

        private void gCbCryptoFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = gCbCryptoFrom.SelectedItem.ToString();
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDCoin");
            string idSelectItem = getIDMethod.Invoke(this.Crypto, new object[] { selectItem }).ToString();
            picCryptoForm.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto,new object[] { idSelectItem });
            this.symbolCryptoFrom = selectItem;
            if (this.symbolCryptoFrom != "" && this.symbolCryptoTo != "")
            {
                string idTo = getIDMethod.Invoke(this.Crypto, new object[] { this.symbolCryptoTo }).ToString();
                double priceCompare = (double)this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { idSelectItem, idTo, 1 });

                label4.Text = string.Format("1 {0} = {2} {1}", this.symbolCryptoFrom, this.symbolCryptoTo, priceCompare);
            }
        }

        private void gCbCryptoTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = gCbCryptoTo.SelectedItem.ToString();
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDCoin");
            string idSelectItem = getIDMethod.Invoke(this.Crypto, new object[] { selectItem }).ToString();
            picCyptoTo.Image = (Bitmap)this.getImageMethod.Invoke(this.Crypto, new object[] { idSelectItem });
            this.symbolCryptoTo = selectItem;
            if (this.symbolCryptoFrom != "" && this.symbolCryptoTo != "")
            {
                string idFrom = getIDMethod.Invoke(this.Crypto, new object[] { this.symbolCryptoFrom }).ToString();
                double priceCompare = (double)this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { idFrom, idSelectItem, 1 });

                label4.Text = string.Format("1 {0} = {2} {1}", this.symbolCryptoFrom, this.symbolCryptoTo, priceCompare);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double quantity = double.Parse(gTbCryptoFrom.Text);
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDCoin");
            string idFrom = getIDMethod.Invoke(this.Crypto, new object[] { this.symbolCryptoFrom }).ToString(); 
            string idTo = getIDMethod.Invoke(this.Crypto, new object[] { this.symbolCryptoTo }).ToString();
            double priceConvert = (double)this.exchangerCurrencyMethod.Invoke(this.Crypto, new object[] { idFrom, idTo, quantity });
            gTbCryptoTo.Text = priceConvert.ToString();


            Trace.WriteLine(string.Format("Covert {0} {1} to {2} {3}", quantity, this.symbolCryptoFrom, priceConvert, this.symbolCryptoTo));
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            int temp = gCbCryptoFrom.SelectedIndex;
            gCbCryptoFrom.SelectedIndex = gCbCryptoTo.SelectedIndex;
            gCbCryptoTo.SelectedIndex = temp;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            LoadCurrency();
        }
    }
}
