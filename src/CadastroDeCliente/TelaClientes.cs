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

    }
}
