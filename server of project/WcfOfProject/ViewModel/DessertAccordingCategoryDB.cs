using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class DessertAccordingCategoryDB : BaseDB
    {
        public DessertAccordingCategoryDB() : base("DessertAccordingCategory")
        { }
        public List<DessertAccordingCategory> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t = list.Cast<DessertAccordingCategory>().ToList();
            return t;
        }
        protected override BaseEntity CreateModel()
        {
            DessertAccordingCategory dessertAccordingCategory = new DessertAccordingCategory();
            dessertAccordingCategory.CodeCategory = MyDB.category.GetCategoryByCode((int)reader["CodeCategory"]);
            dessertAccordingCategory.CodeDessert = MyDB.SpecialDessert.GetDessertByCode((int)reader["CodeDessert"]);
            return dessertAccordingCategory;
        }
    }
}

