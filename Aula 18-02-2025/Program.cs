int[] vetor;
int i, maior_numero, numeros;

Console.WriteLine("Digite o tamanho do vetor");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

for (i = 0; i < numeros; i++)
{
    Console.WriteLine($"Digite {numeros} numeros");
    vetor[i] = int.Parse(Console.ReadLine());   
}
maior_numero = Math.Max();

Console.WriteLine($"O maior numero é {maior_numero}");

