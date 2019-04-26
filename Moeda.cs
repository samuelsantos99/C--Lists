// Classe Moeda, criando objeto moeda, com getters e setters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0904_Ex1
{
    class Moeda
    {
        private string nome;
        private double valor;

        public Moeda(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;   
        }

        public string GetNome()
        {
            return this.nome;
        }

        public double GetValor()
        {
            return this.valor;
        }
    }
}
