using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mühProjesi
{
    public partial class genelGirisEkrani : Form
    {
        public genelGirisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastaGirisiEkrani ekran = new hastaGirisiEkrani();
            ekran.ShowDialog();
            
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            DoktorEkrani doktorEkrani = new DoktorEkrani();
            doktorEkrani.ShowDialog();
        }

        private void btnDepoYetkili_Click(object sender, EventArgs e)
        {
            DepoYetkiliGiriş depoYetkiliGiriş = new DepoYetkiliGiriş();
            depoYetkiliGiriş.ShowDialog();
        }
    }
}
