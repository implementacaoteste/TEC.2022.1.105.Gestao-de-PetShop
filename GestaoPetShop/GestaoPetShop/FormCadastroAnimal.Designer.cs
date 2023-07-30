namespace GestaoPetShop
{
    partial class FormCadastroAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAnimal));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idRacaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label agressivoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label alergiaLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label ativoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petshopDataSet = new GestaoPetShop.petshopDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.AnimalTableAdapter();
            this.tableAdapterManager = new GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.idRacaComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.alergiaTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataNascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.ClienteTableAdapter();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racaTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.RacaTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idRacaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            agressivoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            alergiaLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteComboBox);
            this.groupBox1.Controls.Add(idRacaLabel);
            this.groupBox1.Controls.Add(this.idRacaComboBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(this.sexoComboBox);
            this.groupBox1.Controls.Add(agressivoLabel);
            this.groupBox1.Controls.Add(this.agressivoComboBox);
            this.groupBox1.Controls.Add(corLabel);
            this.groupBox1.Controls.Add(this.corComboBox);
            this.groupBox1.Controls.Add(idadeLabel);
            this.groupBox1.Controls.Add(this.idadeTextBox);
            this.groupBox1.Controls.Add(alergiaLabel);
            this.groupBox1.Controls.Add(this.alergiaTextBox);
            this.groupBox1.Controls.Add(fotoLabel);
            this.groupBox1.Controls.Add(this.fotoPictureBox);
            this.groupBox1.Controls.Add(dataNascimentoLabel);
            this.groupBox1.Controls.Add(this.dataNascimentoMaskedTextBox);
            this.groupBox1.Controls.Add(ativoLabel);
            this.groupBox1.Controls.Add(this.ativoCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Animal";
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoServicosTableAdapter = null;
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
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
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.animalBindingNavigatorSaveItem});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(750, 25);
            this.animalBindingNavigator.TabIndex = 1;
            this.animalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animalBindingNavigatorSaveItem.Text = "Save Data";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(32, 39);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 21);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(191, 39);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(121, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(32, 68);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(90, 21);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clienteBindingSource;
            this.idClienteComboBox.DisplayMember = "Nome";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(191, 65);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(304, 29);
            this.idClienteComboBox.TabIndex = 3;
            this.idClienteComboBox.ValueMember = "Id";
            // 
            // idRacaLabel
            // 
            idRacaLabel.AutoSize = true;
            idRacaLabel.Location = new System.Drawing.Point(32, 103);
            idRacaLabel.Name = "idRacaLabel";
            idRacaLabel.Size = new System.Drawing.Size(76, 21);
            idRacaLabel.TabIndex = 4;
            idRacaLabel.Text = "Id Raca:";
            // 
            // idRacaComboBox
            // 
            this.idRacaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "IdRaca", true));
            this.idRacaComboBox.DataSource = this.racaBindingSource;
            this.idRacaComboBox.DisplayMember = "Nome";
            this.idRacaComboBox.FormattingEnabled = true;
            this.idRacaComboBox.Location = new System.Drawing.Point(191, 100);
            this.idRacaComboBox.Name = "idRacaComboBox";
            this.idRacaComboBox.Size = new System.Drawing.Size(304, 29);
            this.idRacaComboBox.TabIndex = 5;
            this.idRacaComboBox.ValueMember = "Id";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(32, 138);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(61, 21);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(191, 135);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(304, 27);
            this.nomeTextBox.TabIndex = 7;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(32, 171);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(50, 21);
            sexoLabel.TabIndex = 8;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexoComboBox.Location = new System.Drawing.Point(191, 168);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(66, 29);
            this.sexoComboBox.TabIndex = 9;
            // 
            // agressivoLabel
            // 
            agressivoLabel.AutoSize = true;
            agressivoLabel.Location = new System.Drawing.Point(32, 206);
            agressivoLabel.Name = "agressivoLabel";
            agressivoLabel.Size = new System.Drawing.Size(88, 21);
            agressivoLabel.TabIndex = 10;
            agressivoLabel.Text = "Agressivo:";
            // 
            // agressivoComboBox
            // 
            this.agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Agressivo", true));
            this.agressivoComboBox.FormattingEnabled = true;
            this.agressivoComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.agressivoComboBox.Location = new System.Drawing.Point(191, 203);
            this.agressivoComboBox.Name = "agressivoComboBox";
            this.agressivoComboBox.Size = new System.Drawing.Size(66, 29);
            this.agressivoComboBox.TabIndex = 11;
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(32, 241);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(42, 21);
            corLabel.TabIndex = 12;
            corLabel.Text = "Cor:";
            // 
            // corComboBox
            // 
            this.corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Cor", true));
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Cinza",
            "Outros"});
            this.corComboBox.Location = new System.Drawing.Point(191, 238);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(121, 29);
            this.corComboBox.TabIndex = 13;
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(32, 276);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(62, 21);
            idadeLabel.TabIndex = 14;
            idadeLabel.Text = "Idade:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Idade", true));
            this.idadeTextBox.Location = new System.Drawing.Point(191, 273);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(121, 27);
            this.idadeTextBox.TabIndex = 15;
            // 
            // alergiaLabel
            // 
            alergiaLabel.AutoSize = true;
            alergiaLabel.Location = new System.Drawing.Point(32, 309);
            alergiaLabel.Name = "alergiaLabel";
            alergiaLabel.Size = new System.Drawing.Size(70, 21);
            alergiaLabel.TabIndex = 16;
            alergiaLabel.Text = "Alergia:";
            // 
            // alergiaTextBox
            // 
            this.alergiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Alergia", true));
            this.alergiaTextBox.Location = new System.Drawing.Point(191, 306);
            this.alergiaTextBox.MaxLength = 50;
            this.alergiaTextBox.Multiline = true;
            this.alergiaTextBox.Name = "alergiaTextBox";
            this.alergiaTextBox.Size = new System.Drawing.Size(247, 83);
            this.alergiaTextBox.TabIndex = 17;
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(548, 41);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(49, 21);
            fotoLabel.TabIndex = 18;
            fotoLabel.Text = "Foto:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(618, 39);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(102, 76);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 19;
            this.fotoPictureBox.TabStop = false;
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(32, 398);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(153, 21);
            dataNascimentoLabel.TabIndex = 20;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // dataNascimentoMaskedTextBox
            // 
            this.dataNascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "DataNascimento", true));
            this.dataNascimentoMaskedTextBox.Location = new System.Drawing.Point(191, 395);
            this.dataNascimentoMaskedTextBox.Mask = "00/00/0000";
            this.dataNascimentoMaskedTextBox.Name = "dataNascimentoMaskedTextBox";
            this.dataNascimentoMaskedTextBox.Size = new System.Drawing.Size(121, 27);
            this.dataNascimentoMaskedTextBox.TabIndex = 21;
            this.dataNascimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(32, 433);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(57, 21);
            ativoLabel.TabIndex = 22;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.animalBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(191, 428);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(121, 24);
            this.ativoCheckBox.TabIndex = 23;
            this.ativoCheckBox.Text = "checkBox1";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "M - Macho F - Fêmea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "S - Sim N - Não";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.petshopDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
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
            // FormCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormCadastroAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroAnimal";
            this.Load += new System.EventHandler(this.FormCadastroAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private petshopDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idRacaComboBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.ComboBox agressivoComboBox;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox alergiaTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.MaskedTextBox dataNascimentoMaskedTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private petshopDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private petshopDataSetTableAdapters.RacaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
    }
}