using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Domain
{
    internal class Reservation
    {
        private int rentalID;
        private string date;
        private int customerID;
        private string lastName;
        private int equipmentID;
        private string startDate;
        private string returnDate;
        private double eqCost;
        private double totalCost;

        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
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
            this.RentalID = rentalID;
            this.Date = date;
            this.CustomerID = customerID;
            this.LastName = lastName;
            this.EquipmentID = equipmentID;
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
            return $"{RentalID} for {Date}, under {LastName}. Starting {StartDate}, Returning {Returndate}, for a total cost of {TotalCost}";
        }
    }
}
