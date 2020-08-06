using Microsoft.EntityFrameworkCore.Migrations;

namespace Yiming.Infrastructure.TaskManagementSystem.Migrations
{
    public partial class foreign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UsersId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistory_Users_UsersId",
                table: "TasksHistory");

            migrationBuilder.DropIndex(
                name: "IX_TasksHistory_UsersId",
                table: "TasksHistory");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UsersId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "TasksHistory");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "TasksHistory",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistory_UserId",
                table: "TasksHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistory_Users_UserId",
                table: "TasksHistory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksHistory_Users_UserId",
                table: "TasksHistory");

            migrationBuilder.DropIndex(
                name: "IX_TasksHistory_UserId",
                table: "TasksHistory");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "TasksHistory",
                type: "varchar",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "TasksHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TasksHistory_UsersId",
                table: "TasksHistory",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UsersId",
                table: "Tasks",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UsersId",
                table: "Tasks",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TasksHistory_Users_UsersId",
                table: "TasksHistory",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
