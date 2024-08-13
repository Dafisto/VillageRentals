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
        private string returndate;
        private double eqCost;
        private double totalCost;
    }
    public int rentalID
    {
        get { return rentalID; }
        set { rentalID = value; }
    }
    public string date
    {
        get { return date; }
        set { date = value; }
    }
    public int customerID
    {
        get { return customerID; }
        set { customerID = value; }
    }
    public string lastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public int equipmentID
    {
        get { return equipmentID; }
        set { equipmentID = value; }
    }
    public string startDate
    {
        get { return startDate; }
        set { startDate = value; }
    }
    public string returndate
    {
        get { return returnDate; }
        set { returnDate = value; }
    }
    public double eqCost
    {
        get { return eqCost; }
        set { eqCost = value }
    }
    public double totalCost
    {
        get { return totalCost; }
        set { totalCost = value; }
    }
    public Reservation(int rentalID, string date, int customerID, string lastName, int equipmentID, string startDate, string returnDate, double eqCost, double totalCost)
    {

    }
    public override string ToString()
    {
        
    }
}
