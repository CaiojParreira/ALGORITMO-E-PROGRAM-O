int[] vetorA;
int[] vetorB;
int[] vetorC;
int num_A,num_B,num_C,numeros,i,soma = 0;

Console.WriteLine("Digite a quantidade de numeros");
numeros = int.Parse(Console.ReadLine());
vetorA = new int[numeros];
vetorB = new int[numeros];
vetorC = new int[numeros];

Console.WriteLine($"Digite {numeros} para o vetor A");
for (i = 0; i < numeros; i++)
{
   
    vetorA[i] = int.Parse(Console.ReadLine()); 
}
Console.WriteLine($"Digite {numeros} para o vetor B");
for (i = 0;i < numeros; i++) 
{ 
    vetorB[i] = int.Parse(Console.ReadLine());
}

for (i = 0;i<numeros; i++)
{
    vetorC[i] = vetorA[i] + vetorB[i];

    Console.WriteLine("O Resultado das somas é ");
    Console.WriteLine(vetorC[i]);
}

















