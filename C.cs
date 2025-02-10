using System;

class Program
{
    public static void Main(string[] args)
    {
    	double[] vetor = {10.23,84.32,75.10,46.10,50.50};
    	double soma = 0;
    	
    	
    	for ( int i = 0; i < vetor.Length; i++)
    		soma  += vetor[i];
    	{
    		double media =  soma/ vetor.Length;
    		Console.WriteLine("A média dos números :" + media);
    		
    	}
    	
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
  
    }
}
