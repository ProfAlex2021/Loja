using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Geladeira : Eletrodomestico
    {
        private int qtdePrateleira;

        public Geladeira(int voltagem, double peso, double altura, double largura, double profundidade, string marca, string modelo, double preco, int qtdePrateleira) : base(voltagem, peso, altura, largura, profundidade, marca, modelo, preco)
        {
            this.qtdePrateleira = qtdePrateleira;
        }
    }
}
