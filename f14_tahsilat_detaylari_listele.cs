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
    public partial class f14_tahsilat_detaylari_listele : Form
    {
        public f14_tahsilat_detaylari_listele()
        {
            InitializeComponent();
        }


        private void f14_tahsilat_detaylari_listele_Load(object sender, EventArgs e)
        {

        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu f2_Ana_Menu = new f2_ana_menu();
            f2_Ana_Menu.Show();
            this.Hide();
        }
    }
}
