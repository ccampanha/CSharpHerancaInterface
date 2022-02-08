using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            

            Funcionario pedro = new Designer("326.726.225-20");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("453.626.245-10");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("416.555.327-22");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("453.626.245-10");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
