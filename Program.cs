using System;

namespace tabuada
{
class Program
{
    public static void Main(string[] args)
    {
        int formula, contador, numero;

        Console.WriteLine("Digite o número da tabuada.");
        numero = int.Parse(Console.ReadLine());

        for(contador = 1; contador <=10; ++contador)
        {
            formula = numero * contador;
            Console.WriteLine(numero + "X" + contador + "=" + formula);
        }
        Console.ReadKey();
    }   
  }
}