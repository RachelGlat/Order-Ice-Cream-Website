using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category : BaseEntity
    {
      
        public Category()
        {
            this.CodeCategory = CodeCategory;
            this.NameCategory = NameCategory;

        }

        public int CodeCategory { get; set; }
        public string NameCategory { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCategory" };
        }

        public override string GetTableName()
        {
            return "Category";
        }

        public override string ToString()
        {
            return NameCategory;
        }
    }
}
