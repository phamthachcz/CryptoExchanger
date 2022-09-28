using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;


namespace CryptoLib
{
    class CryptoExLib
    {
        public class Currency
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Sign { get; set; }
        }
        

        private string API_KEY = "c89138be-2dd7-4337-ab7e-d509800ad081";

        private XmlDocument doc;




        public Dictionary<string, Currency> dic_Coins;

        public Dictionary<string, Currency> dic_fiats;

        public CryptoExLib()
        {
            this.dic_Coins = new Dictionary<string, Currency>();
            this.dic_fiats = new Dictionary<string, Currency>();
        }

        public string getIDCoin(string key)
        {
            return this.dic_Coins[key].Id;
        }

        public string getIDFiat(string key)
        {
            return this.dic_fiats[key].Id;
        }

        public string getSignFiat(string key)
        {
            return this.dic_fiats[key].Sign;
        }


        public List<string> getCoinKeys()
        {
            return new List<string>(this.dic_Coins.Keys);
        }

        public List<string> getFiatKeys()
        {
            return new List<string>(this.dic_fiats.Keys);
        }

        private double RequestAPI(string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.114 Safari/537.36 Edg/89.0.774.75");
                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");
                string html = client.DownloadString(url);
                string result = Regex.Match(html, "price\":(.*?),", RegexOptions.Singleline).Groups[1].Value.ToString();
                if(result != "")
                {
                    return Math.Round(double.Parse(result), 5);
                }
                else
                {
                    return -1;
                }
                        
                 
                
            }
        }

        public Bitmap GetImage(string id)
        {
            using(WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.114 Safari/537.36 Edg/89.0.774.75");
                string url = "https://s2.coinmarketcap.com/static/img/coins/64x64/" + id + ".png";
                using(Stream stream = client.OpenRead(url))
                {
                    Bitmap bitmap = new Bitmap(stream);
                    return bitmap;
                }
            }
        }

        public double ExchangerCurrency(string idFrom, string idTo, double amount)
        {
            string url = string.Format("https://pro-api.coinmarketcap.com/v1/tools/price-conversion?amount={0}&convert_id={2}&id={1}", amount, idFrom, idTo);
            return RequestAPI(url);     
        }



        public void ReadCurrencyFiat()
        {
            this.doc = new XmlDocument();
            this.doc.Load("fiat.xml");
            foreach (XmlNode fiatNode in this.doc.SelectNodes("/Fiats/Fiat"))
            {
                XmlNode idNode = fiatNode.SelectSingleNode("Id");
                XmlNode nameNode = fiatNode.SelectSingleNode("Name");
                XmlNode signNode = fiatNode.SelectSingleNode("Sign");
                XmlNode symbolNode = fiatNode.SelectSingleNode("Symbol");
                string id = null;
                string name = null;
                string symbol = null;
                string sign = null;
                if (idNode != null)
                {
                    id = idNode.Attributes["value"].Value;
                }
                if(signNode != null)
                {
                    sign = signNode.Attributes["value"].Value;
                }
                if (nameNode != null)
                {
                    name = nameNode.Attributes["value"].Value;
                }

                if (symbolNode != null)
                {
                    symbol = symbolNode.Attributes["value"].Value;
                }
                if (!this.dic_fiats.ContainsKey(symbol))
                {
                    this.dic_fiats.Add(symbol, new Currency() { Id = id, Name = name, Sign = sign });
                }
            }
        }

        public void ReadCurrencyID()
        {
            //this.http.AddHeader("X-CMC_PRO_API_KEY", API_KEY);
            //this.http.AddHeader("'Accepts'", "'application/json'");
            //string html = this.http.Get("https://pro-api.coinmarketcap.com/v1/cryptocurrency/map?sort=cmc_rank").ToString();
            this.doc = new XmlDocument();
            this.doc.Load("crypto.xml");

            foreach (XmlNode coinNode in this.doc.SelectNodes("/Cryptocurrency/Coin"))
            {
                XmlNode idNode = coinNode.SelectSingleNode("Id");
                XmlNode nameNode = coinNode.SelectSingleNode("Name");
                XmlNode symbolNode = coinNode.SelectSingleNode("Symbol");
                string id = null;
                string name = null;
                string symbol = null;
                if(idNode != null)
                {
                    id = idNode.Attributes["value"].Value;
                }

                if(nameNode != null)
                {
                    name = nameNode.Attributes["value"].Value;
                }

                if(symbolNode != null)
                {
                    symbol = symbolNode.Attributes["value"].Value;
                }
                if (!this.dic_Coins.ContainsKey(symbol))
                {
                    this.dic_Coins.Add(symbol, new Currency() { Id = id, Name = name });
                }
            }
            
        }

    }
}
