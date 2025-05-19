using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diga seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Diga sua idade:");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Olá {0} sua idade é: {1}", nome, idade);
    }
}