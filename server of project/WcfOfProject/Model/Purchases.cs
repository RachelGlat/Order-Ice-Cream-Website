using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Purchases : BaseEntity
    {
        public Purchases()
        {
            this.CodePurchase = CodePurchase;
            this.CodeClient = CodeClient;
            this.DatePurchase = DatePurchase;
            this.Time = Time;
            this.FinalPrice = FinalPrice;
            this.PaymentMethod = PaymentMethod;
        }
        public int CodePurchase { get; set; }
        public Clients CodeClient { get; set; }
        public string DatePurchase { get; set; }
        public string Time { get; set; }
        public int FinalPrice { get; set; }
        public string PaymentMethod { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodePurchase" };
        }

        public override string GetTableName()
        {
            return "Purchases";
        }

        public override string ToString()
        {
            return CodePurchase + " " + FinalPrice ;
        }
    }
}
