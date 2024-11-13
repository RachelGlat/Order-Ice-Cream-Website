 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
   public class AdditionsDB:BaseDB
    {
        public AdditionsDB():base("Additions")
        { }
        public List<Additions> GetList()
        {
            if(list.Count() == 0)
            {
                Select();
            }
            return list.Cast<Additions>().ToList();
            
        }
        public Additions GetAdditionByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeAddition == code);
        }
        public Additions GetCodeAdditionByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeAddition == code);
        }
        protected override BaseEntity CreateModel()
        {
            Additions Additions = new Additions();
            Additions.CodeAddition = (int)reader ["CodeAddition"];
            Additions.NameAddition =reader ["NameAddition"].ToString();
            Additions.Picture = reader["Picture"].ToString();
            return Additions;
        }
    }
}
