using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay15.Migrations
{
    public partial class AddReservationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_Guest = table.Column<int>(type: "int", nullable: false),
                    Street_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apt_Suite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Zip_Code = table.Column<string>(type: "nchar(10)", nullable: false),
                    Room_Type = table.Column<string>(type: "nchar(10)", nullable: false),
                    Room_Floor = table.Column<string>(type: "nchar(10)", nullable: false),
                    Room_Number = table.Column<string>(type: "nchar(10)", nullable: false),
                    Total_Bill = table.Column<double>(type: "float", nullable: false),
                    Payment_Type = table.Column<string>(type: "nchar(10)", nullable: false),
                    Card_Type = table.Column<string>(type: "nchar(10)", nullable: false),
                    Card_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Card_Exp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Card_CVC = table.Column<string>(type: "nchar(10)", nullable: false),
                    Arrival_Time = table.Column<DateTime>(type: "date", nullable: false),
                    Leaving_Time = table.Column<DateTime>(type: "date", nullable: false),
                    Check_In = table.Column<bool>(type: "bit", nullable: false),
                    Breakfast = table.Column<int>(type: "int", nullable: false),
                    Lunch = table.Column<int>(type: "int", nullable: false),
                    Dinner = table.Column<int>(type: "int", nullable: false),
                    Cleaning = table.Column<bool>(type: "bit", nullable: false),
                    Towel = table.Column<bool>(type: "bit", nullable: false),
                    S_Surprise = table.Column<bool>(type: "bit", nullable: false),
                    Supply_Status = table.Column<bool>(type: "bit", nullable: false),
                    Food_Bill = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
