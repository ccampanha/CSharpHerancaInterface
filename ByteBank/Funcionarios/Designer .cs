using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000,cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        //com override o metodo sobrescreve a classe base
        public override double GetBonificacao()
        {
           // chama o método GetBonificao da classe "base" Funcionario
            return Salario *= 0.17;
        }
    }
}
 