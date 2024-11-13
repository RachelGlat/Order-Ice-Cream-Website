using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SpecialDessert : BaseEntity
    {
        public SpecialDessert()
        {
            this.CodeDessert = CodeDessert;
            this.NameDessert = NameDessert;
            this.Price = Price;
            this.AmountIceCream = AmountIceCream;
            this.Picture = Picture;
            this.CodeCategory = CodeCategory;
            this.AmountAdditions = AmountAdditions;
            this.Description = Description;
            this.Size = Size;
        }
        public int CodeDessert { get; set; }
        public string NameDessert { get; set; }
        public int Price { get; set; }
        public int AmountIceCream { get; set; }
        public string Picture { get; set; }
        public Category CodeCategory { get; set; }
        public int AmountAdditions { get; set; } 
        public string Description { get; set; }
        public string Size { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeDessert" };
        }

        public override string GetTableName()
        {
            return "SpecialDessert";
        }
       
        public override string ToString()
        {
            return NameDessert + " " + Price + " " + Picture;
        }
    }
}
