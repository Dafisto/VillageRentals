using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villageRentalsRentalProgram.Domain
{
    public class EquipmentCategory
    {
        private int categoryId;
        private string categoryName;

        [PrimaryKey]
        public int CategoryId

        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public EquipmentCategory(int categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }
        public EquipmentCategory()
        {
        }
    }
}
