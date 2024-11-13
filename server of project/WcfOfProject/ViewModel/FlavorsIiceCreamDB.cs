using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class FlavorsIiceCreamDB:BaseDB
    {
        public FlavorsIiceCreamDB():base("FlavorsIiceCream")
        { }
        public List<FlavorsIiceCream> GetList()
        {
            if (list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<FlavorsIiceCream>().ToList();
            return t;
        }
        public FlavorsIiceCream GetCodeIceCreamByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeIceCream == code);
        }
        protected override BaseEntity CreateModel()
        {
            FlavorsIiceCream FlavorsIiceCream = new FlavorsIiceCream();
            FlavorsIiceCream.CodeIceCream = (int)reader["CodeIceCream"];
            FlavorsIiceCream.NameIceCream = reader["NameIceCream"].ToString();
            FlavorsIiceCream.Picture = reader["picture"].ToString();
            FlavorsIiceCream.IsMilk =(bool) reader["IsMilk"];
            return FlavorsIiceCream;
        }
    }
}
