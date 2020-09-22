namespace PADAWAN.CRUD.View
{
    partial class CadastroMateria
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
            this.lbl_CadastroMateria = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_DataCadastro = new System.Windows.Forms.Label();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.txt_DataCadastro = new System.Windows.Forms.TextBox();
            this.cb_Situacao = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.cb_Curso = new System.Windows.Forms.ComboBox();
            this.lbl_MateriaExcluir = new System.Windows.Forms.Label();
            this.txt_MateriaExcluir = new System.Windows.Forms.TextBox();
            this.lbl_ExcluirMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CadastroMateria
            // 
            this.lbl_CadastroMateria.AutoSize = true;
            this.lbl_CadastroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CadastroMateria.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CadastroMateria.Location = new System.Drawing.Point(167, 32);
            this.lbl_CadastroMateria.Name = "lbl_CadastroMateria";
            this.lbl_CadastroMateria.Size = new System.Drawing.Size(226, 25);
            this.lbl_CadastroMateria.TabIndex = 0;
            this.lbl_CadastroMateria.Text = "Cadastro de Matéria";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descricao.Location = new System.Drawing.Point(79, 139);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(51, 16);
            this.lbl_Descricao.TabIndex = 1;
            this.lbl_Descricao.Text = "Curso:";
            // 
            // lbl_DataCadastro
            // 
            this.lbl_DataCadastro.AutoSize = true;
            this.lbl_DataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataCadastro.Location = new System.Drawing.Point(79, 176);
            this.lbl_DataCadastro.Name = "lbl_DataCadastro";
            this.lbl_DataCadastro.Size = new System.Drawing.Size(111, 16);
            this.lbl_DataCadastro.TabIndex = 2;
            this.lbl_DataCadastro.Text = "Data Cadastro:";
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Situacao.Location = new System.Drawing.Point(79, 213);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(72, 16);
            this.lbl_Situacao.TabIndex = 3;
            this.lbl_Situacao.Text = "Situação:";
            // 
            // txt_DataCadastro
            // 
            this.txt_DataCadastro.Location = new System.Drawing.Point(196, 169);
            this.txt_DataCadastro.Name = "txt_DataCadastro";
            this.txt_DataCadastro.Size = new System.Drawing.Size(192, 23);
            this.txt_DataCadastro.TabIndex = 4;
            this.txt_DataCadastro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_Situacao
            // 
            this.cb_Situacao.FormattingEnabled = true;
            this.cb_Situacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_Situacao.Location = new System.Drawing.Point(196, 206);
            this.cb_Situacao.Name = "cb_Situacao";
            this.cb_Situacao.Size = new System.Drawing.Size(121, 23);
            this.cb_Situacao.TabIndex = 5;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(366, 206);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(167, 391);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(354, 391);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 6;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(79, 102);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_Nome.TabIndex = 7;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(196, 95);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(197, 23);
            this.txt_Nome.TabIndex = 8;
            // 
            // cb_Curso
            // 
            this.cb_Curso.FormattingEnabled = true;
            this.cb_Curso.Location = new System.Drawing.Point(196, 132);
            this.cb_Curso.Name = "cb_Curso";
            this.cb_Curso.Size = new System.Drawing.Size(121, 23);
            this.cb_Curso.TabIndex = 5;
            // 
            // lbl_MateriaExcluir
            // 
            this.lbl_MateriaExcluir.AutoSize = true;
            this.lbl_MateriaExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MateriaExcluir.Location = new System.Drawing.Point(79, 338);
            this.lbl_MateriaExcluir.Name = "lbl_MateriaExcluir";
            this.lbl_MateriaExcluir.Size = new System.Drawing.Size(52, 16);
            this.lbl_MateriaExcluir.TabIndex = 7;
            this.lbl_MateriaExcluir.Text = "Nome:";
            // 
            // txt_MateriaExcluir
            // 
            this.txt_MateriaExcluir.Location = new System.Drawing.Point(196, 331);
            this.txt_MateriaExcluir.Name = "txt_MateriaExcluir";
            this.txt_MateriaExcluir.Size = new System.Drawing.Size(197, 23);
            this.txt_MateriaExcluir.TabIndex = 8;
            // 
            // lbl_ExcluirMateria
            // 
            this.lbl_ExcluirMateria.AutoSize = true;
            this.lbl_ExcluirMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExcluirMateria.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ExcluirMateria.Location = new System.Drawing.Point(167, 281);
            this.lbl_ExcluirMateria.Name = "lbl_ExcluirMateria";
            this.lbl_ExcluirMateria.Size = new System.Drawing.Size(91, 25);
            this.lbl_ExcluirMateria.TabIndex = 0;
            this.lbl_ExcluirMateria.Text = "Excluir:";
            // 
            // CadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 458);
            this.Controls.Add(this.lbl_ExcluirMateria);
            this.Controls.Add(this.txt_MateriaExcluir);
            this.Controls.Add(this.lbl_MateriaExcluir);
            this.Controls.Add(this.cb_Curso);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cb_Situacao);
            this.Controls.Add(this.txt_DataCadastro);
            this.Controls.Add(this.lbl_Situacao);
            this.Controls.Add(this.lbl_DataCadastro);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.lbl_CadastroMateria);
            this.Name = "CadastroMateria";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastroMateria;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_DataCadastro;
        private System.Windows.Forms.Label lbl_Situacao;
        private System.Windows.Forms.TextBox txt_DataCadastro;
        private System.Windows.Forms.ComboBox cb_Situacao;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cb_Curso;
        private System.Windows.Forms.Label lbl_MateriaExcluir;
        private System.Windows.Forms.TextBox txt_MateriaExcluir;
        private System.Windows.Forms.Label lbl_ExcluirMateria;
    }
}