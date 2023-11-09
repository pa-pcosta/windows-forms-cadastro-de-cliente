using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCliente
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf {  get; set; }
        public DateTime Nascimento { get; set; }
        public double Peso { get; set; }
    }
}
