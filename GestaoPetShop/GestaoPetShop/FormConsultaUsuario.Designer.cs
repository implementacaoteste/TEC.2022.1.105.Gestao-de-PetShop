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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaUsuario));
            this.textBoxBuscarUsuario = new System.Windows.Forms.TextBox();
            this.comboBoxSelecionarTipoPesquisaUsuario = new System.Windows.Forms.ComboBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonAlterarUsuario = new System.Windows.Forms.Button();
            this.buttonInserirUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarUsuario
            // 
            this.textBoxBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarUsuario.Location = new System.Drawing.Point(142, 33);
            this.textBoxBuscarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarUsuario.Name = "textBoxBuscarUsuario";
            this.textBoxBuscarUsuario.Size = new System.Drawing.Size(132, 26);
            this.textBoxBuscarUsuario.TabIndex = 1;
            // 
            // comboBoxSelecionarTipoPesquisaUsuario
            // 
            this.comboBoxSelecionarTipoPesquisaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSelecionarTipoPesquisaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecionarTipoPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelecionarTipoPesquisaUsuario.FormattingEnabled = true;
            this.comboBoxSelecionarTipoPesquisaUsuario.Items.AddRange(new object[] {
            "Todos",
            "Login",
            "Profissional",
            "Id Profissional"});
            this.comboBoxSelecionarTipoPesquisaUsuario.Location = new System.Drawing.Point(9, 33);
            this.comboBoxSelecionarTipoPesquisaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelecionarTipoPesquisaUsuario.Name = "comboBoxSelecionarTipoPesquisaUsuario";
            this.comboBoxSelecionarTipoPesquisaUsuario.Size = new System.Drawing.Size(129, 28);
            this.comboBoxSelecionarTipoPesquisaUsuario.TabIndex = 0;
            this.comboBoxSelecionarTipoPesquisaUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecionarTipoPesquisaUsuario_SelectedIndexChanged);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(278, 31);
            this.buttonBuscarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(141, 30);
            this.buttonBuscarUsuario.TabIndex = 2;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // buttonAlterarUsuario
            // 
            this.buttonAlterarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAlterarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarUsuario.Location = new System.Drawing.Point(423, 31);
            this.buttonAlterarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterarUsuario.Name = "buttonAlterarUsuario";
            this.buttonAlterarUsuario.Size = new System.Drawing.Size(141, 30);
            this.buttonAlterarUsuario.TabIndex = 5;
            this.buttonAlterarUsuario.Text = "Alterar";
            this.buttonAlterarUsuario.UseVisualStyleBackColor = false;
            this.buttonAlterarUsuario.Click += new System.EventHandler(this.buttonAlterarUsuario_Click);
            // 
            // buttonInserirUsuario
            // 
            this.buttonInserirUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInserirUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirUsuario.Location = new System.Drawing.Point(568, 31);
            this.buttonInserirUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserirUsuario.Name = "buttonInserirUsuario";
            this.buttonInserirUsuario.Size = new System.Drawing.Size(141, 30);
            this.buttonInserirUsuario.TabIndex = 4;
            this.buttonInserirUsuario.Text = "Inserir";
            this.buttonInserirUsuario.UseVisualStyleBackColor = false;
            this.buttonInserirUsuario.Click += new System.EventHandler(this.buttonInserirUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExcluirUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(713, 31);
            this.buttonExcluirUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(141, 30);
            this.buttonExcluirUsuario.TabIndex = 6;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = false;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
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
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.NomeProfissional,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usuarioDataGridView.Location = new System.Drawing.Point(9, 67);
            this.usuarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(845, 437);
            this.usuarioDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // NomeProfissional
            // 
            this.NomeProfissional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeProfissional.DataPropertyName = "NomeProfissional";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProfissional.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeProfissional.HeaderText = "Nome do Profissional";
            this.NomeProfissional.MinimumWidth = 6;
            this.NomeProfissional.Name = "NomeProfissional";
            this.NomeProfissional.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UsuarioLogin";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Login do Usuário";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Ativo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = false;
            this.dataGridViewCheckBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Digite (login, nome do profissional ou id)";
            // 
            // FormConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonInserirUsuario);
            this.Controls.Add(this.buttonAlterarUsuario);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.comboBoxSelecionarTipoPesquisaUsuario);
            this.Controls.Add(this.textBoxBuscarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR USUÁRIO";
            this.Load += new System.EventHandler(this.FormConsultaUsuario_Load);
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
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}