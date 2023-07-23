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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace muhasebe_otomasyonu_31_05_Cars_14_51
{
    public partial class f9_odeme_isl_sil : Form
    {
        public f9_odeme_isl_sil()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void tekrarÖdemeİşlemiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.ResetText();
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

        string baglanti_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
        private void Form9_Load(object sender, EventArgs e)
        {
           
            odeme_islemleri_goruntule();
        }

        private void anaMenüyeGitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu=new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }
    }
}
