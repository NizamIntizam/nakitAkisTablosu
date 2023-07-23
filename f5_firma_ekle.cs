using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe_otomasyonu_31_05_Cars_14_51
{
    public partial class f5_firma_ekle : Form
    {
        public f5_firma_ekle()
        {
            InitializeComponent();
        }

        private void tekrarFirmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ResetText();

            textBox2.Clear();
            textBox2.ResetText();

            textBox3.Clear();
            textBox3.ResetText();

            textBox4.Clear();
            textBox4.ResetText();

           
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void f5_firma_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
