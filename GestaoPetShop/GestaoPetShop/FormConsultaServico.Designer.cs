﻿namespace GestaoPetShop
{
    partial class FormConsultaServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaServico));
            this.comboBox_EscolhaBuscarServico = new System.Windows.Forms.ComboBox();
            this.textBox_BuscarServico = new System.Windows.Forms.TextBox();
            this.servicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_ExcluirServico = new System.Windows.Forms.Button();
            this.button_AlterarServico = new System.Windows.Forms.Button();
            this.button_InserirServico = new System.Windows.Forms.Button();
            this.button_BucarServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_EscolhaBuscarServico
            // 
            this.comboBox_EscolhaBuscarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(211)))), ((int)(((byte)(174)))));
            this.comboBox_EscolhaBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_EscolhaBuscarServico.FormattingEnabled = true;
            this.comboBox_EscolhaBuscarServico.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Descrição"});
            this.comboBox_EscolhaBuscarServico.Location = new System.Drawing.Point(47, 151);
            this.comboBox_EscolhaBuscarServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_EscolhaBuscarServico.Name = "comboBox_EscolhaBuscarServico";
            this.comboBox_EscolhaBuscarServico.Size = new System.Drawing.Size(175, 33);
            this.comboBox_EscolhaBuscarServico.TabIndex = 4;
            this.comboBox_EscolhaBuscarServico.Text = "Buscar Por";
            // 
            // textBox_BuscarServico
            // 
            this.textBox_BuscarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(211)))), ((int)(((byte)(174)))));
            this.textBox_BuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BuscarServico.Location = new System.Drawing.Point(231, 153);
            this.textBox_BuscarServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_BuscarServico.Name = "textBox_BuscarServico";
            this.textBox_BuscarServico.Size = new System.Drawing.Size(764, 30);
            this.textBox_BuscarServico.TabIndex = 5;
            // 
            // servicoDataGridView
            // 
            this.servicoDataGridView.AllowUserToAddRows = false;
            this.servicoDataGridView.AllowUserToDeleteRows = false;
            this.servicoDataGridView.AllowUserToOrderColumns = true;
            this.servicoDataGridView.AutoGenerateColumns = false;
            this.servicoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(211)))), ((int)(((byte)(174)))));
            this.servicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.servicoDataGridView.DataSource = this.servicoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servicoDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.servicoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.servicoDataGridView.Location = new System.Drawing.Point(45, 192);
            this.servicoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.servicoDataGridView.MultiSelect = false;
            this.servicoDataGridView.Name = "servicoDataGridView";
            this.servicoDataGridView.ReadOnly = true;
            this.servicoDataGridView.RowHeadersVisible = false;
            this.servicoDataGridView.RowHeadersWidth = 51;
            this.servicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicoDataGridView.Size = new System.Drawing.Size(951, 471);
            this.servicoDataGridView.TabIndex = 10;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tempo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Models.Servico);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadastrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(545, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alterar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(753, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Excluir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(316, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 44);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consulta de Serviços";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "add-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "editar-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "excluir-removebg-preview.png");
            // 
            // button_ExcluirServico
            // 
            this.button_ExcluirServico.BackColor = System.Drawing.Color.White;
            this.button_ExcluirServico.FlatAppearance.BorderSize = 0;
            this.button_ExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExcluirServico.ForeColor = System.Drawing.Color.Transparent;
            this.button_ExcluirServico.ImageKey = "excluir-removebg-preview.png";
            this.button_ExcluirServico.ImageList = this.imageList1;
            this.button_ExcluirServico.Location = new System.Drawing.Point(753, 59);
            this.button_ExcluirServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ExcluirServico.Name = "button_ExcluirServico";
            this.button_ExcluirServico.Size = new System.Drawing.Size(73, 62);
            this.button_ExcluirServico.TabIndex = 9;
            this.button_ExcluirServico.UseVisualStyleBackColor = false;
            this.button_ExcluirServico.Click += new System.EventHandler(this.button_ExcluirServico_Click);
            // 
            // button_AlterarServico
            // 
            this.button_AlterarServico.BackColor = System.Drawing.Color.White;
            this.button_AlterarServico.FlatAppearance.BorderSize = 0;
            this.button_AlterarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AlterarServico.ForeColor = System.Drawing.Color.Transparent;
            this.button_AlterarServico.ImageKey = "editar-removebg-preview.png";
            this.button_AlterarServico.ImageList = this.imageList1;
            this.button_AlterarServico.Location = new System.Drawing.Point(547, 59);
            this.button_AlterarServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_AlterarServico.Name = "button_AlterarServico";
            this.button_AlterarServico.Size = new System.Drawing.Size(73, 62);
            this.button_AlterarServico.TabIndex = 8;
            this.button_AlterarServico.UseVisualStyleBackColor = false;
            this.button_AlterarServico.Click += new System.EventHandler(this.button_AlterarServico_Click);
            // 
            // button_InserirServico
            // 
            this.button_InserirServico.BackColor = System.Drawing.Color.White;
            this.button_InserirServico.FlatAppearance.BorderSize = 0;
            this.button_InserirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InserirServico.ForeColor = System.Drawing.Color.Transparent;
            this.button_InserirServico.ImageKey = "add-removebg-preview.png";
            this.button_InserirServico.ImageList = this.imageList1;
            this.button_InserirServico.Location = new System.Drawing.Point(352, 59);
            this.button_InserirServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_InserirServico.Name = "button_InserirServico";
            this.button_InserirServico.Size = new System.Drawing.Size(73, 62);
            this.button_InserirServico.TabIndex = 7;
            this.button_InserirServico.UseVisualStyleBackColor = false;
            this.button_InserirServico.Click += new System.EventHandler(this.button_InserirServico_Click);
            // 
            // button_BucarServico
            // 
            this.button_BucarServico.BackColor = System.Drawing.Color.White;
            this.button_BucarServico.FlatAppearance.BorderSize = 0;
            this.button_BucarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BucarServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.button_BucarServico.ImageKey = "buscar-removebg-preview.png";
            this.button_BucarServico.ImageList = this.imageList1;
            this.button_BucarServico.Location = new System.Drawing.Point(191, 59);
            this.button_BucarServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_BucarServico.Name = "button_BucarServico";
            this.button_BucarServico.Size = new System.Drawing.Size(73, 62);
            this.button_BucarServico.TabIndex = 6;
            this.button_BucarServico.UseVisualStyleBackColor = false;
            this.button_BucarServico.Click += new System.EventHandler(this.button_BucarServico_Click);
            // 
            // FormConsultaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicoDataGridView);
            this.Controls.Add(this.button_ExcluirServico);
            this.Controls.Add(this.button_AlterarServico);
            this.Controls.Add(this.button_InserirServico);
            this.Controls.Add(this.button_BucarServico);
            this.Controls.Add(this.textBox_BuscarServico);
            this.Controls.Add(this.comboBox_EscolhaBuscarServico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "FormConsultaServico";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.servicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_EscolhaBuscarServico;
        private System.Windows.Forms.TextBox textBox_BuscarServico;
        private System.Windows.Forms.Button button_BucarServico;
        private System.Windows.Forms.Button button_InserirServico;
        private System.Windows.Forms.Button button_AlterarServico;
        private System.Windows.Forms.Button button_ExcluirServico;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridView servicoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ImageList imageList1;
    }
}