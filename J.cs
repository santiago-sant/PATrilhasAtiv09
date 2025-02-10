using System;
using System.Linq;

class Program
{
    public class Mercadoria
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public static double CalcularPrecoTotal(Mercadoria[] array)
        {
            return array.Sum(m => m.Preco * m.Quantidade);
        }
    }

    public static Mercadoria[] CadastroMercadorias()
    {
        Mercadoria[] produtos = new Mercadoria[40];
        int contador = 0;

        while (contador < 40)
        {
            Console.WriteLine("Informe o nome do produto:");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome)) continue;

            Console.WriteLine($"Informe o preço do {nome}:");
            if (!double.TryParse(Console.ReadLine(), out double preco))
            {
                Console.WriteLine("Preço inválido. Tente novamente.");
                continue;
            }

            Console.WriteLine($"Informe a quantidade do {nome}:");
            if (!int.TryParse(Console.ReadLine(), out int quantidade))
            {
                Console.WriteLine("Quantidade inválida. Tente novamente.");
                continue;
            }

            produtos[contador++] = new Mercadoria { Nome = nome, Preco = preco, Quantidade = quantidade };

            Console.WriteLine("Deseja continuar? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") break;
        }

        return produtos.Take(contador).ToArray();
    }

    public static void Main(string[] args)
    {
        Mercadoria[] produtos = new Mercadoria[0];
        int opcao;

        do
        {
            Console.WriteLine("====================== OPÇÕES ======================");
            Console.WriteLine("1_ Cadastrar mercadorias");
            Console.WriteLine("2_ Preço total em mercadoria da empresa");
            Console.WriteLine("3_ Sair");
            Console.WriteLine("Digite o numero da opção que deseja:");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    produtos = CadastroMercadorias();
                    break;
                case 2:
                    double precoTotal = Mercadoria.CalcularPrecoTotal(produtos);
                    Console.WriteLine($"Valor total em mercadorias: {precoTotal:F2}");
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 3);
    }
}

