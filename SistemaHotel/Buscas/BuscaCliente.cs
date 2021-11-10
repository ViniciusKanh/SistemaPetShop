using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Buscas
{
    public partial class BuscaCliente : Form
    {
        public BuscaCliente()
        {
            InitializeComponent();
        }

        private void BuscaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petShopDataSet1.PET_CLI'. Você pode movê-la ou removê-la conforme necessário.
            this.pET_CLITableAdapter.Fill(this.petShopDataSet1.PET_CLI);

        }
    }
}
