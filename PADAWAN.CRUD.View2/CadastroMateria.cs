using Newtonsoft.Json;
using PADAWAN.CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PADAWAN.CRUD.View
{
    public partial class CadastroMateria : Form
    {
        public CadastroMateria()
        {
            InitializeComponent();
            CarregarCurso();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int.TryParse((Regex.Match(cb_Curso.Text, @"\d+").Value), out int curso);
            var materia = new Models.Materia();
            {

                materia.NomeMateria = txt_Nome.Text;
                materia.IdCurso = curso;
                materia.DataCadastro = DateTime.Parse(txt_DataCadastro.Text);
                materia.SituacaoMateria = cb_Situacao.Text;
                
                

            }

            var content = JsonConvert.SerializeObject(materia);
            var URL = "http://localhost:60096/CadastroMateria/AddMaterias";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            MessageBox.Show("Cadastrado com Sucesso");

            txt_Nome.Text = "";
            cb_Curso.Text = "";
            txt_DataCadastro.Text = "";
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
            var URL = "http://localhost:60096/CadastroMateria/DeletarMaterias";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync($"{URL}?nome={txt_MateriaExcluir.Text}");
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();



            MessageBox.Show("Excluido com Sucesso");

            txt_MateriaExcluir.Text = "";
        }
        private void CarregarCurso()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:60096/CadastroCurso/MostrarCurso";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Curso>>(result.Result);

            foreach (var curso in data)
            {
                cb_Curso.Items.Add($"{curso.IdCurso} - {curso.NomeCurso}");
            }
        }

        private class Root
        {
            public List<Curso> Data { get; set; }
        }
    }
}
