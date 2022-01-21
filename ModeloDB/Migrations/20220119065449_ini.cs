using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Decimost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decimost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivilEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroHijosEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Liquidaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoCesa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoPri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoVaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    AuxilioTrans = table.Column<double>(type: "float", nullable: false),
                    TipoContrato = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipocontrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechafin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ultimaremuneracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoprovincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    decimotercer = table.Column<double>(type: "float", nullable: false),
                    diasvacaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sueldobasico = table.Column<double>(type: "float", nullable: false),
                    Horasextras = table.Column<double>(type: "float", nullable: false),
                    Comision = table.Column<double>(type: "float", nullable: false),
                    Aportes = table.Column<double>(type: "float", nullable: false),
                    Prestamos = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tiempotrabajoempleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicioTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiempotrabajoempleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tiempotrabajoempleados_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tiempotrabajoempleados_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "configuraciones",
                columns: table => new
                {
                    ConfiguracionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalarioMaximo = table.Column<float>(type: "real", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasExtrasMinimas = table.Column<int>(type: "int", nullable: false),
                    HorasExtrasMaximas = table.Column<int>(type: "int", nullable: false),
                    SalrioHorasExtras = table.Column<float>(type: "real", nullable: false),
                    TiempoVigenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuraciones", x => x.ConfiguracionId);
                    table.ForeignKey(
                        name: "FK_configuraciones_tiempotrabajoempleados_TiempoVigenteId",
                        column: x => x.TiempoVigenteId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionSucursalEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    TiempoTrabajoId = table.Column<int>(type: "int", nullable: true),
                    IdTiempo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresas", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_empresas_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empresas_tiempotrabajoempleados_TiempoTrabajoId",
                        column: x => x.TiempoTrabajoId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SueldoBasico = table.Column<float>(type: "real", nullable: false),
                    DecimoTercerSueldo = table.Column<float>(type: "real", nullable: false),
                    DecimoCuartoSueldo = table.Column<float>(type: "real", nullable: false),
                    Utilidades = table.Column<float>(type: "real", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    TiempoTrabajoId = table.Column<int>(type: "int", nullable: true),
                    IdTiempo = table.Column<int>(type: "int", nullable: false),
                    RolDePagosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salarios_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salarios_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salarios_rol_RolDePagosId",
                        column: x => x.RolDePagosId,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salarios_tiempotrabajoempleados_TiempoTrabajoId",
                        column: x => x.TiempoTrabajoId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salario_det",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    idSa = table.Column<int>(type: "int", nullable: false),
                    SalarioId = table.Column<int>(type: "int", nullable: true),
                    CargoId = table.Column<int>(type: "int", nullable: true),
                    CragoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salario_det", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salario_det_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salario_det_empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salario_det_salarios_SalarioId",
                        column: x => x.SalarioId,
                        principalTable: "salarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_configuraciones_TiempoVigenteId",
                table: "configuraciones",
                column: "TiempoVigenteId");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_CargoId",
                table: "empresas",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_TiempoTrabajoId",
                table: "empresas",
                column: "TiempoTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_det_CargoId",
                table: "salario_det",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_det_EmpresaId",
                table: "salario_det",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_det_SalarioId",
                table: "salario_det",
                column: "SalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_CargoId",
                table: "salarios",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_EmpleadoId",
                table: "salarios",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_RolDePagosId",
                table: "salarios",
                column: "RolDePagosId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_TiempoTrabajoId",
                table: "salarios",
                column: "TiempoTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_tiempotrabajoempleados_CargoId",
                table: "tiempotrabajoempleados",
                column: "CargoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tiempotrabajoempleados_EmpleadoId",
                table: "tiempotrabajoempleados",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "configuraciones");

            migrationBuilder.DropTable(
                name: "Decimost");

            migrationBuilder.DropTable(
                name: "Liquidaciones");

            migrationBuilder.DropTable(
                name: "personales");

            migrationBuilder.DropTable(
                name: "salario_det");

            migrationBuilder.DropTable(
                name: "empresas");

            migrationBuilder.DropTable(
                name: "salarios");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "tiempotrabajoempleados");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "empleados");
        }
    }
}
