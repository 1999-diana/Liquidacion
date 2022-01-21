using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DBLiquidacion:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Liquidacion> Liquidaciones { get; set; }
        public DbSet<InformacionPersonal> Personales { get; set; }
        public DbSet<DecimoTercero> Decimost { get; set; }
        public DbSet<RolDePagos> Rol { get; set; }
        public DbSet<Empresa>Empresa{ get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Salario> Salario { get; set; }
        public DbSet<Salario_Det> Salario_Det { get; set; }
        public DbSet<TiempoTrabajoEmpleado> TiempoEm{ get; set; }
    

}
}
