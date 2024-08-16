using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;



//This class will run the script on the building of an application to fill the connected database with data from sql script in resources.
namespace villageRentalsRentalProgram.Persistence
{
    public partial class SQL_ScriptRead 
    { 
        private readonly SQLiteConnection connection;

        public SQL_ScriptRead(string dbPath, string dataBaseScript)
        {
            if (connection != null)                                           //Will run script on application build.  If the database already exists, it will not run the script again.
                return;

            string strCommand = File.ReadAllText(dataBaseScript);
            connection = new SQLiteConnection(dbPath);          

            SQLiteCommand objCommand = connection.CreateCommand(strCommand);
            objCommand.CommandText = strCommand;
            
            objCommand.ExecuteNonQuery();
            connection.Close();          
        }
    }
}
