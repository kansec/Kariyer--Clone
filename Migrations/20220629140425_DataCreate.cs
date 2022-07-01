using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KariyerClone.Migrations
{
    public partial class DataCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MilitaryStatus",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EducationLevel",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "ApplicantCriterias",
                columns: new[] { "Id", "DrivingLicense", "EducationLevel", "MilitaryStatus" },
                values: new object[,]
                {
                    { 1, "B", "Bachelor", "Done" },
                    { 2, "B", "Master", null },
                    { 3, "B", "PHD", "Done" },
                    { 4, null, "Master", null },
                    { 5, null, null, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Description", "FoundationYear", "Logo", "Name", "NumberOfEmployees", "Sector", "Website" },
                values: new object[,]
                {
                    { 1, "California", "Google LLC is an American multinational technology company that focuses on artificial intelligence, search engine technology, online advertising, cloud computing, computer software, quantum computing, e-commerce, and consumer electronics.", 1998, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Google_%22G%22_Logo.svg/800px-Google_%22G%22_Logo.svg.png", "Google", 300000, "IT", "https://www.google.com/" },
                    { 2, "California", "The Walt Disney Company, commonly known as Disney, is an American multinational mass media and entertainment conglomerate headquartered at the Walt Disney Studios complex in Burbank, California.", 1923, "https://frpnet.net/wp-content/uploads/2018/11/Disney-logo-1.jpg", "Disney", 200000, "Media", "https://thewaltdisneycompany.com/" },
                    { 3, "Leiden", "Airbus SE is a European multinational aerospace corporation. Airbus designs, manufactures and sells civil and military aerospace products worldwide and manufactures aircraft in Europe and various countries outside Europe.", 1970, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Logo_Airbus_2014.svg/2560px-Logo_Airbus_2014.svg.png", "AIRBUS", 100000, "Aerospace", "https://www.airbus.com/en" },
                    { 4, "Tokyo", "FromSoftware, Inc. is a Japanese video game development company founded in November 1986 and a subsidiary of Kadokawa Corporation. The company is best known for their Armored Core and Souls series, including the related games Bloodborne, Sekiro, and Elden Ring.", 1986, "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012011/from_soft.png?itok=EA5zFilD", "From Software", 9877, "IT", "https://www.fromsoftware.jp/ww/" },
                    { 5, "Istanbul", "Peak Games is a mobile gaming company based in Istanbul, Turkey. The privately-held company was acquired by Zynga in June 2020 for $1.8 billion. The company launched the games Toy Blast in 2015 and Toon Blast in 2017, both collectively have more than 12 million average mobile daily active users as of June 2020.", 2010, "https://peakweb.global.ssl.fastly.net/static/assets/icons/logo-header-180-90.b348ab1a.png", "Peak", 3213, "IT", "https://peak.com/" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ApplicantCriteriasId", "City", "ClosingDate", "CompanyId", "Department", "Description", "PositionLevel", "PostingDate", "Title", "TypeOfWork" },
                values: new object[,]
                {
                    { 1, 1, "Dubai", new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1662), 2, "Human Resources", "Job Description1", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1653), "Human Resource Specialist", "Part-time" },
                    { 2, 4, "Dubai", new DateTime(2022, 7, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1696), 4, "Human Resources", "Job Description2", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1695), "Human Resource Specialist", "Full-time" },
                    { 3, 2, "Tokyo", new DateTime(2022, 7, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699), 1, "IT", "Job Description3", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699), "Developer", "Contract-Based" },
                    { 4, 3, "Dubai", new DateTime(2022, 7, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702), 4, "Marketing", "Job Description4", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702), "Marketer", "Contract-Based" },
                    { 5, 1, "Adana", new DateTime(2022, 8, 14, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1705), 4, "Sales", "Job Description5", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1704), "Salesman", "Part-time" },
                    { 6, 3, "Istanbul", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708), 4, "Human Resources", "Job Description6", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708), "Human Resource Specialist", "Part-time" },
                    { 7, 2, "Wuhan", new DateTime(2022, 8, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711), 4, "Human Resources", "Job Description7", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711), "Human Resource Specialist", "Contract-Based" },
                    { 8, 4, "Wuhan", new DateTime(2022, 8, 15, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714), 2, "IT", "Job Description8", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714), "Developer", "Contract-Based" },
                    { 9, 3, "Los Angeles", new DateTime(2022, 8, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717), 5, "Marketing", "Job Description9", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717), "Marketer", "Contract-Based" },
                    { 10, 1, "Los Angeles", new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721), 1, "Finance", "Job Description10", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721), "Finance Specialist", "Full-time" },
                    { 11, 3, "Wuhan", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724), 3, "Marketing", "Job Description11", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724), "Marketer", "Part-time" },
                    { 12, 4, "Los Angeles", new DateTime(2022, 7, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727), 3, "IT", "Job Description12", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727), "Developer", "Part-time" },
                    { 13, 3, "Dubai", new DateTime(2022, 8, 7, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1730), 2, "Marketing", "Job Description13", "Junior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1729), "Marketer", "Part-time" },
                    { 14, 4, "Wuhan", new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732), 1, "Sales", "Job Description14", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732), "Salesman", "Contract-Based" },
                    { 15, 4, "Bangkok", new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735), 5, "IT", "Job Description15", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735), "Developer", "Contract-Based" },
                    { 16, 1, "Adana", new DateTime(2022, 8, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1738), 2, "Sales", "Job Description16", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1737), "Salesman", "Contract-Based" },
                    { 17, 2, "Istanbul", new DateTime(2022, 8, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740), 3, "Sales", "Job Description17", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740), "Salesman", "Contract-Based" },
                    { 18, 1, "Tokyo", new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744), 4, "Marketing", "Job Description18", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744), "Marketer", "Full-time" },
                    { 19, 1, "Istanbul", new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747), 4, "Marketing", "Job Description19", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747), "Marketer", "Full-time" },
                    { 20, 1, "Bangkok", new DateTime(2022, 8, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1750), 3, "Human Resources", "Job Description20", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1749), "Human Resource Specialist", "Contract-Based" },
                    { 21, 4, "Wuhan", new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752), 5, "Finance", "Job Description21", "Manager", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752), "Finance Specialist", "Part-time" },
                    { 22, 1, "Dubai", new DateTime(2022, 8, 2, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755), 2, "Sales", "Job Description22", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755), "Salesman", "Contract-Based" },
                    { 23, 1, "Bangkok", new DateTime(2022, 8, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786), 5, "Human Resources", "Job Description23", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786), "Human Resource Specialist", "Full-time" },
                    { 24, 3, "Los Angeles", new DateTime(2022, 8, 5, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789), 1, "Finance", "Job Description24", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789), "Finance Specialist", "Full-time" },
                    { 25, 4, "Istanbul", new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1792), 4, "Marketing", "Job Description25", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1791), "Marketer", "Contract-Based" },
                    { 26, 4, "Tokyo", new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1795), 5, "Human Resources", "Job Description26", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1794), "Human Resource Specialist", "Part-time" },
                    { 27, 1, "Dubai", new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1798), 1, "Finance", "Job Description27", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1797), "Finance Specialist", "Part-time" },
                    { 28, 4, "Dubai", new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800), 5, "Finance", "Job Description28", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800), "Finance Specialist", "Part-time" },
                    { 29, 1, "Dubai", new DateTime(2022, 7, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1837), 1, "Sales", "Job Description29", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1836), "Salesman", "Part-time" },
                    { 30, 4, "Adana", new DateTime(2022, 8, 1, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1840), 4, "Finance", "Job Description30", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1839), "Finance Specialist", "Full-time" },
                    { 31, 1, "Bangkok", new DateTime(2022, 7, 20, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842), 1, "Finance", "Job Description31", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842), "Finance Specialist", "Part-time" },
                    { 32, 1, "Wuhan", new DateTime(2022, 8, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845), 4, "Marketing", "Job Description32", "Senior", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845), "Marketer", "Contract-Based" },
                    { 33, 2, "Wuhan", new DateTime(2022, 7, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847), 3, "IT", "Job Description33", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847), "Developer", "Contract-Based" },
                    { 34, 1, "Dubai", new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851), 5, "Sales", "Job Description34", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851), "Salesman", "Contract-Based" },
                    { 35, 2, "Bangkok", new DateTime(2022, 7, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1855), 4, "IT", "Job Description35", "Principal", new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1854), "Developer", "Full-time" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicantCriterias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ApplicantCriterias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicantCriterias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApplicantCriterias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApplicantCriterias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "MilitaryStatus",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EducationLevel",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "ApplicantCriterias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
