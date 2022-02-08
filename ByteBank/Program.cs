using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("453.626.245-10");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "abc");
            sistemaInterno.Logar(roberta, "123");

            GerenteDeConta camila = new GerenteDeConta("453.626.245-10");
            camila.Nome = "Camila";
            camila.Senha = "123";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "345";


            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(parceiroComercial, "123");



        }
        public static void CalcularBonificacao()
        {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            

            Funcionario pedro = new Designer("326.726.225-20");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("453.626.245-10");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("416.555.327-22");
            igor.Nome = "Igor";

            GerenteDeConta  camila = new GerenteDeConta("453.626.245-10");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
