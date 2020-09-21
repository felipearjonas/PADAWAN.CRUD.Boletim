namespace PADAWAN.CRUD.View
{
    partial class MenuAdministrador
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
            this.btn_Materia = new System.Windows.Forms.Button();
            this.btn_Curso = new System.Windows.Forms.Button();
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Materia
            // 
            this.btn_Materia.Location = new System.Drawing.Point(164, 105);
            this.btn_Materia.Name = "btn_Materia";
            this.btn_Materia.Size = new System.Drawing.Size(123, 58);
            this.btn_Materia.TabIndex = 0;
            this.btn_Materia.Text = "Cadastrar Materia";
            this.btn_Materia.UseVisualStyleBackColor = true;
            this.btn_Materia.Click += new System.EventHandler(this.btn_Materia_Click);
            // 
            // btn_Curso
            // 
            this.btn_Curso.Location = new System.Drawing.Point(164, 197);
            this.btn_Curso.Name = "btn_Curso";
            this.btn_Curso.Size = new System.Drawing.Size(123, 58);
            this.btn_Curso.TabIndex = 0;
            this.btn_Curso.Text = "Cadastrar Curso";
            this.btn_Curso.UseVisualStyleBackColor = true;
            this.btn_Curso.Click += new System.EventHandler(this.btn_Curso_Click);
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.Location = new System.Drawing.Point(164, 291);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(123, 58);
            this.btn_Aluno.TabIndex = 0;
            this.btn_Aluno.Text = "Cadastrar Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = true;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Menu.Location = new System.Drawing.Point(131, 38);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(222, 25);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menu Administrador";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(22, 398);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 433);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.btn_Aluno);
            this.Controls.Add(this.btn_Curso);
            this.Controls.Add(this.btn_Materia);
            this.Name = "MenuAdministrador";
            this.Text = "MenuAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Materia;
        private System.Windows.Forms.Button btn_Curso;
        private System.Windows.Forms.Button btn_Aluno;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Voltar;
    }
}