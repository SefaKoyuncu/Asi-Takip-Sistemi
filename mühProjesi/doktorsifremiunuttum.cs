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
    public partial class doktorsifremiunuttum : Form
    {
        public doktorsifremiunuttum()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void doktorsifremiunuttum_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("select * from doktorbilgileri where TC like '" + maskedtxtBoxTC.Text + "'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {

                    if (txtBoxIpucu.Text == reader["Hatirlatici Isaret"].ToString())
                    {
                        labelTC.Text = "Yeni şifre";
                        labelIpucu.Text = "Şifre tekrar";
                        maskedtxtBoxTC.Visible = false;
                        textBoxsifregir1.Visible = true;
                        txtBoxIpucu.Visible = false;
                        textBoxsifregir2.Visible = true;
                        button1.Visible = false;
                        button2.Visible = true;



                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz ipucu ya da TC kimlik no yanlış!");

                    }


                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                }

                baglanti.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxsifregir1.Text == textBoxsifregir2.Text)
            {
                try
                {
                    baglanti.Open();                       

                    MySqlCommand komut = new MySqlCommand("update doktorbilgileri set Şifre = '"+textBoxsifregir1.Text+"' where TC like  '"+maskedtxtBoxTC.Text+"'", baglanti);
                    MySqlDataReader reader = komut.ExecuteReader();
                    MessageBox.Show("Şifre başarıyla değiştirildi.");

                    baglanti.Close();
                    this.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Şifreler aynı değil!");
            }
        }

        



    }
}
