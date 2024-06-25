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
    public partial class BiletIslemleri : Form
    {
        public BiletIslemleri()
        {
            InitializeComponent();
        }
        FirmaDal fdal = new FirmaDal();
        GuzergahDal gdal = new GuzergahDal();
        BiletDal bdal = new BiletDal();
        private void BiletIslemleri_Load(object sender, EventArgs e)
        {
            CombolariDoldur();
        }

        private void CombolariDoldur()
        {
            // Yolcuları getir
            foreach (var item in YolcuDal.YolcuListesi)
            {
                cmbYolcu.Items.Add(item);
            }

            // Otobus Tiplerini getir
            var values = Enum.GetValues(typeof(OtobusTipi));

            foreach (var item in values)
            {
                cmbOtobusTipi.Items.Add(item);
            }

            //Güzergah illerini getir
            cmbNereden.Items.AddRange(Tools.TurkiyeIlleri);
            cmbNereye.Items.AddRange(Tools.TurkiyeIlleri);
        }
        OtobusTipi secilenOtobusTipi;
        private void cmbOtobusTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFirma.Items.Clear();

            // Seçilen Otobus Tipini bulacağız.
            secilenOtobusTipi = (OtobusTipi)cmbOtobusTipi.SelectedItem;

            // Bu Otobüs tipinde olan tüm firmaları bularak Combobox'a yükleyeceğiz.
            List<Firma> gelenFirmalar = fdal.SecilenTipteOtobusuOlanFirmalariDon(secilenOtobusTipi);

            if (gelenFirmalar.Count != 0)
            {
                foreach (var item in gelenFirmalar)
                {
                    cmbFirma.Items.Add(item);
                }
            }
            else
            {
                lblMesaj.Text = "SEÇİLEN TİPTE OTOBÜSE SAHİP FİRMA BULUNAMAMIŞTIR.";
            }
        }
        Firma secilenFirma;
        Otobus secilenOtobus;
        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Firmayı seçtiğimiz anda otobüslerden bir tanesini random olarak seçelim ve plakasınıTextBox'a yazalım.
            secilenFirma = (Firma)cmbFirma.SelectedItem;

            //Firmanın seçilen tipteki otobusleri arasından random bir seçim yapıyoruz:
            var otobusListesi = fdal.FirmanınIstenenTiptekiOtobusListesi(secilenFirma, secilenOtobusTipi);

            // Random bir sayı üretelim
            Random rnd = new Random();
            int gelenSayi = rnd.Next(0, otobusListesi.Count);
            secilenOtobus = otobusListesi[gelenSayi];
            txtOtobusPlaka.Text = secilenOtobus.Plaka;
        }

        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNereden.SelectedIndex != -1)
            {
                cmbNereye.Visible = true;
                lblNereye.Visible = true;
            }
        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var liste = gdal.GuzergahtakiYerler(new Guzergah()
            //{
            //    Kalkis = cmbNereden.SelectedItem.ToString(),
            //    Varis = cmbNereye.SelectedItem.ToString()
            //});

            //foreach (var item in liste)
            //{
            //    lstTumGezilecekYerler.Items.Add(item);
            //}

            olusturulanGuzergah = new Guzergah()
            {
                Kalkis = cmbNereden.SelectedItem.ToString(),
                Varis = cmbNereye.SelectedItem.ToString()
            };
            var liste = gdal.GuzergahtakiYerler(olusturulanGuzergah);

            if (liste != null)
            {
                foreach (var item in liste)
                {
                    lstTumGezilecekYerler.Items.Add(item);
                }
            }
        }
        GezilecekYer secilenYer;
        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            if (lstTumGezilecekYerler.SelectedIndex != -1)
            {
                secilenYer = (GezilecekYer)lstTumGezilecekYerler.SelectedItem;

                if (!lstSecilenGezilecekYerler.Items.Contains(secilenYer))
                {
                    lstSecilenGezilecekYerler.Items.Add(secilenYer);
                }
            }
        }

        private void btnListedenCikar_Click(object sender, EventArgs e)
        {
            if (lstSecilenGezilecekYerler.SelectedIndex != -1)
            {
                lstSecilenGezilecekYerler.Items.RemoveAt(lstSecilenGezilecekYerler.SelectedIndex);
            }
        }

        private void btnListeyiTemizle_Click(object sender, EventArgs e)
        {
            lstSecilenGezilecekYerler.Items.Clear();
        }
        Guzergah olusturulanGuzergah;
        Yolcu secilenYolcu;

        private void btnBiletiOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                Bilet b = new Bilet()
                {
                    Firma = secilenFirma,
                    Yolcu = secilenYolcu,
                    Guzergah = olusturulanGuzergah,
                    KalkisZamani = dtTarih.Value,
                    KoltukNumarasi = Convert.ToByte(txtKoltukNo.Text),
                    Ucret = Convert.ToDecimal(txtBiletUcreti.Text),
                    Otobus = secilenOtobus
                };
                bdal.Add(b);
                lblMesaj.Text = "Bilet Başarılı Bir Şekilde Oluşturuldu.";
                TumBiletleriGetir();
            }
            catch (Exception ex)
            {

                lblMesaj.Text = ex.Message;
            }
        }

        private void TumBiletleriGetir()
        {
            dgwBiletListesi.DataSource = null;
            dgwBiletListesi.DataSource = BiletDal.BiletListesi;
        }

        private void cmbYolcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenYolcu = (Yolcu)cmbYolcu.SelectedItem;
        }

        
    }
}
