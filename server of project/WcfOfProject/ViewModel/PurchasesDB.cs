using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class PurchasesDB:BaseDB
    {
        public PurchasesDB():base("Purchases")
        { }
        public List<Purchases> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<Purchases>().ToList();
            return t;
        }
        public Purchases GetPurchasesByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodePurchase == code);
        }
        protected override BaseEntity CreateModel()
        {
            Purchases Purchases = new Purchases();
            Purchases.CodePurchase = (int)reader["CodePurchase"];
            Purchases.CodeClient = MyDB.clients.GetCodeClientByCode((int)reader["CodeClient"]);
            Purchases.DatePurchase = reader["DatePurchase"].ToString();
            Purchases.Time = reader["time"].ToString();
            Purchases.FinalPrice = (int) reader["FinalPrice"];
            Purchases.FinalPrice =(int)reader["FinalPrice"];
            return Purchases;
        }
    }
}
