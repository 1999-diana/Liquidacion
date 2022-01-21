using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class LiquidacionDB : DbContext
    {
        //Declaracion de las entiades del moswlo
        public DbSet<Cargo> cargos { get; set; }
        public DbSet<Configuracion> configuraciones { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Salario> salarios { get; set; }
        public DbSet<Salario_Det> salario_det { get; set; }
        public DbSet<TiempoTrabajoEmpleado> tiempotrabajoempleados { get; set; }
        public DbSet<Liquidacion> Liquidaciones { get; set; }
        public DbSet<InformacionPersonal> personales { get; set; }
        public DbSet<DecimoTercero> Decimost { get; set; }
        public DbSet<RolDePagos> rol { get; set; }
        //declaracion de la coneccion

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            string connSQL = "server=DESKTOP-OAT5MPN;database=Proyecto;user id=Sa; password=1234";
            options.UseSqlServer(connSQL);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion
            modelBuilder.Entity<Configuracion>()
                .HasOne(config => config.TiempoVigente)
                .WithMany()
                .HasForeignKey(configs => configs.TiempoVigenteId);

            // Relación uno a muchos; un Empleado tiene muchos Salarios
            modelBuilder.Entity<Salario>()
                .HasOne(sal => sal.TiempoTrabajo)
                .WithMany(emple => emple.Salarios)
                .HasForeignKey(emp => emp.IdTiempo);

            // Relación uno a muchos; en un Tiempo de Trabajo se registran varios Salarios
            modelBuilder.Entity<Salario>()
                .HasOne(tiemp => tiemp.Empleado)
                .WithMany(temp => temp.Salarios)
                .HasForeignKey(sal => sal.EmpleadoId);

            // Relación de uno a muchos: cabecera detalle del salario
            modelBuilder.Entity<Salario_Det>()
                .HasOne(det => det.Salario)
                .WithMany(sal => sal.salario_s)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(saldet => saldet.Id);

            // Relación de uno a muchos: Empresa con detalles del salario
            modelBuilder.Entity<Salario_Det>()
                .HasOne(det => det.Empresa)
                .WithMany(emp => emp.Salario_Dets)
                .HasForeignKey(dets => dets.EmpresaId);

            // Relación uno a muchos; una Materia se dicta en muchos Cursos
            modelBuilder.Entity<Empresa>()
                .HasOne(emp => emp.Cargo)
                .WithMany(car => car.Empresas)
                .HasForeignKey(caremp => caremp.CargoId);



            // Relación uno a muchos; un Período tiene varios cursos
            modelBuilder.Entity<Empresa>()
                .HasOne(emp => emp.TiempoTrabajo)
                .WithMany(ttp => ttp.Empresas)
                .HasForeignKey(empt => empt.IdTiempo);

            _ = modelBuilder.Entity<TiempoTrabajoEmpleado>()
                .HasOne(empl => empl.Empleado)
                .WithMany(ttpp => ttpp.TiempoTrabajoEmpleados)
                .HasForeignKey(empt => empt.EmpleadoId);
        }

    }
}