using Android.Telephony;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Services
{
    internal class Equipment
    {
        private int equipmentId;
        private int categoryID;
        private string eqName;
        private string description;
        private double dailyRate;
        private bool available;
    }
    public int equipmentID
    {
        get { return equipmentID; }
        set { equipmentID = value; }
    }
    public int categoryID
    {
        get { return categoryID; }
        set { categoryID = value; }
    }
    public string eqName
    {
        get { return nameof; }
        set { eqName = value; }
    }
    public string description
    {
        get { return description; }
        set { description = value; }
    }
    public double dailyRate
    {
        get { return dailyRate; }
        set { dailyRate = value; }
    }
    public bool available
        {
            get { return available; }
            set { available = value}
        }

    public Equipment(int equipmentID, int categoryID, string eqName, string description, double dailyRate)
    {
        this.categoryID = categoryID;
        this.equipmentID = equipmentID;
        this.eqName = eqName;
        this.description = description;
        this.dailyRate = dailyRate;
    }
    public override string ToString()
    {

    }
}
