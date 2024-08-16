using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Domain
{
    internal class Reservation
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
<<<<<<< HEAD

        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
=======
        public int RentalId
        {
            get { return rentalId; }
            set { rentalId = value; }
>>>>>>> master
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
<<<<<<< HEAD
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
=======
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
>>>>>>> master
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
<<<<<<< HEAD
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
=======
        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
>>>>>>> master
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
<<<<<<< HEAD
            this.RentalID = rentalID;
            this.Date = date;
            this.CustomerID = customerID;
            this.LastName = lastName;
            this.EquipmentID = equipmentID;
=======
            this.RentalId = rentalID;
            this.Date = date;
            this.CustomerId = customerID;
            this.LastName = lastName;
            this.EquipmentId = equipmentID;
>>>>>>> master
            this.StartDate = startDate;
            this.Returndate = returnDate;
            this.EqCost = eqCost;
            this.TotalCost = totalCost;
        }
<<<<<<< HEAD
        public Reservation()
        {

        }
        public override string ToString()
        {
            return $"{RentalID} for {Date}, under {LastName}. Starting {StartDate}, Returning {Returndate}, for a total cost of {TotalCost}";
=======
        public override string ToString()
        {
            return "";
>>>>>>> master
        }
    }
}
