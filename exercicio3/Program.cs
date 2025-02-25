int[] vetorA;
int[] vetorB;
int[] vetorC;
int num_A,num_B,num_C,numeros,i;

Console.WriteLine("Digite a quantidade de numeros");
numeros = int.Parse(Console.ReadLine());
vetorA = new int[numeros];
vetorB = new int[numeros];
vetorC = new int[numeros];

for (i = 0; i < numeros; i++) 
{
    Console.WriteLine("Digite numeros para o vetor A");
    vetorA[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite numeros para o vetor B");
    vetorB[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite numeros para o vetor B");
    vetorC[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(vetorA);
Console.WriteLine(vetorB);
Console.WriteLine(vetorC);





