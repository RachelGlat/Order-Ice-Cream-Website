using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Clients : BaseEntity
    {
        
        public Clients()
        {
            this.CodeClient = CodeClient;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Mail = Mail;
        }
        public int CodeClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public override string[] GetKeyFields()
        {
            return new string[] { "CodeClient" };
        }

        public override string GetTableName()
        {
            return "Clients";
        }

        public override string ToString()
        {
            return FirstName+" "+ LastName;
        }
    }
}
