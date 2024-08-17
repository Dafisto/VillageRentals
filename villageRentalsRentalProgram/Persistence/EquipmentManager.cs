using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using villageRentalsRentalProgram.Domain;

namespace villageRentalsRentalProgram.Persistence
{
    //this class will work with the equipment table in the connected database to add, remove, and modify
    public class EquipmentManager
    {
        private readonly SQLiteAsyncConnection connection;

        public EquipmentManager(string dbPath)
        {
            if (connection != null)
                return;
            connection = new SQLiteAsyncConnection(dbPath, Constants.Flags);
            connection.CreateTableAsync<Equipment>().Wait();
        }
        public Task<int> UpdateEquipmentAsync(Equipment equipment)
        {
            return connection.UpdateAsync(equipment);  //updates existing equipment at correct spot on table
        }
        public Task<int> InsertEquipmentAsync(Equipment equipment)
        {
            return connection.InsertAsync(equipment); // will insert new equipment at end of table
        }
        
        public Task<List<Equipment>> GetAllEquipmentAsync() //returns list with all equipment from the equipment table
        {
            return connection.Table<Equipment>().ToListAsync();
        }

        public Task<Equipment> GetASingleEquipmentAsync(int equipmentID) // fetches a single equipment with the matching equipmentID through as an argument
        {
            return connection.Table<Equipment>().Where(i => i.EquipmentId == equipmentID).FirstOrDefaultAsync(); // will return the first equipment found matching in the list
        }

        public Task DeleteEquipmentAsync(Equipment equipment) // deletes the equipment item from the book database
        {
            return connection.DeleteAsync(equipment);
        }
        public Task<List<Equipment>> GetAllEquipmentAvaiAsync() //returns list with all equipment from the equipment table
        {
            return connection.Table<Equipment>().Where(i=>i.Available == true).ToListAsync();
        }
    }
}