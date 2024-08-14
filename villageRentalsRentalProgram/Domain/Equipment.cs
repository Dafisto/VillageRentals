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

        public int EquipmentID
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public string EqName
        {
            get { return eqName; }
            set { eqName = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public Equipment(int equipmentID, int categoryID, string eqName, string description, double dailyRate)
        {
            this.CategoryID = categoryID;
            this.EquipmentID = equipmentID;
            this.EqName = eqName;
            this.Description = description;
            this.DailyRate = dailyRate;
        }
        public Equipment()
        {

        }
        public override string ToString()
        {
            return $"{CategoryID}, {EquipmentID}, {EqName}, {Description}, ${DailyRate}";
        }
    }
}
