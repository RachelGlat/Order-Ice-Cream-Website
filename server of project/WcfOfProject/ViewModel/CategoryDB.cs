using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CategoryDB:BaseDB
    {
        public CategoryDB():base("Category")
        { }
        public List<Category> GetList()
        {
            if(list.Count() == 0) 
            {
                Select();
            }    
            var t=  list.Cast<Category>().ToList();
            return t;
        }
        public Category GetCategoryByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeCategory == code);
        }
        protected override BaseEntity CreateModel()
        {
            Category Category = new Category();
            Category.CodeCategory = (int)reader["CodeCategory"];
            Category.NameCategory = reader["NameCategory"].ToString();
            return Category;
        }
    }
}
