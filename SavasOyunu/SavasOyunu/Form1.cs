using SavasOyunu.Models;
namespace SavasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // instance alma iþlemi
        Buyucu oyuncu1 = new Buyucu();
        int DusmanCan;

        private void btnSec_Click(object sender, EventArgs e)
        {
            oyuncu1.OyuncuIsmi = txtOyuncu.Text;
            oyuncu1.Brans = txtBrans.Text;
            oyuncu1.Irk = txtIrk.Text;
            oyuncu1.Silah = txtSilah.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DusmanCan = lblDusmanCan.Width;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            oyuncu1.Saldir();
            DusmanCan -= oyuncu1.SaldiriGucu;
            lblDusmanCan.Width = DusmanCan;
            MessageBox.Show($"Düþmana {oyuncu1.SaldiriGucu} kadar hasar verdiniz.");
            if (DusmanCan <= 0)
            {
                MessageBox.Show("Düþman yenildi!");
            }
        }
    }
}
