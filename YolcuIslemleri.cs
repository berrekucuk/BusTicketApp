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
    public partial class YolcuIslemleri : Form
    {
        public YolcuIslemleri()
        {
            InitializeComponent();
        }
        YolcuDal ydal = new YolcuDal();
        private void btnYolcuKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Yolcu oluştur.
                Yolcu y = new Yolcu(txtTC.Text, txtYolcuAdSoyad.Text)
                {
                    Telefon = txtYolcuTelefon.Text,
                    BagajVarMi = rdEvet.Checked ? true : false,
                    Cinsiyet = rdErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın //Tek satır if sorgusudur.
                };
                //Yolcuyu listeye ekleyelim
                ydal.Add(y);

                //Yolcu listesini güncelle
                YolcuListesiniGuncelle();
                YolcuFormunuTemizle();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void YolcuFormunuTemizle()
        {
            foreach (Control item in grpKayıtIslemleri.Controls )
            {
                if (item is TextBox )
                {
                    item.Text = "";
                    
                }
                
            }
            foreach (Control item in grpBagaj.Controls)
            {
                if(item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
            foreach (Control item in grpCinsiyet.Controls)
            {
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
        }

        private void YolcuListesiniGuncelle()
        {
            lstYolcuListesi.Items.Clear();

            foreach (var item in ydal.GetAll())
            {
                lstYolcuListesi.Items.Add(item);
            }
        }
        Yolcu secilenYolcu;
        private void btnYolcuSil_Click(object sender, EventArgs e)
        {
            secilenYolcu = (Yolcu)lstYolcuListesi.SelectedItem;
            ydal.Delete(secilenYolcu);
            YolcuListesiniGuncelle();
            YolcuFormunuTemizle();
        }

        private void lstYolcuListesi_SelectedIndexChanged(object sender, EventArgs e) //ListBox'a eklenen verilerin üzerinde güncelleme yapabilmek için seçilip yukarıdaki TextBox'larda gerekli verileri göstermektedir. 
        {
            secilenYolcu = (Yolcu)lstYolcuListesi.SelectedItem;

            txtTC.Text = secilenYolcu.TCKimlikNo;
            txtYolcuAdSoyad.Text = secilenYolcu.AdSoyad;
            txtYolcuTelefon.Text = secilenYolcu.Telefon;

            if (secilenYolcu.BagajVarMi)
            {
                rdEvet.Checked = true;
            }
            else
            {
                rdHayır.Checked = true;
            }
            

            if (secilenYolcu.Cinsiyet == Cinsiyet.Erkek)
            {
                rdErkek.Checked = true;
            }
            else
            {
                rdKadın.Checked = true;
            }
        }

        private void btnYolcuGuncelle_Click(object sender, EventArgs e)
        {
            secilenYolcu.TCKimlikNo = txtTC.Text;
            secilenYolcu.AdSoyad = txtYolcuAdSoyad.Text;
            secilenYolcu.Telefon = txtYolcuTelefon.Text;
            secilenYolcu.BagajVarMi = rdEvet.Checked ? true : false;
            secilenYolcu.Cinsiyet = rdErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın;

            ydal.Update(secilenYolcu);
            YolcuListesiniGuncelle();
            YolcuFormunuTemizle();
        }
    }
}
