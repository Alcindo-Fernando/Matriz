int linha, coluna;

Console.WriteLine("infomre a linha da matriz: ");
linha = int.Parse(Console.ReadLine());
Console.WriteLine("Infrome a coluna da matriz: ");
coluna = int.Parse(Console.ReadLine());

int[,] m1 = new int[linha, coluna];

void popularMatriz()
{
    int contador = 1;

    for(int i = 0; i < linha; i++)
    {
        for(int j = 0; j < coluna; j++)
        {

            m1[i, j] = contador;


            contador++;

        }
    }

}


void ExibirMatriz(int[,] matriz)
{

    for(int i = 0; i < linha; i++)
    {
        for(int j = 0; j < coluna; j++)
        {
            Console.WriteLine($"[{matriz[i, j]}]");
        }
    }
}


void ExibirInvertido(int[,] matriz)
{
    for(int i = linha - 1; i >= 0; i--)
    {
        for(int j = coluna-1; j >= 0; j--)
        {
            Console.WriteLine($"[{matriz[i,j]}]");
        }
    }
}

popularMatriz();

ExibirMatriz(m1);

Console.WriteLine("-------------------");

ExibirInvertido(m1);