using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma letra :");
        char letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Sua letra digitada foi: {0}",letra);
    }
}