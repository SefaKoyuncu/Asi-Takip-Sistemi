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
    public partial class doktorHastaEkleGörEkrani : Form
    {
        public doktorHastaEkleGörEkrani()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void doktorHastaEkleGörEkrani_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           /* try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("update hastabilgileri set AdSoyad = '" + txtBoxAdSoyad.Text + "'," +
                    " Adres='"+richtxtBoxAdres.Text+"', Yas='"+txtBoxYas.Text+"', Meslek='"+txtBoxMeslek.Text+"' where TC like " +
                    " '" + maskedtxtBoxTC.Text + "'", baglanti);

                MySqlDataReader reader = komut.ExecuteReader();
                MessageBox.Show("Başarıyla güncellendi.");

                baglanti.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */




            try
            {


                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    komut = new MySqlCommand("update hastabilgileri set AdSoyad = '" + txtBoxAdSoyad.Text + "'," +
                    " Adres='" + richtxtBoxAdres.Text + "', Yas='" + txtBoxYas.Text + "', Meslek='" + txtBoxMeslek.Text + "' , AsilanmaTarihi='" + maskedtxtTarih.Text + "' where TC like " +
                    " '" + maskedtxtBoxTC.Text + "'", baglanti);
                    reader.Close();
                    reader = komut.ExecuteReader();
                    MessageBox.Show("Başarıyla güncellendi.");

                    baglanti.Close();

                }

                else
                {
                    MessageBox.Show("Olmayan kullanıcı için güncelleme yapılamaz!.");
                    baglanti.Close();
                }
                baglanti.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }


            baglanti.Close();

            maskedtxtBoxTC.Clear();
            txtBoxAdSoyad.Clear();
            richtxtBoxAdres.Clear();
            txtBoxYas.Clear();
            txtBoxMeslek.Clear();

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                

                baglanti.Open();
                //MySqlDataAdapter adapter = new MySqlDataAdapter("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                MySqlCommand komut = new MySqlCommand("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'",baglanti);                            
                MySqlDataReader reader = komut.ExecuteReader();
                
                if (reader.Read())
                {
                    MessageBox.Show("Bu TC Kimlik No ile farklı bir kişi var. Ekleme yapılamaz!");
                    baglanti.Close();
                }

                else
                {
                    reader.Close();
                    baglanti.Close();
                    try
                    {
                        
                        baglanti.Open();
                        komut = new MySqlCommand("select *from doktorbilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                        reader = komut.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Bu TC Kimlik No ile farklı bir kişi var. Ekleme yapılamaz!");
                            baglanti.Close();
                        }
                        else
                        {
                            baglanti.Close();
                            reader.Close();
                            baglanti.Open();
                            komut = new MySqlCommand("select *from asidepoyetkilibilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                            reader = komut.ExecuteReader();

                            if (reader.Read())
                            {
                                MessageBox.Show("Bu TC Kimlik No ile farklı bir kişi var. Ekleme yapılamaz!");
                                baglanti.Close();
                            }
                            else
                            {

                                reader.Close();
                                komut = new MySqlCommand();
                                komut.Connection = baglanti;
                                komut.CommandText = "insert into hastabilgileri (TC, AdSoyad, Adres, Yas, Meslek,AsilanmaTarihi) values ('" + maskedtxtBoxTC.Text + "', '" + txtBoxAdSoyad.Text + "','" + richtxtBoxAdres.Text + "','" + txtBoxYas.Text + "','" + txtBoxMeslek.Text + "','" + maskedtxtTarih.Text + "') ";
                                komut.ExecuteNonQuery();

                                MessageBox.Show("Başarıyla eklendi.");

                                baglanti.Close();
                            }
                            baglanti.Close();

                        }
                        baglanti.Close();
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    baglanti.Close();
                }
                baglanti.Close();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            baglanti.Close();
            maskedtxtBoxTC.Clear();
            txtBoxAdSoyad.Clear();
            richtxtBoxAdres.Clear();
            txtBoxYas.Clear();
            txtBoxMeslek.Clear();

        }   



        private void btnSıl_Click(object sender, EventArgs e)
        {
            

           


            try
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {


                    komut = new MySqlCommand("delete from hastabilgileri where TC like '" + maskedtxtBoxTC.Text + "'", baglanti);
                    reader.Close();
                    reader = komut.ExecuteReader();
                    MessageBox.Show("Başarıyla silindi.");

                    baglanti.Close();
                    reader.Close();

                }

                else
                {
                    MessageBox.Show("Böyle bir kayıt yok o yüzden silme yapılamaz!");

                }
                baglanti.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            baglanti.Close();

            

            maskedtxtBoxTC.Clear();
            txtBoxAdSoyad.Clear();
            richtxtBoxAdres.Clear();
            txtBoxYas.Clear();
            txtBoxMeslek.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokToplam();
        }

        private void StokToplam()
        {
            string result = "select sum(StokAdedi) from asidepobilgileri";
            using (MySqlCommand cmd = new MySqlCommand(result, baglanti))
            {
                try
                {
                    baglanti.Open();
                    lblAsiStok.Text = cmd.ExecuteScalar().ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {

                    baglanti.Close();
                }
            }

        }

        private void btnAsiicincagir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("select * from hastabilgileri where TC like '" + maskedtxtBoxTC.Text + "'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {

                    if (Convert.ToInt32(reader["AsiOlmaSayisi"].ToString())==2)
                    {
                        MessageBox.Show("Hasta 2 adet aşı olmuştur. Daha fazla aşı olamaz.");
                        

                    }
                    else if(Convert.ToInt32(reader["AsiOlmaSayisi"].ToString())==1)
                    {
                        komut = new MySqlCommand("update hastabilgileri set AsiyaCagir='" + 1 + "' where TC like " +
                     " '" + maskedtxtBoxTC.Text + "'", baglanti);

                        reader = komut.ExecuteReader();
                        
                        baglanti.Close();

                    }
                    else if (Convert.ToInt32(reader["AsiOlmaSayisi"].ToString()) == 0)
                    {
                        komut = new MySqlCommand("update hastabilgileri set AsiyaCagir='" + 1 + "' where TC like " +
                     " '" + maskedtxtBoxTC.Text + "'", baglanti);

                        reader = komut.ExecuteReader();

                        baglanti.Close();

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

        private void btnguncelleustu_Click(object sender, EventArgs e)
        {
            if (!(maskedtxtBoxTC.Text == "") && !(txtBoxAdSoyad.Text == "") && !(richtxtBoxAdres.Text == "") && !(txtBoxYas.Text == "") && !(txtBoxMeslek.Text == ""))
            {
                btnGuncelle_Click(sender, e);
            }
        }

        private void btnekleustu_Click(object sender, EventArgs e)
        {
            if (!(maskedtxtBoxTC.Text == "") && !(txtBoxAdSoyad.Text == "") && !(richtxtBoxAdres.Text == "") && !(txtBoxYas.Text == "") && !(txtBoxMeslek.Text == ""))
            {
                btnEkle_Click(sender, e);
            }
        }

        private void btnsilustu_Click(object sender, EventArgs e)
        {
            if (!(maskedtxtBoxTC.Text == "") && !(txtBoxAdSoyad.Text == "") && !(richtxtBoxAdres.Text == "") && !(txtBoxYas.Text == "") && !(txtBoxMeslek.Text == ""))
            {
                btnSıl_Click(sender, e);
            }
        }

        private void btnasioldu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("select * from hastabilgileri where TC like '" + maskedtxtBoxTC.Text + "'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    int i = Convert.ToInt32(reader["AsiOlmaSayisi"].ToString());

                    komut = new MySqlCommand("update hastabilgileri set AsiOlmaSayisi='" + i-- + "' where TC like " +
                        " '" + maskedtxtBoxTC.Text + "'", baglanti);
                    reader = komut.ExecuteReader();

                    baglanti.Close();

                }





             



                baglanti.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
