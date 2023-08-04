namespace GestaoPetShop
{
    partial class FormCadastroAgendamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idAnimalComboBox = new System.Windows.Forms.ComboBox();
            this.idProfissionalComboBox = new System.Windows.Forms.ComboBox();
            this.idSituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.dataAgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new GestaoPetShop.petshopDataSet();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.AgendamentoTableAdapter();
            this.tableAdapterManager = new GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.AnimalTableAdapter();
            this.profissionalTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.ProfissionalTableAdapter();
            this.situacaoTableAdapter = new GestaoPetShop.petshopDataSetTableAdapters.SituacaoTableAdapter();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idAnimalLabel
            // 
            idAnimalLabel.AutoSize = true;
            idAnimalLabel.Location = new System.Drawing.Point(9, 52);
            idAnimalLabel.Name = "idAnimalLabel";
            idAnimalLabel.Size = new System.Drawing.Size(65, 16);
            idAnimalLabel.TabIndex = 2;
            idAnimalLabel.Text = "Id Animal:";
            // 
            // idProfissionalLabel
            // 
            idProfissionalLabel.AutoSize = true;
            idProfissionalLabel.Location = new System.Drawing.Point(9, 82);
            idProfissionalLabel.Name = "idProfissionalLabel";
            idProfissionalLabel.Size = new System.Drawing.Size(94, 16);
            idProfissionalLabel.TabIndex = 4;
            idProfissionalLabel.Text = "Id Profissional:";
            // 
            // idSituacaoLabel
            // 
            idSituacaoLabel.AutoSize = true;
            idSituacaoLabel.Location = new System.Drawing.Point(9, 112);
            idSituacaoLabel.Name = "idSituacaoLabel";
            idSituacaoLabel.Size = new System.Drawing.Size(77, 16);
            idSituacaoLabel.TabIndex = 6;
            idSituacaoLabel.Text = "Id Situacao:";
            // 
            // dataAgLabel
            // 
            dataAgLabel.AutoSize = true;
            dataAgLabel.Location = new System.Drawing.Point(9, 142);
            dataAgLabel.Name = "dataAgLabel";
            dataAgLabel.Size = new System.Drawing.Size(59, 16);
            dataAgLabel.TabIndex = 8;
            dataAgLabel.Text = "Data Ag:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.Location = new System.Drawing.Point(9, 170);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(55, 16);
            horarioLabel.TabIndex = 10;
            horarioLabel.Text = "Horario:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(9, 198);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(41, 16);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(9, 228);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(40, 16);
            ativoLabel.TabIndex = 14;
            ativoLabel.Text = "Ativo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Agendamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // idAnimalComboBox
            // 
            this.idAnimalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "IdAnimal", true));
            this.idAnimalComboBox.DataSource = this.animalBindingSource1;
            this.idAnimalComboBox.DisplayMember = "Nome";
            this.idAnimalComboBox.FormattingEnabled = true;
            this.idAnimalComboBox.Location = new System.Drawing.Point(109, 49);
            this.idAnimalComboBox.Name = "idAnimalComboBox";
            this.idAnimalComboBox.Size = new System.Drawing.Size(121, 24);
            this.idAnimalComboBox.TabIndex = 3;
            this.idAnimalComboBox.ValueMember = "Id";
            // 
            // idProfissionalComboBox
            // 
            this.idProfissionalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "IdProfissional", true));
            this.idProfissionalComboBox.DataSource = this.profissionalBindingSource;
            this.idProfissionalComboBox.DisplayMember = "Nome";
            this.idProfissionalComboBox.FormattingEnabled = true;
            this.idProfissionalComboBox.Location = new System.Drawing.Point(109, 79);
            this.idProfissionalComboBox.Name = "idProfissionalComboBox";
            this.idProfissionalComboBox.Size = new System.Drawing.Size(121, 24);
            this.idProfissionalComboBox.TabIndex = 5;
            this.idProfissionalComboBox.ValueMember = "Id";
            // 
            // idSituacaoComboBox
            // 
            this.idSituacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "IdSituacao", true));
            this.idSituacaoComboBox.FormattingEnabled = true;
            this.idSituacaoComboBox.Location = new System.Drawing.Point(109, 109);
            this.idSituacaoComboBox.Name = "idSituacaoComboBox";
            this.idSituacaoComboBox.Size = new System.Drawing.Size(121, 24);
            this.idSituacaoComboBox.TabIndex = 7;
            // 
            // dataAgMaskedTextBox
            // 
            this.dataAgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "DataAg", true));
            this.dataAgMaskedTextBox.Location = new System.Drawing.Point(109, 139);
            this.dataAgMaskedTextBox.Mask = "00/00/0000";
            this.dataAgMaskedTextBox.Name = "dataAgMaskedTextBox";
            this.dataAgMaskedTextBox.Size = new System.Drawing.Size(121, 22);
            this.dataAgMaskedTextBox.TabIndex = 9;
            this.dataAgMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // horarioMaskedTextBox
            // 
            this.horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Horario", true));
            this.horarioMaskedTextBox.Location = new System.Drawing.Point(109, 167);
            this.horarioMaskedTextBox.Mask = "00:00";
            this.horarioMaskedTextBox.Name = "horarioMaskedTextBox";
            this.horarioMaskedTextBox.Size = new System.Drawing.Size(121, 22);
            this.horarioMaskedTextBox.TabIndex = 11;
            this.horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(109, 195);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 22);
            this.totalTextBox.TabIndex = 13;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(109, 223);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(121, 24);
            this.ativoCheckBox.TabIndex = 15;
            this.ativoCheckBox.Text = "checkBox1";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataMember = "Animal";
            this.animalBindingSource1.DataSource = this.petshopDataSet;
            // 
            // profissionalBindingSource
            // 
            this.profissionalBindingSource.DataMember = "Profissional";
            this.profissionalBindingSource.DataSource = this.petshopDataSet;
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
            this.tableAdapterManager.ProfissionalTableAdapter = this.profissionalTableAdapter;
            this.tableAdapterManager.RacaTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = this.situacaoTableAdapter;
            this.tableAdapterManager.TelefoneClienteTableAdapter = null;
            this.tableAdapterManager.TelefoneProfissionalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestaoPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // profissionalTableAdapter
            // 
            this.profissionalTableAdapter.ClearBeforeFill = true;
            // 
            // situacaoTableAdapter
            // 
            this.situacaoTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataMember = "Situacao";
            this.situacaoBindingSource.DataSource = this.petshopDataSet;
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroAgendamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private petshopDataSetTableAdapters.AgendamentoTableAdapter agendamentoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private petshopDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private petshopDataSetTableAdapters.ProfissionalTableAdapter profissionalTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox idAnimalComboBox;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.ComboBox idProfissionalComboBox;
        private System.Windows.Forms.ComboBox idSituacaoComboBox;
        private System.Windows.Forms.MaskedTextBox dataAgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox horarioMaskedTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.BindingSource profissionalBindingSource;
        private petshopDataSetTableAdapters.SituacaoTableAdapter situacaoTableAdapter;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
    }
}