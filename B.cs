using System;

class Program
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

       
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }
    }

    public static void Main(string[] args)
    {
       
        Aluno[] alunos = new Aluno[5]
        {
            new Aluno { Nome = "Gabriel", Nota1 = 10, Nota2 = 7 },
            new Aluno { Nome = "Lucas", Nota1 = 6, Nota2 = 8 },
            new Aluno { Nome = "Vitor", Nota1 = 9, Nota2 = 5 },
            new Aluno { Nome = "Maria", Nota1 = 10, Nota2 = 9 },
            new Aluno { Nome = "Julia", Nota1 = 4, Nota2 = 6 }
        };

        Console.WriteLine("========= Média e dados dos alunos =========");
        
       
        for (int i = 0; i < alunos.Length; i++)
        {
            double media = alunos[i].CalcularMedia();
            Console.WriteLine("Nome: {0}, Nota 1: {1}, Nota 2: {2}, Média: {3}", 
                alunos[i].Nome, alunos[i].Nota1, alunos[i].Nota2, media);
        }

       
        Console.ReadKey(true);
    }
}
