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
    public partial class f17_firma_guncelle : Form
    {
        public f17_firma_guncelle()
        {
            InitializeComponent();
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_ana_menu ana_menu_formu = new f2_ana_menu();
            ana_menu_formu.Show();
            this.Hide();
        }

        private void f17_firma_guncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
