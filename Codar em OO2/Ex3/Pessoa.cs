using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex3
{
    internal abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public string Endereco { get; protected set; }
        public string Telefone { get; protected set; }

        // Construtor opcional para inicialização
        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }


        public abstract void exibirDados();
    }
}
