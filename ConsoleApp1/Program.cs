int[] vetor;
int i, numeros, soma_par = 0, quantidade_pares = 0;
double media;

Console.WriteLine("Digite o tamanho do vetor");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

Console.WriteLine($"Digite {numeros} números");
for (i = 0; i < numeros; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < numeros; i++)
{
    if (vetor[i] % 2 == 0)
    {
        soma_par += vetor[i];
        quantidade_pares++;
    }
}

if (quantidade_pares > 0)
{
    media = (double)soma_par / quantidade_pares;
    Console.WriteLine($"A média dos números pares é: {media}");
}
else
{
    Console.WriteLine("Não há números pares para calcular a média.");
}