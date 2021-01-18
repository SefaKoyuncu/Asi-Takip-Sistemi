using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mühProjesi
{
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());

        }

        private void txtBoxGiris_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("select * from doktorbilgileri where TC like '" + maskedtxtBoxTC.Text + "'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {

                    if (txtBoxSifre.Text == reader["Şifre"].ToString())
                    {
                        doktorHastaEkleGörEkrani doktorHasta = new doktorHastaEkleGörEkrani();
                        doktorHasta.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz şifre ya da TC kimlik no yanlış!");
                       
                    }


                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                }

                baglanti.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            doktorsifremiunuttum doktorsifremiunuttum = new doktorsifremiunuttum();
            doktorsifremiunuttum.ShowDialog();
            
        }
    }
}
