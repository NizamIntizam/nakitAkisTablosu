using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace muhasebe_otomasyonu_31_05_Cars_14_51
{
    public partial class f8_odeme_islemi_guncelle : Form
    {
        public f8_odeme_islemi_guncelle()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void tekrarTahsilatİşlemiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ResetText();
        }

        private void f8_odeme_islemi_guncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
