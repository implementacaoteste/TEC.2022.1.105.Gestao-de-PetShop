namespace GestaoPetShop
{
    partial class frmCadastroAgendamento
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idAnimalLabel;
            System.Windows.Forms.Label idProfissionalLabel;
            System.Windows.Forms.Label idSituacaoLabel;
            System.Windows.Forms.Label dataAgLabel;
            System.Windows.Forms.Label horarioLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label ativoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAgendamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new GestaoPetShop.petshopDataSet();
            this.idAnimalComboBox = new System.Windows.Forms.ComboBox();
            this.idProfissionalComboBox = new System.Windows.Forms.ComboBox();
            this.idSituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.dataAgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agendamentoTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.AgendamentoTableAdapter();
            this.tableAdapterManager = new GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.AnimalTableAdapter();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdicionar = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.btnPosterior = new System.Windows.Forms.PictureBox();
            this.btnUltimo = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnPrimeiro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profissionalTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.ProfissionalTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            idAnimalLabel = new System.Windows.Forms.Label();
            idProfissionalLabel = new System.Windows.Forms.Label();
            idSituacaoLabel = new System.Windows.Forms.Label();
            dataAgLabel = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPosterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 36);
            idLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(68, 21);
            idLabel.TabIndex = 0;
            idLabel.Text = "Código";
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(12, 108);
            idAnimalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(141, 21);
            idAnimalLabel.TabIndex = 2;
            idAnimalLabel.Text = "Nome do Animal";
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(392, 108);
            idProfissionalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(167, 21);
            idProfissionalLabel.TabIndex = 4;
            idProfissionalLabel.Text = "Nome do Profissional";
            // 
            // idSituacaoLabel
            // 
            idSituacaoLabel.AutoSize = true;
            idSituacaoLabel.Location = new System.Drawing.Point(446, 36);
            idSituacaoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idSituacaoLabel.Name = "idSituacaoLabel";
            idSituacaoLabel.Size = new System.Drawing.Size(227, 21);
            idSituacaoLabel.TabIndex = 6;
            idSituacaoLabel.Text = "Situação do Agendamento";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(139, 36);
            dataAgLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(51, 21);
            dataAgLabel.TabIndex = 8;
            dataAgLabel.Text = "Data";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(274, 36);
            horarioLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(65, 21);
            horarioLabel.TabIndex = 10;
            horarioLabel.Text = "Horário";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(694, 36);
            totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(49, 21);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(704, 137);
            ativoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(53, 21);
            ativoLabel.TabIndex = 14;
            ativoLabel.Text = "Ativo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(idAnimalLabel);
            this.groupBox1.Controls.Add(this.idAnimalComboBox);
            this.groupBox1.Controls.Add(idProfissionalLabel);
            this.groupBox1.Controls.Add(this.idProfissionalComboBox);
            this.groupBox1.Controls.Add(idSituacaoLabel);
            this.groupBox1.Controls.Add(this.idSituacaoComboBox);
            this.groupBox1.Controls.Add(dataAgLabel);
            this.groupBox1.Controls.Add(this.dataAgMaskedTextBox);
            this.groupBox1.Controls.Add(horarioLabel);
            this.groupBox1.Controls.Add(this.horarioMaskedTextBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(ativoLabel);
            this.groupBox1.Controls.Add(this.ativoCheckBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(20, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1011, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "minutos";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(16, 65);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(106, 27);
            this.idTextBox.TabIndex = 0;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "Agendamento";
            this.agendamentoBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idAnimalComboBox
            // 
            this.idAnimalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalComboBox.FormattingEnabled = true;
            this.idAnimalComboBox.Location = new System.Drawing.Point(16, 134);
            this.idAnimalComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.idAnimalComboBox.Name = "idAnimalComboBox";
            this.idAnimalComboBox.Size = new System.Drawing.Size(366, 29);
            this.idAnimalComboBox.TabIndex = 5;
            this.idAnimalComboBox.ValueMember = "Id";
            // 
            // idProfissionalComboBox
            // 
            this.idProfissionalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalComboBox.DataSource = this.profissionalBindingSource;
            this.idProfissionalComboBox.DisplayMember = "Nome";
            this.idProfissionalComboBox.FormattingEnabled = true;
            this.idProfissionalComboBox.Location = new System.Drawing.Point(396, 134);
            this.idProfissionalComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.idProfissionalComboBox.Name = "idProfissionalComboBox";
            this.idProfissionalComboBox.Size = new System.Drawing.Size(276, 29);
            this.idProfissionalComboBox.TabIndex = 6;
            this.idProfissionalComboBox.ValueMember = "Id";
            // 
            // idSituacaoComboBox
            // 
            this.idSituacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdSituacao", true));
            this.idSituacaoComboBox.FormattingEnabled = true;
            this.idSituacaoComboBox.Location = new System.Drawing.Point(450, 65);
            this.idSituacaoComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.idSituacaoComboBox.Name = "idSituacaoComboBox";
            this.idSituacaoComboBox.Size = new System.Drawing.Size(222, 29);
            this.idSituacaoComboBox.TabIndex = 3;
            // 
            // dataAgMaskedTextBox
            // 
            this.dataAgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgMaskedTextBox.Location = new System.Drawing.Point(143, 65);
            this.dataAgMaskedTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.dataAgMaskedTextBox.Mask = "00/00/0000";
            this.dataAgMaskedTextBox.Name = "dataAgMaskedTextBox";
            this.dataAgMaskedTextBox.Size = new System.Drawing.Size(111, 27);
            this.dataAgMaskedTextBox.TabIndex = 1;
            this.dataAgMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // horarioMaskedTextBox
            // 
            this.horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioMaskedTextBox.Location = new System.Drawing.Point(275, 65);
            this.horarioMaskedTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.horarioMaskedTextBox.Mask = "00:00";
            this.horarioMaskedTextBox.Name = "horarioMaskedTextBox";
            this.horarioMaskedTextBox.Size = new System.Drawing.Size(83, 27);
            this.horarioMaskedTextBox.TabIndex = 2;
            this.horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(698, 65);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(175, 27);
            this.totalTextBox.TabIndex = 4;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(683, 129);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(126, 39);
            this.ativoCheckBox.TabIndex = 7;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(20, 377);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1011, 478);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoServicosTableAdapter = null;
            this.tableAdapterManager.AgendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmailClienteTableAdapter = null;
            this.tableAdapterManager.EmailProfissionalTableAdapter = null;
            this.tableAdapterManager.FuncaoPermissaoTableAdapter = null;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.PermissaoTableAdapter = null;
            this.tableAdapterManager.ProfissionalTableAdapter = null;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.TelefoneClienteTableAdapter = null;
            this.tableAdapterManager.TelefoneProfissionalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(284, 19);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(56, 32);
            this.btnAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(86, 19);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(56, 32);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.Image = ((System.Drawing.Image)(resources.GetObject("btnPosterior.Image")));
            this.btnPosterior.Location = new System.Drawing.Point(152, 19);
            this.btnPosterior.Margin = new System.Windows.Forms.Padding(5);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(56, 32);
            this.btnPosterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPosterior.TabIndex = 2;
            this.btnPosterior.TabStop = false;
            this.btnPosterior.Click += new System.EventHandler(this.btnPosterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(218, 19);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(5);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(56, 32);
            this.btnUltimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUltimo.TabIndex = 2;
            this.btnUltimo.TabStop = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(350, 19);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 32);
            this.btnExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(416, 19);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 32);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(482, 19);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(56, 32);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.Location = new System.Drawing.Point(20, 19);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(56, 32);
            this.btnPrimeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrimeiro.TabIndex = 2;
            this.btnPrimeiro.TabStop = false;
            this.btnPrimeiro.Tag = "";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // profissionalBindingSource
            // 
            this.profissionalBindingSource.DataMember = "Profissional";
            this.profissionalBindingSource.DataSource = this.petshopDataSet;
            // 
            // profissionalTableAdapter
            // 
            this.profissionalTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "Foto", true));
            this.pictureBox2.Location = new System.Drawing.Point(773, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // frmCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 749);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPosterior);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroAgendamento";
            this.Text = "Cadastro de Agendamento";
            this.Load += new System.EventHandler(this.frmCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPosterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUltimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrimeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private petshopDataSetTableAdapters.AgendamentoTableAdapter agendamentoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox idAnimalComboBox;
        private System.Windows.Forms.ComboBox idProfissionalComboBox;
        private System.Windows.Forms.ComboBox idSituacaoComboBox;
        private System.Windows.Forms.MaskedTextBox dataAgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox horarioMaskedTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private petshopDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.PictureBox btnAdicionar;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox btnPosterior;
        private System.Windows.Forms.PictureBox btnUltimo;
        private System.Windows.Forms.PictureBox btnExcluir;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnPrimeiro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource profissionalBindingSource;
        private petshopDataSetTableAdapters.ProfissionalTableAdapter profissionalTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}