using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class seed_userData_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e4"),
                column: "ConcurrencyStamp",
                value: "6ee4e277-29bb-4e07-b899-1cecad5e10fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                column: "ConcurrencyStamp",
                value: "3cff8670-ea68-44c4-9801-998719422763");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e6"),
                column: "ConcurrencyStamp",
                value: "1027fa58-0a82-4874-a918-3d312b2a00b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "898f7328-783c-4e45-abf8-99e2f2a4f9ce", "behnamAdmin@gmail.com", "BEHNAMADMIN@GMAIL.COM", "BEHNAMADMIN", "AQAAAAEAACcQAAAAENtMEbnGuFeyQgL0ft3xetAu0fRgpEHfUqS2YJjzREcY9n61YITEFBN1ux3GKrmUWA==", "behnamAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e2"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "5cef2b9f-f3c4-4e26-8609-af9401e57db1", "BEHNAMAUTHOR@GMAIL.COM", "BEHNAMAUTHOR", "AQAAAAEAACcQAAAAELvBa14tni5b1fS3LUGs4epekeU7V2dxG9J+CmFyM2aqWMXzZFQXsDRM1wjLfeJlLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "925c3271-aa8e-4dd7-b94f-ec1a980e46ab", "behnamBasic@gmail.com", "BEHNAMBASIC@GMAIL.COM", "BEHNAMBASIC", "AQAAAAEAACcQAAAAEPEnNxaS5ala/XBPmrqs4VqbSHElxPe0N+9sKL8qjLubHdUAHvFFGUPsO1P89J7Q3A==", "behnamBasic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e4"),
                column: "ConcurrencyStamp",
                value: "7f22d675-e3e4-4f8e-9f50-821682609d2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                column: "ConcurrencyStamp",
                value: "c02e3efd-df09-4966-8304-fadd6b5ec4ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e6"),
                column: "ConcurrencyStamp",
                value: "9491d837-cd5f-48bf-a3c5-142b17bd4e44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e871f8b2-c4e3-4697-a856-263a822c4662", "behnaAdmin@gmail.com", null, null, "AQAAAAEAACcQAAAAEJhcIxal9mWUZ2ywXOUzYpvYP8zwy5Mp43fdVNjy/IZks88CUk3cTiCcuvgXxt923A==", "behnaAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e2"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "159eb2e7-3646-4f5a-beaa-4a0fa810fefb", null, null, "AQAAAAEAACcQAAAAEFpfvT3vZB5m59GP9UzlaZrEpT7/GWWk0BYJ3LlGUz8v16zlsVi6MrAWc1PbIBWmkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e3"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9ca84b64-edf3-49ae-a285-bf05996c11c2", "behnaBasic@gmail.com", null, null, "AQAAAAEAACcQAAAAEPQy8w0ajZCmkoOZJXPfYsVlOihdWSRAroSkPgkf5R2m3kXJmtqlF6o+wdR3enG1RA==", "behnaBasic" });
        }
    }
}
