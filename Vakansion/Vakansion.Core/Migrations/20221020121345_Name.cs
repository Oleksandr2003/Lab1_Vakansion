using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vakansion.Core.Migrations
{
    public partial class Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unemployeds",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unemployeds", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Unemployeds_Datas_DataId",
                        column: x => x.DataId,
                        principalTable: "Datas",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unemployeds_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

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
<<<<<<< Updated upstream:Vakansion/Vakansion.Core/Migrations/20221020121345_Name.cs
                    { "706a77ed-bb8b-47a1-9a80-a06931d02e49", "7a68ce91-efce-4044-963e-d3910100f1e5", "Admin", "ADMIN" },
                    { "cc2c8e5a-0ef5-4397-be24-f62194674072", "b0c5b333-52cc-4c21-884d-1f32fd66ace8", "User", "USER" }
=======
                    { "4a125544-5ac0-4927-a181-b7ef3547562a", "0a01f496-738a-4781-9dfc-eec1f23de4cd", "Admin", "ADMIN" },
                    { "705ba428-5f5e-4ae3-b884-504cf3a3a4e1", "f0f3f692-fe58-4c52-804e-322f1b0e90a7", "User", "USER" }
>>>>>>> Stashed changes:Vakansion/Vakansion.Core/Migrations/20221018175144_First.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<< Updated upstream:Vakansion/Vakansion.Core/Migrations/20221020121345_Name.cs
                    { "523a7c7f-773b-4f91-b6ca-ddd3f6ad1e92", 0, "7cb0c9b4-9345-4b57-a6d9-10be97ca0fd3", "user@vacansyukraine.com", true, null, null, false, null, "USER@VACANSYUKRAINE.COM", "USER@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAECyWYP+qwdHUY+hLxb/ilyuLtAw+Hd422ogoMkDnPVMuczUHmJE4+CUhBvFVb2WEzQ==", null, false, "e3829778-303c-4308-a595-f63f337d73b8", false, "user@vacansyukraine.com" },
                    { "88c575fc-5f94-49ff-acb2-9fcc9402d481", 0, "e17bb092-b586-493f-8dc1-8b31a56b38eb", "admin@vacansyukraine.com", true, null, null, false, null, "ADMIN@VACANSYUKRAINE.COM", "ADMIN@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEEX0TIFbt3IrXQndzFNtFatcpfdRMA86jd/qXPaeCnUGFILRsBKtkoN31QsphEcgFA==", null, false, "497ef9be-d226-4a8f-9806-d19fc609eb0d", false, "admin@vacansyukraine.com" }
=======
                    { "76b3fb1f-1201-452e-b1bb-d0d1aac44cad", 0, "c5205b5d-39eb-4618-9ccc-60d04e010bd5", "admin@vacansyukraine.com", true, null, null, false, null, "ADMIN@VACANSYUKRAINE.COM", "ADMIN@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEE3N2Re+5dQc4tr6rworgNjEFEsa5RCPTjiJMvSbWGuEYRiwfZ1Ed16YHOnIkDHewQ==", null, false, "22754281-a0a9-4896-a64f-a58ba77a5410", false, "admin@vacansyukraine.com" },
                    { "be7003a7-d841-46d4-adfb-92db7ed1ae39", 0, "0dc5df06-3f9f-4d96-9c37-0270ea66f9f3", "user@vacansyukraine.com", true, null, null, false, null, "USER@VACANSYUKRAINE.COM", "USER@VACANSYUKRAINE.COM", "AQAAAAEAACcQAAAAEKsLm+LPJfP1sOuJ1mbke4qJWfSSBksIGxTS5ZMwXiFKGjB9Ix/POCOnXDoxmIGLoA==", null, false, "0cf71d8a-621b-4fd1-a9fd-8ec18391e9d5", false, "user@vacansyukraine.com" }
>>>>>>> Stashed changes:Vakansion/Vakansion.Core/Migrations/20221018175144_First.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< Updated upstream:Vakansion/Vakansion.Core/Migrations/20221020121345_Name.cs
                values: new object[] { "706a77ed-bb8b-47a1-9a80-a06931d02e49", "523a7c7f-773b-4f91-b6ca-ddd3f6ad1e92" });
=======
                values: new object[] { "4a125544-5ac0-4927-a181-b7ef3547562a", "76b3fb1f-1201-452e-b1bb-d0d1aac44cad" });
>>>>>>> Stashed changes:Vakansion/Vakansion.Core/Migrations/20221018175144_First.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< Updated upstream:Vakansion/Vakansion.Core/Migrations/20221020121345_Name.cs
                values: new object[] { "cc2c8e5a-0ef5-4397-be24-f62194674072", "523a7c7f-773b-4f91-b6ca-ddd3f6ad1e92" });
=======
                values: new object[] { "4a125544-5ac0-4927-a181-b7ef3547562a", "be7003a7-d841-46d4-adfb-92db7ed1ae39" });
>>>>>>> Stashed changes:Vakansion/Vakansion.Core/Migrations/20221018175144_First.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
<<<<<<< Updated upstream:Vakansion/Vakansion.Core/Migrations/20221020121345_Name.cs
                values: new object[] { "706a77ed-bb8b-47a1-9a80-a06931d02e49", "88c575fc-5f94-49ff-acb2-9fcc9402d481" });
=======
                values: new object[] { "705ba428-5f5e-4ae3-b884-504cf3a3a4e1", "be7003a7-d841-46d4-adfb-92db7ed1ae39" });
>>>>>>> Stashed changes:Vakansion/Vakansion.Core/Migrations/20221018175144_First.cs

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Vacancyses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Unemployeds");

            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Educations");
        }
    }
}
