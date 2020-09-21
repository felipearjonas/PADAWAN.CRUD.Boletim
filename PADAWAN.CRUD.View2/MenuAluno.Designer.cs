namespace PADAWAN.CRUD.View
{
    partial class MenuAluno
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_Notas = new System.Windows.Forms.Label();
            this.btn_Notas = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Visualizacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(52, 147);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(52, 16);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sobrenome.Location = new System.Drawing.Point(52, 201);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(91, 16);
            this.lbl_Sobrenome.TabIndex = 1;
            this.lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 346);
            this.textBox3.TabIndex = 4;
            // 
            // lbl_Notas
            // 
            this.lbl_Notas.AutoSize = true;
            this.lbl_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Notas.Location = new System.Drawing.Point(434, 39);
            this.lbl_Notas.Name = "lbl_Notas";
            this.lbl_Notas.Size = new System.Drawing.Size(52, 16);
            this.lbl_Notas.TabIndex = 5;
            this.lbl_Notas.Text = "Notas:";
            // 
            // btn_Notas
            // 
            this.btn_Notas.Location = new System.Drawing.Point(224, 255);
            this.btn_Notas.Name = "btn_Notas";
            this.btn_Notas.Size = new System.Drawing.Size(94, 40);
            this.btn_Notas.TabIndex = 6;
            this.btn_Notas.Text = "Notas";
            this.btn_Notas.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(45, 391);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // lbl_Visualizacao
            // 
            this.lbl_Visualizacao.AutoSize = true;
            this.lbl_Visualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Visualizacao.Location = new System.Drawing.Point(91, 52);
            this.lbl_Visualizacao.Name = "lbl_Visualizacao";
            this.lbl_Visualizacao.Size = new System.Drawing.Size(247, 25);
            this.lbl_Visualizacao.TabIndex = 8;
            this.lbl_Visualizacao.Text = "Visualização de Notas";
            // 
            // MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Visualizacao);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Notas);
            this.Controls.Add(this.lbl_Notas);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "MenuAluno";
            this.Text = "MenuAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_Notas;
        private System.Windows.Forms.Button btn_Notas;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Visualizacao;
    }
}