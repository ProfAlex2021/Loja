using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Usuario
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public Usuario(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }

        public static List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario("vendedor", "venda123"));
            lista.Add(new Usuario("supervisor", "super123"));
            lista.Add(new Usuario("gerente", "ger123"));
            lista.Add(new Usuario("suporte", "sup123"));

            return lista;
        }
    }
}
