using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazynEduApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ContextCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Author_AuthorsId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCase_BookCaseId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCase",
                table: "BookCase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "BookCase",
                newName: "BookCases");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCases",
                table: "BookCases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCases_BookCaseId",
                table: "Books",
                column: "BookCaseId",
                principalTable: "BookCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCases_BookCaseId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCases",
                table: "BookCases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "BookCases",
                newName: "BookCase");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCase",
                table: "BookCase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Author_AuthorsId",
                table: "AuthorBook",
                column: "AuthorsId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCase_BookCaseId",
                table: "Books",
                column: "BookCaseId",
                principalTable: "BookCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
