using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class Salario
    {
        private string nom;
        private double sal;
        private double mont;
        private double bonus;

       public string Nome
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public double Salar
        {
            get
            {
                return sal;
            }
            set
            {
                sal = value;
            }
        }

        public double Montante
        {
            get
            {
                return mont;
            }
            set
            {
                mont = value;
            }
        }
         public double bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }
       
        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nom);
            Console.WriteLine();
            Console.WriteLine("Salario: " + sal);
            Console.WriteLine();
            Console.WriteLine("Bonus: " + Total)
            

        }


        public void calcularTotal()
        {
            mont = (15 / 100) * bonus;

            Console.WriteLine("Total: " + bonus);
            Console.WriteLine();
        }

    }
}
