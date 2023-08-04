﻿namespace GestaoPetShop
{
    partial class ConsultaAgendamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelecionarTipoBusca = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarAgendamento = new System.Windows.Forms.TextBox();
            this.button_BuscarAgendamentos = new System.Windows.Forms.Button();
            this.button_InserirAgendamentos = new System.Windows.Forms.Button();
            this.button_AlterarAgendamentos = new System.Windows.Forms.Button();
            this.button_ExcluirAgendamento = new System.Windows.Forms.Button();
            this.dataGridView1_FormsPrincipalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1_FormsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_BuscarData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta de Agendamentos";
            // 
            // comboBox_SelecionarTipoBusca
            // 
            this.comboBox_SelecionarTipoBusca.FormattingEnabled = true;
            this.comboBox_SelecionarTipoBusca.Items.AddRange(new object[] {
            "Todos",
            "Por Id",
            "Por Nome"});
            this.comboBox_SelecionarTipoBusca.Location = new System.Drawing.Point(12, 99);
            this.comboBox_SelecionarTipoBusca.Name = "comboBox_SelecionarTipoBusca";
            this.comboBox_SelecionarTipoBusca.Size = new System.Drawing.Size(121, 24);
            this.comboBox_SelecionarTipoBusca.TabIndex = 8;
            this.comboBox_SelecionarTipoBusca.Text = "Buscar por";
            // 
            // textBox_BuscarAgendamento
            // 
            this.textBox_BuscarAgendamento.Location = new System.Drawing.Point(139, 101);
            this.textBox_BuscarAgendamento.Name = "textBox_BuscarAgendamento";
            this.textBox_BuscarAgendamento.Size = new System.Drawing.Size(288, 22);
            this.textBox_BuscarAgendamento.TabIndex = 9;
            // 
            // button_BuscarAgendamentos
            // 
            this.button_BuscarAgendamentos.Location = new System.Drawing.Point(433, 100);
            this.button_BuscarAgendamentos.Name = "button_BuscarAgendamentos";
            this.button_BuscarAgendamentos.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarAgendamentos.TabIndex = 10;
            this.button_BuscarAgendamentos.Text = "Buscar";
            this.button_BuscarAgendamentos.UseVisualStyleBackColor = true;
            this.button_BuscarAgendamentos.Click += new System.EventHandler(this.button_BuscarAgendamentos_Click);
            // 
            // button_InserirAgendamentos
            // 
            this.button_InserirAgendamentos.Location = new System.Drawing.Point(513, 101);
            this.button_InserirAgendamentos.Name = "button_InserirAgendamentos";
            this.button_InserirAgendamentos.Size = new System.Drawing.Size(75, 23);
            this.button_InserirAgendamentos.TabIndex = 11;
            this.button_InserirAgendamentos.Text = "Cadastrar";
            this.button_InserirAgendamentos.UseVisualStyleBackColor = true;
            this.button_InserirAgendamentos.Click += new System.EventHandler(this.button_InserirAgendamentos_Click);
            // 
            // button_AlterarAgendamentos
            // 
            this.button_AlterarAgendamentos.Location = new System.Drawing.Point(594, 101);
            this.button_AlterarAgendamentos.Name = "button_AlterarAgendamentos";
            this.button_AlterarAgendamentos.Size = new System.Drawing.Size(75, 23);
            this.button_AlterarAgendamentos.TabIndex = 12;
            this.button_AlterarAgendamentos.Text = "Alterar";
            this.button_AlterarAgendamentos.UseVisualStyleBackColor = true;
            // 
            // button_ExcluirAgendamento
            // 
            this.button_ExcluirAgendamento.Location = new System.Drawing.Point(675, 101);
            this.button_ExcluirAgendamento.Name = "button_ExcluirAgendamento";
            this.button_ExcluirAgendamento.Size = new System.Drawing.Size(75, 23);
            this.button_ExcluirAgendamento.TabIndex = 13;
            this.button_ExcluirAgendamento.Text = "Excluir";
            this.button_ExcluirAgendamento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1_FormsPrincipalDataGridView
            // 
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToAddRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToDeleteRows = false;
            this.dataGridView1_FormsPrincipalDataGridView.AllowUserToOrderColumns = true;
            this.dataGridView1_FormsPrincipalDataGridView.AutoGenerateColumns = false;
            this.dataGridView1_FormsPrincipalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_FormsPrincipalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1_FormsPrincipalDataGridView.DataSource = this.dataGridView1_FormsPrincipalBindingSource;
            this.dataGridView1_FormsPrincipalDataGridView.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1_FormsPrincipalDataGridView.Name = "dataGridView1_FormsPrincipalDataGridView";
            this.dataGridView1_FormsPrincipalDataGridView.ReadOnly = true;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersVisible = false;
            this.dataGridView1_FormsPrincipalDataGridView.RowHeadersWidth = 51;
            this.dataGridView1_FormsPrincipalDataGridView.RowTemplate.Height = 24;
            this.dataGridView1_FormsPrincipalDataGridView.Size = new System.Drawing.Size(758, 308);
            this.dataGridView1_FormsPrincipalDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataAg";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAnimal";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Servico";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Profissional";
            this.dataGridViewTextBoxColumn6.HeaderText = "Profissional";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TelCliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contato";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridView1_FormsPrincipalBindingSource
            // 
            this.dataGridView1_FormsPrincipalBindingSource.DataSource = typeof(Models.DataGridView1_FormsPrincipal);
            // 
            // textBox_BuscarData
            // 
            this.textBox_BuscarData.Location = new System.Drawing.Point(139, 130);
            this.textBox_BuscarData.Name = "textBox_BuscarData";
            this.textBox_BuscarData.Size = new System.Drawing.Size(100, 22);
            this.textBox_BuscarData.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Models.Agendamento);
            // 
            // ConsultaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BuscarData);
            this.Controls.Add(this.dataGridView1_FormsPrincipalDataGridView);
            this.Controls.Add(this.button_ExcluirAgendamento);
            this.Controls.Add(this.button_AlterarAgendamentos);
            this.Controls.Add(this.button_InserirAgendamentos);
            this.Controls.Add(this.button_BuscarAgendamentos);
            this.Controls.Add(this.textBox_BuscarAgendamento);
            this.Controls.Add(this.comboBox_SelecionarTipoBusca);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaAgendamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelecionarTipoBusca;
        private System.Windows.Forms.TextBox textBox_BuscarAgendamento;
        private System.Windows.Forms.Button button_BuscarAgendamentos;
        private System.Windows.Forms.Button button_InserirAgendamentos;
        private System.Windows.Forms.Button button_AlterarAgendamentos;
        private System.Windows.Forms.Button button_ExcluirAgendamento;
        private System.Windows.Forms.BindingSource dataGridView1_FormsPrincipalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1_FormsPrincipalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBox_BuscarData;
        private System.Windows.Forms.Label label2;
    }
}