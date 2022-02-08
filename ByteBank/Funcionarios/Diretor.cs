using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000,cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //com override o metodo sobrescreve a classe base
        public override double GetBonificacao()
        {
           // chama o método GetBonificao da classe "base" Funcionario
            return Salario*=0.5;
        }
    }
}
 