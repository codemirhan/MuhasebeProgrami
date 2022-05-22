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
    public partial class Form2 : Form
    {
      
        
         
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokTakip stokTakip = new StokTakip();
            stokTakip.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariIslem cariIslem = new CariIslem();
            cariIslem.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ajanda ajanda = new Ajanda();
            ajanda.Show();
            this.Hide();
        }
    }
}
