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
    public partial class UserHomeFiat : UserControl
    {
        

        private string symbolCryptoFrom = "";

        private string symbolCryptoTo = "";

        private Assembly lib;
        private Type CryptoType;
        private MethodInfo exchangerCurrencyMethod;
        private MethodInfo getImageMethod;

        private object Fiat;

        public UserHomeFiat()
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
            this.Fiat = Activator.CreateInstance(this.CryptoType);

            MethodInfo readCurrencyMethod = this.CryptoType.GetMethod("ReadCurrencyFiat");
            readCurrencyMethod.Invoke(this.Fiat, new object[0]);

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
            MethodInfo getKeyFiatMethod = this.CryptoType.GetMethod("getFiatKeys");
            object lsKeysFrom = getKeyFiatMethod.Invoke(this.Fiat, new object[0]);
            object lsKeysTo = getKeyFiatMethod.Invoke(this.Fiat, new object[0]);
            gCbCryptoFrom.DataSource = lsKeysFrom;
            gCbCryptoTo.DataSource = lsKeysTo;
            gCbCryptoTo.SelectedIndex = 7;
        }
        private void LoadCurrency()
        {
            this.Invoke(new Action(() =>
            {
                ucCryptoUSD.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { "2781", "2781", 1}).ToString();
                ucCryptoEUR.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { "2790", "2781", 1 }).ToString();
                ucCryptoGBP.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { "2791", "2781", 1 }).ToString();
                ucCryptoAUD.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { "2782", "2781", 1 }).ToString();
                ucCryptoCZK.lbPrice.Text = "$" + this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { "2788", "2781", 1 }).ToString();

                ucCryptoUSD.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { "1" });
                ucCryptoEUR.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { "2790" });
                ucCryptoGBP.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { "2791" });
                ucCryptoAUD.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { "2782" });
                ucCryptoCZK.picCrypto.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { "2788" });
            }));

        }

        private void gCbCryptoFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = gCbCryptoFrom.SelectedItem.ToString();
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDFiat");
            string idSelectItem = getIDMethod.Invoke(this.Fiat, new object[] { selectItem }).ToString();
            picCryptoForm.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { idSelectItem });
            this.symbolCryptoFrom = selectItem;
            if (this.symbolCryptoFrom != "" && this.symbolCryptoTo != "")
            {
                string idTo = getIDMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoTo }).ToString();
                double priceCompare = (double)this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { idSelectItem, idTo, 1 });

                MethodInfo getSignMethod = this.CryptoType.GetMethod("getSignFiat");
                label4.Text = string.Format("1 {0} = {2} {1}", getSignMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoFrom}), getSignMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoTo }), priceCompare);
            }
        }

        private void gCbCryptoTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = gCbCryptoTo.SelectedItem.ToString();
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDFiat");
            string idSelectItem = getIDMethod.Invoke(this.Fiat, new object[] { selectItem }).ToString();
            picCyptoTo.Image = (Bitmap)this.getImageMethod.Invoke(this.Fiat, new object[] { idSelectItem });
            this.symbolCryptoTo = selectItem;
            if (this.symbolCryptoFrom != "" && this.symbolCryptoTo != "")
            {
                string idFrom = getIDMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoFrom }).ToString();
                double priceCompare = (double)this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { idFrom, idSelectItem, 1 });
                MethodInfo getSignMethod = this.CryptoType.GetMethod("getSignFiat");
                label4.Text = string.Format("1 {0} = {2} {1}", getSignMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoFrom }), getSignMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoTo }), priceCompare);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            int temp = gCbCryptoFrom.SelectedIndex;
            gCbCryptoFrom.SelectedIndex = gCbCryptoTo.SelectedIndex;
            gCbCryptoTo.SelectedIndex = temp;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double quantity = double.Parse(gTbCryptoFrom.Text);
            MethodInfo getIDMethod = this.CryptoType.GetMethod("getIDFiat");
            string idFrom = getIDMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoFrom }).ToString();
            string idTo = getIDMethod.Invoke(this.Fiat, new object[] { this.symbolCryptoTo }).ToString();
            double priceConvert = (double)this.exchangerCurrencyMethod.Invoke(this.Fiat, new object[] { idFrom, idTo, quantity });
            gTbCryptoTo.Text = priceConvert.ToString();

            Trace.WriteLine(string.Format("Covert {0} {1} to {2} {3}", quantity, this.symbolCryptoFrom, priceConvert, this.symbolCryptoTo));
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            LoadCurrency();
        }
    }
}
