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

<<<<<<< HEAD
        public int CategoryID
=======
        public int CategoryId
>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
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
<<<<<<< HEAD
            return $"{CategoryID} {CategoryName}";
=======
<<<<<<< HEAD
            return "";
=======
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }
        public EquipmentCategory()
        {

>>>>>>> ec4350a7d3df8a8f91c03d00dc95770cbdf4a541
>>>>>>> master
        }
    }
}
