﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Domain
{
    internal class EquipmentCategory
    {
        internal int categoryID;
        internal string categoryName;

        public int categoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public string categoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public override string ToString()
        {
            return
        }
    }
}
