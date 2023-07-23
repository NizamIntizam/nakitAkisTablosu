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
    public partial class f19_akis_islemleri_listele : Form
    {
        public f19_akis_islemleri_listele()
        {
            InitializeComponent();
        }

        private void anaMenüyeGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu f2_Ana_Menu = new f2_ana_menu();
            f2_Ana_Menu.Show();
            this.Hide();
        }
    }
}
