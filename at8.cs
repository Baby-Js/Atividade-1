using System;

class Blabla
{
    static void Main(string[] args)
    {
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do desconto: ");
        double desconto = double.Parse(Console.ReadLine());
        double precoFinal = preco - (preco * desconto / 100);
        Console.WriteLine("O preço final do produto é: {0}",precoFinal);
    }
}