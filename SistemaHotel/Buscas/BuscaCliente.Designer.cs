
namespace SistemaHotel.Buscas
{
    partial class BuscaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.petShopDataSet = new SistemaHotel.PetShopDataSet();
            this.petShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petShopDataSet1 = new SistemaHotel.PetShopDataSet1();
            this.pETCLIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pET_CLITableAdapter = new SistemaHotel.PetShopDataSet1TableAdapters.PET_CLITableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTTANIMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDANIMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETCLIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.qTTANIMALDataGridViewTextBoxColumn,
            this.iDANIMALDataGridViewTextBoxColumn,
            this.iDCIDADEDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pETCLIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(995, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes Cadastrado";
            // 
            // petShopDataSet
            // 
            this.petShopDataSet.DataSetName = "PetShopDataSet";
            this.petShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petShopDataSetBindingSource
            // 
            this.petShopDataSetBindingSource.DataSource = this.petShopDataSet;
            this.petShopDataSetBindingSource.Position = 0;
            // 
            // petShopDataSet1
            // 
            this.petShopDataSet1.DataSetName = "PetShopDataSet1";
            this.petShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pETCLIBindingSource
            // 
            this.pETCLIBindingSource.DataMember = "PET_CLI";
            this.pETCLIBindingSource.DataSource = this.petShopDataSet1;
            // 
            // pET_CLITableAdapter
            // 
            this.pET_CLITableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            // 
            // qTTANIMALDataGridViewTextBoxColumn
            // 
            this.qTTANIMALDataGridViewTextBoxColumn.DataPropertyName = "QTTANIMAL";
            this.qTTANIMALDataGridViewTextBoxColumn.HeaderText = "QTTANIMAL";
            this.qTTANIMALDataGridViewTextBoxColumn.Name = "qTTANIMALDataGridViewTextBoxColumn";
            // 
            // iDANIMALDataGridViewTextBoxColumn
            // 
            this.iDANIMALDataGridViewTextBoxColumn.DataPropertyName = "IDANIMAL";
            this.iDANIMALDataGridViewTextBoxColumn.HeaderText = "IDANIMAL";
            this.iDANIMALDataGridViewTextBoxColumn.Name = "iDANIMALDataGridViewTextBoxColumn";
            // 
            // iDCIDADEDataGridViewTextBoxColumn
            // 
            this.iDCIDADEDataGridViewTextBoxColumn.DataPropertyName = "IDCIDADE";
            this.iDCIDADEDataGridViewTextBoxColumn.HeaderText = "IDCIDADE";
            this.iDCIDADEDataGridViewTextBoxColumn.Name = "iDCIDADEDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscaCliente";
            this.Text = "BuscaCliente";
            this.Load += new System.EventHandler(this.BuscaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pETCLIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource petShopDataSetBindingSource;
        private PetShopDataSet petShopDataSet;
        private PetShopDataSet1 petShopDataSet1;
        private System.Windows.Forms.BindingSource pETCLIBindingSource;
        private PetShopDataSet1TableAdapters.PET_CLITableAdapter pET_CLITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTTANIMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDANIMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
    }
}