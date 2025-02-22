int[] vetor;
int i, maior_numero, numeros,posicao;

Console.WriteLine("Digite o tamanho do vetor");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

for (i = 0; i < numeros; i++)
{
    Console.WriteLine($"Digite {numeros} numeros");
    vetor[i] = int.Parse(Console.ReadLine());   
}
maior_numero = vetor[0];
posicao = 0;

for (i = 1; i < numeros; i++)
{
    if (vetor[i] > maior_numero)
        maior_numero = vetor[i];
        posicao = i;
}


Console.WriteLine($"O maior numero é {maior_numero} na posição {posicao}");

