using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeCliente
{
    public partial class TelaClientes : Form
    {
        List<Cliente> _listaClientes = new List<Cliente>();
        int _ultimoIdUtilizado = 0;
        public TelaClientes()
        {
            InitializeComponent();
            InicializarCampos();
        }

        private void InicializarCampos()
        {
            //Inicializa lista
            _listaClientes.Add(new Cliente() { Id = 0, Nome = "Usuario_Teste_1", Sobrenome = "Usuario_Teste_1", Cpf = "111.111.111-11", Nascimento = new DateTime(2000,01,02), Peso = 50.00});
            _listaClientes.Add(new Cliente() { Id = 0, Nome = "Usuario_Teste_2", Sobrenome = "Usuario_Teste_2", Cpf = "222.222.222-22", Nascimento = new DateTime(2000, 03, 04), Peso = 50.00 });
            _listaClientes.Add(new Cliente() { Id = 0, Nome = "Usuario_Teste_3", Sobrenome = "Usuario_Teste_3", Cpf = "333.333.333-33", Nascimento = new DateTime(2000, 05, 06), Peso = 50.00 });

            dataGridViewListaClientes.DataSource = _listaClientes;
            dataGridViewListaClientes.MultiSelect = false;
            dataGridViewListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitializeMaskedTextedBox(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.Text = string.Empty;
        }

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            //Cria objeto do tipo Cliente com base nos valores preenchidos nos campos
            Cliente novoCliente = new Cliente()
            {
                Id = GeraId(),
                Nome = textBoxNome.Text,
                Sobrenome = textBoxSobrenome.Text,
                Cpf = maskedTextBoxCpf.Text,
                Nascimento = dateTimePickerNascimento.Value,
                Peso = Convert.ToDouble(textBoxPeso.Text)
            };

            //Adiciona objeto à lista de clientes
            _listaClientes.Add(novoCliente);

            //Refresh dataGridViewClientes e reseta campos
            ReiniciaCampos();
        }

        private void ReiniciaCampos()
        {
            dataGridViewListaClientes.DataSource = "null";
            dataGridViewListaClientes.DataSource = _listaClientes;

            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            maskedTextBoxCpf.Text = string.Empty;
            dateTimePickerNascimento.Value = DateTime.Today;
            textBoxPeso.Text = string.Empty;
            textBoxPeso.Text += string.Empty;
        }

        private int GeraId()
        {
            return ++_ultimoIdUtilizado;
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
