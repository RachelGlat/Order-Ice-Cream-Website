using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class DessertAccordingCategory : BaseEntity
    {

        public DessertAccordingCategory()
        {
            this.CodeCategory = CodeCategory;
            this.CodeDessert = CodeDessert;
        }
        public Category CodeCategory { get; set; }
        public SpecialDessert CodeDessert { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCategory" + "CodeDessert" };
        }


        public override string GetTableName()
        {
            return "DessertAccordingCategory";
        }



    }
}
