namespace EstoqueApp.form_cad_produto
{
    partial class frm_cad_produto
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
            this.lbl_cad_produto_nome = new System.Windows.Forms.Label();
            this.txtbox_cad_produto_nome = new System.Windows.Forms.TextBox();
            this.lbl_cad_produto_descricao = new System.Windows.Forms.Label();
            this.lbl_cad_produto_status = new System.Windows.Forms.Label();
            this.cbox_cad_produto_status = new System.Windows.Forms.ComboBox();
            this.cbox_cad_produto_unidade = new System.Windows.Forms.ComboBox();
            this.lbl_cad_produto_unidade = new System.Windows.Forms.Label();
            this.grbox_cad_produto = new System.Windows.Forms.GroupBox();
            this.txtbox_cad_produto_descricao = new System.Windows.Forms.TextBox();
            this.grbox_cad_produto_precos = new System.Windows.Forms.GroupBox();
            this.lbl_cad_produto_compra = new System.Windows.Forms.Label();
            this.txtbox_cad_produto_compra = new System.Windows.Forms.TextBox();
            this.lbl_cad_produto_venda = new System.Windows.Forms.Label();
            this.txtbox_cad_produto_venda = new System.Windows.Forms.TextBox();
            this.gb_acoes = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.grbox_cad_produto.SuspendLayout();
            this.grbox_cad_produto_precos.SuspendLayout();
            this.gb_acoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cad_produto_nome
            // 
            this.lbl_cad_produto_nome.AutoSize = true;
            this.lbl_cad_produto_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_nome.Location = new System.Drawing.Point(5, 121);
            this.lbl_cad_produto_nome.Name = "lbl_cad_produto_nome";
            this.lbl_cad_produto_nome.Size = new System.Drawing.Size(62, 24);
            this.lbl_cad_produto_nome.TabIndex = 2;
            this.lbl_cad_produto_nome.Text = "Nome";
            // 
            // txtbox_cad_produto_nome
            // 
            this.txtbox_cad_produto_nome.Enabled = false;
            this.txtbox_cad_produto_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cad_produto_nome.Location = new System.Drawing.Point(83, 123);
            this.txtbox_cad_produto_nome.Name = "txtbox_cad_produto_nome";
            this.txtbox_cad_produto_nome.Size = new System.Drawing.Size(221, 22);
            this.txtbox_cad_produto_nome.TabIndex = 3;
            // 
            // lbl_cad_produto_descricao
            // 
            this.lbl_cad_produto_descricao.AutoSize = true;
            this.lbl_cad_produto_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_descricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_descricao.Location = new System.Drawing.Point(5, 160);
            this.lbl_cad_produto_descricao.Name = "lbl_cad_produto_descricao";
            this.lbl_cad_produto_descricao.Size = new System.Drawing.Size(94, 24);
            this.lbl_cad_produto_descricao.TabIndex = 4;
            this.lbl_cad_produto_descricao.Text = "Descrição";
            // 
            // lbl_cad_produto_status
            // 
            this.lbl_cad_produto_status.AutoSize = true;
            this.lbl_cad_produto_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_status.Location = new System.Drawing.Point(5, 69);
            this.lbl_cad_produto_status.Name = "lbl_cad_produto_status";
            this.lbl_cad_produto_status.Size = new System.Drawing.Size(60, 24);
            this.lbl_cad_produto_status.TabIndex = 6;
            this.lbl_cad_produto_status.Text = "Status";
            // 
            // cbox_cad_produto_status
            // 
            this.cbox_cad_produto_status.Enabled = false;
            this.cbox_cad_produto_status.FormattingEnabled = true;
            this.cbox_cad_produto_status.Location = new System.Drawing.Point(83, 72);
            this.cbox_cad_produto_status.Name = "cbox_cad_produto_status";
            this.cbox_cad_produto_status.Size = new System.Drawing.Size(170, 24);
            this.cbox_cad_produto_status.TabIndex = 7;
            this.cbox_cad_produto_status.Text = "Selecione o status...";
            // 
            // cbox_cad_produto_unidade
            // 
            this.cbox_cad_produto_unidade.Enabled = false;
            this.cbox_cad_produto_unidade.FormattingEnabled = true;
            this.cbox_cad_produto_unidade.Location = new System.Drawing.Point(438, 74);
            this.cbox_cad_produto_unidade.MaxLength = 2;
            this.cbox_cad_produto_unidade.Name = "cbox_cad_produto_unidade";
            this.cbox_cad_produto_unidade.Size = new System.Drawing.Size(153, 24);
            this.cbox_cad_produto_unidade.TabIndex = 11;
            this.cbox_cad_produto_unidade.Text = "Selecione a UN...";
            // 
            // lbl_cad_produto_unidade
            // 
            this.lbl_cad_produto_unidade.AutoSize = true;
            this.lbl_cad_produto_unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_unidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_unidade.Location = new System.Drawing.Point(338, 74);
            this.lbl_cad_produto_unidade.Name = "lbl_cad_produto_unidade";
            this.lbl_cad_produto_unidade.Size = new System.Drawing.Size(81, 24);
            this.lbl_cad_produto_unidade.TabIndex = 10;
            this.lbl_cad_produto_unidade.Text = "Unidade";
            // 
            // grbox_cad_produto
            // 
            this.grbox_cad_produto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox_cad_produto.Controls.Add(this.txtbox_cad_produto_descricao);
            this.grbox_cad_produto.Controls.Add(this.grbox_cad_produto_precos);
            this.grbox_cad_produto.Controls.Add(this.cbox_cad_produto_unidade);
            this.grbox_cad_produto.Controls.Add(this.lbl_cad_produto_unidade);
            this.grbox_cad_produto.Controls.Add(this.lbl_cad_produto_nome);
            this.grbox_cad_produto.Controls.Add(this.txtbox_cad_produto_nome);
            this.grbox_cad_produto.Controls.Add(this.lbl_cad_produto_descricao);
            this.grbox_cad_produto.Controls.Add(this.cbox_cad_produto_status);
            this.grbox_cad_produto.Controls.Add(this.lbl_cad_produto_status);
            this.grbox_cad_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_cad_produto.Location = new System.Drawing.Point(6, 12);
            this.grbox_cad_produto.Name = "grbox_cad_produto";
            this.grbox_cad_produto.Size = new System.Drawing.Size(703, 405);
            this.grbox_cad_produto.TabIndex = 13;
            this.grbox_cad_produto.TabStop = false;
            this.grbox_cad_produto.Text = "Novo Cadastro";
            // 
            // txtbox_cad_produto_descricao
            // 
            this.txtbox_cad_produto_descricao.Enabled = false;
            this.txtbox_cad_produto_descricao.Location = new System.Drawing.Point(9, 187);
            this.txtbox_cad_produto_descricao.Multiline = true;
            this.txtbox_cad_produto_descricao.Name = "txtbox_cad_produto_descricao";
            this.txtbox_cad_produto_descricao.Size = new System.Drawing.Size(675, 72);
            this.txtbox_cad_produto_descricao.TabIndex = 13;
            // 
            // grbox_cad_produto_precos
            // 
            this.grbox_cad_produto_precos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox_cad_produto_precos.Controls.Add(this.lbl_cad_produto_compra);
            this.grbox_cad_produto_precos.Controls.Add(this.txtbox_cad_produto_compra);
            this.grbox_cad_produto_precos.Controls.Add(this.lbl_cad_produto_venda);
            this.grbox_cad_produto_precos.Controls.Add(this.txtbox_cad_produto_venda);
            this.grbox_cad_produto_precos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_cad_produto_precos.Location = new System.Drawing.Point(9, 280);
            this.grbox_cad_produto_precos.Name = "grbox_cad_produto_precos";
            this.grbox_cad_produto_precos.Size = new System.Drawing.Size(675, 97);
            this.grbox_cad_produto_precos.TabIndex = 12;
            this.grbox_cad_produto_precos.TabStop = false;
            this.grbox_cad_produto_precos.Text = "Preços";
            // 
            // lbl_cad_produto_compra
            // 
            this.lbl_cad_produto_compra.AutoSize = true;
            this.lbl_cad_produto_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_compra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_compra.Location = new System.Drawing.Point(6, 58);
            this.lbl_cad_produto_compra.Name = "lbl_cad_produto_compra";
            this.lbl_cad_produto_compra.Size = new System.Drawing.Size(77, 24);
            this.lbl_cad_produto_compra.TabIndex = 15;
            this.lbl_cad_produto_compra.Text = "Compra";
            // 
            // txtbox_cad_produto_compra
            // 
            this.txtbox_cad_produto_compra.Enabled = false;
            this.txtbox_cad_produto_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cad_produto_compra.Location = new System.Drawing.Point(84, 60);
            this.txtbox_cad_produto_compra.Name = "txtbox_cad_produto_compra";
            this.txtbox_cad_produto_compra.Size = new System.Drawing.Size(111, 22);
            this.txtbox_cad_produto_compra.TabIndex = 16;
            // 
            // lbl_cad_produto_venda
            // 
            this.lbl_cad_produto_venda.AutoSize = true;
            this.lbl_cad_produto_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad_produto_venda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cad_produto_venda.Location = new System.Drawing.Point(6, 30);
            this.lbl_cad_produto_venda.Name = "lbl_cad_produto_venda";
            this.lbl_cad_produto_venda.Size = new System.Drawing.Size(66, 24);
            this.lbl_cad_produto_venda.TabIndex = 13;
            this.lbl_cad_produto_venda.Text = "Venda";
            // 
            // txtbox_cad_produto_venda
            // 
            this.txtbox_cad_produto_venda.Enabled = false;
            this.txtbox_cad_produto_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cad_produto_venda.Location = new System.Drawing.Point(84, 32);
            this.txtbox_cad_produto_venda.Name = "txtbox_cad_produto_venda";
            this.txtbox_cad_produto_venda.Size = new System.Drawing.Size(111, 22);
            this.txtbox_cad_produto_venda.TabIndex = 14;
            // 
            // gb_acoes
            // 
            this.gb_acoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_acoes.Controls.Add(this.btn_pesquisar);
            this.gb_acoes.Controls.Add(this.btn_salvar);
            this.gb_acoes.Controls.Add(this.btn_novo);
            this.gb_acoes.Location = new System.Drawing.Point(6, 423);
            this.gb_acoes.Name = "gb_acoes";
            this.gb_acoes.Size = new System.Drawing.Size(703, 59);
            this.gb_acoes.TabIndex = 14;
            this.gb_acoes.TabStop = false;
            this.gb_acoes.Text = "Ações";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(181, 28);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(80, 25);
            this.btn_pesquisar.TabIndex = 23;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(95, 28);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(80, 25);
            this.btn_salvar.TabIndex = 22;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(9, 28);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(80, 25);
            this.btn_novo.TabIndex = 21;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // frm_cad_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 492);
            this.Controls.Add(this.gb_acoes);
            this.Controls.Add(this.grbox_cad_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cad_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.grbox_cad_produto.ResumeLayout(false);
            this.grbox_cad_produto.PerformLayout();
            this.grbox_cad_produto_precos.ResumeLayout(false);
            this.grbox_cad_produto_precos.PerformLayout();
            this.gb_acoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_cad_produto_nome;
        private System.Windows.Forms.TextBox txtbox_cad_produto_nome;
        private System.Windows.Forms.Label lbl_cad_produto_descricao;
        private System.Windows.Forms.Label lbl_cad_produto_status;
        private System.Windows.Forms.ComboBox cbox_cad_produto_status;
        private System.Windows.Forms.ComboBox cbox_cad_produto_unidade;
        private System.Windows.Forms.Label lbl_cad_produto_unidade;
        private System.Windows.Forms.GroupBox grbox_cad_produto;
        private System.Windows.Forms.GroupBox grbox_cad_produto_precos;
        private System.Windows.Forms.Label lbl_cad_produto_compra;
        private System.Windows.Forms.TextBox txtbox_cad_produto_compra;
        private System.Windows.Forms.Label lbl_cad_produto_venda;
        private System.Windows.Forms.TextBox txtbox_cad_produto_venda;
        private System.Windows.Forms.TextBox txtbox_cad_produto_descricao;
        private System.Windows.Forms.GroupBox gb_acoes;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
    }
}