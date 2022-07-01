using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KariyerClone.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "529b54c4-8323-4f83-8a77-b702f0674758", "bdd6c275-356d-4033-9865-689c26e7c24c", "Administrator", "ADMINISTRATOR" },
                    { "5f034be7-2575-4f84-88de-2156531a5208", "b068854a-eb44-48d4-851d-a6d0663b9785", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 7, 31, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3166), 2, "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3153), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Wuhan", new DateTime(2022, 7, 21, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3213), 3, "Sales", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3212), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Istanbul", new DateTime(2022, 8, 21, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3217), 3, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3217), "Salesman" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Adana", new DateTime(2022, 7, 9, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3221), 3, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3221), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Wuhan", new DateTime(2022, 8, 20, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3225), 2, "Finance", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3225), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Adana", new DateTime(2022, 8, 5, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3231), "Finance", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3231), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Dubai", new DateTime(2022, 7, 13, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3235), 1, "Human Resources", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3235), "Human Resource Specialist", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Istanbul", new DateTime(2022, 8, 13, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3239), "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3238), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { 3, "Adana", new DateTime(2022, 7, 13, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3243), 2, "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Los Angeles", new DateTime(2022, 7, 22, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3248), 3, "Sales", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3247), "Salesman", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 4, "Tokyo", new DateTime(2022, 8, 29, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3252), 2, "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3251), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 3, new DateTime(2022, 8, 22, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3256), 3, "Human Resources", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3255), "Human Resource Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Wuhan", new DateTime(2022, 7, 9, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3260), "IT", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3259), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { 3, "Los Angeles", new DateTime(2022, 8, 15, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3264), 1, "Marketing", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3263), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Los Angeles", new DateTime(2022, 8, 27, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3268), 3, "Junior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3267), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 4, new DateTime(2022, 7, 27, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3272), 5, "Sales", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3271), "Salesman" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Istanbul", new DateTime(2022, 7, 11, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3276), 2, "Human Resources", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3275), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 4, "Wuhan", new DateTime(2022, 7, 29, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3281), 3, "Marketing", "Junior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3281), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 8, 24, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3285), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { "Los Angeles", new DateTime(2022, 7, 21, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3290), 4, "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { 2, "Istanbul", new DateTime(2022, 8, 6, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3293), 2, "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 8, 25, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3340), 2, "Junior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3340), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Dubai", new DateTime(2022, 8, 14, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3345), 4, "IT", "Junior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3344), "Developer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Los Angeles", new DateTime(2022, 8, 21, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3349), 3, "Finance", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3348), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Los Angeles", new DateTime(2022, 8, 3, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3352), 5, "Marketing", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3352), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, new DateTime(2022, 8, 4, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3356), 5, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3355), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 13, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3360), 5, "IT", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3359), "Developer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Bangkok", new DateTime(2022, 7, 7, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3364), 1, "Sales", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3363), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PostingDate", "TypeOfWork" },
                values: new object[] { 4, "Bangkok", new DateTime(2022, 8, 2, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3367), 2, new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3367), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 8, 4, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3371), 4, "Marketing", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3370), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Wuhan", new DateTime(2022, 7, 18, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3375), 4, "Human Resources", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3374), "Human Resource Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Wuhan", new DateTime(2022, 8, 27, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3379), 2, "Sales", "Junior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3378), "Salesman", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 8, 8, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3382), 4, "IT", "Senior", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3382), "Developer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, new DateTime(2022, 7, 14, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3387), 5, "Sales", "Manager", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3387), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 2, "Istanbul", new DateTime(2022, 8, 6, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3392), "Principal", new DateTime(2022, 7, 1, 13, 28, 29, 241, DateTimeKind.Local).AddTicks(3391), "Full-time" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529b54c4-8323-4f83-8a77-b702f0674758");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f034be7-2575-4f84-88de-2156531a5208");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4137), 1, "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4124), "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Dubai", new DateTime(2022, 7, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4178), 4, "Human Resources", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4177), "Human Resource Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Adana", new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4181), 4, "IT", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4181), "Developer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Bangkok", new DateTime(2022, 7, 27, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4185), 2, "Human Resources", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4184), "Human Resource Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Adana", new DateTime(2022, 7, 23, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4188), 4, "IT", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4188), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4193), "Sales", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4193), "Salesman", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Istanbul", new DateTime(2022, 8, 9, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4197), 3, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4196), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { "Adana", new DateTime(2022, 8, 7, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4200), "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4200), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { 1, "Los Angeles", new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4204), 5, "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 7, 8, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4208), 5, "Finance", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4208), "Finance Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 3, "Dubai", new DateTime(2022, 7, 31, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4212), 5, "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4212), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 1, new DateTime(2022, 8, 17, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4216), 2, "Finance", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4215), "Finance Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Istanbul", new DateTime(2022, 7, 14, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4219), "Finance", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4218), "Finance Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { 1, "Istanbul", new DateTime(2022, 8, 3, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4222), 4, "IT", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4222), "Developer" });

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
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 3, new DateTime(2022, 7, 29, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4229), 4, "IT", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4228), "Developer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { "Adana", new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4232), 5, "Sales", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4232), "Salesman", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { 1, "Dubai", new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4237), 5, "IT", "Senior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4236), "Developer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "PostingDate", "TypeOfWork" },
                values: new object[] { 3, new DateTime(2022, 8, 20, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4240), new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4239), "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 28, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4243), 3, "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PositionLevel", "PostingDate" },
                values: new object[] { 1, "Adana", new DateTime(2022, 7, 26, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4246), 5, "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClosingDate", "CompanyId", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { new DateTime(2022, 7, 12, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4249), 3, "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4249), "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, "Wuhan", new DateTime(2022, 7, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4253), 5, "Marketing", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4252), "Marketer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Bangkok", new DateTime(2022, 7, 30, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4256), 5, "Sales", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4255), "Salesman", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Bangkok", new DateTime(2022, 7, 29, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4259), 1, "IT", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4259), "Developer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, new DateTime(2022, 8, 24, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4262), 4, "Human Resources", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4262), "Human Resource Specialist", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PostingDate", "Title" },
                values: new object[] { "Dubai", new DateTime(2022, 8, 8, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4265), 1, "Marketing", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4265), "Marketer" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 3, "Istanbul", new DateTime(2022, 8, 6, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4268), 5, "Marketing", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4268), "Marketer", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "PostingDate", "TypeOfWork" },
                values: new object[] { 2, "Los Angeles", new DateTime(2022, 7, 16, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4271), 4, new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4271), "Full-time" });

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
                columns: new[] { "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title" },
                values: new object[] { "Tokyo", new DateTime(2022, 7, 31, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4278), 5, "Finance", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4277), "Finance Specialist" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 4, "Dubai", new DateTime(2022, 8, 15, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4281), 3, "IT", "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4281), "Developer", "Contract-Based" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 2, "Los Angeles", new DateTime(2022, 7, 19, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4285), 1, "Finance", "Principal", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4284), "Finance Specialist", "Part-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ApplicantCriteriasId", "ClosingDate", "CompanyId", "Department", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[] { 1, new DateTime(2022, 8, 11, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4330), 2, "Marketing", "Junior", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4329), "Marketer", "Full-time" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ApplicantCriteriasId", "City", "ClosingDate", "PositionLevel", "PostingDate", "TypeOfWork" },
                values: new object[] { 1, "Wuhan", new DateTime(2022, 7, 6, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4333), "Manager", new DateTime(2022, 7, 1, 13, 20, 8, 968, DateTimeKind.Local).AddTicks(4333), "Part-time" });
        }
    }
}
