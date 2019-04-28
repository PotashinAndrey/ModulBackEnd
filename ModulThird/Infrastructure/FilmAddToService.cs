using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModulThird.Models;
using ModulThird.Services;
using Npgsql;
using Dapper;


namespace ModulThird.Infrastructure
{
    public class FilmAddToService : IFilmAddToService
    {
        private const string ConnectionString = 
            "host=localhost;port=5432;database=films_spoilers;username=postgres;password=password";

        public async void SetFilm(Film film)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO films (id, name, releasedate)"
                    + " VALUES (@id, @name, @releasedate)";

                await connection.ExecuteAsync(query, film);
            }
        }
    }
}
