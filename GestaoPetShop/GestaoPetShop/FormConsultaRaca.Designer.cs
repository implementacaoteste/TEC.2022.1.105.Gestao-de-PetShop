namespace GestaoPetShop
{
    partial class FormConsultaRaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaRaca));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelBuscraPorAnimal = new System.Windows.Forms.Label();
            this.petshopDataSet = new GestaoPetShop.petshopDataSet();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.RacaTableAdapter();
            this.tableAdapterManager = new GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.racaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscar.Location = new System.Drawing.Point(200, 128);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(76, 30);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAlterar.Location = new System.Drawing.Point(281, 128);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(76, 30);
            this.buttonAlterar.TabIndex = 1;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserir.Location = new System.Drawing.Point(362, 128);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(76, 30);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluir.Location = new System.Drawing.Point(444, 128);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(76, 30);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "&Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // labelBuscraPorAnimal
            // 
            this.labelBuscraPorAnimal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBuscraPorAnimal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelBuscraPorAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscraPorAnimal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBuscraPorAnimal.Location = new System.Drawing.Point(0, 9);
            this.labelBuscraPorAnimal.Name = "labelBuscraPorAnimal";
            this.labelBuscraPorAnimal.Size = new System.Drawing.Size(528, 53);
            this.labelBuscraPorAnimal.TabIndex = 4;
            this.labelBuscraPorAnimal.Text = "Buscar por Raça";
            this.labelBuscraPorAnimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBuscraPorAnimal.Click += new System.EventHandler(this.labelBuscraPorAnimal_Click);
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "Raca";
            this.racaBindingSource.DataSource = this.petshopDataSet;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoServicosTableAdapter = null;
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmailClienteTableAdapter = null;
            this.tableAdapterManager.EmailProfissionalTableAdapter = null;
            this.tableAdapterManager.FuncaoPermissaoTableAdapter = null;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.PermissaoTableAdapter = null;
            this.tableAdapterManager.ProfissionalTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.TelefoneClienteTableAdapter = null;
            this.tableAdapterManager.TelefoneProfissionalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // racaDataGridView
            // 
            this.racaDataGridView.AllowUserToAddRows = false;
            this.racaDataGridView.AllowUserToDeleteRows = false;
            this.racaDataGridView.AllowUserToOrderColumns = true;
            this.racaDataGridView.AllowUserToResizeColumns = false;
            this.racaDataGridView.AllowUserToResizeRows = false;
            this.racaDataGridView.AutoGenerateColumns = false;
            this.racaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.racaDataGridView.DataSource = this.racaBindingSource;
            this.racaDataGridView.Location = new System.Drawing.Point(7, 166);
            this.racaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.racaDataGridView.Name = "racaDataGridView";
            this.racaDataGridView.ReadOnly = true;
            this.racaDataGridView.RowHeadersVisible = false;
            this.racaDataGridView.RowHeadersWidth = 51;
            this.racaDataGridView.RowTemplate.Height = 24;
            this.racaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racaDataGridView.Size = new System.Drawing.Size(513, 142);
            this.racaDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Especie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Especie";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaisOrigem";
            this.dataGridViewTextBoxColumn4.HeaderText = "PaisOrigem";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Nome",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(8, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(8, 132);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(148, 22);
            this.textBoxBuscar.TabIndex = 8;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSelecionar.Location = new System.Drawing.Point(325, 312);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(95, 30);
            this.buttonSelecionar.TabIndex = 9;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = false;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(425, 312);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(95, 30);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por";
            // 
            // FormConsultaRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.racaDataGridView);
            this.Controls.Add(this.labelBuscraPorAnimal);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormConsultaRaca";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultaPorRaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private petshopDataSetTableAdapters.RacaTableAdapter racaTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView racaDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBuscraPorAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}