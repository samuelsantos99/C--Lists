// Criação da classe cofre, com método para adicionar moeda no cofre, onde as moedas inseridas serão registradas no List Moeda, criado na classe Moeda.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0904_Ex1
{
    class Cofre
    {
        private List<Moeda> moedas;
        
        public Cofre()
        {
            moedas = new List<Moeda>();
        }

        public void AdicionarMoeda(Moeda m)
        {
            if(m != null)
            {
                moedas.Add(m);
            }
        }

        public double CalcularValorTotal()
        {
            double total = 0.0;

            foreach(Moeda m in moedas)
            {
                total += m.GetValor();
            }

            return total;
        }


    }
}
