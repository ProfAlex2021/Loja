using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Televisao : Eletrodomestico
    {
        private int polegadas;
        private string? resolucao;

        public Televisao(int voltagem, double peso, double altura, double largura, double profundidade, string marca, string modelo, double preco, int polegadas, string resolucao) : base(voltagem, peso, altura, largura, profundidade, marca, modelo, preco)
        {
            this.polegadas = polegadas;
            this.resolucao = resolucao;
        }
    }
}
