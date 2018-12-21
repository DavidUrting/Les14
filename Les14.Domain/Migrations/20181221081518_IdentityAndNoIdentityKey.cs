﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Les14.Domain.Migrations
{
    public partial class IdentityAndNoIdentityKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Keys");

            migrationBuilder.CreateTable(
                name: "AutoGeneratedKey",
                schema: "Keys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoGeneratedKey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoAutoGeneratedKey",
                schema: "Keys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoAutoGeneratedKey", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoGeneratedKey",
                schema: "Keys");

            migrationBuilder.DropTable(
                name: "NoAutoGeneratedKey",
                schema: "Keys");
        }
    }
}
