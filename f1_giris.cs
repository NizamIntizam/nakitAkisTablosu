using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyonu_31_05_Cars_14_51
{
    public partial class f1_giris : Form
    {
        public f1_giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string baglanti_ayar_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
            string sql_komut_metni = "Select * From kullanicilar_tbl";
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglanti_ayar_metni))
                {
                    using (SqlCommand sql_komut = new SqlCommand(sql_komut_metni, baglanti))
                    {
                        baglanti.Open();
                        SqlDataReader veri_okuyucu = sql_komut.ExecuteReader();

                        while (veri_okuyucu.Read())
                        {
                            comboBox1.Items.Add(veri_okuyucu["kullanici_adi"].ToString());
                        }
                        veri_okuyucu.Close();
                    }
                }
            }



            catch (Exception hata_mesaji)
            {
                MessageBox.Show("Veritabanı Bağlantı Hatası: " + hata_mesaji.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilen_kullanici_adi = comboBox1.Text.ToString();
            string girilen_sifre = textBox1.Text;

            string baglanti_ayar_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
            string sql_komut_metni = "Select * From kullanicilar_tbl  WHERE kullanici_adi = @kullanici_adi AND kullanici_sifre = @kullanici_sifre";


            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglanti_ayar_metni))
                {
                    using (SqlCommand yeni_komut = new SqlCommand(sql_komut_metni, baglanti))
                    {
                        yeni_komut.Parameters.AddWithValue("@kullanici_adi", secilen_kullanici_adi);
                        yeni_komut.Parameters.AddWithValue("@kullanici_sifre", girilen_sifre);

                        baglanti.Open();
                        SqlDataReader veri_okuyucu = yeni_komut.ExecuteReader();

                        if (veri_okuyucu.HasRows)
                        {

                            f2_ana_menu ana_form = new f2_ana_menu();
                            ana_form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifreniz Hatalı, Lütfen Tekrar Giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Clear();



                        }
                        baglanti.Close();
                    }
                }


            }
            catch (Exception hata_mesaji)
            {
                //MessageBox.Show("Veritabanı Bağlantı Hatası: " + hata_mesaji.Message);
                MessageBox.Show("Veritabanı Bağlantı Hatası","Hata Mesajı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
