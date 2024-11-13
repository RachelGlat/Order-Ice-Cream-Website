using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class DsetailingScoopOfIceCreamDessertDB : BaseDB
    {
        public DsetailingScoopOfIceCreamDessertDB() : base("DsetailingScoopOfIceCreamDessert")
        { }
        public List<DsetailingScoopOfIceCreamDessert> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<DsetailingScoopOfIceCreamDessert>().ToList();
            return t;
        }
        //public DsetailingScoopOfIceCreamDessert GetCodeSpecificationDessertByCode(int code)
        //{
        //    return GetList().FirstOrDefault(x => x.CodeSpecificationDessert == code);
        //}
        protected override BaseEntity CreateModel()
        {
            DsetailingScoopOfIceCreamDessert dsetailingScoopOfIceCreamDessert = new DsetailingScoopOfIceCreamDessert();
            dsetailingScoopOfIceCreamDessert.CodeSpecificationDessert =MyDB.DetailingDessertInPurchase.GetCodedessertByCode( (int)reader["CodeSpecificationDessert"]);
            dsetailingScoopOfIceCreamDessert.CodeIceCream =MyDB.FlavorsIiceCream.GetCodeIceCreamByCode ((int) reader["CodeIceCream"]);
            dsetailingScoopOfIceCreamDessert.Amount = (int) reader["Amount"];
            return dsetailingScoopOfIceCreamDessert;
        }
    }

}
