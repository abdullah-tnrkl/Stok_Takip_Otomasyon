using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProjeStokTakip
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        StokHareket st = new StokHareket();

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {

            st.BackColor = Color.Red;
            DialogResult tus;
            tus = colorDialog1.ShowDialog();
            if (tus == DialogResult.OK)
            {
               
            }
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
