using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex3
{
    internal class PessoaFisica : Pessoa
    {
        private long _cpf;

        private int _estadoCivil;

        public PessoaFisica(String nome, String endereco, String telefone, long cpf, int estadoCivil) : base(nome, endereco, telefone)
        {
            this._cpf = cpf;
            this._estadoCivil = estadoCivil;
        }

        public override void exibirDados()
        {
            Console.WriteLine($"Nome:{Nome}\nEndereço:{Endereco}\nTelefone:{Telefone}\nCPF:{_cpf}\nestadoCivil:{_estadoCivil}\n\n");
        }
    }
}
