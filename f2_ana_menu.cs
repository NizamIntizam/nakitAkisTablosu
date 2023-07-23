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
    public partial class f2_ana_menu : Form
    {

        string baglanti_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
        public f2_ana_menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            firma_adlari_goruntule();
            odeme_islemleri_goruntule();
            tahsilat_islemleri_goruntule();
        }


        public void firma_adlari_goruntule()
        {
            SqlConnection baglanti;
            string sorgu_metni;
            SqlCommand sql_komutu;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni = "SELECT * FROM firmalar_tbl";
            sql_komutu = new SqlCommand(sorgu_metni, baglanti);
            SqlDataReader reader = sql_komutu.ExecuteReader();
            while (reader.Read())
            {

                //string veri = reader.GetString(4); // 0, kolon indeksini temsil eder
                //comboBox1.Items.Add(veri);

                string firma_adlari = reader.GetString(1);
                //string firma_adlari = Convert.ToString(reader.GetString(4));
                comboBox1.Items.Add(firma_adlari); 

            }

            reader.Close();
            baglanti.Close();
        }

        public void odeme_islemleri_goruntule()
        {
            SqlConnection baglanti1;
            string sorgu_metni1;
            SqlCommand sql_komutu1;
            baglanti1 = new SqlConnection(baglanti_metni);
            baglanti1.Open();
            sorgu_metni1 = "SELECT * FROM odeme_islemleri_tbl";
            sql_komutu1 = new SqlCommand(sorgu_metni1, baglanti1);
            SqlDataReader reader1 = sql_komutu1.ExecuteReader();
            while (reader1.Read())
            {

                string veri = reader1.GetString(1); // 0, kolon indeksini temsil eder
                comboBox2.Items.Add(veri);

            }

            reader1.Close();
            baglanti1.Close();
        }


        public void tahsilat_islemleri_goruntule()
        {
            SqlConnection baglanti2;
            string sorgu_metni2;
            SqlCommand sql_komutu2;
            baglanti2 = new SqlConnection(baglanti_metni);
            baglanti2.Open();
            sorgu_metni2 = "SELECT * FROM tahsilat_islemleri_tbl";
            sql_komutu2 = new SqlCommand(sorgu_metni2, baglanti2);
            SqlDataReader reader2 = sql_komutu2.ExecuteReader();
            while (reader2.Read())
            {

                string veri = reader2.GetString(1); // 0, kolon indeksini temsil eder
                comboBox3.Items.Add(veri);

            }

            reader2.Close();
            baglanti2.Close();
        }

   

        private void kullanıcıEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f3_kullanici_ekle kullanici_ekleme_formu = new f3_kullanici_ekle();
            kullanici_ekleme_formu.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            f3_kullanici_ekle kullanici_ekleme_formu = new f3_kullanici_ekle();
            kullanici_ekleme_formu.Show();
            this.Hide();
        }

        private void kullanıcıSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f4_kullanici_sil kullanici_silme_formu = new f4_kullanici_sil();
            kullanici_silme_formu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f4_kullanici_sil kullanici_silme_formu = new f4_kullanici_sil();
            kullanici_silme_formu.Show();
            this.Hide();
        }

        private void firmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5_firma_ekle firma_ekleme_formu=new f5_firma_ekle();
            firma_ekleme_formu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f5_firma_ekle firma_ekleme_formu = new f5_firma_ekle();
            firma_ekleme_formu.Show();
            this.Hide();
        }

        private void firmaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6_firma_sil firma_silme_formu = new f6_firma_sil();
            firma_silme_formu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f6_firma_sil firma_silme_formu = new f6_firma_sil();
            firma_silme_formu.Show();
            this.Hide();
        }


        private void tahsilatDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14_tahsilat_detaylari_listele tahsilat_detaylari_listeleme_formu = new f14_tahsilat_detaylari_listele();
            tahsilat_detaylari_listeleme_formu.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f11_tahsilat_islemi_sil tahsilat_detaylari_formu = new f11_tahsilat_islemi_sil();
            tahsilat_detaylari_formu.Show();
            this.Hide();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            f13_tahsilat_islemi_guncelle tum_detaylar_formu = new f13_tahsilat_islemi_guncelle();
            tum_detaylar_formu.Show();
            this.Hide();
        }

        private void tümDetaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f18_tum_detaylar_listele tum_detaylari_listele_formu=new f18_tum_detaylar_listele();
            tum_detaylari_listele_formu.Show();
            this.Hide();
        }

        private void ödemeDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f15_odeme_detaylari_listele odeme_detaylari_listeleme_formu=new f15_odeme_detaylari_listele();
            odeme_detaylari_listeleme_formu.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            f14_tahsilat_detaylari_listele nakit_odemeler_formu = new f14_tahsilat_detaylari_listele();
            nakit_odemeler_formu.Show();
            this.Hide();
        }

        private void firmaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f21_firma_bilgileri_listeleme firma_bilgileri_listele_formu = new f21_firma_bilgileri_listeleme();
            firma_bilgileri_listele_formu.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f15_odeme_detaylari_listele firma_bilgileri_formu = new f15_odeme_detaylari_listele();
            firma_bilgileri_formu.Show();
            this.Hide();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            firma_adlari_goruntule();
        }

        private void kullanıcıBilgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f16_kullanici_guncelle kul_bilg_guncelleme_formu=new f16_kullanici_guncelle();
            kul_bilg_guncelleme_formu.Show();
            this.Hide();
        }

        private void firmaBilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f17_firma_guncelle firma_bilgileri_guncelle_formu=new f17_firma_guncelle();
            firma_bilgileri_guncelle_formu.Show();
            this.Hide();
        }


        private void tümİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void firmaKârZararDurumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f20_firma_durumlari firma_Durumlari_formu=new f20_firma_durumlari();
            firma_Durumlari_formu.Show();
            this.Hide();
        }

        private void firmaNakitÖdemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f19_akis_islemleri_listele tum_islemler_formu=new f19_akis_islemleri_listele();
            tum_islemler_formu.Show();
            this.Hide();
        }


        private void nakitTahsilatİşlemiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f11_tahsilat_islemi_sil tahsilat_islemi_silme_formu = new f11_tahsilat_islemi_sil();
            tahsilat_islemi_silme_formu.Show();
            this.Hide();
        }

        private void nakitTahsilatİşlemiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f12_tahsilat_islemi_ekle tahsilat_islemi_ekleme_formu = new f12_tahsilat_islemi_ekle();
            tahsilat_islemi_ekleme_formu.Show();
            this.Hide();
        }

        private void nakitTahsilatİşlemiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f13_tahsilat_islemi_guncelle tahsilat_islemi_guncelle_formu = new f13_tahsilat_islemi_guncelle();
            tahsilat_islemi_guncelle_formu.Show();
            this.Hide();
        }

        private void nakitÖdemeİşlemiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9_odeme_isl_sil odeme_islemi_silme_formu = new f9_odeme_isl_sil();
            odeme_islemi_silme_formu.Show();
            this.Hide();
        }

        private void nakitÖdemeİşlemiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7_odeme_islemi_ekle odeme_islemi_ekleme_formu = new f7_odeme_islemi_ekle();
            odeme_islemi_ekleme_formu.Show();
            this.Hide();
        }

        private void nakitÖdemeİşlemiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8_odeme_islemi_guncelle odeme_islemi_guncelle = new f8_odeme_islemi_guncelle();
            odeme_islemi_guncelle.Show();
            this.Hide();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10_kullanici_bilgileri_listele kullanici_Bilgileri_Listele= new f10_kullanici_bilgileri_listele();
            kullanici_Bilgileri_Listele.Show();
            this.Hide();
        }
    }
}
