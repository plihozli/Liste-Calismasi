namespace Liste_Calismasi
{
    public partial class Form1 : Form
    {
        List<string> isim = new List<string>();
        List<string> soyadý = new List<string>();
        List<string> meslek = new List<string>();
        string yazi = ("");
        int sayac = 0;
        int z = 0;
        int buyukluk = 0;
        int toplam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isim.Add(textBox1.Text);
            soyadý.Add(textBox2.Text);
            meslek.Add(textBox3.Text);
            sayac++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = z; i < sayac; i++)
            {
                yazi = isim[i] + soyadý[i] + meslek[i];
                comboBox1.Items.Add(yazi);
                listBox1.Items.Add(yazi);
            }
            z = sayac;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            isim.Clear();
            soyadý.Clear();
            meslek.Clear();
            sayac = 0;
            z = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string taha = textBox4.Text;
            int deger = isim.Where(taha => taha.Contains(listBox1.Text)).Count();

            MessageBox.Show("Burada " + deger + "taha degeri vardýr");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string taha = textBox4.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                buyukluk = listBox1.Items[0].ToString().Length;
                toplam = buyukluk + toplam;
            }
            MessageBox.Show("buyukluk" + toplam);
            int sinirlayici = textBox4.Text.Length;
            float space = toplam - sinirlayici + 1;
            float deger = isim.Where(taha => taha.Contains(listBox1.Text)).Count();
            MessageBox.Show("sdf" + deger);
            float olasýlýk = 100 * (deger / space);
            textBox5.Text = Convert.ToString(olasýlýk);
            toplam = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}