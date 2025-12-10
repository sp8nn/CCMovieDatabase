using CCMovieDatabase.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Security.Cryptography.Xml;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddNoahMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "The Avengers", ReleaseDate = new DateOnly(2012, 05, 04), Description = "Earth's mightiest heroes unite for the first time to stop Loki and an alien invasion.", RatingId = 1, ThumbnailURL = "https://www.reddit.com/media?url=https%3A%2F%2Fi.redd.it%2Fpopular-franchises-characters-that-used-to-be-way-less-v0-sdphli3r550e1.jpg%3Fwidth%3D776%26format%3Dpjpg%26auto%3Dwebp%26s%3Dc8768696c692f4f164754b705d23bebae50408c7" },
                new Movie { Id = 2, Title = "Avengers: Age of Ultron", ReleaseDate = new DateOnly(2015, 05, 01), Description = "The team faces a rogue AI bent on wiping out humanity.", RatingId = 1, ThumbnailURL = "https://www.hollywoodreporter.com/wp-content/uploads/2015/02/avengers_age_of_ultron.jpg" },
                new Movie { Id = 2, Title = "Avengers: Infinity War", ReleaseDate = new DateOnly(2018, 04, 23), Description = "The Avengers battle Thanos as he tries to collect all six Infinity Stones.", RatingId = 1, ThumbnailURL = "https://atthemovies.uk/cdn/shop/products/AvengersInfinity2018us27x40in195.jpg?v=1621388999&width=1090" },
                new Movie { Id = 2, Title = "Avengers: Endgame", ReleaseDate = new DateOnly(2019, 04, 26), Description = "The surviving heroes attempt to reverse the damage inflicted by Thanos.", RatingId = 1, ThumbnailURL = "https://atthemovies.uk/cdn/shop/products/AvengersEndGame2019US27x40u75.jpg?v=1621388294" },
                new Movie { Id = 2, Title = "Avengers: Doomsday", ReleaseDate = new DateOnly(2026, 12, 18), Description = "The Avengers face a catastrophic new threat...Doom.", RatingId = 1, ThumbnailURL = "https://m.media-amazon.com/images/M/MV5BMGNiN2RlZTMtMTkyZC00YjkwLTgyY2QtMDg1ZDNhODQwNWM4XkEyXkFqcGc@._V1_.jpg" },
            };
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
