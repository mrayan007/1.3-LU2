using Dapper;
using Microsoft.Data.SqlClient;
using back_end.Models;

namespace back_end.Repositories
{
    public class UserRepository
    {
        private readonly string sqlConnectionString;
        public UserRepository(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }

        public async Task<User> InsertAsync(User user)
        {
            using (var sqlConnection = new SqlConnection(sqlConnectionString))
            {
                var environmentId = await sqlConnection.ExecuteAsync("INSERT INTO [Gebruiker] (Username, Wachtwoord) VALUES (@Username, @Wachtwoord)", user);
                return user;
            }
        }
    }
}
