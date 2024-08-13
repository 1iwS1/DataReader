using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataReader.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastSyncTime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SyncResult = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectSK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AnalyticsUpdatedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProjectVisibility = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects_Id", x => x.ProjectSK);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnalyticsUpdatedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GitHubUserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Id", x => x.UserSK);
                });

            migrationBuilder.CreateTable(
                name: "WorkItems",
                columns: table => new
                {
                    WorkItemId = table.Column<int>(type: "int", nullable: false),
                    InProgressDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompletedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InProgressDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CompletedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AnalyticsUpdatedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WorkItemRevisionSK = table.Column<int>(type: "int", nullable: true),
                    AreaSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IterationSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivatedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChangedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ClosedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreatedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ResolvedDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    StateChangeDateSK = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WorkItemType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChangedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ActivatedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClosedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    ResolvedDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompletedWork = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Effort = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FinishDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OriginalEstimate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RemainingWork = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StoryPoints = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TargetDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentWorkItemId = table.Column<int>(type: "int", nullable: true),
                    TagNames = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StateChangeDate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Custom_Company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Custom_Eksternareferenca = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Custom_ITServiceorApplication = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Custom_Statusprojekta = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Custom_TicketNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AssignedToUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangedByUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivatedByUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClosedByUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResolvedByUserSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectSK = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItems_Id", x => x.WorkItemId);
                    table.ForeignKey(
                        name: "FK_WorkItems_ActivatedByUserSK",
                        column: x => x.ActivatedByUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_AssignedToUserSK",
                        column: x => x.AssignedToUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_ChangedByUserSK",
                        column: x => x.ChangedByUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_ClosedByUserSK",
                        column: x => x.ClosedByUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_CreatedByUserSK",
                        column: x => x.CreatedByUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_ProjectSK",
                        column: x => x.ProjectSK,
                        principalTable: "Projects",
                        principalColumn: "ProjectSK");
                    table.ForeignKey(
                        name: "FK_WorkItems_ResolvedByUserSK",
                        column: x => x.ResolvedByUserSK,
                        principalTable: "Users",
                        principalColumn: "UserSK");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ActivatedByUserSK",
                table: "WorkItems",
                column: "ActivatedByUserSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_AssignedToUserSK",
                table: "WorkItems",
                column: "AssignedToUserSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ChangedByUserSK",
                table: "WorkItems",
                column: "ChangedByUserSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ClosedByUserSK",
                table: "WorkItems",
                column: "ClosedByUserSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_CreatedByUserSK",
                table: "WorkItems",
                column: "CreatedByUserSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ProjectSK",
                table: "WorkItems",
                column: "ProjectSK");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ResolvedByUserSK",
                table: "WorkItems",
                column: "ResolvedByUserSK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "WorkItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
