int[] vetor;
int i,numeros;

Console.WriteLine("Digite o tamanho do vetor");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

Console.WriteLine($"Digite {numeros}");
for (i = 0; i < numeros; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());
}