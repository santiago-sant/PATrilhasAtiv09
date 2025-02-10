using System;

class Program
{
    public static void Main(string[] args)
    {
    	int[] vetor = {10,20,30,40,50};
    	foreach (int numero in vetor)
    	Console.WriteLine(numero);
    	
    	
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
  
    }
}
