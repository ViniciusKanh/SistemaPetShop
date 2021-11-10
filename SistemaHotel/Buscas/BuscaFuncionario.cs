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

namespace SistemaHotel.Buscas
{
    public partial class BuscaFuncionario : Form
    {
        public BuscaFuncionario()
        {
            InitializeComponent();
        }

        private void BuscaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petShopDataSet.PET_FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.pET_FUNCIONARIOTableAdapter.Fill(this.petShopDataSet.PET_FUNCIONARIO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
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


                using (SqlConnection connection = new SqlConnection(cnn.ConnectionString))
                {
                    connection.Open();
                    var Sqlquery = "Select * from PET_FUNCIONARIO";

                    SqlDataAdapter SqlDataAdapter;
                    using (SqlDataAdapter da = new SqlDataAdapter(Sqlquery, connection))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                }



            }
                }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na Busca de Dados" + erro);



            }
        }
    }
}
