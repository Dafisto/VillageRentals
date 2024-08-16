﻿
using System;
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

        public Equipment(int equipmentID, int categoryID, string eqName, string description, double dailyRate)
        {
            this.categoryId = categoryID;
            this.equipmentId = equipmentID;
            this.eqName = eqName;
            this.description = description;
            this.dailyRate = dailyRate;
        }
        public Equipment()
        {
        }
     
    }
}
