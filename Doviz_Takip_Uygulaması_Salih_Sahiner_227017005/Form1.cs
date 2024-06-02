using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Takip_Uygulaması_Salih_Sahiner_227017005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblusdalıs.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblusdsatıs.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblgbpalıs.Text = GBPAlış;
            lblgbpsatıs.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string EURDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lbleuralıs.Text = EURAlış;
            lbleursatıs.Text = EURDSatış;

            string SARAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexBuying").InnerXml;
            string SARSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
            lblsaralıs.Text = SARAlış;
            lblsarsatıs.Text = SARSatış;

            string AZNAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexBuying").InnerXml;
            string AZNSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexSelling").InnerXml;
            lblaznalıs.Text = AZNAlış;
            lblaznsatıs.Text = AZNSatış;

            string CHFAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexBuying").InnerXml;
            string CHFSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
            lblchfalıs.Text = CHFAlış;
            lblchfsatıs.Text = CHFSatış;

            label1.Text=DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblusdalıs.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblusdsatıs.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblgbpalıs.Text = GBPAlış;
            lblgbpsatıs.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string EURDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lbleuralıs.Text = EURAlış;
            lbleursatıs.Text = EURDSatış;

            string SARAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexBuying").InnerXml;
            string SARSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
            lblsaralıs.Text = SARAlış;
            lblsarsatıs.Text = SARSatış;

            string AZNAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexBuying").InnerXml;
            string AZNSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexSelling").InnerXml;
            lblaznalıs.Text = AZNAlış;
            lblaznsatıs.Text = AZNSatış;

            string CHFAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexBuying").InnerXml;
            string CHFSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
            lblchfalıs.Text = CHFAlış;
            lblchfsatıs.Text = CHFSatış;
            label1.Text = DateTime.Now.ToLongDateString();

        }
    }
}
