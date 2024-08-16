using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using villageRentalsRentalProgram.Domain;
namespace villageRentalsRentalProgram.Persistence
{
    internal class EquipmentCategoryManagement
    {
        private readonly SQLiteAsyncConnection connection;

        public EquipmentCategoryManagement(string dbPath)
        {
            if (connection != null)
                return;
            connection = new SQLiteAsyncConnection(dbPath, Constants.Flags);
            connection.CreateTableAsync<EquipmentCategory>().Wait();
        }

        public Task<int> InsertEquipmentCategory(EquipmentCategory category) // This will save the category 
        {
            if (category.CategoryId != 0)
            {
                return connection.UpdateAsync(category);  //updates existing category at correct spot on table
            }
            else
            {
                return connection.InsertAsync(category); // will insert new category at end of table
            }
        }
        public Task<List<EquipmentCategory>> GetAllEquipmentCategoryAsync() //returns list with all categories from the cateogory table
        {
            return connection.Table<EquipmentCategory>().ToListAsync();
        }

        public Task<EquipmentCategory> GetASingleEquipmentCategory(int catID) // fetches a single category with the matching categoryId through as an argument
        {
            return connection.Table<EquipmentCategory>().Where(i => i.CategoryId == catID).FirstOrDefaultAsync(); // will return the first category found matching in the list
        }

        public Task DeleteEquipmentCategoryAsync(EquipmentCategory category) // deletes the category item from the book database
        {
            return connection.DeleteAsync(category);
        }
    }
}
