<<<<<<< HEAD
﻿using System;
=======
﻿
using System;
>>>>>>> master
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace villageRentalsRentalProgram.Services
{
    public class Equipment
    {
        private int equipmentId;
        private int categoryId;
        private string eqName;
        private string description;
        private double dailyRate;
        private bool available;

<<<<<<< HEAD
        public int EquipmentID
=======
        public int EquipmentId
>>>>>>> master
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }
<<<<<<< HEAD
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
=======
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
>>>>>>> master
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
<<<<<<< HEAD
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
=======
            this.categoryId = categoryID;
            this.equipmentId = equipmentID;
            this.eqName = eqName;
            this.description = description;
            this.dailyRate = dailyRate;
        }
        public Equipment()
        {
        }
     
>>>>>>> master
    }
}
