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

        private void firmaÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Açmak istediðim formun instance'ýný alýyorum
            //FirmaIslemleri firmaForm = new FirmaIslemleri();
            ////FirmaIslemleri formunu Form1'e baðladým.
            //firmaForm.MdiParent = this;
            ////FirmaIslemleri formunu açtým.
            //firmaForm.Show();

            FirmaIslemleri firmaForm = new FirmaIslemleri();
            FormKontrolEt(firmaForm);

        }

        private void yolcuÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YolcuIslemleri yolcuForm = new YolcuIslemleri();
            FormKontrolEt(yolcuForm);
        }

        private void otobüsÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtobusIslemleri otobusForm = new OtobusIslemleri();
            FormKontrolEt(otobusForm);
        }

        private void FormKontrolEt(Form form) //Bu metod açýk olan formlarýn tekrar açýlmasýna engel olacaktýr.
        {
            form.MdiParent = this;

            var FormAcikMi = false;

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == form.GetType()) //Açýk formlarý kontrol edicek
                {
                    FormAcikMi = true;
                }
            }
            if (FormAcikMi)
            {
                MessageBox.Show("Form Zaten Açýk");
            }
            else
            {
                form.Show();
            }
        }

        private void biletÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletIslemleri biletFormu = new BiletIslemleri();
            FormKontrolEt(biletFormu);
        }

        private void güzergahÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuzergahIslemleri guzergahFormu = new GuzergahIslemleri();
            FormKontrolEt(guzergahFormu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Burada VerileriGetir() metodunu çaðýracaðýz.
            Tools.VerileriGetir();
        }
    }
}
