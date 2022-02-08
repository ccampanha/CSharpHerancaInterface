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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.979.157-20";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);
            Console.WriteLine(carlos.GetBonificacao());

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "453.626.245-10";
            roberta.Salario = 9000;
            gerenciador.Registrar(roberta);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
