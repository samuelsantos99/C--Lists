// Main que instancia e testa as duas classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0904_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cofre cofre = new Cofre();

            cofre.AdicionarMoeda(new Moeda("Dez centavos", 0.10));
            cofre.AdicionarMoeda(new Moeda("Cinco centavos", 0.05 ));
            cofre.AdicionarMoeda(new Moeda("Dez reais", 10 ));

            Console.WriteLine("Total={0}", cofre.CalcularValorTotal());
            Console.ReadLine();


        }
    }
}
