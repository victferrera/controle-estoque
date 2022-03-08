namespace EstoqueApp.Telas.frm_pesquisaProduto
{
    partial class frm_pesquisa_produto
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
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_inativos = new System.Windows.Forms.RadioButton();
            this.rb_ativos = new System.Windows.Forms.RadioButton();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.grid_produtos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_inativos);
            this.groupBox1.Controls.Add(this.rb_ativos);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.txt_filtro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(135, 56);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 4;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_inativos
            // 
            this.rb_inativos.AutoSize = true;
            this.rb_inativos.Location = new System.Drawing.Point(67, 56);
            this.rb_inativos.Name = "rb_inativos";
            this.rb_inativos.Size = new System.Drawing.Size(62, 17);
            this.rb_inativos.TabIndex = 3;
            this.rb_inativos.TabStop = true;
            this.rb_inativos.Text = "Inativos";
            this.rb_inativos.UseVisualStyleBackColor = true;
            // 
            // rb_ativos
            // 
            this.rb_ativos.AutoSize = true;
            this.rb_ativos.Location = new System.Drawing.Point(7, 56);
            this.rb_ativos.Name = "rb_ativos";
            this.rb_ativos.Size = new System.Drawing.Size(54, 17);
            this.rb_ativos.TabIndex = 2;
            this.rb_ativos.TabStop = true;
            this.rb_ativos.Text = "Ativos";
            this.rb_ativos.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(607, 29);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 1;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(7, 29);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(594, 20);
            this.txt_filtro.TabIndex = 0;
            // 
            // grid_produtos
            // 
            this.grid_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_produtos.Location = new System.Drawing.Point(12, 114);
            this.grid_produtos.Name = "grid_produtos";
            this.grid_produtos.Size = new System.Drawing.Size(697, 186);
            this.grid_produtos.TabIndex = 1;
            this.grid_produtos.Visible = false;
            // 
            // frm_pesquisa_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(721, 312);
            this.Controls.Add(this.grid_produtos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_pesquisa_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produto";
            this.Load += new System.EventHandler(this.frm_pesquisa_produto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_inativos;
        private System.Windows.Forms.RadioButton rb_ativos;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.DataGridView grid_produtos;
    }
}