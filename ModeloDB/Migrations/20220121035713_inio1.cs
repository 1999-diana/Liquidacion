using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class inio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empresas_tiempotrabajoempleados_TiempoTrabajoId",
                table: "empresas");

            migrationBuilder.DropForeignKey(
                name: "FK_salario_det_salarios_SalarioId",
                table: "salario_det");

            migrationBuilder.DropForeignKey(
                name: "FK_salarios_tiempotrabajoempleados_TiempoTrabajoId",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_salarios_TiempoTrabajoId",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_salario_det_SalarioId",
                table: "salario_det");

            migrationBuilder.DropIndex(
                name: "IX_empresas_TiempoTrabajoId",
                table: "empresas");

            migrationBuilder.DropColumn(
                name: "TiempoTrabajoId",
                table: "salarios");

            migrationBuilder.DropColumn(
                name: "SalarioId",
                table: "salario_det");

            migrationBuilder.DropColumn(
                name: "TiempoTrabajoId",
                table: "empresas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "salario_det",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_IdTiempo",
                table: "salarios",
                column: "IdTiempo");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_IdTiempo",
                table: "empresas",
                column: "IdTiempo");

            migrationBuilder.AddForeignKey(
                name: "FK_empresas_tiempotrabajoempleados_IdTiempo",
                table: "empresas",
                column: "IdTiempo",
                principalTable: "tiempotrabajoempleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salario_det_salarios_Id",
                table: "salario_det",
                column: "Id",
                principalTable: "salarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_salarios_tiempotrabajoempleados_IdTiempo",
                table: "salarios",
                column: "IdTiempo",
                principalTable: "tiempotrabajoempleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empresas_tiempotrabajoempleados_IdTiempo",
                table: "empresas");

            migrationBuilder.DropForeignKey(
                name: "FK_salario_det_salarios_Id",
                table: "salario_det");

            migrationBuilder.DropForeignKey(
                name: "FK_salarios_tiempotrabajoempleados_IdTiempo",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_salarios_IdTiempo",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_empresas_IdTiempo",
                table: "empresas");

            migrationBuilder.AddColumn<int>(
                name: "TiempoTrabajoId",
                table: "salarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "salario_det",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SalarioId",
                table: "salario_det",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiempoTrabajoId",
                table: "empresas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_salarios_TiempoTrabajoId",
                table: "salarios",
                column: "TiempoTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_det_SalarioId",
                table: "salario_det",
                column: "SalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_TiempoTrabajoId",
                table: "empresas",
                column: "TiempoTrabajoId");

            migrationBuilder.AddForeignKey(
                name: "FK_empresas_tiempotrabajoempleados_TiempoTrabajoId",
                table: "empresas",
                column: "TiempoTrabajoId",
                principalTable: "tiempotrabajoempleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salario_det_salarios_SalarioId",
                table: "salario_det",
                column: "SalarioId",
                principalTable: "salarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salarios_tiempotrabajoempleados_TiempoTrabajoId",
                table: "salarios",
                column: "TiempoTrabajoId",
                principalTable: "tiempotrabajoempleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
