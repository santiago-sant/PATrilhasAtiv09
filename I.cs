using System;
using System.Linq;


class Program
{
    public static void Main()
    {
      

        string[] nomes = new string[10];
       
        for (int i = 0; i < 10; i++)
        {

            Console.Write($"Insira o {i + 1}º nome: ");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("OS nomes digitados foram: ");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

        Console.ReadKey();
    }
}
