using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class AdditionAccordingCategory : BaseEntity
    {
      
        public AdditionAccordingCategory()
        {
            this.CodeCategory = CodeCategory;
            this.CodeAddition = CodeAddition;
        }
        public Category CodeCategory { get; set; }
        public Additions CodeAddition { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeCategory"+ "CodeAddition" };
        }


        public override string GetTableName()
        {
            return "AdditionAccordingCategory";
        }



    }
}