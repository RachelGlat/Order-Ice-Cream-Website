using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;
using ViewModel;

namespace WcfOfProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        //פעולות  Get
     
        public List<Category> GetAllCategory()
        {
            return MyDB.category.GetList();
        }


        public List<FlavorsIiceCream> GetAllFlavors()
        {
            return MyDB.FlavorsIiceCream.GetList();
        }


        public List<SpecialDessert> GetSpecielDessert()
        {
            return MyDB.SpecialDessert.GetList();
        }

        public List<AdditionAccordingCategory> GetAllAdditions(Category c)
        {
            var t = MyDB.AdditionAccordingCategory.GetList();
            var y = t.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeAddition).ToList();
            return t;
        }
        public List<Additions> GetAdditions()
        {
            return MyDB.Additions.GetList();
        }


        public List<DessertAccordingCategory> GetDessertAccordingCategories(Category c)
        {
            var t = MyDB.DessertAccordingCategory.GetList();
           var y = t.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeDessert).ToList();
            return t;
        }

        public List<ConstantConstricted> GetAllconstantConstricteds(Category c)
        {
            return MyDB.ConstantConstricted.GetList();

        }

        public List<SpecificationAdditionsDessert> GetSpecificationAdditionsDesserts()
        {
            return MyDB.SpecificationAdditionsDessert.GetList();
        }
      public List<AdditionAccordingCategory> GetAdditionAccordingCategories()
        {
            return MyDB.AdditionAccordingCategory.GetList();
        }

        //פעולות הוספה
        public int AddAdditionAcordingCategory(AdditionAccordingCategory ad)
        {
            MyDB.AdditionAccordingCategory.Add(ad);
          return  MyDB.AdditionAccordingCategory.SaveChanges();
        }
        public int AddAdition(Additions a)
        {
            MyDB.Additions.Add(a);
            return MyDB.Additions.SaveChanges();
        }
      
       public int Addspecialdessert(SpecialDessert s)
        {
            MyDB.SpecialDessert.Add(s);
            return MyDB.SpecialDessert.SaveChanges();
        }
        public void AddClient(Clients c)
        {
            MyDB.clients.Add(c);
            MyDB.clients.SaveChanges();
        }
        public int AddConstantConstricted(ConstantConstricted con)
        {
            MyDB.ConstantConstricted.Add(con);
          return  MyDB.ConstantConstricted.SaveChanges();
        }

        public int AddDettalingDessertImPurches(DetailingDessertInPurchase d)
        {
            MyDB.DetailingDessertInPurchase.Add(d);
            return MyDB.DetailingDessertInPurchase.SaveChanges();
        }

        public int AddFlavorIceCream(FlavorsIiceCream fla)
        {
            MyDB.FlavorsIiceCream.Add(fla);
            return MyDB.FlavorsIiceCream.SaveChanges();
        }

        public int AddPurches(Purchases pr)
        {
            MyDB.purchases.Add(pr);
            return MyDB.purchases.SaveChanges();
        }

        public int  AddSpecificationAdditionsDessert(SpecificationAdditionsDessert sad)
        {
            MyDB.SpecificationAdditionsDessert.Add(sad);
            return MyDB.SpecificationAdditionsDessert.SaveChanges();
        }

        public int Adddetailing_scoop_of_ice_cream_dessert(DsetailingScoopOfIceCreamDessert ds)
        {
            MyDB.DsetailingScoopOfIceCreamDessert.Add(ds);
            return MyDB.DsetailingScoopOfIceCreamDessert.SaveChanges();
        }
        //פעולות מחיקה
        public void DellAdditionAcordingCategory(AdditionAccordingCategory ad)
        {
            MyDB.AdditionAccordingCategory.Deleted(ad);
            MyDB.AdditionAccordingCategory.SaveChanges();
        }

        public void DellAdditions(Additions a)
        {
            MyDB.Additions.Deleted(a);
            MyDB.Additions.SaveChanges();
        } 
 
        public void DellFlavorIceCream(FlavorsIiceCream fla)
        {
            MyDB.FlavorsIiceCream.Deleted(fla);
            MyDB.FlavorsIiceCream.SaveChanges();
        }

        
        public void DellSpecialDessert(SpecialDessert s)
        {
            MyDB.SpecialDessert.Deleted(s);
            MyDB.SpecialDessert.SaveChanges();
        }
        //פעולות עידכון
        public void UpDateAdditionAccordingCategory(AdditionAccordingCategory ad)
        {
            throw new NotImplementedException();
        }

        public void UpDateAdditions(Additions a)
        {
            throw new NotImplementedException();
        }

        public void UpDateClients(Clients c)
        {
            throw new NotImplementedException();
        }

        public void UpDateConstantConstricted(ConstantConstricted con)
        {
            throw new NotImplementedException();
        }

        public void UpDateConstrictedIinPurchase(ConstrictedIinPurchase copu)
        {
            throw new NotImplementedException();
        }

        public void UpDateDsetailingScoopOfIceCreamDessert(DsetailingScoopOfIceCreamDessert dscoop)
        {
            throw new NotImplementedException();
        }

        public void UpDateDetailingDessertInPurchase(DetailingDessertInPurchase dtdessert)
        {
            throw new NotImplementedException();
        }

        public void UpDateFlavorsIiceCream(FlavorsIiceCream fla)
        {
            throw new NotImplementedException();
        }

        public void UpDatePurchases(Purchases p)
        {
            throw new NotImplementedException();
        }

        public void UpDateSpecialDessert(SpecialDessert sp)
        {
            throw new NotImplementedException();
        }

        public void UpDateSpecificationAdditionsDessert(SpecificationAdditionsDessert spadd)
        {
            throw new NotImplementedException();
        }
        

      //פעולות קבלת קוד
        public List<Additions> GetAllAdditionsnew()
        {
            return MyDB.Additions.GetList();
        }

        public int GetCodeToAddition()
        {
            if (MyDB.Additions.GetList().Count == 0) return 1;
            return MyDB.Additions.GetList().Max(x => x.CodeAddition) + 1;
        }

      public int GetCodeToFlavors()
        {
            if (MyDB.FlavorsIiceCream.GetList().Count == 0) return 1;
            return MyDB.FlavorsIiceCream.GetList().Max(x => x.CodeIceCream) + 1;
        }
        public int GetCodeToMutzar()
        {
            if (MyDB.SpecialDessert.GetList().Count == 0) return 1;
            return MyDB.SpecialDessert.GetList().Max(x => x.CodeDessert) + 1;
        }


        void IService1.AddAdditionAcordingCategory(AdditionAccordingCategory ad)
        {
            throw new NotImplementedException();
        }

        public int GetCodeToClient()
        {
            if (MyDB.clients.GetList().Count == 0) return 1;
            return MyDB.clients.GetList().Max(x => x.CodeClient) + 1;
        }
        public int GetCodeToDettalingDessert()
        {
            if (MyDB.DetailingDessertInPurchase.GetList().Count == 0) return 1;
            return MyDB.DetailingDessertInPurchase.GetList().Max(x => x.CodeSpecificationDessert) + 1;
        }
    }
}
