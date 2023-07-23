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
    public partial class f7_odeme_islemi_ekle : Form
    {
        public f7_odeme_islemi_ekle()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void ödemeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ResetText();
        }

        private void f7_odeme_islemi_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
