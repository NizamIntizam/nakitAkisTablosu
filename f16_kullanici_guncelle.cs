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
    public partial class f16_kullanici_guncelle : Form
    {

       
        
        public f16_kullanici_guncelle()
        {
            InitializeComponent();
        }
        static string baglanti_metni = "Data Source=DESKTOP-55SBJJL\\SQLEXPRESS;Initial Catalog=muhasebe;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(baglanti_metni);
        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }
        public void firma_bilgilerini_listele_fx()
        {
            
            SqlConnection baglanti = new SqlConnection(baglanti_metni);
            string sql_listeleme_komutu = "Select* from firmalar_tbl";
            SqlCommand sql_komut = new SqlCommand(sql_listeleme_komutu,baglanti);
            SqlDataAdapter data_adapter = new SqlDataAdapter(sql_komut);
            DataTable data_table = new DataTable();
            data_adapter.Fill(data_table);
            dataGridView1.DataSource = data_table;
            baglanti.Close();

        }
       

        private void Form16_Load(object sender, EventArgs e)
        {

            firma_bilgilerini_listele_fx();
        }





        int i1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string kayit_guncelle = "Update firmalar_tbl Set firma_unvan=@firma_unvan, firma_tel_no=@firma_tel_no," +
                "yetkili_ad_sad=@yetkili_ad_sad, yetkili_tel_no=@yetkili_tel_no where firma_id=@firma_id";
            SqlCommand sql_komut = new SqlCommand(kayit_guncelle, baglanti);
            baglanti.Open();
            sql_komut.Parameters.AddWithValue("@firma_unvan", textBox1.Text);
            sql_komut.Parameters.AddWithValue("@firma_tel_no", textBox2.Text);
            sql_komut.Parameters.AddWithValue("@yetkili_ad_sad", textBox3.Text);
            sql_komut.Parameters.AddWithValue("@yetkili_tel_no", textBox4.Text);
            sql_komut.Parameters.AddWithValue("@firma_id", dataGridView1.Rows[i1].Cells[0].Value);
            sql_komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi");
            baglanti.Close();
            firma_bilgilerini_listele_fx();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i1 = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i1].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i1].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i1].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i1].Cells[4].Value.ToString();
        }


    }
}
