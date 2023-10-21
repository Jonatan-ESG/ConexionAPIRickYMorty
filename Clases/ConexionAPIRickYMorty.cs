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
    }
}
