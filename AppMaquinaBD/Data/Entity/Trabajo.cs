using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaquinaBD.Data.Entity
{
    public class Trabajo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Hectareas { get; set; }
        public string Agroquimico { get; set; }
        public string Ubicacion { get; set; }
    }
}
