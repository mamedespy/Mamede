namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToDouble(textBox1.Text);
            Double valor2 = Convert.ToDouble(textBox2.Text);
            Double result = 0.0f;

            if (radioButton1.Checked)
                result = valor1 + valor2;
            if (radioButton2.Checked)
                result = valor1 - valor2;
            if (radioButton3.Checked)
                result = valor1 * valor2;
            if (radioButton4.Checked)
                result = valor1 / valor2;
            if (radioButton5.Checked)
                result = (valor1 + valor2) / 2;
            if (radioButton6.Checked)
                result = valor1 * valor1;
            label4.Text = "Resultado: " + result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soma o valor 1 com o valor 2", "Soma");
        }

        private void subtraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subtrai o valor 1 pelo valor 2", "Subtração");
        }

        private void multiplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multiplica o valor 1 pelo valor 2", "Multiplicação");
        }

        private void divisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Divide o valor 1 pelo valor 2", "Divisão");
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calcula a média dos 2 valores", "Média");
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calcula o Quadrado do valor 1. Mantenha o 0 no valor 2", "Quadrado");
        }
    }
}