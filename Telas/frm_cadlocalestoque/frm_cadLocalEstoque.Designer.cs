namespace EstoqueApp.Telas.frm_cadlocalestoque
{
    partial class frm_cadLocalEstoque
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
            this.gp_info = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rt_descricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.num_codigo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.gp_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_info
            // 
            this.gp_info.Controls.Add(this.btn_pesquisar);
            this.gp_info.Controls.Add(this.label3);
            this.gp_info.Controls.Add(this.rt_descricao);
            this.gp_info.Controls.Add(this.label2);
            this.gp_info.Controls.Add(this.txt_nome);
            this.gp_info.Controls.Add(this.num_codigo);
            this.gp_info.Controls.Add(this.label1);
            this.gp_info.Controls.Add(this.btn_cadastrar);
            this.gp_info.Location = new System.Drawing.Point(12, 12);
            this.gp_info.Name = "gp_info";
            this.gp_info.Size = new System.Drawing.Size(550, 304);
            this.gp_info.TabIndex = 8;
            this.gp_info.TabStop = false;
            this.gp_info.Text = "Informações";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(85, 275);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 15;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição";
            // 
            // rt_descricao
            // 
            this.rt_descricao.Location = new System.Drawing.Point(4, 154);
            this.rt_descricao.Name = "rt_descricao";
            this.rt_descricao.Size = new System.Drawing.Size(540, 98);
            this.rt_descricao.TabIndex = 13;
            this.rt_descricao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(4, 101);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(270, 23);
            this.txt_nome.TabIndex = 11;
            // 
            // num_codigo
            // 
            this.num_codigo.Location = new System.Drawing.Point(4, 47);
            this.num_codigo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_codigo.Name = "num_codigo";
            this.num_codigo.Size = new System.Drawing.Size(120, 23);
            this.num_codigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(4, 275);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // frm_cadLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 325);
            this.Controls.Add(this.gp_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_cadLocalEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Local de Estoque";
            this.gp_info.ResumeLayout(false);
            this.gp_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_codigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rt_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.NumericUpDown num_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}