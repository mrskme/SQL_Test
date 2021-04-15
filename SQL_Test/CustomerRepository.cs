using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQL_Test
{
    public class CustomerRepository
    {
        private SqlConnection _connection;
        string readMany = @"SELECT Id, FirstName, MiddleName, LastName
                             FROM Customer
                             WHERE Id = @Id";
        string readOneByName = @"SELECT Id, FirstName, MiddleName, LastName
                                  From Customer
                                  WHERE FirstName = @FirstName";
        string create = @"INSERT INTO Customer(FirstName, LastName, MiddleName)
                           Values (@FirstName, @LastName, @MiddleName";
        string delete = @"DELETE FROM Customer
                           WHERE Id = @Id";
        string deleteAll = @"DELETE FROM Customer";
        string update = @"UPDATE Customer
                           SET LastName = @LastName, FirstName = @FirstName
                           WHERE Id = @id";

        public CustomerRepository(SqlConnection connection)
        {
            _connection = connection;
        }
        public async Task<int> Create(Customer customer)
        {
            //@FirstName betyr sett inn verdien fra feltet FirstName i objektet som pekes på av variabelen customer
            var sql = @"INSERT INTO Customer(FirstName, LastName, MiddleName)
                           Values (@FirstName, @LastName, @MiddleName)";
            return await _connection.ExecuteAsync(sql, customer);
        }
    }
}
