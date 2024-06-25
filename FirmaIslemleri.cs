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
    public partial class FirmaIslemleri : Form
    {
        public FirmaIslemleri()
        {
            InitializeComponent();
        }
        FirmaDal fdal = new FirmaDal();
        private void btnFirmaKaydet_Click(object sender, EventArgs e)
        {
            // Firma adı ve telefon alanları boş ("") veya null'dan farklı ise firma ekleme işlemi yapılacak.
            if (!string.IsNullOrEmpty(txtFirmaAdi.Text) && !string.IsNullOrEmpty(txtFirmaTelefonu.Text))
            {
                Firma frm = new Firma()
                {
                    Ad = txtFirmaAdi.Text,
                    Telefon = txtFirmaTelefonu.Text
                };

                fdal.Add(frm); // Ekleme işlemi yapıldı.
                FirmaListesiGuncelle();
                FormuTemizle();
            }
        }

        private void FormuTemizle()
        {
            // Grupbox'ın bütün kontrollerine tek tek bak, TextBox tipinde bir control varsa bunun text özelliğini temizle.
            foreach (Control item in grpFirmaKayıt.Controls)
            {
                //Eğer bu kontrollerden herhangi bir tanesi TextBox tipinde ise text özelliğini temizliyoruz.
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void FirmaListesiGuncelle()
        {
            lstFirmaListesi.Items.Clear();
            foreach (var item in fdal.GetAll())
            {
                lstFirmaListesi.Items.Add(item);
            }
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            // İlk olarak bizim listBox'dan seçilen nesneyi yakalamaya ihtiyacımız var.
            var secilen = (Firma)lstFirmaListesi.SelectedItem;
            // Daha sonra bu nesneyi FirmaDal classından bulunan Delete isimli metoda parametre olarak göndereceğiz.
            fdal.Delete(secilen);
            FirmaListesiGuncelle();
        }
        Firma secilenFirma;
        private void lstFirmaListesi_SelectedIndexChanged(object sender, EventArgs e) //Listbox'a eklenen veriyi seçince yukarıdaki alanlarda(TextBox gibi) görünmesi  için yapıyoruz
        {
            // Önce listeden seçilen nesneyi yakalamak gerekiyor.
            secilenFirma = (Firma)lstFirmaListesi.SelectedItem;

            // Daha sonra bu nesne üzerindeki ilgili alanları textboxlara yazabiliriz.
            txtFirmaAdi.Text = secilenFirma.Ad;
            txtFirmaTelefonu.Text = secilenFirma.Telefon;            
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            secilenFirma.Ad = txtFirmaAdi.Text;
            secilenFirma.Telefon = txtFirmaTelefonu.Text;

            fdal.Update(secilenFirma);
            FirmaListesiGuncelle();
            FormuTemizle();
        }
    }
}
