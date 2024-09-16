using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIAP.Agroplus.Sprint3.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_REGIAO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NOME = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    REGIAO_BRASIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PLANTIO_FREQUENTE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TEMPERATURA_MEDIA = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    PRECIPITACAO_MEDIA = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    DATA_CRIACAO = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_REGIAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_PLANTACAO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    RegiaoId = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NOME_PRODUTO = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    CNPJ_PRODUTO = table.Column<string>(type: "NVARCHAR2(14)", maxLength: 14, nullable: false),
                    TAMANHO_EM_HECTARES = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    DATA_CRIACAO = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PLANTACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_PLANTACAO_T_REGIAO_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "T_REGIAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_PLANTACAO_RegiaoId",
                table: "T_PLANTACAO",
                column: "RegiaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_PLANTACAO");

            migrationBuilder.DropTable(
                name: "T_REGIAO");
        }
    }
}
