using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using villageRentalsRentalProgram.Persistence;

namespace villageRentalsRentalProgram.Domain
{
    public class Equipment
    {
        private int equipmentId;
        private int categoryId;
        private string eqName;
        private string description;
        private double dailyRate;
        private bool available;

        [PrimaryKey]
        public int EquipmentId

        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
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
 
        public Equipment(int equipmentID, int categoryID, string eqName, string description, double dailyRate, bool available)
        {
            this.CategoryId = categoryID;
            this.EquipmentId = equipmentID;
            this.EqName = eqName;
            this.Description = description;
            this.DailyRate = dailyRate;
            this.Available = available;
        }
        public Equipment()
        {

        }
        public override string ToString()
        {
            return $"{CategoryId}, {EquipmentId}, {EqName}, {Description}, ${DailyRate}";
        }
    }
}
