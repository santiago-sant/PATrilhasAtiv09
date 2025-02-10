class Program
{
    public static void Main()
    {
        int[] numero1 = new int[5];
        int[] numero2 = new int[5];
        int[] soma = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Insira o {i + 1}º número do primeiro conjunto: ");
            numero1[i] = int.Parse(Console.ReadLine());

            Console.Write($"Insira o {i + 1}º número do segundo conjunto: ");
            numero2[i] = int.Parse(Console.ReadLine());

            soma[i] = numero1[i] + numero2[i];
        }

        Console.WriteLine("A soma dos vetores é: " + string.Join(", ", soma));
        Console.ReadKey();
    }
}
