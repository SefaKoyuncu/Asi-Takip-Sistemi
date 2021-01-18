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

    public partial class hastaBilgileri : Form
    {
        public hastaBilgileri()
        {
            InitializeComponent();
        }
        public String gelen;
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastaBilgileri_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());

            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("select * from hastabilgileri where TC like '"+gelen+"'",baglanti);
            MySqlDataReader reader = komut.ExecuteReader();

            while(reader.Read())
            {
              



                lblTC.Text = gelen;
                lbladsoyad.Text = reader["AdSoyad"].ToString();
                lbladres.Text = reader["Adres"].ToString();
                lblyas.Text = reader["Yas"].ToString();
                lblmeslek.Text = reader["Meslek"].ToString();
                labelTarih.Text= reader["AsilanmaTarihi"].ToString();


            }
            baglanti.Close();







            //maskedtxtBoxTC.Text = gelen;




        }
    }
}
