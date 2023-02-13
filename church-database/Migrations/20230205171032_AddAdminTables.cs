using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace church_database.Migrations
{
    public partial class AddAdminTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicantCommunity",
                columns: table => new
                {
                    ApplicantCommunityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantCommunityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantCommunityDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicantCommunity", x => x.ApplicantCommunityId);
                });

            migrationBuilder.CreateTable(
                name: "ApplyingEntity",
                columns: table => new
                {
                    ApplyingEntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyingEntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplyingEntityDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyingEntity", x => x.ApplyingEntityId);
                });

            migrationBuilder.CreateTable(
                name: "CompletionStatus",
                columns: table => new
                {
                    CompletionStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletionStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionStatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletionStatus", x => x.CompletionStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    ProjectStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.ProjectStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.ProjectTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicantCommunity");

            migrationBuilder.DropTable(
                name: "ApplyingEntity");

            migrationBuilder.DropTable(
                name: "CompletionStatus");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ProjectTypes");
        }
    }
}
