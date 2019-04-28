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
    public class SpoilerInfoService : ISpoilerInfoService
    {
        private const string ConnectionString =
           "host=localhost;port=5432;database=films_spoilers;username=postgres;password=password";

        public async Task<Spoiler> GetById(Guid id)
        {
            Console.WriteLine(id.ToString());

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<Spoiler>(
                    "SELECT * FROM spoilers WHERE \"filmId\" = @id LIMIT 1", new { id });
            }

        }
    }
}
