using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTicketApp.DAL;
using TourTicketApp.Entities;
using TourTicketApp.My_Tool;

namespace TourTicketApp
{
    public partial class GuzergahIslemleri : Form
    {
        public GuzergahIslemleri()
        {
            InitializeComponent();
        }

        private void GuzergahIslemleri_Load(object sender, EventArgs e)
        {
            IlleriGetir();
        }

        private void IlleriGetir()
        {
            cmbNereden.Items.AddRange(Tools.TurkiyeIlleri);
            cmbNereye.Items.AddRange(Tools.TurkiyeIlleri);

        }

        GuzergahDal gdal = new GuzergahDal();
        private void btnGuzergahKaydet_Click(object sender, EventArgs e)
        {
            //Eğer ComboBox'lardan seçilen bir şey varsa kaydedebilirsin
            //Seçilen şehir aynı olmamalı

            if (cmbNereden.SelectedIndex != -1 && cmbNereye.SelectedIndex != -1 && (cmbNereden.SelectedIndex != cmbNereye.SelectedIndex)) // SelectedIndex -1 ise seçilen bişey yok demektir.
            {
                // Guzergah Nesnesini oluşturabiliriz.
                Guzergah g = new Guzergah()
                {
                    Kalkis = cmbNereden.SelectedItem.ToString(),
                    Varis = cmbNereye.SelectedItem.ToString()
                };
                gdal.Add(g);
                GuzergahListesiniGuncelle();
            }
        }

        private void GuzergahListesiniGuncelle()
        {
            lstGuzergahListesi.Items.Clear();

            foreach (var item in gdal.GetAll())
            {
                lstGuzergahListesi.Items.Add(item);
            }
        }
        Guzergah secilenGuzergah;
        private void lstGuzergahListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenGuzergah = (Guzergah)lstGuzergahListesi.SelectedItem;
            GezilecekYerleriGuncelle();
        }

        private void btnYerEkle_Click(object sender, EventArgs e)
        {
            // Burada yer GezilecekYer nesnesi oluşturularak yukarıdaki listeden seçilen güzergahın GezilecekYer adlı listesine eklenecektir.

            if(lstGuzergahListesi.SelectedIndex != -1)
            {
                GezilecekYer yer = new GezilecekYer()
                {
                    YerAdi = txtGezilecekYer.Text
                };
                gdal.GuzergahaYerEkle(secilenGuzergah, yer);
                GezilecekYerleriGuncelle();

            }
        }

        private void GezilecekYerleriGuncelle()
        {
            lstGezilecekYerler.Items.Clear();

            foreach (var yer in secilenGuzergah.GezilecekYerler)
            {
                lstGezilecekYerler.Items.Add(yer);
            }
        }
    }
}
