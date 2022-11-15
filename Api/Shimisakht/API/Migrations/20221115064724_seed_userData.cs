using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class seed_userData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e4"), "7f22d675-e3e4-4f8e-9f50-821682609d2e", "ADMIN", "ADMIN" },
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), "c02e3efd-df09-4966-8304-fadd6b5ec4ad", "AUTHOR", "AUTHOR" },
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e6"), "9491d837-cd5f-48bf-a3c5-142b17bd4e44", "BASICUSER", "BASICUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e1"), 0, "e871f8b2-c4e3-4697-a856-263a822c4662", "behnaAdmin@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEJhcIxal9mWUZ2ywXOUzYpvYP8zwy5Mp43fdVNjy/IZks88CUk3cTiCcuvgXxt923A==", null, false, null, false, "behnaAdmin" },
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e2"), 0, "159eb2e7-3646-4f5a-beaa-4a0fa810fefb", "behnamAuthor@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEFpfvT3vZB5m59GP9UzlaZrEpT7/GWWk0BYJ3LlGUz8v16zlsVi6MrAWc1PbIBWmkg==", null, false, null, false, "behnamAuthor" },
                    { new Guid("b74ddd14-6340-4840-95c2-db12554843e3"), 0, "9ca84b64-edf3-49ae-a285-bf05996c11c2", "behnaBasic@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEPQy8w0ajZCmkoOZJXPfYsVlOihdWSRAroSkPgkf5R2m3kXJmtqlF6o+wdR3enG1RA==", null, false, null, false, "behnaBasic" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e4"), new Guid("b74ddd14-6340-4840-95c2-db12554843e1") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new Guid("b74ddd14-6340-4840-95c2-db12554843e2") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e6"), new Guid("b74ddd14-6340-4840-95c2-db12554843e3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e4"), new Guid("b74ddd14-6340-4840-95c2-db12554843e1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new Guid("b74ddd14-6340-4840-95c2-db12554843e2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b74ddd14-6340-4840-95c2-db12554843e6"), new Guid("b74ddd14-6340-4840-95c2-db12554843e3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b74ddd14-6340-4840-95c2-db12554843e3"));
        }
    }
}
