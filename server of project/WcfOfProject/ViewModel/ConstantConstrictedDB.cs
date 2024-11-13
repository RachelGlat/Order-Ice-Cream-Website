using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ConstantConstrictedDB:BaseDB
    {
        public ConstantConstrictedDB():base("ConstantConstricted")
        { }
        public List<ConstantConstricted> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<ConstantConstricted>().ToList();
            return t;
        }
        protected override BaseEntity CreateModel()
        {
            ConstantConstricted ConstantConstricted = new ConstantConstricted();
            ConstantConstricted.CodeConstricted = (int)reader["CodeConstricted"];
            ConstantConstricted.NameConstricted = reader["NameConstricted"].ToString();
            ConstantConstricted.Price = (int) reader["Price"];
            ConstantConstricted.Size = reader["Size"].ToString();
            ConstantConstricted.CodeCategory = MyDB.category.GetCategoryByCode ((int)reader["CodeCategory"]);
            ConstantConstricted.Picture = reader["Picture"].ToString();
            return ConstantConstricted;
        }
    }
}
