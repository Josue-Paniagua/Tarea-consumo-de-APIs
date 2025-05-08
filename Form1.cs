using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace consumo_de_APIs
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //AGREGAR METODOS ASINCRONOS
        private async Task BuscarPESO()
        {

            await Task.Delay(1000); 
        }
        private async Task BuscarHAB()
        {
            await Task.Delay(4000); 
        }
        private async Task BuscarALT()
        {
            await Task.Delay(4000); 
        }
        private async Task BuscarID()
        {
            await Task.Delay(5000); 
        }

        private async Task BuscarImagen()
        {
            await Task.Delay(3000); 
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string pokemonName = txtNombre.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";
            try
            {
                var taskPeso = BuscarPESO();
                var taskHab = BuscarHAB();
                var taskAlt = BuscarALT();
                var taskID = BuscarID();
                var taskImg = BuscarImagen();

                lblpeso.Text = "Cargando peso...";
                lblHab.Text = "Buscanod los niveles de habilidad...";
                lblaltura.Text = "Buscando la altura...";
                lblID.Text = "Identicando  el ID...";

                await Task.WhenAll(taskPeso, taskHab, taskAlt, taskID, taskImg);
            }
            catch (TaskCanceledException)

            {
                MessageBox.Show("La tarea fue cancelada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            try
            {

                string response = await client.GetStringAsync(url);
                JObject data = JObject.Parse(response);
                lblpeso.Text = $"Peso: {data["weight"]}";
                lblHab.Text = $"Nivel de experiencia:{data["base_experience"]}";
                lblaltura.Text = $"Altura: {data["height"]}";
                lblID.Text = $" Id: {data["id"]}";
                string imagenUrl = data["sprites"]["front_default"].ToString();
                pictureBox1.Load(imagenUrl);
                GuardarResultados(data);

            }


            catch
            (Exception ex)
            {
                MessageBox.Show("Pokémon no encontrado: " + ex.Message);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNombre.Text = "";
            lblpeso.Text = "";
            lblHab.Text = "";
            lblaltura.Text = "";
            lblID.Text = "";
            pictureBox1.Image = null;
            txtCiudad.Text = "";


        }

        //PARTE PARA GUARDAR LOS RESULTADOS EN UN ARCHIVO DE TEXTO
        private void GuardarResultados(JObject data)
        {
            string nombre = data["name"].ToString();
            string peso = data["weight"].ToString();
            string altura = data["height"].ToString();
            string id = data["id"].ToString();

            string contenido = $"Nombre: {nombre}\nPeso: {peso}\nAltura: {altura}\nID: {id}";

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\pokemon_resultado.txt";
            File.WriteAllText(ruta, contenido);
            MessageBox.Show("Datos guardados en el escritorio.");
        }

        //FUNCION PARA OBTENER EL CLIMA
        private async Task ObtenerClima()
        {
        
            try
            {
                string ciudad = txtCiudad.Text; 
                if (string.IsNullOrWhiteSpace(ciudad))
                {
                    ciudad = "Guatemala"; 
                }

                string url = $"https://wttr.in/{ciudad}?format=3"; 
                string response = await client.GetStringAsync(url);

                MessageBox.Show($"Clima actual: {response}");
                lblclima.Text = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener clima: " + ex.Message);
            }
        }


        private async void btnClima_Click(object sender, EventArgs e)
        {

            await ObtenerClima();
        }

    }
}

