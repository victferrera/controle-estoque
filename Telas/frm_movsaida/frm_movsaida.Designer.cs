namespace EstoqueApp.Telas.frm_movsaida
{
    partial class frm_movsaida
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descriacaoLocal = new System.Windows.Forms.TextBox();
            this.txt_localestoque = new System.Windows.Forms.TextBox();
            this.btn_procuraLocal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razaoSocial = new System.Windows.Forms.TextBox();
            this.btn_procuraCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_participante = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_dataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_items = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_unidadeProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_qtdProduto = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.btn_procurarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigoProduto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_items)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_descriacaoLocal);
            this.groupBox4.Controls.Add(this.txt_localestoque);
            this.groupBox4.Controls.Add(this.btn_procuraLocal);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 80);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Local Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição do Local";
            // 
            // txt_descriacaoLocal
            // 
            this.txt_descriacaoLocal.Location = new System.Drawing.Point(185, 45);
            this.txt_descriacaoLocal.Name = "txt_descriacaoLocal";
            this.txt_descriacaoLocal.Size = new System.Drawing.Size(383, 23);
            this.txt_descriacaoLocal.TabIndex = 9;
            // 
            // txt_localestoque
            // 
            this.txt_localestoque.Location = new System.Drawing.Point(6, 44);
            this.txt_localestoque.Name = "txt_localestoque";
            this.txt_localestoque.Size = new System.Drawing.Size(100, 23);
            this.txt_localestoque.TabIndex = 6;
            // 
            // btn_procuraLocal
            // 
            this.btn_procuraLocal.Location = new System.Drawing.Point(112, 44);
            this.btn_procuraLocal.Name = "btn_procuraLocal";
            this.btn_procuraLocal.Size = new System.Drawing.Size(43, 23);
            this.btn_procuraLocal.TabIndex = 8;
            this.btn_procuraLocal.Text = "...";
            this.btn_procuraLocal.UseVisualStyleBackColor = true;
            this.btn_procuraLocal.Click += new System.EventHandler(this.btn_procuraLocal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_razaoSocial);
            this.groupBox3.Controls.Add(this.btn_procuraCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_participante);
            this.groupBox3.Location = new System.Drawing.Point(6, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 81);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Razão Social";
            // 
            // txt_razaoSocial
            // 
            this.txt_razaoSocial.Location = new System.Drawing.Point(185, 45);
            this.txt_razaoSocial.Name = "txt_razaoSocial";
            this.txt_razaoSocial.Size = new System.Drawing.Size(383, 23);
            this.txt_razaoSocial.TabIndex = 4;
            // 
            // btn_procuraCliente
            // 
            this.btn_procuraCliente.Location = new System.Drawing.Point(112, 44);
            this.btn_procuraCliente.Name = "btn_procuraCliente";
            this.btn_procuraCliente.Size = new System.Drawing.Size(43, 23);
            this.btn_procuraCliente.TabIndex = 3;
            this.btn_procuraCliente.Text = "...";
            this.btn_procuraCliente.UseVisualStyleBackColor = true;
            this.btn_procuraCliente.Click += new System.EventHandler(this.btn_procuraCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código";
            // 
            // txt_participante
            // 
            this.txt_participante.Location = new System.Drawing.Point(6, 44);
            this.txt_participante.Name = "txt_participante";
            this.txt_participante.Size = new System.Drawing.Size(100, 23);
            this.txt_participante.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt_dataEmissao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emissão";
            // 
            // dt_dataEmissao
            // 
            this.dt_dataEmissao.Location = new System.Drawing.Point(141, 44);
            this.dt_dataEmissao.Name = "dt_dataEmissao";
            this.dt_dataEmissao.Size = new System.Drawing.Size(200, 23);
            this.dt_dataEmissao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(6, 44);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 23);
            this.txt_numero.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dt_items);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dt_items
            // 
            this.dt_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_items.Location = new System.Drawing.Point(6, 200);
            this.dt_items.Name = "dt_items";
            this.dt_items.RowTemplate.Height = 25;
            this.dt_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_items.Size = new System.Drawing.Size(744, 150);
            this.dt_items.TabIndex = 2;
            this.dt_items.Visible = false;
            this.dt_items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_items_CellDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_remover);
            this.groupBox6.Controls.Add(this.btn_adicionar);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txt_unidadeProduto);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_qtdProduto);
            this.groupBox6.Location = new System.Drawing.Point(6, 91);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(744, 103);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informações de Saída";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(81, 70);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(70, 23);
            this.btn_remover.TabIndex = 6;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(6, 70);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(69, 23);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Unidade";
            // 
            // txt_unidadeProduto
            // 
            this.txt_unidadeProduto.Location = new System.Drawing.Point(112, 41);
            this.txt_unidadeProduto.Name = "txt_unidadeProduto";
            this.txt_unidadeProduto.Size = new System.Drawing.Size(51, 23);
            this.txt_unidadeProduto.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quantidade";
            // 
            // txt_qtdProduto
            // 
            this.txt_qtdProduto.Location = new System.Drawing.Point(6, 41);
            this.txt_qtdProduto.Name = "txt_qtdProduto";
            this.txt_qtdProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_qtdProduto.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_nomeProduto);
            this.groupBox5.Controls.Add(this.btn_procurarProduto);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_codigoProduto);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(744, 79);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informações do Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome do Produto";
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(180, 38);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(382, 23);
            this.txt_nomeProduto.TabIndex = 3;
            // 
            // btn_procurarProduto
            // 
            this.btn_procurarProduto.Location = new System.Drawing.Point(112, 38);
            this.btn_procurarProduto.Name = "btn_procurarProduto";
            this.btn_procurarProduto.Size = new System.Drawing.Size(39, 23);
            this.btn_procurarProduto.TabIndex = 2;
            this.btn_procurarProduto.Text = "...";
            this.btn_procurarProduto.UseVisualStyleBackColor = true;
            this.btn_procurarProduto.Click += new System.EventHandler(this.btn_procurarProduto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Código do Produto";
            // 
            // txt_codigoProduto
            // 
            this.txt_codigoProduto.Location = new System.Drawing.Point(6, 38);
            this.txt_codigoProduto.Name = "txt_codigoProduto";
            this.txt_codigoProduto.Size = new System.Drawing.Size(100, 23);
            this.txt_codigoProduto.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // frm_movsaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_movsaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Saída";
            this.Load += new System.EventHandler(this.frm_movsaida_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_items)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descriacaoLocal;
        private System.Windows.Forms.TextBox txt_localestoque;
        private System.Windows.Forms.Button btn_procuraLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_razaoSocial;
        private System.Windows.Forms.Button btn_procuraCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_participante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_dataEmissao;
        private System.Windows.Forms.DataGridView dt_items;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_unidadeProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_qtdProduto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.Button btn_procurarProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigoProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_adicionar;
    }
}