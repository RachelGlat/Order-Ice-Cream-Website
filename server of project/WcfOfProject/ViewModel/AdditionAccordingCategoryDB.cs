
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace ViewModel
{
   public class   AdditionAccordingCategoryDB:BaseDB
    {
        public AdditionAccordingCategoryDB() : base("AdditionAccordingCategory")
        { }
        public List<AdditionAccordingCategory> GetList()
        {
            if(list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<AdditionAccordingCategory>().ToList();
            return t;
        }
        protected override BaseEntity CreateModel()
        {
           AdditionAccordingCategory additionAccordingCategory  = new AdditionAccordingCategory();
          additionAccordingCategory.CodeCategory = MyDB.category.GetCategoryByCode((int)reader["CodeCategory"]);
          additionAccordingCategory.CodeAddition = MyDB.Additions.GetAdditionByCode((int)reader["CodeAddition"]);
            return additionAccordingCategory;
        }
    }
}
