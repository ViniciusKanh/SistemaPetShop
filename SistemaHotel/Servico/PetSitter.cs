using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Servico
{
    public partial class frmPetSitter : Form
    {
        public frmPetSitter()
        {
            InitializeComponent();
        }

        private void habilitarCampos()
        {
            textNomeCli.Enabled = true;
            TxtCPF.Enabled = true;
            TxtTelefone.Enabled = true;
            textCODCLI.Enabled = true;
            txt_IDAGENDAMENTO.Enabled = true;
            txtEndereco.Enabled = true;
            cbCidade.Enabled = true;
            TxtCEP.Enabled = true;
            TxtNomePet.Enabled = true;
            cbCategoria.Enabled = true;
            txtInfAdd.Enabled = true;
            txtNomeBaba.Enabled = true;
            TxtCPFBaba.Enabled = true;
            txtTelefoneBaba.Enabled = true;
            cbCargo.Enabled = true;
            DTAgendamento.Enabled = true;
            TxtHora.Enabled = true;
            cbPagamento.Enabled = true;
            TxtInfoAddSitter.Enabled = true;
            textCODCLI.Focus();

        }

        private void desabilitarCampos()
        {
            textNomeCli.Enabled = false;
            TxtCPF.Enabled = false;
            TxtTelefone.Enabled = false;
            textCODCLI.Enabled = false;
            txt_IDAGENDAMENTO.Enabled = false;
            txtEndereco.Enabled = false;
            cbCidade.Enabled = false;
            TxtCEP.Enabled = false;
            TxtNomePet.Enabled = false;
            cbCategoria.Enabled = false;
            txtInfAdd.Enabled = false;
            txtNomeBaba.Enabled = false;
            TxtCPFBaba.Enabled = false;
            txtTelefoneBaba.Enabled = false;
            cbCargo.Enabled = false;
            DTAgendamento.Enabled = false;
            TxtHora.Enabled = false;
            cbPagamento.Enabled = false;
            TxtInfoAddSitter.Enabled = false;
            textCODCLI.Focus();
        }

        private void limparCampos()
        {
            textNomeCli.Text = "";
            TxtCPF.Text = "";
            TxtTelefone.Text = "";
            textCODCLI.Text = "";
            txt_IDAGENDAMENTO.Text = "";
            txtEndereco.Text = "";
            cbCidade.Text = "";
            TxtCEP.Text = "";
            TxtNomePet.Text = "";
            cbCategoria.Text = "";
            txtInfAdd.Text = "";
            txtNomeBaba.Text = "";
            TxtCPFBaba.Text = "";
            txtTelefoneBaba.Text = "";
            cbCargo.Text = "";
            DTAgendamento.Text = "";
            TxtHora.Text = "";
            cbPagamento.Text = "";
            TxtInfoAddSitter.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void textNomeCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textCODCLI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomePet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInfAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeBaba_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCPFBaba_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefoneBaba_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                textCODCLI.Text = "";
                textCODCLI.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            if (textCODCLI.Text.ToString().Trim() == "")
            {
                textCODCLI.Text = "";
                MessageBox.Show("Preencha o Id do Cliente Primeiro", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCODCLI.Focus();
                return;
            }

            if (txtNomeBaba.Text == "")
            {
                MessageBox.Show("Preencha o nome do Sitter", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeBaba.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
