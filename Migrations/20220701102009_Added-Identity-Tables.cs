using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KariyerClone.Migrations
{
    public partial class AddedIdentityTables : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Istanbul", new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4137), 1, "Finance", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4124), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 7, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4178), "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4177), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 3, "Adana", new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4181), 4, "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4181), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Bangkok", new DateTime(2022, 7, 27, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4185), 2, "Human Resources", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4184), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, new DateTime(2022, 7, 23, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4188), "IT", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4188), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Tokyo", new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4193), 1, "Sales", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4193), "Salesman", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Istanbul", new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4197), 3, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4196), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Adana", new DateTime(2022, 8, 7, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4200), 4, "Finance", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4200), "Finance Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4204), "Sales", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4203), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 7, 8, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4208), 5, "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4208), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Dubai", new DateTime(2022, 7, 31, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4212), 5, "Human Resources", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4212), "Human Resource Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 8, 17, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4216), 2, "Finance", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4215), "Finance Specialist", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Istanbul", new DateTime(2022, 7, 14, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4219), 4, "Finance", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4218), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Istanbul", new DateTime(2022, 8, 3, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4222), 4, "IT", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4222), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Adana", new DateTime(2022, 8, 17, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4226), 1, "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4225), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 7, 29, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4229), 4, "IT", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4228), "Developer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { "Adana", new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4232), 5, "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Dubai", new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4237), 5, "IT", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4236), "Developer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 8, 20, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4240), 1, "Sales", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4239), "Salesman" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "PostingDate", "TypeOfWork" },
                values: new object[] { 2, "Tokyo", new DateTime(2022, 7, 28, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4243), new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4242), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Adana", new DateTime(2022, 7, 26, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4246), "Sales", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4246), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4249), 3, "Human Resources", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4249), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Wuhan", new DateTime(2022, 7, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4253), "Marketing", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4252), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Bangkok", new DateTime(2022, 7, 30, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4256), 5, "Sales", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4255), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 7, 29, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4259), 1, "IT", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4259), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Dubai", new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4262), 4, "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4262), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosingDate", "Department", "PostingDate", "Title" },
                values: new object[] { new DateTime(2022, 8, 8, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4265), "Marketing", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4265), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 8, 6, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4268), "Marketing", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4268), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Los Angeles", new DateTime(2022, 7, 16, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4271), 4, "Marketing", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4271), "Marketer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 1, "Bangkok", new DateTime(2022, 7, 28, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4274), 1, "Human Resources", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4274), "Human Resource Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PostingDate", "TypeOfWork" },
                values: new object[] { 4, "Tokyo", new DateTime(2022, 7, 31, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4278), 5, new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4277), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 4, "Dubai", new DateTime(2022, 8, 15, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4281), 3, "IT", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4281), "Developer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Los Angeles", new DateTime(2022, 7, 19, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4285), 1, "Finance", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4284), "Finance Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 8, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4330), 2, "Marketing", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4329), "Marketer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Wuhan", new DateTime(2022, 7, 6, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4333), 5, "Finance", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4333), "Finance Specialist", "Part-time" });

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Dubai", new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1662), 2, "Human Resources", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1653), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 4, new DateTime(2022, 7, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1696), "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1695), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 2, "Tokyo", new DateTime(2022, 7, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699), 1, "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Dubai", new DateTime(2022, 7, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702), 4, "Marketing", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 8, 14, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1705), "Sales", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1704), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708), 4, "Human Resources", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Wuhan", new DateTime(2022, 8, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711), 4, "Human Resources", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711), "Human Resource Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Wuhan", new DateTime(2022, 8, 15, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714), 2, "IT", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714), "Developer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, new DateTime(2022, 8, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717), "Marketing", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, "Los Angeles", new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721), 1, "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Wuhan", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724), 3, "Marketing", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, new DateTime(2022, 7, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727), 3, "IT", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727), "Developer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Dubai", new DateTime(2022, 8, 7, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1730), 2, "Marketing", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1729), "Marketer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Wuhan", new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732), 1, "Sales", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Bangkok", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735), 5, "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Adana", new DateTime(2022, 8, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1738), 2, "Sales", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1737), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { "Istanbul", new DateTime(2022, 8, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740), 3, "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744), 4, "Marketing", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744), "Marketer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { 1, "Istanbul", new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747), 4, "Marketing", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, "Bangkok", new DateTime(2022, 8, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1749), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Wuhan", new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752), "Finance", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752), "Finance Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Dubai", new DateTime(2022, 8, 2, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755), 2, "Sales", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Bangkok", new DateTime(2022, 8, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786), "Human Resources", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786), "Human Resource Specialist", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Los Angeles", new DateTime(2022, 8, 5, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789), 1, "Finance", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789), "Finance Specialist", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Istanbul", new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1792), 4, "Marketing", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1791), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1795), 5, "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1794), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClosingDate", "Department", "PostingDate", "Title" },
                values: new object[] { new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1798), "Finance", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1797), "Finance Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 4, "Dubai", new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800), "Finance", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800), "Finance Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Dubai", new DateTime(2022, 7, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1837), 1, "Sales", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1836), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 4, "Adana", new DateTime(2022, 8, 1, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1840), 4, "Finance", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1839), "Finance Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, "Bangkok", new DateTime(2022, 7, 20, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842), 1, new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 1, "Wuhan", new DateTime(2022, 8, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845), 4, "Marketing", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Wuhan", new DateTime(2022, 7, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847), 3, "IT", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847), "Developer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851), 5, "Sales", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Bangkok", new DateTime(2022, 7, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1855), 4, "IT", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1854), "Developer", "Full-time" });
        }
    }
}
