Console.WriteLine("Bem vindo ao programa que calcula a sequência de Fibonacci! Informe a quantidade de números da sequência: ");
int quantRep = int.Parse(Console.ReadLine());
int[] numeros = new int[quantRep];
numeros[0] = 0;
numeros[1] = 1;
int fibonacci;
Console.Write($"{numeros[0]}, ");
Console.Write($"{numeros[1]}, ");
for(int i = 2; i < quantRep; i++){
  fibonacci = numeros[i-1] + numeros[i-2];
  Console.Write($"{fibonacci}, ");
  numeros[i] = fibonacci;
}
