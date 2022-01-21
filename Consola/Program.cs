using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;

namespace Consola
{
     class Program
    {
        static void Main(string[] args)
        {
            TiempoTrabajoEmpleado per2019 = new()
            {
                FechaInicioTrabajo = new DateTime(2019, 1, 1),
                FechaFinTrabajo = new DateTime(2020, 1, 1)
            };

            TiempoTrabajoEmpleado per2020 = new() { FechaInicioTrabajo = new DateTime(2020, 4, 1), FechaFinTrabajo = new DateTime(2021, 4, 1) };
            TiempoTrabajoEmpleado per2021 = new() { FechaInicioTrabajo = new DateTime(2021, 9, 1), FechaFinTrabajo = new DateTime(2022, 9, 1) };
            List<TiempoTrabajoEmpleado> listaPeriodos = new() { per2019, per2020, per2021 };

            Salario salarioLuis = new() { SueldoBasico = 400.00f, DecimoCuartoSueldo = 183.01f, DecimoTercerSueldo = 535.00f, Utilidades = 730.00f };
            Salario salarioAna = new() { SueldoBasico = 400.00f, DecimoCuartoSueldo = 248.77f, DecimoTercerSueldo = 500.00f, Utilidades = 1500.00f };
            Salario salarioRosa = new() { SueldoBasico = 400.00f, DecimoCuartoSueldo = 356.16f, DecimoTercerSueldo = 425.00f, Utilidades = 800.00f };
            Salario salarioCarlos = new() { SueldoBasico = 400.00f, DecimoCuartoSueldo = 213.70f, DecimoTercerSueldo = 635.00f, Utilidades = 805.00f };
            Salario salarioJorge = new() { SueldoBasico = 400.00f, DecimoCuartoSueldo = 253.15f, DecimoTercerSueldo = 815.00f, Utilidades = 790.00f };
            List<Salario> lstSalarios = new() { salarioLuis, salarioAna, salarioRosa, salarioCarlos, salarioJorge };

            // .- Registro de los empleados
            Empleado empLuis = new() { NombreEmpleado = "Luis Gutierrez", CedulaEmpleado = "1716651169", Telefono = "0987456987", Direccion = "Quitumbe", EstadoCivilEmpleado = "Casado", NumeroHijosEmpleado = 2, TiempoTrabajoEmpleados = new List<TiempoTrabajoEmpleado>() { per2019, per2020, per2021 }, Salarios = new List<Salario>() { salarioLuis } };
            Empleado empAna = new() { NombreEmpleado = "Ana Velasquez", CedulaEmpleado = "1758965789", Telefono = "0987456321", Direccion = "Sangolqui", EstadoCivilEmpleado = "Casada", NumeroHijosEmpleado = 5 , TiempoTrabajoEmpleados = new List<TiempoTrabajoEmpleado>() { per2019, per2020, per2021 }, Salarios = new List<Salario>() { salarioAna } };
            Empleado empRosa = new() { NombreEmpleado = "Rosa Perez", CedulaEmpleado = "1725874585", Telefono = "098745698", Direccion = "El condado", EstadoCivilEmpleado = "Soltera", NumeroHijosEmpleado = 0 , TiempoTrabajoEmpleados = new List<TiempoTrabajoEmpleado>() { per2019, per2020, per2021 }, Salarios = new List<Salario>() { salarioRosa } };
            Empleado empCarlos = new() { NombreEmpleado = "Carlos Bustamante", CedulaEmpleado = "1736895478", Telefono = "0987456124", Direccion = "Guayaquil", EstadoCivilEmpleado = "Casado", NumeroHijosEmpleado = 1, TiempoTrabajoEmpleados = new List<TiempoTrabajoEmpleado>() { per2019, per2020, per2021 }, Salarios = new List<Salario>() { salarioJorge } };
            Empleado empJorge = new() { NombreEmpleado = "Jorge Villamarin", CedulaEmpleado = "1587965878", Telefono = "09874256999", Direccion = "Ibarra", EstadoCivilEmpleado = "Soltero", NumeroHijosEmpleado = 0, TiempoTrabajoEmpleados = new List<TiempoTrabajoEmpleado>() { per2019, per2020, per2021 }, Salarios = new List<Salario>() { salarioLuis } };
            List<Empleado> lstEstudiantes = new() { empLuis, empAna, empRosa, empCarlos, empJorge };


            // .- Registros de salarios
            Cargo gerenteMarketing = new Cargo()
            {
                Area = "Area de Marketing",
                NombreCargo = "Gerente de Marketing",
                DescripcionCargo = "Maximo gerente del area de Marketing"
            };
            Cargo gerenteSistemas = new() { Area = "Area de Sistemas", NombreCargo = "Gerente de Sistemas", DescripcionCargo = "Gerente de desarrollo y sistemas" };
            Cargo secretaria = new() { Area = "Area de Secreatarias", NombreCargo = "Secretaria gerencial", DescripcionCargo = "Secretaria del gerente de sistemas" };
            Cargo vendedor = new() { Area = "Area de Ventas", NombreCargo = "Vendedor", DescripcionCargo = "Vendedor en ventanillas" };
            Cargo repartidor = new() { Area = "Area de Logistica", NombreCargo = "Gerente de Logistica y pagos", DescripcionCargo = "Repartidor de productos" };
            Cargo limpieza = new() { Area = "Area de Limpieza", NombreCargo = "Limpiedor/ra", DescripcionCargo = "Aseo de la empresa" };
            Cargo gerenteVentas = new() { Area = "Area de gerencia en ventas", NombreCargo = "Gerente de Ventas y garantias", DescripcionCargo = "Gerente de ventas" };
            Cargo deparTecnico = new() { Area = "Area de Tecnicos", NombreCargo = "Gerente Tecnico", DescripcionCargo = "Gerente de reparaciones y devoluciones" };
            List<Cargo> lstCargos = new()
            {
                gerenteMarketing,
                gerenteSistemas,
                secretaria,
                vendedor,
                repartidor,
                limpieza,
                gerenteVentas,
                deparTecnico,

            };
            


            // .- Registro de las sucursales de la empresa
            Empresa SucursalesCostaGuayas = new Empresa()
            {
                TiempoTrabajo = per2019,
                Cargo = gerenteMarketing,
                RUC = "1254789653123",
                DireccionSucursalEmpresa = "Guayaquil",
                TelefonoEmpresa = "3653427"
            };
            Empresa SucursalesCostaManabi = new Empresa()
            {
                TiempoTrabajo = per2019,
                Cargo = gerenteSistemas,
                RUC = "2356478921423",
                DireccionSucursalEmpresa = "Manabi",
                TelefonoEmpresa = "3653438"
            };
            Empresa SucursalesCostaEsmeraldas = new Empresa()
            {
                TiempoTrabajo = per2019,
                Cargo = limpieza,
                RUC = "1254789653",
                DireccionSucursalEmpresa = "Esmeraldas",
                TelefonoEmpresa = "3653449"
            };
            Empresa SucursalesSierraIbarra = new Empresa()
            {
                TiempoTrabajo = per2020,
                Cargo = deparTecnico,
                RUC = "1784523698542",
                DireccionSucursalEmpresa = "Ibarra",
                TelefonoEmpresa = "3256789"
            };
            Empresa SucursalesSierraCuenca = new Empresa()
            {
                TiempoTrabajo = per2020,
                Cargo = secretaria,
                RUC = "1457896523457",
                DireccionSucursalEmpresa = "Cuenca",
                TelefonoEmpresa = "3678965"
            };
            Empresa SucursalesSierraQuito = new Empresa()
            {
                TiempoTrabajo = per2019,
                Cargo = repartidor,
                RUC = "1751162376895",
                DireccionSucursalEmpresa = "Quito",
                TelefonoEmpresa = "3256568"
            };
            Empresa SucursalesOrienteLagoAgrio = new Empresa()
            {
                TiempoTrabajo = per2021,
                Cargo = vendedor,
                RUC = "1751245789365",
                DireccionSucursalEmpresa = "Lago Agrio",
                TelefonoEmpresa = "2586956"
            };
            Empresa SucursalesOrienteNapo = new Empresa()
            {
                TiempoTrabajo = per2021,
                Cargo = gerenteVentas,
                RUC = "1716651169784",
                DireccionSucursalEmpresa = "Napo",
                TelefonoEmpresa = "1245786"
            };
            List<Empresa> lstEmpresas = new List<Empresa>() {
                // costa
                SucursalesCostaEsmeraldas,SucursalesCostaGuayas,SucursalesCostaManabi,
                // sierra
                SucursalesSierraIbarra,SucursalesSierraQuito,SucursalesSierraCuenca,
                // oriente
                SucursalesOrienteLagoAgrio,SucursalesOrienteNapo
            };
            Configuracion configuracion = new()
            {
                NombreEmpresa = "Tecnomega C.A",
                SalarioMaximo = 1000.00f,
                HorasExtrasMaximas = 15,
                HorasExtrasMinimas = 5,
                SalrioHorasExtras = 10.00f,
                TiempoVigente = per2019
            };
            List<Configuracion> listaConfiguracion = new() { configuracion };
        }
    }
}