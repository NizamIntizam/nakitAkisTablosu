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
    public partial class f4_kullanici_sil : Form
    {
        string baglanti_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";

        public f4_kullanici_sil()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            kullanici_adlarini_goruntule();
            SqlConnection baglanti;
            string sorgu_metni;
            SqlCommand sql_komutu;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni = "SELECT * FROM kullanicilar_tbl where kullanici_rol_id=1 ";
            sql_komutu = new SqlCommand(sorgu_metni, baglanti);
            SqlDataReader reader = sql_komutu.ExecuteReader();
            while (reader.Read())
            {

                string veri = reader.GetString(1); // 0, kolon indeksini temsil eder
                comboBox2.Items.Add(veri);

            }

            reader.Close();
            baglanti.Close();
        }

        public void kullanici_adlarini_goruntule()
        {
            SqlConnection baglanti;
            string sorgu_metni;
            SqlCommand sql_komutu;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni = "SELECT * FROM kullanicilar_tbl where kullanici_id>1";
            sql_komutu = new SqlCommand(sorgu_metni, baglanti);
            SqlDataReader reader = sql_komutu.ExecuteReader();
            while (reader.Read())
            {

                string veri = reader.GetString(1); // 0, kolon indeksini temsil eder
                comboBox1.Items.Add(veri);

            }

            reader.Close();
            baglanti.Close();
        }

        

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //textBox1.ResetText();

            comboBox1.Items.Clear();
            comboBox1.ResetText();

            kullanici_adlarini_goruntule();
        }

        private void sorgu_part_1()
        {
            SqlConnection baglanti;
            string sorgu_metni;
            SqlCommand sql_komutu;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni = "SELECT * FROM kullanicilar_tbl where kullanici_id>1";
            sql_komutu = new SqlCommand(sorgu_metni, baglanti);
            SqlDataReader reader = sql_komutu.ExecuteReader();

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Sileceğiniz Kullanıcı Adını Seçmelisiniz!", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // 
            //string selectedData = comboBox1.SelectedItem.ToString();

            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Kullanıcı Adınızı Seçmelisiniz!", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Şifrenizi Giriniz", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            reader.Close();
        }

        private void sorgu_part_2()
        {
            string yoneticinin_kullanici_adi =comboBox2.SelectedText;
            //comboBox2.Text = yoneticinin_kullanici_adi;
            //yoneticinin_kullanici_adi=comboBox2.SelectedItem.ToString();
            string forma_yazilan_sifre = textBox2.Text;


            SqlConnection baglanti;
            string sorgu_metni2;
            SqlCommand sql_komutu2;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni2 = "SELECT * FROM kullanicilar_tbl where kullanici_sifre='" + forma_yazilan_sifre + "AND kullanici_adi="
                + yoneticinin_kullanici_adi + "'";
            sql_komutu2 = new SqlCommand(sorgu_metni2, baglanti);
            SqlDataReader reader2 = sql_komutu2.ExecuteReader();

            if (!reader2.Read())
            {
                MessageBox.Show("Şifrenizi eksik yada yanlış girdiniz", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
                sorgu_part_1();
                sorgu_part_2();
   
        }
    }
}
