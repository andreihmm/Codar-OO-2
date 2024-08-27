using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codar_em_OO2.Ex3
{
    internal class main3
    {
        static int Main(string[] args)
        {
            PessoaJuridica pj1 = new PessoaJuridica("Vasco", "Rua Bobs", "99009", 1998, "Vasco S.A.F.", "Pedrinho");
            PessoaFisica pf1 = new PessoaFisica("Payet", "Marseile", "191919", 1672678, 0);

            pj1.exibirDados();
            pf1.exibirDados();

            return 0;
        }
    }
}
