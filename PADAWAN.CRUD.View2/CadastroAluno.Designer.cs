namespace PADAWAN.CRUD.View
{
    partial class CadastroAluno
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
            this.lbl_CadastroAluno = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.txt_Datanasc = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.cb_Curso = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.txt_CpfExcluir = new System.Windows.Forms.TextBox();
            this.lbl_ExcluirAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CadastroAluno
            // 
            this.lbl_CadastroAluno.AutoSize = true;
            this.lbl_CadastroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CadastroAluno.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CadastroAluno.Location = new System.Drawing.Point(190, 23);
            this.lbl_CadastroAluno.Name = "lbl_CadastroAluno";
            this.lbl_CadastroAluno.Size = new System.Drawing.Size(207, 25);
            this.lbl_CadastroAluno.TabIndex = 0;
            this.lbl_CadastroAluno.Text = "Cadastro de Aluno";
            this.lbl_CadastroAluno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(82, 101);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sobrenome.Location = new System.Drawing.Point(82, 136);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(91, 16);
            this.lbl_Sobrenome.TabIndex = 2;
            this.lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datanasc.Location = new System.Drawing.Point(82, 172);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(152, 16);
            this.lbl_datanasc.TabIndex = 3;
            this.lbl_datanasc.Text = "Data de Nascimento:";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cpf.Location = new System.Drawing.Point(88, 208);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(40, 16);
            this.lbl_Cpf.TabIndex = 4;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Curso.Location = new System.Drawing.Point(88, 248);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(51, 16);
            this.lbl_Curso.TabIndex = 5;
            this.lbl_Curso.Text = "Curso:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(190, 94);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(317, 23);
            this.txt_Nome.TabIndex = 6;
            // 
            // txt_Sobrenome
            // 
            this.txt_Sobrenome.Location = new System.Drawing.Point(190, 129);
            this.txt_Sobrenome.Name = "txt_Sobrenome";
            this.txt_Sobrenome.Size = new System.Drawing.Size(317, 23);
            this.txt_Sobrenome.TabIndex = 6;
            // 
            // txt_Datanasc
            // 
            this.txt_Datanasc.Location = new System.Drawing.Point(250, 165);
            this.txt_Datanasc.Name = "txt_Datanasc";
            this.txt_Datanasc.Size = new System.Drawing.Size(127, 23);
            this.txt_Datanasc.TabIndex = 6;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(190, 201);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(199, 23);
            this.txt_Cpf.TabIndex = 6;
            // 
            // cb_Curso
            // 
            this.cb_Curso.FormattingEnabled = true;
            this.cb_Curso.Location = new System.Drawing.Point(190, 241);
            this.cb_Curso.Name = "cb_Curso";
            this.cb_Curso.Size = new System.Drawing.Size(121, 23);
            this.cb_Curso.TabIndex = 7;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(432, 240);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(314, 432);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(155, 432);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 10;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CPF.Location = new System.Drawing.Point(94, 390);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(40, 16);
            this.lb_CPF.TabIndex = 4;
            this.lb_CPF.Text = "CPF:";
            // 
            // txt_CpfExcluir
            // 
            this.txt_CpfExcluir.Location = new System.Drawing.Point(155, 383);
            this.txt_CpfExcluir.Name = "txt_CpfExcluir";
            this.txt_CpfExcluir.Size = new System.Drawing.Size(199, 23);
            this.txt_CpfExcluir.TabIndex = 6;
            // 
            // lbl_ExcluirAluno
            // 
            this.lbl_ExcluirAluno.AutoSize = true;
            this.lbl_ExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExcluirAluno.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ExcluirAluno.Location = new System.Drawing.Point(195, 321);
            this.lbl_ExcluirAluno.Name = "lbl_ExcluirAluno";
            this.lbl_ExcluirAluno.Size = new System.Drawing.Size(91, 25);
            this.lbl_ExcluirAluno.TabIndex = 4;
            this.lbl_ExcluirAluno.Text = "Excluir:";
            this.lbl_ExcluirAluno.Click += new System.EventHandler(this.lbl_ExcluirAluno_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 520);
            this.Controls.Add(this.lbl_ExcluirAluno);
            this.Controls.Add(this.txt_CpfExcluir);
            this.Controls.Add(this.lb_CPF);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cb_Curso);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Datanasc);
            this.Controls.Add(this.txt_Sobrenome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_datanasc);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_CadastroAluno);
            this.Name = "CadastroAluno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CadastroAluno;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.Label lbl_datanasc;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Sobrenome;
        private System.Windows.Forms.TextBox txt_Datanasc;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.ComboBox cb_Curso;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label lb_CPF;
        private System.Windows.Forms.TextBox txt_CpfExcluir;
        private System.Windows.Forms.Label lbl_ExcluirAluno;
    }
}