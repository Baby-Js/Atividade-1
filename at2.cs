using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número real: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        Console.Write("O número real foi: {0}",numero);
    }
}