using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3Intento.Modelos
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public int Precio { get; set; }
    }
}
