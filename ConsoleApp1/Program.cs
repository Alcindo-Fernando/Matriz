int tamanho;
int soma;

Console.WriteLine("informe o tamanho da linha e coluna da matriz: ");
tamanho = int.Parse(Console.ReadLine());



int[,] m1 = new int[tamanho, tamanho];
void PopularMatriz()
{
    
    int contador = 0;

    for(int i = 0; i < tamanho; i++)
    {
        for(int j = 0; j < tamanho; j++)
        {

            Console.WriteLine($"informe a posição do {contador} da matriz");
            m1[i, j] = int.Parse(Console.ReadLine());

            contador++;
        }
    }
   
}

void SomarExibirLinha(int[,] matriz)
{
    for(int i = 0; i < tamanho; i++)
    {
        soma = 0;

        for(int j = 0; j < tamanho; j++)
        {
            soma += matriz[i, j];
        }

        Console.WriteLine($"Soma Linha {i} = {soma}");
    }
}

void SomarExibirColuna(int[,] matriz)
{

    for(int j = 0; j < tamanho; j++)
    {
        soma = 0;
        for(int i = 0; i < tamanho; i++)
        {

            soma += matriz[i, j];

        }

        Console.WriteLine($"Soma coluna {j} = {soma}");

    }

}

void SomarExibirDiagPrinc(int[,] matriz)
{
    soma = 0;

    for (int i = 0; i < tamanho; i++)
    {
        soma += matriz[i, i];

    }

    Console.WriteLine($"Soma da Diagonal Principal = {soma}" );

}

void SomarExibirDiagInv(int[,] matriz)
{
    soma = 0;
    for(int i = 0; i < tamanho; i++)
    {
        soma += matriz[i, (tamanho - 1) - i];
    }

    Console.WriteLine($"Soma da Diagonal Inversa = {soma}" );
  
}

PopularMatriz();
SomarExibirLinha(m1);
Console.WriteLine("----------");
SomarExibirColuna(m1);
Console.WriteLine("----------");
SomarExibirDiagPrinc(m1);
Console.WriteLine("----------");
SomarExibirDiagInv(m1);