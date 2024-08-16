using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;




namespace villageRentalsRentalProgram.Persistence
{
    public partial class SQL_ScriptRead
    { 
        private readonly SQLiteConnection connection;

        public SQL_ScriptRead(string dbPath, string dataBaseScript)
        {
            string strCommand = File.ReadAllText(dataBaseScript);
            connection = new SQLiteConnection(dbPath);          

            SQLiteCommand objCommand = connection.CreateCommand(strCommand);
            objCommand.CommandText = strCommand;
            
            objCommand.ExecuteNonQuery();
            connection.Close();          
        }
    }
}
