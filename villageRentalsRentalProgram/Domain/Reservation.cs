using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using villageRentalsRentalProgram.Services;
using SQLite;

namespace villageRentalsRentalProgram.Domain
{
    public class Reservation
    {
        private int rentalId;
        private string date;
        private int customerId;
        private string lastName;
        private int equipmentId;
        private string startDate;
        private string returnDate;
        private double eqCost;
        private double totalCost;

        [PrimaryKey]
        public int RentalId
        {
            get { return rentalId; }
            set { rentalId = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string Returndate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public double EqCost
        {
            get { return eqCost; }
            set { eqCost = value; }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        public Reservation(int rentalID, string date, int customerID, string lastName, int equipmentID, string startDate, string returnDate, double eqCost, double totalCost)
        {
            this.RentalId = rentalID;
            this.Date = date;
            this.CustomerId = customerID;
            this.LastName = lastName;
            this.EquipmentId = equipmentID;
            this.StartDate = startDate;
            this.Returndate = returnDate;
            this.EqCost = eqCost;
            this.TotalCost = totalCost;
        }
        public Reservation()
        {

        }
        public override string ToString()
        {
            return $"{RentalId} for {Date}, under {LastName}. Starting {StartDate}, Returning {Returndate}, for a total cost of {TotalCost}";
        }
    }
}
