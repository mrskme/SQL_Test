using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace SQL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQueries().Wait();
        }

        private static async Task TestQueries()
        {
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EirikTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var conn = new SqlConnection(connStr);

            var customerRepository = new CustomerRepository(conn);
            await customerRepository.Create(new Customer("Eirik", "Skaara", "Berg"));

            //ExecuteAsync() er for de ikke er queries men som bare
            //gjør endringer og bare returnerer et tall

            //int rowsDeleted = await conn.ExecuteAsync(deleteAll);

            //int rowsInserted1 = await conn.ExecuteAsync(create,
            //    new {FirstName = "Eirik", MiddleName = "Skaara", LastName = "Berg"});
            //int rowsInserted2 = await conn.ExecuteAsync(create,
            //    new { FirstName = "Per", MiddleName = (string)null, LastName = "Peresjen" });
            //int rowsInserted3 = await conn.ExecuteAsync(create,
            //    new { FirstName = "Pål", MiddleName = (string)null, LastName = "Pålegg" });

            //IEnumerable<Customer> customer = await conn.QueryAsync<Customer>(readMany);
            ////Denne er ment til der man får et resultat sett som kan ha flere
            //Customer eirik = await conn.QueryFirstOrDefaultAsync<Customer>(readOneByName, new {FirstName = "Eirik"});
            ////conn.QuerySingleAsync() da er det forventa at man aldri får mer enn en

            //int rowsAffected2 = await conn.ExecuteAsync(update,
            //    new {FirstName = "Petter", LastName = "Pettersen", Id = eirik.Id});
            //customer = await conn.QueryAsync<Customer>(readMany);

            //int rowsAffected3 = await conn.ExecuteAsync(delete,
            //    new {Id = eirik.Id});
            //customer = await conn.QueryAsync<Customer>(readMany);



        }
    }
}
