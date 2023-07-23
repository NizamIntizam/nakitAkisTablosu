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
    public partial class f18_tum_detaylar_listele : Form
    {
        public f18_tum_detaylar_listele()
        {
            InitializeComponent();
        }

        private void f18_tum_detaylar_listele_Load(object sender, EventArgs e)
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
