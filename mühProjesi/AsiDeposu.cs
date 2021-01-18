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
    public partial class AsiDeposu : Form
    {
        public AsiDeposu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        public String gelen; 

        private void AsiDeposu_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";           
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "mühprojesi";
            baglanti = new MySqlConnection(build.ToString());

            txtBoxyetkiliTC.Text = gelen;

            //lblStok.Text = "";


           
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("select * from asidepoyetkilibilgileri where TC like '" + txtBoxyetkiliTC.Text + "'", baglanti);
            MySqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                lblyetkiliTC.Text= reader["TC"].ToString();
                lblyetkiliAdSoyad.Text= reader["AdSoyad"].ToString();
                lblYetkiliMevki.Text= reader["BulunduğuİşMevki"].ToString();





               


            }
            
            baglanti.Close();
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)//güncelle butonu
        {
            /*
            try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("update asidepobilgileri set StokAdedi='" + txtBoxStokAdedi.Text + "', EklemeTarihi='" + maskedtxtBoxTarih.Text + "' where StokID like " +
                    " '" + txtBoxID.Text + "'", baglanti);

                MySqlDataReader reader = komut.ExecuteReader();
                MessageBox.Show("Başarıyla güncellendi.");

                baglanti.Close();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            StokToplam();

            txtBoxID.Text = "";
            txtBoxStokAdedi.Text = "";
            maskedtxtBoxTarih.Text = "";
            //StokDurumu();

            */


            try
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select * from asidepobilgileri where StokID like '" + txtBoxID.Text + "'", baglanti);

               
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    komut = new MySqlCommand("update asidepobilgileri set StokAdedi='" + txtBoxStokAdedi.Text + "', EklemeTarihi='" + maskedtxtBoxTarih.Text + "' where StokID like " +
                                   " '" + txtBoxID.Text + "'", baglanti);
                    reader.Close();           
                    reader = komut.ExecuteReader();
                    MessageBox.Show("Başarıyla güncellendi.");

                    reader.Close();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Böyle bir Stok ID bulunamadı!");
                }

                baglanti.Close();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            baglanti.Close();
            StokToplam();

            txtBoxID.Text = "";
            txtBoxStokAdedi.Text = "";
            maskedtxtBoxTarih.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)//ekle butonu
        {           

            try
            {

                baglanti.Open();
                //MySqlDataAdapter adapter = new MySqlDataAdapter("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                MySqlCommand komut = new MySqlCommand("select *from asidepobilgileri where StokID like '%" + txtBoxID.Text + "%'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Bu Stok ID ile farklı bir stok zaten var. Farklı bir Stok ID kullanınız.");

                }

                else
                {
                    try
                    {
                        reader.Close();
                        komut = new MySqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "insert into asidepobilgileri (StokID, YetkiliTC, StokAdedi, EklemeTarihi) values ('" + txtBoxID.Text + "', '" + txtBoxyetkiliTC.Text + "', '" + txtBoxStokAdedi.Text + "','" + maskedtxtBoxTarih.Text + "') ";
                        komut.ExecuteNonQuery();

                       


                        MessageBox.Show("Başarıyla eklendi.");

                        baglanti.Close();
                        reader.Close();
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                baglanti.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            baglanti.Close();
            
            StokToplam();

            txtBoxID.Text = "";
            txtBoxStokAdedi.Text = "";
            maskedtxtBoxTarih.Text = "";


            //StokDurumu();
        } 

        private void button3_Click(object sender, EventArgs e)//sil butonu
        {
           /* try
            {
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("delete from asidepobilgileri where StokID like '" + txtBoxID.Text + "'", baglanti);

                MySqlDataReader reader = komut.ExecuteReader();
                MessageBox.Show("Başarıyla silindi.");

                baglanti.Close();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
            //txtBoxID.Text = "";
            //txtBoxStokAdedi.Text = "";
            //maskedtxtBoxTarih.Text = "";






            try
            {

                baglanti.Open();
                //MySqlDataAdapter adapter = new MySqlDataAdapter("select *from hastabilgileri where TC like '%" + maskedtxtBoxTC.Text + "%'", baglanti);
                MySqlCommand komut = new MySqlCommand("select *from asidepobilgileri where StokID like '%" + txtBoxID.Text + "%'", baglanti);
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    

                    komut = new MySqlCommand("delete from asidepobilgileri where StokID like '" + txtBoxID.Text + "'", baglanti);
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
            


            txtBoxID.Text = "";
            txtBoxStokAdedi.Text = "";
            maskedtxtBoxTarih.Text = "";






            StokToplam();


            //StokDurumu();
        }

        /*public void StokDurumu()
        {
            baglanti.Open();
           
            MySqlCommand komut = new MySqlCommand("select sum(StokAdedi) from asidepobilgileri ", baglanti);
           // MySqlDataReader reader = komut.ExecuteReader();
            MySqlDataAdapter adapter;
            komut.Connection = baglanti;
            komut.CommandText = "select sum(StokAdedi) from asidepobilgileri ";
            adapter =new MySqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if(dataTable.Rows.Count >0  )
            {
                //lblStok.Text = dataTable.;
            }
        




            //lblStok.Text = reader["StokAdedi"].ToString();
            //while (reader.Read())
            //{
            //stok += Convert.ToDouble(reader["StokAdedi"].ToString());

            //lblStok.Text=komut.ExecuteScalar().ToString();


            //string query = "select sum(StokAdedi) from asidepobilgileri ";
            //using (System.Data.IDbCommand command = new System.Data.OleDb.OleDbCommand(query))
            //{
            //  object result = command.ExecuteScalar();
            //lblStok.Text = Convert.ToString(result);
            //}


            //lblStok.Text = reader["StokAdedi"].ToString();
            
            if (Convert.ToDouble(reader["StokAdedi"].ToString()) > 0)
            {
                lblStok.Text = reader["StokAdedi"].ToString();
            }
            else if (Convert.ToDouble(reader["StokAdedi"].ToString()) == 0)
            {
                lblStok.Text = "Stokta aşı yok.";
            }
            else
            {

                MessageBox.Show("Oops! Aşı stoğunda bir problem var! Aşı deposuyla iletişime geçiniz.");

            }
            //}
            baglanti.Close();
        }*/

        private void btnStok_Click(object sender, EventArgs e)
        {
            //StokDurumu();

            //lblStok.Text = StokToplam();
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
                     lblStok.Text= cmd.ExecuteScalar().ToString();

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

        private void btnBos_Click(object sender, EventArgs e)
        {
            if(!(txtBoxID.Text == "") && !(txtBoxStokAdedi.Text=="") && !(maskedtxtBoxTarih.Text=="") )
            {
                button2_Click(sender,e);
            }

            
        }

        private void btnekleustu_Click(object sender, EventArgs e)
        {
            if (!(txtBoxID.Text == "") && !(txtBoxStokAdedi.Text == "") && !(maskedtxtBoxTarih.Text == ""))
            {
                button1_Click(sender, e);
            }
        }

        private void btnsilustu_Click(object sender, EventArgs e)
        {
            if (!(txtBoxID.Text == "") && !(txtBoxStokAdedi.Text == "") && !(maskedtxtBoxTarih.Text == ""))
            {
                button3_Click(sender, e);
            }
        }
    }
}
