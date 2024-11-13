using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ViewModel
{
    public class SpecialDessertDB : BaseDB
    {
        public SpecialDessertDB() : base("SpecialDessert")
        { }
        public List<SpecialDessert> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<SpecialDessert>().ToList();
            return t;

        }
        public SpecialDessert GetDessertByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeDessert == code);
        }
        public SpecialDessert GetCodeDessertByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeDessert == code);
        }
        protected override BaseEntity CreateModel()
        {
            SpecialDessert SpecialDessert = new SpecialDessert();
            SpecialDessert.CodeDessert = (int)reader["CodeDessert"];
            SpecialDessert.NameDessert = reader["NameDessert"].ToString();
            SpecialDessert.Price = (int)reader["price"];
            SpecialDessert.AmountIceCream = (int)reader["AmountIceCream"];
            SpecialDessert.Picture = reader["picture"].ToString();
            SpecialDessert.CodeCategory = MyDB.category.GetCategoryByCode((int)reader["CodeCategory"]);
            SpecialDessert.AmountAdditions = (int)reader["AmountAdditions"];
            SpecialDessert.Description = reader["Description"].ToString();
            SpecialDessert.Description = reader["Size"].ToString();
            return SpecialDessert;
        }
    }
}
