using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace church_database.Migrations
{
    public partial class AddedProjectsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesiredDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedEndOfProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    ProjectStatusId = table.Column<int>(type: "int", nullable: false),
                    ApplyingEntityId = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantCommunityId = table.Column<int>(type: "int", nullable: false),
                    ApplicantInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalProjectCost = table.Column<int>(type: "int", nullable: false),
                    LocalContribution = table.Column<int>(type: "int", nullable: true),
                    AmountToBeAppliedForAgencies = table.Column<int>(type: "int", nullable: true),
                    ProjectCompletionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionStatusId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_ApplicantCommunity_ApplicantCommunityId",
                        column: x => x.ApplicantCommunityId,
                        principalTable: "ApplicantCommunity",
                        principalColumn: "ApplicantCommunityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ApplyingEntity_ApplyingEntityId",
                        column: x => x.ApplyingEntityId,
                        principalTable: "ApplyingEntity",
                        principalColumn: "ApplyingEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_CompletionStatus_CompletionStatusId",
                        column: x => x.CompletionStatusId,
                        principalTable: "CompletionStatus",
                        principalColumn: "CompletionStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectStatus_ProjectStatusId",
                        column: x => x.ProjectStatusId,
                        principalTable: "ProjectStatus",
                        principalColumn: "ProjectStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectTypes_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "ProjectTypes",
                        principalColumn: "ProjectTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApplicantCommunityId",
                table: "Projects",
                column: "ApplicantCommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApplyingEntityId",
                table: "Projects",
                column: "ApplyingEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompletionStatusId",
                table: "Projects",
                column: "CompletionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
