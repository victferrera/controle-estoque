namespace EstoqueApp.Telas
{
    partial class frm_moventrada
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
            this.tab_informacoes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_localDescricao = new System.Windows.Forms.TextBox();
            this.txt_LocalEstoque = new System.Windows.Forms.TextBox();
            this.btn_procurarLocal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nomeParticipante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigoParticipante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_emissao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nm_movtoNumero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_itemMovto = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_removerProduto = new System.Windows.Forms.Button();
            this.btn_adicionarItem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_unidadeProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_qtdEntrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_procurarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigoProduto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_informacoes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_movtoNumero)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_itemMovto)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_informacoes
            // 
            this.tab_informacoes.Controls.Add(this.tabPage1);
            this.tab_informacoes.Controls.Add(this.tabPage2);
            this.tab_informacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_informacoes.Location = new System.Drawing.Point(12, 27);
            this.tab_informacoes.Name = "tab_informacoes";
            this.tab_informacoes.SelectedIndex = 0;
            this.tab_informacoes.Size = new System.Drawing.Size(783, 512);
            this.tab_informacoes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_localDescricao);
            this.groupBox3.Controls.Add(this.txt_LocalEstoque);
            this.groupBox3.Controls.Add(this.btn_procurarLocal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição";
            // 
            // txt_localDescricao
            // 
            this.txt_localDescricao.Location = new System.Drawing.Point(162, 38);
            this.txt_localDescricao.Name = "txt_localDescricao";
            this.txt_localDescricao.Size = new System.Drawing.Size(403, 23);
            this.txt_localDescricao.TabIndex = 9;
            // 
            // txt_LocalEstoque
            // 
            this.txt_LocalEstoque.Location = new System.Drawing.Point(3, 38);
            this.txt_LocalEstoque.Name = "txt_LocalEstoque";
            this.txt_LocalEstoque.Size = new System.Drawing.Size(100, 23);
            this.txt_LocalEstoque.TabIndex = 6;
            // 
            // btn_procurarLocal
            // 
            this.btn_procurarLocal.Location = new System.Drawing.Point(109, 38);
            this.btn_procurarLocal.Name = "btn_procurarLocal";
            this.btn_procurarLocal.Size = new System.Drawing.Size(41, 23);
            this.btn_procurarLocal.TabIndex = 8;
            this.btn_procurarLocal.Text = "...";
            this.btn_procurarLocal.UseVisualStyleBackColor = true;
            this.btn_procurarLocal.Click += new System.EventHandler(this.btn_procurarLocal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Local";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_nomeParticipante);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_codigoParticipante);
            this.groupBox2.Location = new System.Drawing.Point(3, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Cliente/Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Razão Social";
            // 
            // txt_nomeParticipante
            // 
            this.txt_nomeParticipante.Location = new System.Drawing.Point(165, 37);
            this.txt_nomeParticipante.Name = "txt_nomeParticipante";
            this.txt_nomeParticipante.Size = new System.Drawing.Size(403, 23);
            this.txt_nomeParticipante.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // txt_codigoParticipante
            // 
            this.txt_codigoParticipante.Location = new System.Drawing.Point(6, 37);
            this.txt_codigoParticipante.Name = "txt_codigoParticipante";
            this.txt_codigoParticipante.Size = new System.Drawing.Size(100, 23);
            this.txt_codigoParticipante.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_emissao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nm_movtoNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Documento";
            // 
            // dt_emissao
            // 
            this.dt_emissao.Location = new System.Drawing.Point(165, 39);
            this.dt_emissao.Name = "dt_emissao";
            this.dt_emissao.Size = new System.Drawing.Size(200, 23);
            this.dt_emissao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Emissão";
            // 
            // nm_movtoNumero
            // 
            this.nm_movtoNumero.Location = new System.Drawing.Point(6, 39);
            this.nm_movtoNumero.Name = "nm_movtoNumero";
            this.nm_movtoNumero.Size = new System.Drawing.Size(120, 23);
            this.nm_movtoNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dt_itemMovto);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item";
            // 
            // dt_itemMovto
            // 
            this.dt_itemMovto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_itemMovto.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dt_itemMovto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_itemMovto.Location = new System.Drawing.Point(6, 270);
            this.dt_itemMovto.MultiSelect = false;
            this.dt_itemMovto.Name = "dt_itemMovto";
            this.dt_itemMovto.RowTemplate.Height = 25;
            this.dt_itemMovto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_itemMovto.Size = new System.Drawing.Size(763, 208);
            this.dt_itemMovto.TabIndex = 2;
            this.dt_itemMovto.Visible = false;
            this.dt_itemMovto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_itemMovto_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_removerProduto);
            this.groupBox4.Controls.Add(this.btn_adicionarItem);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(763, 258);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações do Item";
            // 
            // btn_removerProduto
            // 
            this.btn_removerProduto.Location = new System.Drawing.Point(87, 222);
            this.btn_removerProduto.Name = "btn_removerProduto";
            this.btn_removerProduto.Size = new System.Drawing.Size(72, 23);
            this.btn_removerProduto.TabIndex = 11;
            this.btn_removerProduto.Text = "Remover";
            this.btn_removerProduto.UseVisualStyleBackColor = true;
            this.btn_removerProduto.Click += new System.EventHandler(this.btn_removerProduto_Click);
            // 
            // btn_adicionarItem
            // 
            this.btn_adicionarItem.Location = new System.Drawing.Point(12, 222);
            this.btn_adicionarItem.Name = "btn_adicionarItem";
            this.btn_adicionarItem.Size = new System.Drawing.Size(69, 23);
            this.btn_adicionarItem.TabIndex = 10;
            this.btn_adicionarItem.Text = "Adicionar";
            this.btn_adicionarItem.UseVisualStyleBackColor = true;
            this.btn_adicionarItem.Click += new System.EventHandler(this.btn_adicionarItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txt_unidadeProduto);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txt_qtdEntrada);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_nomeProduto);
            this.groupBox6.Location = new System.Drawing.Point(6, 96);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(454, 120);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Unidade";
            // 
            // txt_unidadeProduto
            // 
            this.txt_unidadeProduto.Location = new System.Drawing.Point(122, 91);
            this.txt_unidadeProduto.Name = "txt_unidadeProduto";
            this.txt_unidadeProduto.ReadOnly = true;
            this.txt_unidadeProduto.Size = new System.Drawing.Size(51, 23);
            this.txt_unidadeProduto.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quantidade Entrada";
            // 
            // txt_qtdEntrada
            // 
            this.txt_qtdEntrada.Location = new System.Drawing.Point(6, 91);
            this.txt_qtdEntrada.Name = "txt_qtdEntrada";
            this.txt_qtdEntrada.Size = new System.Drawing.Size(100, 23);
            this.txt_qtdEntrada.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nome";
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(6, 39);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.ReadOnly = true;
            this.txt_nomeProduto.Size = new System.Drawing.Size(387, 23);
            this.txt_nomeProduto.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.btn_procurarProduto);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_codigoProduto);
            this.groupBox5.Location = new System.Drawing.Point(6, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 65);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar Item";
            // 
            // btn_procurarProduto
            // 
            this.btn_procurarProduto.Location = new System.Drawing.Point(112, 36);
            this.btn_procurarProduto.Name = "btn_procurarProduto";
            this.btn_procurarProduto.Size = new System.Drawing.Size(41, 23);
            this.btn_procurarProduto.TabIndex = 9;
            this.btn_procurarProduto.Text = "...";
            this.btn_procurarProduto.UseVisualStyleBackColor = true;
            this.btn_procurarProduto.Click += new System.EventHandler(this.btn_procurarProduto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código";
            // 
            // txt_codigoProduto
            // 
            this.txt_codigoProduto.Location = new System.Drawing.Point(6, 36);
            this.txt_codigoProduto.Name = "txt_codigoProduto";
            this.txt_codigoProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_codigoProduto.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem1,
            this.excluirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.salvarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // frm_moventrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 551);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tab_informacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_moventrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Entrada";
            this.Load += new System.EventHandler(this.frm_moventrada_Load);
            this.tab_informacoes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_movtoNumero)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_itemMovto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_informacoes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_localDescricao;
        private System.Windows.Forms.TextBox txt_LocalEstoque;
        private System.Windows.Forms.Button btn_procurarLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nomeParticipante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigoParticipante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nm_movtoNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_adicionarItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_qtdEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_procurarProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigoProduto;
        private System.Windows.Forms.DateTimePicker dt_emissao;
        private System.Windows.Forms.Button btn_removerProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_unidadeProduto;
        private System.Windows.Forms.DataGridView dt_itemMovto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}