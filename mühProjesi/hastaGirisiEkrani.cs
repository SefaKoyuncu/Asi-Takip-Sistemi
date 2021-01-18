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
    public partial class hastaGirisiEkrani : Form
    {
        public hastaGirisiEkrani()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Ara("select *from hastabilgileri where TC like '%" + maskedtxtBoxTCgiris.Text + "%'");
            

            
        }

        private void hastaGirisiEkrani_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());
        }

        /*public void ESG(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        */

        public void Ara(string sql)
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,baglanti);
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            MySqlDataReader reader = komut.ExecuteReader();


            if (reader.Read())
            {
                //MessageBox.Show("Giriş Başarılı.");
                hastaBilgileri hastaBilgileri = new hastaBilgileri();
                hastaBilgileri.gelen = maskedtxtBoxTCgiris.Text.ToString();
                hastaBilgileri.ShowDialog();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");

            }
            baglanti.Close();
        }




    }
}
