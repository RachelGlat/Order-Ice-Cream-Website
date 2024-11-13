using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class SpecificationAdditionsDessertDB:BaseDB
    {
        public SpecificationAdditionsDessertDB():base("SpecificationAdditionsDessert")
        { }
        public List<SpecificationAdditionsDessert> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<SpecificationAdditionsDessert>().ToList();
            return t;
        }
        protected override BaseEntity CreateModel()
        {
            SpecificationAdditionsDessert specificationAdditionsDessert = new SpecificationAdditionsDessert();
           specificationAdditionsDessert.CodeSpecificationAdditionsDessert = MyDB.DetailingDessertInPurchase.GetCodedessertByCode((int)reader["CodeSpecificationAdditionsDessert"]);
            specificationAdditionsDessert.CodeAdditions =MyDB.Additions.GetCodeAdditionByCode((int) reader["CodeAdditions"]);
            specificationAdditionsDessert.Amount =(int) reader["amount"];
            return specificationAdditionsDessert;
        }
    }
}
