using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string RUC { get; set; }
        public string DireccionSucursalEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }
       
        public List<Salario_Det> Salario_Dets { get; set; }
        public TiempoTrabajoEmpleado TiempoTrabajo { get; set; }
        public int IdTiempo { get; set; }
    }
}
