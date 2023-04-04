namespace Equacao_Segundo_Grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if(delta < 0)
            {
                MessageBox.Show("A equação não possui raizes reais.");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta))/ (2*a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                MessageBox.Show($"Delta: {delta}, x1: {x1}, x2: {x2}");
                
            }
        }

        
    }
}