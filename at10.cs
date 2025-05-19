using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome da sua rua: ");
        string nomeRua = Console.ReadLine();
        Console.Write("Digite o número da sua casa: ");
        int numeroCasa = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome da seu bairro: ");
        string nomeBairro = Console.ReadLine();
        Console.Write("Digite o nome da sua cidade: ");
        string nomeCidade = Console.ReadLine();
        Console.Write("Digite o nome do seu estado: ");
        string nomeEstado = Console.ReadLine();

        Console.WriteLine("Você mora na rua {0}, casa {1}- {2}, cidade {3} - estado {4}",nomeRua,numeroCasa,nomeBairro,nomeCidade,nomeEstado);
    }
}
