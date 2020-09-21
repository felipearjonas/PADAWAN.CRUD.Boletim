namespace PADAWAN.CRUD.View
{
    partial class Menu
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
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.btn_Professor = new System.Windows.Forms.Button();
            this.btn_Administrador = new System.Windows.Forms.Button();
            this.lbl_Menu2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(226, 46);
            this.lbl_Menu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(367, 25);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "Bem vindo ao PADAWAN Boletim,";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Aluno.Location = new System.Drawing.Point(103, 204);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(140, 75);
            this.btn_Aluno.TabIndex = 1;
            this.btn_Aluno.Text = "Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = true;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click);
            // 
            // btn_Professor
            // 
            this.btn_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Professor.Location = new System.Drawing.Point(325, 204);
            this.btn_Professor.Name = "btn_Professor";
            this.btn_Professor.Size = new System.Drawing.Size(138, 73);
            this.btn_Professor.TabIndex = 1;
            this.btn_Professor.Text = "Professor";
            this.btn_Professor.UseVisualStyleBackColor = true;
            this.btn_Professor.Click += new System.EventHandler(this.btn_Professor_Click);
            // 
            // btn_Administrador
            // 
            this.btn_Administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Administrador.Location = new System.Drawing.Point(543, 204);
            this.btn_Administrador.Name = "btn_Administrador";
            this.btn_Administrador.Size = new System.Drawing.Size(137, 75);
            this.btn_Administrador.TabIndex = 1;
            this.btn_Administrador.Text = "Administrador";
            this.btn_Administrador.UseVisualStyleBackColor = true;
            this.btn_Administrador.Click += new System.EventHandler(this.btn_Administrador_Click);
            // 
            // lbl_Menu2
            // 
            this.lbl_Menu2.AutoSize = true;
            this.lbl_Menu2.Location = new System.Drawing.Point(255, 86);
            this.lbl_Menu2.Name = "lbl_Menu2";
            this.lbl_Menu2.Size = new System.Drawing.Size(295, 25);
            this.lbl_Menu2.TabIndex = 2;
            this.lbl_Menu2.Text = "escolha a opção desejada:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.Controls.Add(this.lbl_Menu2);
            this.Controls.Add(this.btn_Administrador);
            this.Controls.Add(this.btn_Professor);
            this.Controls.Add(this.btn_Aluno);
            this.Controls.Add(this.lbl_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Aluno;
        private System.Windows.Forms.Button btn_Professor;
        private System.Windows.Forms.Button btn_Administrador;
        private System.Windows.Forms.Label lbl_Menu2;
    }
}