using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SpecificationAdditionsDessert : BaseEntity
    {
        public SpecificationAdditionsDessert()
        {
            this.CodeSpecificationAdditionsDessert = CodeSpecificationAdditionsDessert;
            this.CodeAdditions = CodeAdditions;
            this.Amount = Amount;
        }
        public DetailingDessertInPurchase CodeSpecificationAdditionsDessert { get; set; }
        public Additions CodeAdditions { get; set; }
        public int Amount { get; set; }
        public override string[] GetKeyFields()
        {
            return new string[] { "CodeSpecificationAdditionsDessert"+ "CodeAdditions" };
        }

        public override string GetTableName()
        {
            return "SpecificationAdditionsDessert";
        }

        public override string ToString()
        {
            return CodeAdditions + " " + Amount;
        }
    }
}
