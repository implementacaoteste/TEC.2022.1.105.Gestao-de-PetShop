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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label label;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label descricaoLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecoAplicado = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.button_InserirServicoAgendamento = new System.Windows.Forms.Button();
            this.dataGridView_ServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_ServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.descricaoComboBox1 = new System.Windows.Forms.ComboBox();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            descricaoLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(90, 249);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(72, 16);
            descricaoLabel.TabIndex = 15;
            descricaoLabel.Text = "Descricao:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(29, 249);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(494, 251);
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(88, 16);
            label.TabIndex = 19;
            label.Text = "Valor Unitário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(605, 249);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(145, 16);
            label8.TabIndex = 23;
            label8.Text = "Valor Unitário Aplicado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(393, 249);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 16);
            label9.TabIndex = 24;
            label9.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(789, 246);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 16);
            label10.TabIndex = 27;
            label10.Text = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1028, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(845, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor Total R$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome do Cliente";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(563, 133);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 24);
            this.comboBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Animal";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(144, 133);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Situação";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(836, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profissional";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(94, 269);
            this.descricaoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(293, 24);
            this.descricaoComboBox.TabIndex = 1;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(751, 270);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(109, 22);
            this.textBoxSubtotal.TabIndex = 5;
            // 
            // textBoxPrecoAplicado
            // 
            this.textBoxPrecoAplicado.Location = new System.Drawing.Point(623, 270);
            this.textBoxPrecoAplicado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoAplicado.Name = "textBoxPrecoAplicado";
            this.textBoxPrecoAplicado.Size = new System.Drawing.Size(105, 22);
            this.textBoxPrecoAplicado.TabIndex = 4;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(397, 271);
            this.textBoxQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(73, 22);
            this.textBoxQuantidade.TabIndex = 2;
            this.textBoxQuantidade.Text = "1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(11, 269);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(59, 22);
            this.idTextBox.TabIndex = 0;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(478, 271);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(104, 22);
            this.precoTextBox.TabIndex = 3;
            // 
            // button_InserirServicoAgendamento
            // 
            this.button_InserirServicoAgendamento.Location = new System.Drawing.Point(956, 266);
            this.button_InserirServicoAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.button_InserirServicoAgendamento.Name = "button_InserirServicoAgendamento";
            this.button_InserirServicoAgendamento.Size = new System.Drawing.Size(86, 28);
            this.button_InserirServicoAgendamento.TabIndex = 7;
            this.button_InserirServicoAgendamento.Text = "Inserir";
            this.button_InserirServicoAgendamento.UseVisualStyleBackColor = true;
            this.button_InserirServicoAgendamento.Click += new System.EventHandler(this.button_InserirServicoAgendamento_Click);
            // 
            // dataGridView_ServicoBindingSource
            // 
            this.dataGridView_ServicoBindingSource.DataSource = typeof(Models.AgendamentoServico);
            // 
            // dataGridView_ServicoDataGridView
            // 
            this.dataGridView_ServicoDataGridView.AllowUserToAddRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView_ServicoDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView_ServicoDataGridView.AutoGenerateColumns = false;
            this.dataGridView_ServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_ServicoDataGridView.DataSource = this.dataGridView_ServicoBindingSource;
            this.dataGridView_ServicoDataGridView.Location = new System.Drawing.Point(13, 332);
            this.dataGridView_ServicoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ServicoDataGridView.Name = "dataGridView_ServicoDataGridView";
            this.dataGridView_ServicoDataGridView.ReadOnly = true;
            this.dataGridView_ServicoDataGridView.RowHeadersVisible = false;
            this.dataGridView_ServicoDataGridView.RowHeadersWidth = 51;
            this.dataGridView_ServicoDataGridView.Size = new System.Drawing.Size(1014, 288);
            this.dataGridView_ServicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValorUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorComDesconto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor com Desconto";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(871, 268);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(928, 711);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 28;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // descricaoLabel1
            // 
            descricaoLabel1.AutoSize = true;
            descricaoLabel1.Location = new System.Drawing.Point(122, 220);
            descricaoLabel1.Name = "descricaoLabel1";
            descricaoLabel1.Size = new System.Drawing.Size(72, 16);
            descricaoLabel1.TabIndex = 28;
            descricaoLabel1.Text = "Descricao:";
            // 
            // descricaoComboBox1
            // 
            this.descricaoComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox1.DataSource = this.servicoBindingSource;
            this.descricaoComboBox1.DisplayMember = "Descricao";
            this.descricaoComboBox1.FormattingEnabled = true;
            this.descricaoComboBox1.Location = new System.Drawing.Point(200, 217);
            this.descricaoComboBox1.Name = "descricaoComboBox1";
            this.descricaoComboBox1.Size = new System.Drawing.Size(210, 24);
            this.descricaoComboBox1.TabIndex = 29;
            this.descricaoComboBox1.ValueMember = "Id";
            // 
            // FormCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 770);
            this.Controls.Add(descricaoLabel1);
            this.Controls.Add(this.descricaoComboBox1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(label10);
            this.Controls.Add(this.dataGridView_ServicoDataGridView);
            this.Controls.Add(this.descricaoComboBox);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(label9);
            this.Controls.Add(this.button_InserirServicoAgendamento);
            this.Controls.Add(label8);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.textBoxPrecoAplicado);
            this.Controls.Add(label);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastroAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FormCadastroAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_InserirServicoAgendamento;
        private System.Windows.Forms.BindingSource dataGridView_ServicoBindingSource;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxPrecoAplicado;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.DataGridView dataGridView_ServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox descricaoComboBox1;
    }
}