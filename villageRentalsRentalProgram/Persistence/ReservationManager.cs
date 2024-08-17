﻿using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using villageRentalsRentalProgram.Domain;

//This class will manage the reservation table in the database for the application to add, modify, and delete reservations.
//  will also work with the report system to be able to get sales via date and client
// It will also check all other reservations to make sure that the equipmentId does not already exist
namespace villageRentalsRentalProgram.Persistence
{
    public class ReservationManager
    {
        private readonly SQLiteAsyncConnection connection;

        public ReservationManager(string dbPath)
        {
            if (connection != null)
                return;
            connection = new SQLiteAsyncConnection(dbPath, Constants.Flags);
            connection.CreateTableAsync<Reservation>().Wait();
        }
        public Task<int> InsertReservation(Reservation reservation) // This will save the reservation 
        {
            if (reservation.RentalId != 0)
            {
                return connection.UpdateAsync(reservation);  //updates existing reservation at correct spot on table
            }
            else
            {
                return connection.InsertAsync(reservation); // will insert new reservation at end of table
            }
        }
        public Task<List<Reservation>> GetAllReservationsAsync() //returns list with all reservations from the reservation table
        {
            return connection.Table<Reservation>().ToListAsync();
        }

        public Task<Reservation> GetASingleReservation(int rentalID) // fetches a single resrvation with the matching reservationCode through as an argument
        {
            return connection.Table<Reservation>().Where(i => i.RentalId == rentalID).FirstOrDefaultAsync(); // will return the first reservation found matching in the list
        }

        public Task DeleteReservationAsync(Reservation reservation) // deletes the reservation from the reservation database
        {
            return connection.DeleteAsync(reservation);
        }
    }
}

