using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000,cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }

        //com override o metodo sobrescreve a classe base
        public override double GetBonificacao()
        {
           // chama o método GetBonificao da classe "base" Funcionario
            return Salario *= 0.20;
        }
    }
}
 