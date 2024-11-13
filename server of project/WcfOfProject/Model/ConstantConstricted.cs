using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConstantConstricted : BaseEntity
    {
        
        public ConstantConstricted()
        {
            this.CodeConstricted = CodeConstricted;
            this.NameConstricted = NameConstricted;
            this.Price = Price;
            this.Size = Size;
            this.CodeCategory = CodeCategory;
            this.Picture = Picture;
        }
        public int CodeConstricted { get; set; }
        public string NameConstricted { get; set; }
        public int Price { get; set; }
        public string Size { get; set; }
        public Category CodeCategory { get; set; }
        public string Picture { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeConstricted" };
        }

        public override string GetTableName()
        {
            return "ConstantConstricted";
        }


        public override string ToString()
        {
            return NameConstricted+" "+ Picture;
        }
    }
}
