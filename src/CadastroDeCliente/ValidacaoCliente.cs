
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroDeCliente
{
    internal class ValidacaoCliente
    {
        Cliente _cliente;

        string _padraoNome = "^[a-zA-Z]+$";
        string _padraoSobrenome;
        string _padraoCPF;
        string _padraoNascimento;
        string _padraoPeso;

        ValidacaoCliente(Cliente cliente) 
        {
            _cliente = cliente;
        }

        void Validar(Cliente cliente)
        {
            try
            {
                
            }
            catch { }
        }
    }
}
