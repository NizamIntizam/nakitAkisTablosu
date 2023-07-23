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
    public partial class f3_kullanici_ekle : Form
    {

        string baglanti_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
        public f3_kullanici_ekle()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu=new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            kullanici_rollerini_goruntule();
        }

        public void kullanici_rollerini_goruntule()
        {
            SqlConnection baglanti;
            string sorgu_metni;
            SqlCommand sql_komutu;
            baglanti = new SqlConnection(baglanti_metni);
            baglanti.Open();
            sorgu_metni = "SELECT * FROM kullanici_rol_tbl";
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

        private void yeniKullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox1.ResetText();
            
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            

            textBox2.Clear();
            textBox2.ResetText();

            textBox3.Clear();
            textBox3.ResetText();

            textBox4.Clear();
            textBox4.ResetText();

            kullanici_rollerini_goruntule();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
