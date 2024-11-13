using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ClientsDB:BaseDB
    {
        public ClientsDB():base("Clients")
        { }
        public List<Clients> GetList()
        {
            if(list.Count() == 0)
            {
                Select();
            }
            var t= list.Cast<Clients>().ToList();
            return t;
        }
        public Clients GetCodeClientByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.CodeClient == code);
        }
        protected override BaseEntity CreateModel()
        {
            Clients Clients = new Clients();
            Clients.CodeClient = (int)reader["CodeClient"];
            Clients.FirstName = reader["FirstName"].ToString();
            Clients.LastName = reader["LastName"].ToString();
            Clients.Phone = reader["Phone"].ToString();
            Clients.Mail = reader["Mail"].ToString();
            return Clients;
        }
    }
}
