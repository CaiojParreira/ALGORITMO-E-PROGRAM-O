int[] vetor;
int i, numeros, pares;

Console.WriteLine("Digite a quantidade de numeros");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

Console.WriteLine($"Digite {numeros} numeros");
for (i = 0; i < numeros; i++)
{  
    vetor[i] = int.Parse(Console.ReadLine());
}
pares = 0;

Console.WriteLine("Os numeros pares são: ");
for (i = 0; i < numeros; i++)
{
    if (vetor[i] %2 ==0)
    {
        Console.WriteLine(vetor[i]);
        pares++;
    }
}
Console.WriteLine($"a quantidade de numeros pares é {pares}");
