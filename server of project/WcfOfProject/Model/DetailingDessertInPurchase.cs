using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetailingDessertInPurchase : BaseEntity
    {
       
        public DetailingDessertInPurchase()
        {
            this.CodeSpecificationDessert = CodeSpecificationDessert;
            this.CodePurchases = CodePurchases;
            this.CodeDessert = CodeDessert;
        }
        public int CodeSpecificationDessert { get; set; }
        public Purchases CodePurchases { get; set; }
        public SpecialDessert CodeDessert { get; set; }
       

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeSpecificationDessert" };
        }

        public override string GetTableName()
        {
            return "DetailingDessertInPurchase";
        }

    }
}
