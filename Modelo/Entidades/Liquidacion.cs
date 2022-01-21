using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Liquidacion
    {
        public int Id{ get; set; }
        public string NombreEmpleado { get; set; }
        public string PeriodoCesa { get; set; }
        public string PeriodoPri { get; set; }
        public string PeriodoVaca { get; set; }
        public double SalarioBase { get; set; }
        public double AuxilioTrans { get; set; }
        public string TipoContrato { get; set; }
      


    }
}
