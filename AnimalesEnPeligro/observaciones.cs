using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesEnPeligro
{
    class observaciones
    {
        public int idObsevacion { get; set; }
        public int idObservador { get; set; } 
        public int idEspecie { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public string detalle { get; set; }
    }
}

