using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Eletrodomestico
    {
        protected int Voltagem { get; set; }
        protected double Peso { get; set; }
        protected double Altura { get; set; }
        protected double Largura { get; set; }
        protected double Profundidade { get; set; }
        protected string? Marca { get; set; }
        protected string? Modelo { get; set; }
        protected double Preco { get; set; }

        public Eletrodomestico(int voltagem, double peso, double altura, double largura, double profundidade, string marca, string modelo, double preco)
        {
            this.Voltagem = voltagem;
            this.Peso = peso;
            this.Altura = altura;
            this.Largura = largura;
            this.Profundidade = profundidade;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Preco = preco;
        }
    }
}
    