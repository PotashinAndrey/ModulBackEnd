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
    public class FilmInfoService : IFilmInfoService
    {
        private const string ConnectionString =
           "host=localhost;port=5432;database=films_spoilers;username=postgres;password=password";

        public async Task<Film> GetById(Guid id)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<Film>(
                    "SELECT * FROM films WHERE Id = @id", new { id });
            }

        }
    }
}
    