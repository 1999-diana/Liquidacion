using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Salario_Det
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int idSa { get; set; }
        public Salario Salario { get; set; }
        public Cargo Cargo { get; set; }
        public int CragoId { get; set; }
    }
}
