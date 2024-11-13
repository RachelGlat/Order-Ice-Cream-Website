using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Maneger : BaseEntity
    {
        public Maneger()
        {
            this.codeManeger = codeManeger;
            this.Id = Id;
            this.nameManeger = nameManeger;
        }
        public int codeManeger { get; set; }
        public int Id { get; set; }
        public string nameManeger { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "codeManeger" };
        }

        public override string GetTableName()
        {
            return "Id";
        }

        public override string ToString()
        {
            return nameManeger ;
        }
    }
}

