using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Denga.Pipeworks.SiteSettings.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettingsGroupSiteSettings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false),
                    SettingsGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettingsGroupSiteSettings", x => new { x.SettingId, x.SettingsGroupId });
                    table.ForeignKey(
                        name: "FK_SiteSettingsGroupSiteSettings_SiteSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "SiteSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteSettingsGroupSiteSettings_SiteSettingsGroups_SettingsGroupId",
                        column: x => x.SettingsGroupId,
                        principalTable: "SiteSettingsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettingsGroupSiteSettings_SettingsGroupId",
                table: "SiteSettingsGroupSiteSettings",
                column: "SettingsGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteSettingsGroupSiteSettings");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "SiteSettingsGroups");
        }
    }
}
