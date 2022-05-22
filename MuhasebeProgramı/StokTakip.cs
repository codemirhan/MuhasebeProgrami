using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeProgramı
{
    public partial class StokTakip : Form
    {
        Form2 form2 = new Form2();
        public StokTakip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void StokTakip_Load(object sender, EventArgs e)
        {

        }
    }
}
