using Newtonsoft.Json;
using PADAWAN.CRUD.Boletim.Controllers;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class MenuAluno : Form
    {
        public MenuAluno()
        {
            InitializeComponent();
            CarregarAluno();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CarregarAluno()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/Cadastro/MostraAlunos";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Aluno>>(result.Result);

            foreach (var aluno in data)
            {
                cb_NomeAluno.Items.Add($"{aluno.IdAluno} - {aluno.Nome}");
            }
        }
        
        private class Root
        {
            public List<Aluno> Data { get; set; }
            public List<Curso> DataCurso { get; set; }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Notas_Click(object sender, EventArgs e)
        {
            var idselecaoaluno = int.Parse(Selecionar());
         
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/CadastroNotas/MostraNotas";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Auxiliar>>(result.Result);

            textBox3.Text = "";
            

            foreach (var nota in data.Where(q => q.IdAluno == idselecaoaluno))
            {
                
                textBox3.Text += $"{nota.NomeMateria} - {nota.NotaAluno}\r\n";
                
            }
           
        }

        private string Selecionar()
        {
            string selecao = cb_NomeAluno.Text.Substring(0, cb_NomeAluno.Text.IndexOf('-'));
            return selecao;
        }
    }
}
