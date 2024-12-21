using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MD4_SQL.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Gender", "Name", "StudentIdNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "Carrie", "SN50202", "Hettinger" },
                    { 2, 0, "Jody", "SN10578", "Feest" },
                    { 3, 1, "Robin", "SN62987", "Feil" },
                    { 4, 2, "Byron", "SN01399", "Ortiz" },
                    { 5, 1, "Leona", "SN05198", "Smith" },
                    { 6, 2, "Hector", "SN99740", "Walker" },
                    { 7, 0, "Rene", "SN55840", "Parisian" },
                    { 8, 0, "Ronald", "SN71165", "Harber" },
                    { 9, 0, "Jesse", "SN78365", "Kihn" },
                    { 10, 2, "Fannie", "SN85399", "Rempel" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ContractDate", "Gender", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2013, 9, 10, 18, 32, 29, 553, DateTimeKind.Local).AddTicks(2923), 1, "Hester", "Reinger" },
                    { 2, new DateTime(2019, 12, 19, 10, 2, 39, 356, DateTimeKind.Local).AddTicks(8084), 1, "Moses", "Jacobson" },
                    { 3, new DateTime(2014, 2, 23, 1, 56, 46, 497, DateTimeKind.Local).AddTicks(6311), 2, "Rahul", "Gibson" },
                    { 4, new DateTime(2013, 7, 8, 11, 43, 5, 662, DateTimeKind.Local).AddTicks(3862), 1, "Shanon", "Pagac" },
                    { 5, new DateTime(2013, 8, 27, 17, 14, 36, 932, DateTimeKind.Local).AddTicks(4043), 1, "Melissa", "Stanton" },
                    { 6, new DateTime(2022, 8, 10, 9, 15, 32, 912, DateTimeKind.Local).AddTicks(7041), 0, "Annabell", "Smitham" },
                    { 7, new DateTime(2024, 2, 3, 19, 12, 17, 911, DateTimeKind.Local).AddTicks(9865), 1, "Maybelle", "Ortiz" },
                    { 8, new DateTime(2010, 3, 15, 8, 12, 39, 486, DateTimeKind.Local).AddTicks(1834), 0, "Hellen", "Hammes" },
                    { 9, new DateTime(2019, 12, 16, 19, 36, 59, 579, DateTimeKind.Local).AddTicks(1080), 2, "Seth", "Deckow" },
                    { 10, new DateTime(2022, 3, 7, 6, 44, 38, 515, DateTimeKind.Local).AddTicks(6561), 2, "Samantha", "Prosacco" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "laudantium", 1 },
                    { 2, "consequatur", 2 },
                    { 3, "exercitationem", 3 },
                    { 4, "mollitia", 4 },
                    { 5, "occaecati", 5 },
                    { 6, "aspernatur", 6 },
                    { 7, "aut", 7 },
                    { 8, "saepe", 8 },
                    { 9, "voluptas", 9 },
                    { 10, "asperiores", 10 }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CourseId", "Deadline", "Description" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 23, 10, 53, 54, 980, DateTimeKind.Local).AddTicks(6177), "et" },
                    { 2, 2, new DateTime(2025, 5, 18, 6, 55, 26, 46, DateTimeKind.Local).AddTicks(4686), "nam" },
                    { 3, 3, new DateTime(2025, 2, 5, 1, 59, 40, 502, DateTimeKind.Local).AddTicks(8800), "ut" },
                    { 4, 4, new DateTime(2025, 1, 22, 20, 59, 49, 280, DateTimeKind.Local).AddTicks(8565), "distinctio" },
                    { 5, 5, new DateTime(2025, 8, 8, 8, 1, 20, 863, DateTimeKind.Local).AddTicks(8757), "dolorem" },
                    { 6, 6, new DateTime(2025, 1, 6, 10, 8, 1, 551, DateTimeKind.Local).AddTicks(4215), "hic" },
                    { 7, 7, new DateTime(2025, 3, 20, 11, 46, 56, 990, DateTimeKind.Local).AddTicks(2376), "dolorem" },
                    { 8, 8, new DateTime(2025, 1, 16, 6, 58, 39, 303, DateTimeKind.Local).AddTicks(6934), "aliquam" },
                    { 9, 9, new DateTime(2025, 2, 28, 10, 29, 0, 982, DateTimeKind.Local).AddTicks(2078), "nulla" },
                    { 10, 10, new DateTime(2025, 12, 3, 12, 49, 12, 774, DateTimeKind.Local).AddTicks(7611), "sit" }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AssignmentId", "Score", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, 1, 18, 1, new DateTime(2025, 11, 30, 5, 44, 14, 942, DateTimeKind.Local).AddTicks(9496) },
                    { 2, 2, 60, 2, new DateTime(2025, 12, 2, 2, 24, 42, 389, DateTimeKind.Local).AddTicks(7053) },
                    { 3, 3, 25, 3, new DateTime(2025, 8, 17, 8, 7, 31, 129, DateTimeKind.Local).AddTicks(1718) },
                    { 4, 4, 39, 4, new DateTime(2025, 2, 16, 8, 26, 59, 227, DateTimeKind.Local).AddTicks(4006) },
                    { 5, 5, 51, 5, new DateTime(2025, 2, 20, 8, 48, 59, 212, DateTimeKind.Local).AddTicks(2664) },
                    { 6, 6, 31, 6, new DateTime(2025, 12, 10, 16, 49, 4, 946, DateTimeKind.Local).AddTicks(1293) },
                    { 7, 7, 30, 7, new DateTime(2025, 10, 2, 18, 59, 50, 627, DateTimeKind.Local).AddTicks(3787) },
                    { 8, 8, 17, 8, new DateTime(2025, 6, 25, 14, 31, 42, 718, DateTimeKind.Local).AddTicks(9416) },
                    { 9, 9, 29, 9, new DateTime(2025, 1, 9, 20, 58, 33, 415, DateTimeKind.Local).AddTicks(7775) },
                    { 10, 10, 22, 10, new DateTime(2025, 3, 6, 10, 39, 21, 497, DateTimeKind.Local).AddTicks(9815) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
