
using System;
using System.Linq;

class Program
{
    public static void Main()
    {
    	int [] numero1 = new int[5];
    	int [] numero2 = new int[5];
    	int [] soma = new int[5] 
    		
    		for (int i = 0; i > 5; i++)
    	{
        Console.Write("Quantos números você deseja inserir? ");
        numero[i] Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Quantos números você deseja inserir? ");
        int quantidade = Convert.ToInt32(Console.ReadLine())


        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número atual é maior que o maior número encontrado até agora
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Console.WriteLine("O maior número inserido foi: " + maiorNumero);
        Console.ReadKey();
    }
}
