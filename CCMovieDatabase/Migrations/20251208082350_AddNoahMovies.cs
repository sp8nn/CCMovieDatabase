using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddNoahMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Title", "Description", "ReleaseDate", "RatingId", "ThumbnailURL" },
                values: new object[,]
                {
                    { 2001, "The Avengers", "Earth's mightiest heroes unite...", new DateOnly(2012, 5, 4), 3, "/images/avengers1.jpg" },
                    { 2002, "Avengers: Age of Ultron", "The team faces a rogue AI...", new DateOnly(2015, 5, 1), 3, "/images/avengers2.jpg" },
                    { 2003, "Avengers: Infinity War", "The Avengers battle Thanos...", new DateOnly(2018, 4, 27), 3, "/images/avengers3.jpg" },
                    { 2004, "Avengers: Endgame", "The surviving heroes attempt to reverse Thanos' damage...", new DateOnly(2019, 4, 26), 3, "/images/avengers4.jpg" },
                    { 2005, "Avengers: Doomsday", "The Avengers face a catastrophic new threat...", new DateOnly(2026, 5, 1), 3, "/images/avengers5.jpg" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
