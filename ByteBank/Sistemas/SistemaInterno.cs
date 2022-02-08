using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel user, string senha)
        {
            bool usuarioAutenticado = user.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Benvindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
