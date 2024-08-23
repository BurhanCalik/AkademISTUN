﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicianPlatform.Data.Migrations
{
    /// <inheritdoc />
    public partial class TicketModelUpdated_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketSenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketRespondSenderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketRespondContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
