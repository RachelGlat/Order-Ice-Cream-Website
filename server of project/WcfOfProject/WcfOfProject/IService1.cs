using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;


namespace WcfOfProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        // void AddSpecialDesert (SpecialDessert sd);
        // [OperationContract]

        // void AddConstantConstricted (ConstantConstricted c);
      
       //פעולות get
        [OperationContract]
        List<FlavorsIiceCream> GetAllFlavors();

        [OperationContract]
        List<SpecialDessert> GetSpecielDessert();

        [OperationContract]
        List<AdditionAccordingCategory> GetAllAdditions(Category c);
        [OperationContract]
        List<Additions> GetAdditions();
        [OperationContract]
        List<Category> GetAllCategory();
        [OperationContract]
        List<SpecificationAdditionsDessert> GetSpecificationAdditionsDesserts();
        [OperationContract]
        List<AdditionAccordingCategory> GetAdditionAccordingCategories();
       


        //פעולות קבלת קוד
        [OperationContract]
        int GetCodeToAddition();
        [OperationContract]
        int GetCodeToFlavors();
        [OperationContract]
        int GetCodeToMutzar();
        [OperationContract]
        int GetCodeToClient();
        [OperationContract]
        int GetCodeToDettalingDessert();


        //פעולות הוספה
        [OperationContract]
        void AddAdditionAcordingCategory(AdditionAccordingCategory ad);
        [OperationContract]
        int AddAdition(Additions a);
        [OperationContract]
       
        void AddClient(Clients c);

        [OperationContract]
        int Addspecialdessert(SpecialDessert s);
        [OperationContract]
        int AddConstantConstricted(ConstantConstricted con);
        [OperationContract]
        int AddFlavorIceCream(FlavorsIiceCream fla);
        [OperationContract]
        int AddPurches(Purchases pr);
        [OperationContract]
        int AddSpecificationAdditionsDessert(SpecificationAdditionsDessert sad);
        [OperationContract]
        int Adddetailing_scoop_of_ice_cream_dessert(DsetailingScoopOfIceCreamDessert ds);

        [OperationContract]
        int AddDettalingDessertImPurches(DetailingDessertInPurchase d);



        //פעולות מחיקה
        [OperationContract]
        void DellAdditionAcordingCategory(AdditionAccordingCategory ad);
        [OperationContract]
        void DellAdditions(Additions a);
        [OperationContract]
        void DellFlavorIceCream(FlavorsIiceCream fla);

        [OperationContract]
        void DellSpecialDessert(SpecialDessert s);

        //פעולות עידכון
        [OperationContract]
        void UpDateAdditionAccordingCategory(AdditionAccordingCategory ad);
        [OperationContract]
        void UpDateAdditions(Additions a);
        [OperationContract]
        void UpDateClients(Clients c);
        [OperationContract]
        void UpDateConstantConstricted(ConstantConstricted con);
        [OperationContract]
        void UpDateConstrictedIinPurchase(ConstrictedIinPurchase copu);
        [OperationContract]
        void UpDateDsetailingScoopOfIceCreamDessert(DsetailingScoopOfIceCreamDessert dscoop);
        [OperationContract]
        void UpDateDetailingDessertInPurchase(DetailingDessertInPurchase dtdessert);
        [OperationContract]
        void UpDateFlavorsIiceCream(FlavorsIiceCream fla);
        [OperationContract]
        void UpDatePurchases(Purchases p);
        [OperationContract]
        void UpDateSpecialDessert(SpecialDessert sp);

       
        
    }
}