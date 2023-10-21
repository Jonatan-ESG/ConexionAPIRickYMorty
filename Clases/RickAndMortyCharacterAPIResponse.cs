using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionAPIRickYMorty.Clases
{
    internal class RickAndMortyCharacterAPIResponse
    {
        public Info info { get; set; }

        public List<Character> results { get; set;}
    }
}
