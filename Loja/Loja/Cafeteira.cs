using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Cafeteira : Eletrodomestico
    {
        private int capacidade;

        public Cafeteira(int voltagem, double peso, double altura, double largura, double profundidade, string marca, string modelo, double preco, int capacidade) : base(voltagem, peso, altura, largura, profundidade, marca, modelo, preco)
        {
            this.capacidade = capacidade;
        }
    }
}
