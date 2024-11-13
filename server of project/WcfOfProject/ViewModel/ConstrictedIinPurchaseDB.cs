using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ConstrictedIinPurchaseDB:BaseDB
    {
        public ConstrictedIinPurchaseDB():base("ConstrictedIinPurchase")
        { }
        public List<ConstrictedIinPurchase> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<ConstrictedIinPurchase>().ToList();
            return t;
        }
        protected override BaseEntity CreateModel()
        {
            ConstrictedIinPurchase ConstrictedIinPurchase = new ConstrictedIinPurchase();
            ConstrictedIinPurchase.CodePurchase = MyDB.purchases.GetPurchasesByCode((int)reader["CodePurchase"]);
            ConstrictedIinPurchase.CodeConstricted = (int)reader["CodeConstricted"];
            ConstrictedIinPurchase.Amount = (int)reader["amount"];
            return ConstrictedIinPurchase;
        }
    }
}
