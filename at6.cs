using System;

class Program
{
 public static void Main()
    {
        float numb;
        Console.WriteLine("Digite um número decimal: ");
         numb = float.Parse(Console.ReadLine());
            
        if(numb == float.NaN)
        {
             Console.WriteLine("O número digitado foi: " + numb);
        }
        else {
            Console.WriteLine("Número inválido. Tente novamente.");
             }
    }
}