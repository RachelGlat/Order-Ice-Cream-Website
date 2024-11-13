using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConstrictedIinPurchase : BaseEntity
    {
       
        public ConstrictedIinPurchase()
        {
            this.CodePurchase = CodePurchase;
            this.CodeConstricted = CodeConstricted;
            this.Amount = Amount;
        }
        public Purchases CodePurchase { get; set; }
        public int CodeConstricted { get; set; }
        public int Amount { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodePurchase" };
        }

        public override string GetTableName()
        {
            return "ConstrictedIinPurchase";
        }

        //public override string ToString()
        //{
        //    return ;
        //}
    }
}
