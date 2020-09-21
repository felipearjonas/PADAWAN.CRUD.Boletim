using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class CadastroCurso : Form
    {
        public static List<Models.Curso> listagem = new List<Models.Curso>();
        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var curso = new Models.Curso();
            {
                
                curso.NomeCurso = txt_Nome.Text;
                curso.SituacaoCurso = cb_Situacao.Text;
                

            }

            var content = JsonConvert.SerializeObject(curso);
            var URL = "http://localhost:60096/CadastroCurso/AddCursos";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Cadastrado com Sucesso");

            txt_Nome.Text = "";
            cb_Situacao.Text = "";

           
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdministrador();
            this.Hide();
            menu.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            

            var URL = "http://localhost:60096/CadastroCurso/DeletarCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync($"{URL}?nome={txt_NomeExcluir.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            

            MessageBox.Show("Excluido com Sucesso");

            txt_NomeExcluir.Text = "";

        }
    }
}
