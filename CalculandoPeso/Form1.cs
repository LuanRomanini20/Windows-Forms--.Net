namespace CalculandoPeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(textBox1.Text);
            double altura = double.Parse(textBox2.Text);
            double calc = peso / (altura * altura);


            if (calc < 18.5)
            {
                MessageBox.Show("Abaixo do peso");

            }else if(calc >= 18.5 && calc <25){

                MessageBox.Show("Peso normal");

            }else if(calc >= 25 && calc < 30)
            {
                MessageBox.Show("Acima do peso");
            }
            else
            {
                MessageBox.Show("Obeso");
            }
        }
    }
}