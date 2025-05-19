using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        int quant = palavra.Length;

        Console.WriteLine("A palavra {0} tem {1} letras", palavra, quant);

    }
}
