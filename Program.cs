using System;
using System.Globalization;

namespace ExercEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine(" Entre os dados do produto : ");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preco:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidad:");
            p.Quantidade= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Dados do produto " + p);

        }
    }
}
