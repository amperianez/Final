using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countermeasures",
                columns: table => new
                {
                    CountermeasureID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeAndSubname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countermeasures", x => x.CountermeasureID);
                });

            migrationBuilder.CreateTable(
                name: "Habitats",
                columns: table => new
                {
                    HabitatID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HabitatName = table.Column<string>(type: "TEXT", nullable: false),
                    HabitatDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitats", x => x.HabitatID);
                });

            migrationBuilder.CreateTable(
                name: "Weaknesses",
                columns: table => new
                {
                    WeaknessID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WeaknessDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weaknesses", x => x.WeaknessID);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MonsterName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Species = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    WeaknessID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterID);
                    table.ForeignKey(
                        name: "FK_Monsters_Weaknesses_WeaknessID",
                        column: x => x.WeaknessID,
                        principalTable: "Weaknesses",
                        principalColumn: "WeaknessID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountermeasureMonster",
                columns: table => new
                {
                    CountermeasuresCountermeasureID = table.Column<int>(type: "INTEGER", nullable: false),
                    MonstersMonsterID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountermeasureMonster", x => new { x.CountermeasuresCountermeasureID, x.MonstersMonsterID });
                    table.ForeignKey(
                        name: "FK_CountermeasureMonster_Countermeasures_CountermeasuresCountermeasureID",
                        column: x => x.CountermeasuresCountermeasureID,
                        principalTable: "Countermeasures",
                        principalColumn: "CountermeasureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountermeasureMonster_Monsters_MonstersMonsterID",
                        column: x => x.MonstersMonsterID,
                        principalTable: "Monsters",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterHabitats",
                columns: table => new
                {
                    HabitatID = table.Column<int>(type: "INTEGER", nullable: false),
                    MonsterID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterHabitats", x => new { x.HabitatID, x.MonsterID });
                    table.ForeignKey(
                        name: "FK_MonsterHabitats_Habitats_HabitatID",
                        column: x => x.HabitatID,
                        principalTable: "Habitats",
                        principalColumn: "HabitatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterHabitats_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountermeasureMonster_MonstersMonsterID",
                table: "CountermeasureMonster",
                column: "MonstersMonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterHabitats_MonsterID",
                table: "MonsterHabitats",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_WeaknessID",
                table: "Monsters",
                column: "WeaknessID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountermeasureMonster");

            migrationBuilder.DropTable(
                name: "MonsterHabitats");

            migrationBuilder.DropTable(
                name: "Countermeasures");

            migrationBuilder.DropTable(
                name: "Habitats");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "Weaknesses");
        }
    }
}
