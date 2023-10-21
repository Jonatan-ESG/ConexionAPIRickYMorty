using ConexionAPIRickYMorty.Clases;

namespace ConexionAPIRickYMorty
{
    public partial class Form1 : Form
    {
        ConexionRickYMorty conexion = new ConexionRickYMorty();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<Character> personajes = await conexion.obtenerPersonajes();
            foreach (Character personaje in personajes)
            {
                PictureBox fotoPersonaje = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 200,
                    Height = 200,
                    Margin = new Padding(5),
                    ImageLocation = personaje.image
                };

                fotoPersonaje.Click += (sender, e) =>
                {
                    MessageBox.Show($"{personaje.id}");
                };

                contenedorPersonajes.Controls.Add(fotoPersonaje);
            }
        }
    }
}