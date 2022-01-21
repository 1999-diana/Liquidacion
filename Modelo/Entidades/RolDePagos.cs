using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class RolDePagos
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public double Sueldobasico { get; set; }
        public double Horasextras { get; set; }
        public double Comision { get; set; }
        public double Aportes { get; set; }
        public double Prestamos { get; set; }
        public double Total { get; set; }
        public List<Salario> Salario { get; set; }
    }
}
