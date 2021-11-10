using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            cbCIdade.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();

        }

        private void habilitarCamposAnimal()
        {
            TxtNomeAnimal.Enabled = true;
            cbCategoria.Enabled = true;
            txtRemedio.Enabled = true;
            TxtInformacoes.Enabled = true;
            TxtNomeAnimal.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            cbCIdade.Enabled = false;
            txtTelefone.Enabled = false;
            TxtCep.Enabled = false;
        }

        private void desabilitarCamposAnimal()
        {
            TxtNomeAnimal.Enabled = false;
            cbCategoria.Enabled = false;
            txtRemedio.Enabled = false;
            TxtInformacoes.Enabled = false;
           
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            TxtCep.Text = "";
        }

        private void limparCamposAnimal()
        {
            TxtNomeAnimal.Text = "";
            cbCategoria.Text = "";
            txtRemedio.Text = "";
            TxtInformacoes.Text = "";
            
        }




        private void FrmCliente_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR


                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           


            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA EDITAR

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscarCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbCIdade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            habilitarCamposAnimal();
            button4.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (TxtNomeAnimal.Text.ToString().Trim() == "")
            {
                TxtNomeAnimal.Text = "";
                MessageBox.Show("Preencha o Nome do Animal", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNomeAnimal.Focus();
                return;
            }

            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Selecionar a Categoria ", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCategoria.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Enabled = true;
            button4.Enabled = false;
            limparCamposAnimal();
            desabilitarCamposAnimal();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (TxtNomeAnimal.Text.ToString().Trim() == "")
            {
                TxtNomeAnimal.Text = "";
                MessageBox.Show("Preencha o Nome do Animal", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNomeAnimal.Focus();
                return;
            }

            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Preencha a Categoria", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbCategoria.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA EDITAR

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Enabled = true;
            button3.Enabled = false;
            button1.Enabled = false;
            limparCamposAnimal();
            desabilitarCamposAnimal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR


                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = true;
                button3.Enabled = false;
                button1.Enabled = false;
                TxtNomeAnimal.Text = "";
                cbCategoria.Enabled = false;
            }
        }
        private void TxtNomeAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtInformacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRemedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
