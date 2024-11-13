using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Additions : BaseEntity
    {
      
        public Additions()
        {
            this.CodeAddition = CodeAddition;
            this.NameAddition = NameAddition;
            this.Picture = Picture;
        }
            public int CodeAddition { get; set; }
            public string NameAddition { get; set; }
            public string Picture { get; set; }

            public override string[] GetKeyFields()
            {
            return new string[] { "CodeAddition" };
        }

            public override string GetTableName()
            {
            return "Additions";
            }
            public override string ToString()
            {
                return NameAddition+" "+ Picture;
            }
        }
}
