using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.Write("Informe quantos números você deseja inserir: ");
        int j = int.Parse(Console.ReadLine());

        int[] numero1 = new int[j]; 

        for (int i = 0; i < j; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            numero1[i] = int.Parse(Console.ReadLine());
        }

        var ordenadoDesc = numero1.OrderByDescending(n => n).ToArray();

        Console.WriteLine("\nNúmeros em ordem decrescente: " + string.Join(", ", ordenadoDesc));
        Console.ReadKey();
    }
}
