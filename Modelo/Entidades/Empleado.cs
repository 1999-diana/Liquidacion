using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
  
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string NombreEmpleado { get; set; }
        public string CedulaEmpleado { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string EstadoCivilEmpleado { get; set; }
        public int NumeroHijosEmpleado { get; set; }
        public List<TiempoTrabajoEmpleado> TiempoTrabajoEmpleados { get; set; }
        public List<Salario> Salarios { get; set; }

    }
}
