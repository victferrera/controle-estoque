namespace EstoqueApp.form_cad_pesquisa
{
    partial class frm_cad_pesquisa
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
            this.grbox_cad_pesquisa_filtros = new System.Windows.Forms.GroupBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.lbl_cad_pesquisa_filtro = new System.Windows.Forms.Label();
            this.btn_cad_pesquisa_pesquisar = new System.Windows.Forms.Button();
            this.txt_cad_pesquisa_filtro = new System.Windows.Forms.TextBox();
            this.grid_cad_pesquisa_cadastros = new System.Windows.Forms.DataGridView();
            this.grbox_cad_pesquisa_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_pesquisa_cadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox_cad_pesquisa_filtros
            // 
            this.grbox_cad_pesquisa_filtros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.lbl_filtro);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.lbl_cad_pesquisa_filtro);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.btn_cad_pesquisa_pesquisar);
            this.grbox_cad_pesquisa_filtros.Controls.Add(this.txt_cad_pesquisa_filtro);
            this.grbox_cad_pesquisa_filtros.Location = new System.Drawing.Point(13, 5);
            this.grbox_cad_pesquisa_filtros.Name = "grbox_cad_pesquisa_filtros";
            this.grbox_cad_pesquisa_filtros.Size = new System.Drawing.Size(775, 77);
            this.grbox_cad_pesquisa_filtros.TabIndex = 0;
            this.grbox_cad_pesquisa_filtros.TabStop = false;
            this.grbox_cad_pesquisa_filtros.Text = "Filtro";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(7, 22);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(410, 16);
            this.lbl_filtro.TabIndex = 3;
            this.lbl_filtro.Text = "Para realizar a pesquisa informe Código, Sigla, Descrição ou Status";
            // 
            // lbl_cad_pesquisa_filtro
            // 
            this.lbl_cad_pesquisa_filtro.AutoSize = true;
            this.lbl_cad_pesquisa_filtro.Location = new System.Drawing.Point(7, 20);
            this.lbl_cad_pesquisa_filtro.Name = "lbl_cad_pesquisa_filtro";
            this.lbl_cad_pesquisa_filtro.Size = new System.Drawing.Size(0, 13);
            this.lbl_cad_pesquisa_filtro.TabIndex = 2;
            // 
            // btn_cad_pesquisa_pesquisar
            // 
            this.btn_cad_pesquisa_pesquisar.Location = new System.Drawing.Point(583, 39);
            this.btn_cad_pesquisa_pesquisar.Name = "btn_cad_pesquisa_pesquisar";
            this.btn_cad_pesquisa_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_pesquisa_pesquisar.TabIndex = 1;
            this.btn_cad_pesquisa_pesquisar.Text = "Pesquisar";
            this.btn_cad_pesquisa_pesquisar.UseVisualStyleBackColor = true;
            this.btn_cad_pesquisa_pesquisar.Click += new System.EventHandler(this.btn_cad_pesquisa_pesquisar_Click);
            // 
            // txt_cad_pesquisa_filtro
            // 
            this.txt_cad_pesquisa_filtro.Location = new System.Drawing.Point(7, 41);
            this.txt_cad_pesquisa_filtro.Name = "txt_cad_pesquisa_filtro";
            this.txt_cad_pesquisa_filtro.Size = new System.Drawing.Size(569, 20);
            this.txt_cad_pesquisa_filtro.TabIndex = 0;
            // 
            // grid_cad_pesquisa_cadastros
            // 
            this.grid_cad_pesquisa_cadastros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_cad_pesquisa_cadastros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_cad_pesquisa_cadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cad_pesquisa_cadastros.Location = new System.Drawing.Point(13, 88);
            this.grid_cad_pesquisa_cadastros.Name = "grid_cad_pesquisa_cadastros";
            this.grid_cad_pesquisa_cadastros.Size = new System.Drawing.Size(775, 350);
            this.grid_cad_pesquisa_cadastros.TabIndex = 1;
            this.grid_cad_pesquisa_cadastros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_cad_pesquisa_cadastros_KeyPress);
            // 
            // frm_cad_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_cad_pesquisa_cadastros);
            this.Controls.Add(this.grbox_cad_pesquisa_filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_cad_pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.grbox_cad_pesquisa_filtros.ResumeLayout(false);
            this.grbox_cad_pesquisa_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cad_pesquisa_cadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox_cad_pesquisa_filtros;
        internal System.Windows.Forms.DataGridView grid_cad_pesquisa_cadastros;
        private System.Windows.Forms.Button btn_cad_pesquisa_pesquisar;
        private System.Windows.Forms.TextBox txt_cad_pesquisa_filtro;
        private System.Windows.Forms.Label lbl_cad_pesquisa_filtro;
        private System.Windows.Forms.Label lbl_filtro;
    }
}