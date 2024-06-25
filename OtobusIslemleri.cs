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

namespace TourTicketApp
{
    public partial class OtobusIslemleri : Form
    {
        public OtobusIslemleri()
        {
            InitializeComponent();
        }

        private void OtobusIslemleri_Load(object sender, EventArgs e)
        {
            CombolariDoldur();
        }

        private void CombolariDoldur()
        {
            // FirmaDal isimli sınıfın Instance'ını alarak  burada kullanmaya çalıştığımızda 'new'lediğimiz için içerisindeki tüm listeler ıfırlanmış olacaktır.
            // FirmaDal fdal = new FirmaDal();

            if (FirmaDal.FirmaListesi != null) //Firma eklemeden otobus kayıt ekranındaki firma seçme kısmını açtığımızda hata  almamak için bu kontrolü ekledik. // Tüm firmaları Combobox'a getirir.
            {
                foreach (var item in FirmaDal.FirmaListesi)
                {
                    cmbFirma.Items.Add(item);
                }
            }

            //Tüm Otobus Tiplerini ComboBox'a getirir.
            var otobusTipleri = Enum.GetValues(typeof(OtobusTipi));

            foreach (var item in otobusTipleri)
            {
                cmbOtobüsTipi.Items.Add(item);
            }
        }
        OtobusDal odal = new OtobusDal();
        private void btnOtobusKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Otobus o = new Otobus()
                {
                    Firma = secilenFirma,
                    Plaka = txtPlakaNo.Text,
                    KoltukSayisi = Convert.ToByte(nmrKapasite.Value),
                    Wifi = rdEvet.Checked?true:false,  //Burada bir tek satırlık if yazmış olduk. rdEvet işaretliyse (?=> soru işareti ise anlamında) true olsun değise false olsun anlamındadır.
                    OtobusTipi = secilenOtobus
                };

                odal.Add(o);
                odal.FirmayaOtobusAta(secilenFirma, o);
                OtobusListesiGuncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void OtobusListesiGuncelle()
        {
           lstOtobusListesi.Items.Clear();

            foreach (var item in odal.GetAll())
            {
                lstOtobusListesi.Items.Add(item);
            }
        }

        Firma secilenFirma;
        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenFirma = (Firma)cmbFirma.SelectedItem;
        }
        OtobusTipi secilenOtobus; // OtobusTipi Enum sınıfından geliyor.
        private void cmbOtobüsTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOtobus = (OtobusTipi)cmbOtobüsTipi.SelectedItem;
        }
    }
}
