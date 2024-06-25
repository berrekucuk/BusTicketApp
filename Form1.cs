using TourTicketApp;
using TourTicketApp.My_Tool;

namespace BusTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firma��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// A�mak istedi�im formun instance'�n� al�yorum
            //FirmaIslemleri firmaForm = new FirmaIslemleri();
            ////FirmaIslemleri formunu Form1'e ba�lad�m.
            //firmaForm.MdiParent = this;
            ////FirmaIslemleri formunu a�t�m.
            //firmaForm.Show();

            FirmaIslemleri firmaForm = new FirmaIslemleri();
            FormKontrolEt(firmaForm);

        }

        private void yolcu��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YolcuIslemleri yolcuForm = new YolcuIslemleri();
            FormKontrolEt(yolcuForm);
        }

        private void otob�s��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtobusIslemleri otobusForm = new OtobusIslemleri();
            FormKontrolEt(otobusForm);
        }

        private void FormKontrolEt(Form form) //Bu metod a��k olan formlar�n tekrar a��lmas�na engel olacakt�r.
        {
            form.MdiParent = this;

            var FormAcikMi = false;

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == form.GetType()) //A��k formlar� kontrol edicek
                {
                    FormAcikMi = true;
                }
            }
            if (FormAcikMi)
            {
                MessageBox.Show("Form Zaten A��k");
            }
            else
            {
                form.Show();
            }
        }

        private void bilet��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletIslemleri biletFormu = new BiletIslemleri();
            FormKontrolEt(biletFormu);
        }

        private void g�zergah��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuzergahIslemleri guzergahFormu = new GuzergahIslemleri();
            FormKontrolEt(guzergahFormu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Burada VerileriGetir() metodunu �a��raca��z.
            Tools.VerileriGetir();
        }
    }
}
