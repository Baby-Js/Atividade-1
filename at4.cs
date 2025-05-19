using System;
using System.Runtime.Intrinsics.Arm;

class Quarto
{
    static void Main()
    {
       Console.WriteLine("Digite sim ou não");
        string resp = Console.ReadLine();
        if (resp == "sim")
        {
            Console.WriteLine("Você digitou sim");
        }
        else if (resp == "não" || resp == "nao")
        {
            Console.WriteLine("Você digitou não");
        }
        else
        {
            Console.WriteLine("Você digitou algo diferente de sim ou não");
        }
    }
}
