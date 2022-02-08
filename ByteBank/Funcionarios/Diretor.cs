using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
   
    public class Diretor : Funcionario
    {
        //com override o metodo sobrescreve a classe base
        public override double GetBonificacao()
        {
           // chama o método GetBonificao da classe "base" Funcionario
            return Salario + base.GetBonificacao();
        }
    }
}
 