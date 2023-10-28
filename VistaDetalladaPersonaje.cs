using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionAPIRickYMorty.Clases;

namespace ConexionAPIRickYMorty
{
    public partial class VistaDetalladaPersonaje : Form
    {
        ConexionRickYMorty conexion = new ConexionRickYMorty();
        public VistaDetalladaPersonaje(int idPersonaje)
        {
            InitializeComponent();
            RenderizarPersonaje(idPersonaje);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public async void RenderizarPersonaje(int idPersonaje)
        {
            Character personajeBuscado = await ObtenerPersonaje(idPersonaje);

            lblNombre.Text = personajeBuscado.name;

            lblEspecie.Text = personajeBuscado.species;

            lblTipo.Text = personajeBuscado.type == "" ? "Sin Tipo" : personajeBuscado.type;

            status.SizeMode = PictureBoxSizeMode.StretchImage;
            status.Width = 43;
            status.Height = 43;

            switch (personajeBuscado.status)
            {
                case "Alive":
                    status.Image = Properties.Resources.alive;
                    break;
                case "Dead":
                    status.Image = Properties.Resources.dead;
                    break;
                default:
                    status.Image = Properties.Resources.unknown;
                    break;
            }


            fotoPersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoPersonaje.Width = 200;
            fotoPersonaje.Height = 200;
            fotoPersonaje.Margin = new Padding(5);
            fotoPersonaje.ImageLocation = personajeBuscado.image;

            genero.SizeMode = PictureBoxSizeMode.StretchImage;
            genero.Width = 43;
            genero.Height = 43;
            genero.Image = personajeBuscado.gender == "Male" ? Properties.Resources.M : Properties.Resources.F;
        }

        public async Task<Character> ObtenerPersonaje(int idPersonaje)
        {
            Character personajeBuscado = await conexion.obtenerPersonaje(idPersonaje);
            return personajeBuscado;
        }
    }
}
