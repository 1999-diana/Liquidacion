using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Salario
    {
        public int Id { get; set; }
        public string Estado { get; set; }   // PENdiente, APRobada, ANUlada


        public float SueldoBasico { get; set; }
        public float DecimoTercerSueldo { get; set; }
        public float DecimoCuartoSueldo { get; set; }
        public float Utilidades { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public List<Salario_Det> salario_s { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public TiempoTrabajoEmpleado TiempoTrabajo { get; set; }
        public int IdTiempo { get; set; }
    }
}
