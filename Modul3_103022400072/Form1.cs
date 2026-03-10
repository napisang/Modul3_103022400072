namespace Modul3_103022400072
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (satuanawal.SelectedIndex == -1 || satuanakhir.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (!double.TryParse(nilaiawal.Text, out double nilai))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double hasil = KonversiSuhu(nilai, satuanawal.Text, satuanakhir.Text);
            nilaiawal.Text = hasil.ToString("F2");
        }
        private double KonversiSuhu(double nilai, string dari, string ke)
        {
            double celcius;
            switch (dari)
            {
                case "celcius": celcius = nilai; break;
                case "fahrenheit": celcius = (nilai - 32) * 5 / 9; break;
                case "kelvin": celcius = nilai - 273; break;
                case "reamur": celcius = nilai * 5 / 4; break;
                default: celcius = nilai; break;
            }

            switch (ke)
            {
                case "celcius": return celcius;
                case "fahrenheit": return celcius * 9 / 5 + 32;
                case "kelvin": return celcius + 273;
                case "reamur": return celcius * 4 / 5;
                default: return celcius;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void satuanakhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
