namespace MuhasebeProgramı
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullanici == "emirhan" && sifre == "123")
            {
                MessageBox.Show("Giriş \nİşlemi başarıLI", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş \nİşlemi başarısız", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}