using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameWebsite.Data.Migrations
{
    public partial class FixedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_AspNetUsers_CreatedById1",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById1",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedById1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CreatedById1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatedById1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatedById1",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_CreatedById1",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "CreatedById1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedById1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedById1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedById1",
                table: "Attachments");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Attachments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatedById",
                table: "Posts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedById",
                table: "Comments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedById",
                table: "Categories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_CreatedById",
                table: "Attachments",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_AspNetUsers_CreatedById",
                table: "Attachments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById",
                table: "Comments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedById",
                table: "Posts",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_AspNetUsers_CreatedById",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedById",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CreatedById",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CreatedById",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CreatedById",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_CreatedById",
                table: "Attachments");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedById",
                table: "Posts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById1",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedById",
                table: "Comments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById1",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedById",
                table: "Categories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById1",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CreatedById",
                table: "Attachments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedById1",
                table: "Attachments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatedById1",
                table: "Posts",
                column: "CreatedById1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedById1",
                table: "Comments",
                column: "CreatedById1");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatedById1",
                table: "Categories",
                column: "CreatedById1");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_CreatedById1",
                table: "Attachments",
                column: "CreatedById1");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_AspNetUsers_CreatedById1",
                table: "Attachments",
                column: "CreatedById1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById1",
                table: "Categories",
                column: "CreatedById1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CreatedById1",
                table: "Comments",
                column: "CreatedById1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedById1",
                table: "Posts",
                column: "CreatedById1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
