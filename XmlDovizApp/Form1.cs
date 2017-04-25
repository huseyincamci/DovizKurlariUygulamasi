using System;
using System.Windows.Forms;
using System.Xml;

namespace XmlDovizApp
{
    public partial class Form1 : Form
    {
        private readonly XmlDocument _xml; 
        public Form1()
        {
            InitializeComponent();
            _xml = new XmlDocument();
        }

        private void btnDovizGetir_Click(object sender, EventArgs e)
        {
            _xml.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            XmlNode today = _xml.SelectSingleNode("Tarih_Date");
            string tarih = today.Attributes["Tarih"].Value;
            lblTarih.Text = tarih;

            XmlNodeList dovizler = today?.SelectNodes("Currency");
            if (dovizler == null) return;
            foreach (XmlNode doviz in dovizler)
            {
                var isim = doviz.SelectSingleNode("Isim");
                var alisFiyati = doviz.SelectSingleNode("ForexBuying");
                var satisFiyati = doviz.SelectSingleNode("ForexSelling");

                ListViewItem item = new ListViewItem {Text = isim.InnerText};
                item.SubItems.Add(alisFiyati.InnerText);
                item.SubItems.Add(satisFiyati.InnerText);
                lstvDovizler.Items.Add(item);
            }
        }
    }
}
