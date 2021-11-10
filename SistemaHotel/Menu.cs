using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show();
        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCargo form = new Cadastros.FrmCargo();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void NovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmClientes form = new Cadastros.FrmClientes();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cadastros.FrmClientes form = new Cadastros.FrmClientes();
            form.Show();
        }

        private void MenuMovimentacoes_Click(object sender, EventArgs e)
        {

        }

        private void MenuProdutos_Click(object sender, EventArgs e)
        {

        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void MenuChekInOut_Click(object sender, EventArgs e)
        {

        }

        private void CidadestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastros.FormCidade form = new Cadastros.FormCidade();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Servico.frmPetSitter form = new Servico.frmPetSitter();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source= VINICIUS-SANTOS;Initial Catalog=PetShop;User ID=sa;Password=intel";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Conectado com o Banco de Dados !");
                cnn.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                "Verifique os dados informados" + erro);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void funcionariosCadastradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Buscas.BuscaFuncionario form = new Buscas.BuscaFuncionario();
            form.Show();

        }

        private void MenuRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void clientesCadastradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Buscas.BuscaCliente form = new Buscas.BuscaCliente();
            form.Show();

        }
    }
}
