namespace GestaoPetShop
{
    partial class FormConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaUsuario));
            this.textBoxBuscarUsuario = new System.Windows.Forms.TextBox();
            this.comboBoxSelecionarTipoPesquisaUsuario = new System.Windows.Forms.ComboBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonAlterarUsuario = new System.Windows.Forms.Button();
            this.buttonInserirUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarUsuario
            // 
            this.textBoxBuscarUsuario.Location = new System.Drawing.Point(139, 133);
            this.textBoxBuscarUsuario.Name = "textBoxBuscarUsuario";
            this.textBoxBuscarUsuario.Size = new System.Drawing.Size(381, 22);
            this.textBoxBuscarUsuario.TabIndex = 2;
            // 
            // comboBoxSelecionarTipoPesquisaUsuario
            // 
            this.comboBoxSelecionarTipoPesquisaUsuario.FormattingEnabled = true;
            this.comboBoxSelecionarTipoPesquisaUsuario.Items.AddRange(new object[] {
            "Todos",
            "Login",
            "Profissinal",
            "Id Profissional"});
            this.comboBoxSelecionarTipoPesquisaUsuario.Location = new System.Drawing.Point(12, 131);
            this.comboBoxSelecionarTipoPesquisaUsuario.Name = "comboBoxSelecionarTipoPesquisaUsuario";
            this.comboBoxSelecionarTipoPesquisaUsuario.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSelecionarTipoPesquisaUsuario.TabIndex = 3;
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(202, 98);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(75, 29);
            this.buttonBuscarUsuario.TabIndex = 4;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // buttonAlterarUsuario
            // 
            this.buttonAlterarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAlterarUsuario.Location = new System.Drawing.Point(283, 98);
            this.buttonAlterarUsuario.Name = "buttonAlterarUsuario";
            this.buttonAlterarUsuario.Size = new System.Drawing.Size(75, 29);
            this.buttonAlterarUsuario.TabIndex = 5;
            this.buttonAlterarUsuario.Text = "Alterar";
            this.buttonAlterarUsuario.UseVisualStyleBackColor = false;
            this.buttonAlterarUsuario.Click += new System.EventHandler(this.buttonAlterarUsuario_Click);
            // 
            // buttonInserirUsuario
            // 
            this.buttonInserirUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirUsuario.Location = new System.Drawing.Point(364, 98);
            this.buttonInserirUsuario.Name = "buttonInserirUsuario";
            this.buttonInserirUsuario.Size = new System.Drawing.Size(75, 29);
            this.buttonInserirUsuario.TabIndex = 6;
            this.buttonInserirUsuario.Text = "Inserir";
            this.buttonInserirUsuario.UseVisualStyleBackColor = false;
            this.buttonInserirUsuario.Click += new System.EventHandler(this.buttonInserirUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(445, 98);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(75, 29);
            this.buttonExcluirUsuario.TabIndex = 7;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = false;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consulta de Usuário";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AllowUserToResizeColumns = false;
            this.usuarioDataGridView.AllowUserToResizeRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.NomeProfissional,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 161);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(508, 180);
            this.usuarioDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // NomeProfissional
            // 
            this.NomeProfissional.DataPropertyName = "NomeProfissional";
            this.NomeProfissional.HeaderText = "Nome do Profissional";
            this.NomeProfissional.MinimumWidth = 6;
            this.NomeProfissional.Name = "NomeProfissional";
            this.NomeProfissional.ReadOnly = true;
            this.NomeProfissional.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UsuarioLogin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Login do Usuário";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // FormConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonInserirUsuario);
            this.Controls.Add(this.buttonAlterarUsuario);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.comboBoxSelecionarTipoPesquisaUsuario);
            this.Controls.Add(this.textBoxBuscarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox textBoxBuscarUsuario;
        private System.Windows.Forms.ComboBox comboBoxSelecionarTipoPesquisaUsuario;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button buttonAlterarUsuario;
        private System.Windows.Forms.Button buttonInserirUsuario;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}