using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FlavorsIiceCream : BaseEntity
    {
        public FlavorsIiceCream()
        {
            this.CodeIceCream = CodeIceCream;
            this.NameIceCream = NameIceCream;
            this.Picture = Picture;
            this.IsMilk = IsMilk;
        }
        public int CodeIceCream { get; set; }
        public string NameIceCream { get; set; }
        public string Picture { get; set; }
        public bool IsMilk { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeIceCream" };
        }

        public override string GetTableName()
        {
            return "FlavorsIiceCream";
        }

        public override string ToString()
        {
            return NameIceCream+" "+ Picture+" "+ IsMilk;
        }
    }
}
