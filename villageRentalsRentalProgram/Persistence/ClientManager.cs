using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using villageRentalsRentalProgram.Domain;


namespace villageRentalsRentalProgram.Persistence
{ 
    public class ClientManager
    { 

        private readonly SQLiteAsyncConnection connection;       
        
        public ClientManager(string dbPath)
        {
            if (connection != null)
                return;
            connection = new SQLiteAsyncConnection(dbPath, Constants.Flags);
            connection.CreateTableAsync<Client>().Wait();        
        }             
        
        public Task<int> InsertClientAsync(Client client) // This will save client to client database or update the client
        {
            if (client.CustomerID != 0)
            {
                return connection.UpdateAsync(client);  //updates existing client at correct spot on table
            }
            else
            {
                return connection.InsertAsync(client); // will insert new client at end of table
            }
        }
        public Task<List<Client>> GetAllClientsAsync()
        {
            return connection.Table<Client>().ToListAsync(); // will return the entire table
        }

        public Task<Client> GetAClientAsync(int customerID) //return a single client row from table
        {
            return connection.Table<Client>().Where(i => i.CustomerID == customerID).FirstOrDefaultAsync();
        }

     //There will not be a way to delete clients as the system will need to hold a record of them in the case they have been banned.
    }
}