namespace ParcelasWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(ValorTextBox.Text);
            int parcelas = int.Parse(ParcelasTextBox.Text);

            CalcularParcelas(valor, parcelas);
        }

        void CalcularParcelas(double valor, int parcelas)
        {

            if (parcelas == 0 || parcelas == 1)
            {
                // 10% de desconto
                valor = valor * 0.9;
            }
            if (parcelas > 1 && parcelas <= 5)
            {
                // valor continua o msm
            }
            if (parcelas > 5)
            {
                // 7% de juros
                valor = valor * 1.07;
            }

            double valorP = valor / parcelas;

            for (int i = 0; i < parcelas; i++)
            {
                dataGridView1.Rows.Add((i+1)+"°",(valorP * (i + 1)).ToString("c"));
            }
            dataGridView1.Rows.Add("Total", valor.ToString("c"));
            
        }


    }

}