using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vakansion.Core.Migrations
{
    public partial class Firsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Unemployeds_UnemployedClassId",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Unemployeds_UnemployedClassId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Vacancys_VacancyId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Vacancys_VacancyId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Unemployeds_Vacancys_VacancyId",
                table: "Unemployeds");

            migrationBuilder.DropTable(
                name: "Vacancys");

            migrationBuilder.DropIndex(
                name: "IX_Unemployeds_VacancyId",
                table: "Unemployeds");

            migrationBuilder.DropIndex(
                name: "IX_Positions_VacancyId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Employers_VacancyId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Educations_UnemployedClassId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Datas_UnemployedClassId",
                table: "Datas");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80d9bb10-67b5-4b48-9500-c6d7c71bede4", "1c5ea35f-361a-45d7-8a77-71a2a359f679" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bfa31fb9-7b11-4f2b-b710-0e7243443fbf", "1c5ea35f-361a-45d7-8a77-71a2a359f679" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bfa31fb9-7b11-4f2b-b710-0e7243443fbf", "962ca386-78fa-4c52-a694-df60fc4cd2d0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d9bb10-67b5-4b48-9500-c6d7c71bede4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfa31fb9-7b11-4f2b-b710-0e7243443fbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c5ea35f-361a-45d7-8a77-71a2a359f679");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "962ca386-78fa-4c52-a694-df60fc4cd2d0");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Unemployeds");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "UnemployedClassId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "UnemployedClassId",
                table: "Datas");

            migrationBuilder.CreateTable(
                name: "Vacancyses",
                columns: table => new
                {
                    VacancysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    UnemployedId = table.Column<int>(type: "int", nullable: false),
                    DataClassId = table.Column<int>(type: "int", nullable: true),
                    EducationClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancyses", x => x.VacancysId);
                    table.ForeignKey(
                        name: "FK_Vacancyses_Datas_DataClassId",
                        column: x => x.DataClassId,
                        principalTable: "Datas",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Vacancyses_Educations_EducationClassId",
                        column: x => x.EducationClassId,
                        principalTable: "Educations",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Vacancyses_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancyses_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacancyses_Unemployeds_UnemployedId",
                        column: x => x.UnemployedId,
                        principalTable: "Unemployeds",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20d374b1-7576-4d0e-a16a-1a2065074b31", "6a1299b4-4c31-4721-a8f3-61bd8c3f549d", "User", "USER" },
                    { "473c0403-d73e-4fc9-bcfc-dbd17b9943e6", "14ab7b62-0ca7-4127-bc22-68f64ec81242", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c20b7c03-733b-40af-8c6a-b1ef6bc93445", 0, "d1996a0d-a936-49e3-a112-174121afe1a4", "admin@vacansyukraine.com", true, null, null, false, null, "ADMIN@VACANSYUKRAINE.COM", "ADMIN@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEDLifz+jkqablWKXKVQFcSjCeDi/im3+V0pAfbpbkpi6DAm71dwybtQ/+iDH8yPD8Q==", null, false, "b6b0ce61-3bb4-4e36-83ff-fd8fe7a20915", false, "admin@vacansyukraine.com" },
                    { "fe56737b-fc92-462e-bd47-97cfd3b1fc8e", 0, "641fbd9b-3507-4803-ab69-7b3ec37875a2", "user@vacansyukraine.com", true, null, null, false, null, "USER@VACANSYUKRAINE.COM", "USER@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEJyf0sFtcGGWSRjW26np5wwqFHn7m/PKdQ1g9j3UgeazHaTU5itER1ZZw3P5N3uubg==", null, false, "71c42ca3-674b-4f68-9e67-4927002bd13a", false, "user@vacansyukraine.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "473c0403-d73e-4fc9-bcfc-dbd17b9943e6", "c20b7c03-733b-40af-8c6a-b1ef6bc93445" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "20d374b1-7576-4d0e-a16a-1a2065074b31", "fe56737b-fc92-462e-bd47-97cfd3b1fc8e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "473c0403-d73e-4fc9-bcfc-dbd17b9943e6", "fe56737b-fc92-462e-bd47-97cfd3b1fc8e" });

            migrationBuilder.CreateIndex(
                name: "IX_Unemployeds_DataId",
                table: "Unemployeds",
                column: "DataId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unemployeds_EducationId",
                table: "Unemployeds",
                column: "EducationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancyses_DataClassId",
                table: "Vacancyses",
                column: "DataClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancyses_EducationClassId",
                table: "Vacancyses",
                column: "EducationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancyses_EmployerId",
                table: "Vacancyses",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancyses_PositionId",
                table: "Vacancyses",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancyses_UnemployedId",
                table: "Vacancyses",
                column: "UnemployedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unemployeds_Datas_DataId",
                table: "Unemployeds",
                column: "DataId",
                principalTable: "Datas",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unemployeds_Educations_EducationId",
                table: "Unemployeds",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unemployeds_Datas_DataId",
                table: "Unemployeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Unemployeds_Educations_EducationId",
                table: "Unemployeds");

            migrationBuilder.DropTable(
                name: "Vacancyses");

            migrationBuilder.DropIndex(
                name: "IX_Unemployeds_DataId",
                table: "Unemployeds");

            migrationBuilder.DropIndex(
                name: "IX_Unemployeds_EducationId",
                table: "Unemployeds");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "473c0403-d73e-4fc9-bcfc-dbd17b9943e6", "c20b7c03-733b-40af-8c6a-b1ef6bc93445" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20d374b1-7576-4d0e-a16a-1a2065074b31", "fe56737b-fc92-462e-bd47-97cfd3b1fc8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "473c0403-d73e-4fc9-bcfc-dbd17b9943e6", "fe56737b-fc92-462e-bd47-97cfd3b1fc8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20d374b1-7576-4d0e-a16a-1a2065074b31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "473c0403-d73e-4fc9-bcfc-dbd17b9943e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c20b7c03-733b-40af-8c6a-b1ef6bc93445");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe56737b-fc92-462e-bd47-97cfd3b1fc8e");

            migrationBuilder.AddColumn<int>(
                name: "VacancyId",
                table: "Unemployeds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VacancyId",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VacancyId",
                table: "Employers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnemployedClassId",
                table: "Educations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnemployedClassId",
                table: "Datas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vacancys",
                columns: table => new
                {
                    VacancyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    UnemployedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancys", x => x.VacancyId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80d9bb10-67b5-4b48-9500-c6d7c71bede4", "23de16ae-1288-43c2-9e27-84c42d8d12a6", "User", "USER" },
                    { "bfa31fb9-7b11-4f2b-b710-0e7243443fbf", "8b617f60-e2a8-4e9d-a980-2dd07903b154", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c5ea35f-361a-45d7-8a77-71a2a359f679", 0, "8c069f7b-575e-4da5-9da0-5e6bffe98b41", "user@vacansyukraine.com", true, null, null, false, null, "USER@VACANSYUKRAINE.COM", "USER@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEOkbXyQQ1wdQIA//a5h7pD4AYM06wcceGkQpNx4z4Up/DFYy5I3+JF19f+RbgpCWdQ==", null, false, "c5f52490-8e51-4f40-85fe-1e823680a95f", false, "user@vacansyukraine.com" },
                    { "962ca386-78fa-4c52-a694-df60fc4cd2d0", 0, "26f787fc-9316-4ec4-bfac-a1160ee096a6", "admin@vacansyukraine.com", true, null, null, false, null, "ADMIN@VACANSYUKRAINE.COM", "ADMIN@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEJBeXzF3EHoZCFv99WbDDHccAO4XFMalaHMcv9Qn33+vnvt6i5Oh4tvCkUlcau0VhA==", null, false, "faa38e43-967b-462f-9ef2-e9720064b62a", false, "admin@vacansyukraine.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80d9bb10-67b5-4b48-9500-c6d7c71bede4", "1c5ea35f-361a-45d7-8a77-71a2a359f679" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bfa31fb9-7b11-4f2b-b710-0e7243443fbf", "1c5ea35f-361a-45d7-8a77-71a2a359f679" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bfa31fb9-7b11-4f2b-b710-0e7243443fbf", "962ca386-78fa-4c52-a694-df60fc4cd2d0" });

            migrationBuilder.CreateIndex(
                name: "IX_Unemployeds_VacancyId",
                table: "Unemployeds",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_VacancyId",
                table: "Positions",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_VacancyId",
                table: "Employers",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UnemployedClassId",
                table: "Educations",
                column: "UnemployedClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Datas_UnemployedClassId",
                table: "Datas",
                column: "UnemployedClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Unemployeds_UnemployedClassId",
                table: "Datas",
                column: "UnemployedClassId",
                principalTable: "Unemployeds",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Unemployeds_UnemployedClassId",
                table: "Educations",
                column: "UnemployedClassId",
                principalTable: "Unemployeds",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Vacancys_VacancyId",
                table: "Employers",
                column: "VacancyId",
                principalTable: "Vacancys",
                principalColumn: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Vacancys_VacancyId",
                table: "Positions",
                column: "VacancyId",
                principalTable: "Vacancys",
                principalColumn: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unemployeds_Vacancys_VacancyId",
                table: "Unemployeds",
                column: "VacancyId",
                principalTable: "Vacancys",
                principalColumn: "VacancyId");
        }
    }
}
