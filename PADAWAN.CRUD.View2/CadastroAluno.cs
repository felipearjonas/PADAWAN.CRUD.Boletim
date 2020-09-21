using Newtonsoft.Json;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
            CarregarCurso();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdministrador();
            this.Hide();
            menu.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var aluno = new Models.Aluno();
            {

                aluno.Nome = txt_Nome.Text;
                aluno.Sobrenome = txt_Sobrenome.Text;
                aluno.DataNascimento = DateTime.Parse(txt_Datanasc.Text);
                aluno.Cpf = txt_Cpf.Text;
                aluno.IdCurso = int.Parse(cb_Curso.Text);

            }

            var content = JsonConvert.SerializeObject(aluno);
            var URL = "http://localhost:60096/Cadastro/AddAlunos";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Cadastrado com Sucesso");

            txt_Nome.Text = "";
            txt_Sobrenome.Text = "";
            txt_Datanasc.Text = "";
            txt_Cpf.Text = "";
            cb_Curso.Text = "";
            


        }
        private void CarregarCurso()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/Cadastro/MostraAlunos";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<Root>(result.Result).Data;

            foreach (var curso in data)
            {
                cb_Curso.Items.Add(curso.NomeCurso);
            }
        }

        private class Root
        {
            public List<Curso> Data { get; set; }
        }

        private void lbl_ExcluirAluno_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var URL = "http://localhost:60096/Cadastro/DeletarAluno";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync($"{URL}?nome={txt_CpfExcluir.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();



            MessageBox.Show("Excluido com Sucesso");
            txt_CpfExcluir.Text = "";
        }
    }
}
