using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
  public class DetailingDessertInPurchaseDB:BaseDB
    {
        public DetailingDessertInPurchaseDB():base("DetailingDessertInPurchase")
        { }
        public List<DetailingDessertInPurchase> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<DetailingDessertInPurchase>().ToList();
            return t;
        }
        public DetailingDessertInPurchase GetCodedessertByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeSpecificationDessert == code);
        }
        protected override BaseEntity CreateModel()
        {
            DetailingDessertInPurchase DetailingDessertInPurchase = new DetailingDessertInPurchase();
            DetailingDessertInPurchase.CodeSpecificationDessert =((int)reader["CodeSpecificationDessert"]);
            DetailingDessertInPurchase.CodePurchases =MyDB.purchases.GetPurchasesByCode ((int)reader["CodePurchases"]);
            DetailingDessertInPurchase.CodeDessert =MyDB.SpecialDessert.GetCodeDessertByCode ((int)reader["CodeDessert"]);
            return DetailingDessertInPurchase;
        }
    }
}
