using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex3
{
    internal class PessoaJuridica : Pessoa
    {
        private long _cnpj;
        private String _razaoSocial;
        private String _nomeRepresentante;

        public PessoaJuridica(String nome, String endereco, String telefone, long cnpj, String razaoSocial, String nomeRepresentante) : base(nome, endereco, telefone)
        {
            this._cnpj = cnpj;
            this._razaoSocial = razaoSocial;
            this._nomeRepresentante = nomeRepresentante;
        }


        public override void exibirDados()
        {
            Console.WriteLine($"Nome:{Nome}\nEndereço:{Endereco}\nTelefone:{Telefone}\nRazãoSocial:{_razaoSocial}\nNomeRepresentante:{_nomeRepresentante}\n\n");
        }
    }
}
