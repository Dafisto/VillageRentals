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
<<<<<<< HEAD
        public int RentalId
        {
            get { return rentalId; }
            set { rentalId = value; }
=======
        [PrimaryKey]
        public int RentalID
        {
            get { return rentalID; }
            set { rentalID = value; }
>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
<<<<<<< HEAD
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
=======
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
<<<<<<< HEAD
        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
=======
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
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
            this.RentalId = rentalID;
            this.Date = date;
            this.CustomerId = customerID;
            this.LastName = lastName;
            this.EquipmentId = equipmentID;
=======
            this.RentalID = rentalID;
            this.Date = date;            
            this.CustomerID = customerID;
            this.LastName = lastName;
            this.EquipmentID = equipmentID;
>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
            this.StartDate = startDate;
            this.Returndate = returnDate;
            this.EqCost = eqCost;
            this.TotalCost = totalCost;
        }
<<<<<<< HEAD
        public Reservation()
        {

        }
=======
<<<<<<< HEAD
>>>>>>> master
        public override string ToString()
        {
            return $"{RentalId} for {Date}, under {LastName}. Starting {StartDate}, Returning {Returndate}, for a total cost of {TotalCost}";
        }
    }
=======
        public Reservation()
        {
        }

    }

>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
}
