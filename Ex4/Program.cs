string[,] boletim = new string[4, 7];

boletim[0, 0] = "Mat";
boletim[1, 0] = "Port";
boletim[2, 0] = "Art";
boletim[3, 0] = "Qui";

int contadorMateria = 0;
int contadorNota; ;
float soma;
float media;

for (int i = 0; i < 4; i++)
{
    soma = 0;
    media = 0;
    float nota = 0;
    contadorNota = 1;
    for(int j = 1; j < 5; j++)
    {
        Console.WriteLine($"adicione a nota {contadorNota} da matéria {boletim[contadorMateria,0]}: ");
        nota = float.Parse(Console.ReadLine());

        soma += nota;

        boletim[i, j] = nota.ToString();


        contadorNota++;

    }

    media = soma / 4;
    if(media < 4)
    {
        boletim[i, 6] = "Reprovado!";
    } else if(media > 4 || media < 7)
    {
        boletim[i, 6] = "Recuperação!";
    }
    else
    {
        boletim[i, 6] = "Aprovado!";

    }

    boletim[i, 5] = media.ToString();


    contadorMateria++;
}

void ExibirMatriz(string[,] matriz)
{

    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < 7; j++)
        {
            Console.Write($"[{matriz[i, j]}]\t");
        }

        Console.WriteLine();

    }

}

ExibirMatriz(boletim);