using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionAPIRickYMorty.Clases
{
    internal class ConexionRickYMorty
    {
        string API_URL = "https://rickandmortyapi.com/api";

        public async Task<List<Character>> obtenerPersonajes()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string respuesta = await client.GetStringAsync($"{API_URL}/character");

                    RickAndMortyCharacterAPIResponse resultadoSerializado = JsonConvert.DeserializeObject<RickAndMortyCharacterAPIResponse>(respuesta);

                    Info info = resultadoSerializado.info;
                    List<Character> listaPersonajes = resultadoSerializado.results;

                    return listaPersonajes;
                }
                catch (Exception ex) {
                    return new List<Character>();
                }

            }
        }

        public async Task<Character> obtenerPersonaje(int idPersonaje)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string respuesta = await client.GetStringAsync($"{API_URL}/character/{idPersonaje}");

                    Character resultadoSerializado = JsonConvert.DeserializeObject<Character>(respuesta);

                    return resultadoSerializado;
                }
                catch (Exception ex)
                {
                    return new Character();
                }

            }
        }
    }
}
