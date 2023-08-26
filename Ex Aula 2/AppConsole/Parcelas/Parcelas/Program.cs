double valor = double.Parse(Console.ReadLine());
int parcelas = int.Parse(Console.ReadLine());

calcularParcelas(valor, parcelas);

void calcularParcelas (double valor, int parcelas) {

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
    mostrarValores(valor, parcelas);
}

void mostrarValores (double valor, int parcelas) {
    double valorP = valor / parcelas;
    for (int i = 0; i < parcelas; i++)
    {
        Console.WriteLine("parcela " + (i + 1) + "° : " + (valorP * (i + 1)).ToString("c"));
    }
    Console.WriteLine("valor final: " + valor.ToString("c"));
}




