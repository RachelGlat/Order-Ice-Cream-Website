using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DsetailingScoopOfIceCreamDessert : BaseEntity
    {
        public DsetailingScoopOfIceCreamDessert()
        {
            this.CodeSpecificationDessert = CodeSpecificationDessert;
            this.CodeIceCream = CodeIceCream;
            this.Amount = Amount;
        }
        public DetailingDessertInPurchase CodeSpecificationDessert { get; set; }
        public FlavorsIiceCream CodeIceCream { get; set; }
        public int Amount { get; set; }
  

        public override string[] GetKeyFields()
        {
            return new string[] { "code_specification_dessert"+ "code_ice_cream" }; 
        }

        public override string GetTableName()
        {
            return "DsetailingScoopOfIceCreamDessert";
        }

        public override string ToString()
        {
            return Amount.ToString() ;
        }
    }
}

