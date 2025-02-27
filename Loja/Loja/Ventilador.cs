using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Ventilador : Eletrodomestico
    {
        private int velocidade;

        public Ventilador(int voltagem, double peso, double altura, double largura, double profundidade, string marca, string modelo, double preco, int velocidade) : base(voltagem, peso, altura, largura, profundidade, marca, modelo, preco)
        {
            this.velocidade = velocidade;
        }
    }
}
