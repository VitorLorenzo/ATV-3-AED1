using System;
using System.Globalization;

namespace Calculo_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario p1;
            p1 = new Salario();

            Console.WriteLine("Digite o nome:");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Digite seu salario:");
            p1.Salar = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite seu total de vendas:");
            p1.bonus = double.Parse(Console.ReadLine("F4", CultureInfo.InvariantCulture)());
            p1.Montante = double.Parse(Console.ReadLine());
            Console.WriteLine();   


            p1.ImprimirDados();
            p1.calcularTotal();



        }
    }
}