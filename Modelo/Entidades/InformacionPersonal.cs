using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class InformacionPersonal
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string tipocontrato { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechafin { get; set; }
        public DateTime ultimaremuneracion { get; set; }
        public string tipoprovincia { get; set; }
        public double decimotercer { get; set; }
        public string diasvacaciones { get; set; }

    }
}
