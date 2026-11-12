int linha = 3;
int coluna = 5;

int[,] m1 = new int[linha,coluna];
int[,] matrizInvertida = new int[linha, coluna];
void PopularMatriz(int[,] matriz)
{
    int contador = 1;
    for(int i = 0;  i < linha; i++)
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

    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.Write($"[{matriz[i, j]}]");
        }

        Console.WriteLine("\n");
    }
}

void GerarNovaMatriz(int[,] matriz)
{
    int contadorLinha = 0;
    int contadorColuna = 0;

    for(int i = linha-1; i >= 0; i--)
    {
        contadorColuna = 0;
        for(int j = coluna - 1; j >= 0; j--)
        {
           
            
            matrizInvertida[contadorLinha, contadorColuna] = matriz[i, j];
            contadorColuna++;
        }
        contadorLinha++;
    }

}

PopularMatriz(m1);

GerarNovaMatriz(m1);

ExibirMatriz(m1);

Console.WriteLine("---------------");

ExibirMatriz(matrizInvertida);
