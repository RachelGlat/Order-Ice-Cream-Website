using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ClientOfProject.ServiceReference1;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ClientOfProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class help : Page
    {
        int sum = 0;
        Service1Client client = new Service1Client();
        List<Additions> additionslist = null;
        List<SpecialDessert> specialdessertlist = null;
        int code ;
        List<SpecialDessert> shopping = new List<SpecialDessert>();
        //List<SpecificationAdditionsDessert> additionD = new List<SpecificationAdditionsDessert>();
        //List<SpecificationAdditionsDessert> additionDCurrent = new List<SpecificationAdditionsDessert>();
        List<DetailingDessertInPurchase> l = new List<DetailingDessertInPurchase>();
        List<DsetailingScoopOfIceCreamDessert> ld = new List<DsetailingScoopOfIceCreamDessert>();
        List<FlavorsIiceCream> fic = new List<FlavorsIiceCream>();
        List<SpecificationAdditionsDessert> said = new List<SpecificationAdditionsDessert>();
        List<Additions> dish = new List<Additions>();
        List<SpecialDessert> sal = new List<SpecialDessert>();
        public help()
        {
            this.InitializeComponent();
        }


        private async void Page_Loading(FrameworkElement sender, object args)
        {
            List<Category> ll = await client.GetAllCategoryAsync();
            lvCategory.ItemsSource = ll;

            List<FlavorsIiceCream> f = await client.GetAllFlavorsAsync();
            lvFlavors.ItemsSource = f;

            List<Additions> a = await client.GetAdditionsAsync();
            lvadditions.ItemsSource = a;

            //List<SpecialDessert> specialdessertlist = await client.GetSpecielDessertAsync();
            //lvInvantion.ItemsSource = specialdessertlist;

            //List<SpecificationAdditionsDessert> sd = await client.GetSpecificationAdditionsDessertsAsync();
            //lvInvantion.ItemsSource = sd;


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Category c = (sender as Button).Tag as Category;
        //    var temp = await client.GetAllDesertAsync(c);
        //    dessertList = temp.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeDessert).ToList();
        //    lvDessert.ItemsSource = dessertList;
        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private async void btCategory_Tapped(object sender, TappedRoutedEventArgs e)
        {

            // אם לקטגוריה שנבחרה יש תוספות -שיהיו זמינות לפי קטגוריה 
            Category c = (sender as Button).Tag as Category;
            //var temp = await client.GetAllAdditionsAsync(c);
            //additionslist = temp.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeAddition).ToList();
            //lvadditions.ItemsSource = additionslist;

            //כשבוחרים קטגוריה שיווצרו כפתורים מסוג ספיישל דסרט עם המנות של אותה קטגורייה
            SpecialDessert s = new SpecialDessert();
            List<SpecialDessert> specialdessertlist = await client.GetSpecielDessertAsync();
            //lvInvantion.ItemsSource = specialdessertlist;
            if (specialdessertlist.Count() > 0)
            {
                specialdessertlist = specialdessertlist.Where(u => u.CodeCategory.CodeCategory == c.CodeCategory).ToList();
            }
            lvInvantion.ItemsSource = specialdessertlist;

            if(c.CodeCategory==1 || c.CodeCategory==3 || c.CodeCategory == 6 || c.CodeCategory == 7 )
            {
                if(lvFlavors.IsEnabled==true)
                {
                    lvFlavors.IsEnabled = false;
                }
            }

           if(c.CodeCategory==1 || c.CodeCategory==3 || c.CodeCategory==4)
            {
                var temp = await client.GetAllAdditionsAsync(c);
                additionslist = temp.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeAddition).ToList();
                lvadditions.ItemsSource = additionslist;
            }

           if(c.CodeCategory==2 || c.CodeCategory==5 ||c.CodeCategory==6 ||c.CodeCategory==7)
            {
                lvadditions.IsEnabled = false;
            }
           if(c.CodeCategory==1 || c.CodeCategory==3 || c.CodeCategory==4)
            {
                lvadditions.IsEnabled = true;
            }

            if (c.CodeCategory==2)
            {
                lvFlavors.IsEnabled = true;

            }
          


        }
       
        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {

            //הצגת התוספות
           
        }
        //הוספה לסל
        private void btInvention_Click(object sender, RoutedEventArgs e)
        {
            
            var f = lvInvantion.SelectedItem as SpecialDessert;
            sum += f.Price;
            txsum2.Text = sum.ToString();
            code = f.CodeDessert;
            //var t = (sender as StackPanel).Tag as SpecialDessert;
            shopping.Add(f);
            lvSal.ItemsSource = shopping.ToList();
            foreach (var item in fic)
            {
                DsetailingScoopOfIceCreamDessert d = new DsetailingScoopOfIceCreamDessert();
                d.CodeSpecificationDessert = new DetailingDessertInPurchase() { CodeSpecificationDessert = code };
                d.CodeIceCream = item;
                ld.Add(d);
            }
            foreach(var item in dish)
            {
                SpecificationAdditionsDessert spa = new SpecificationAdditionsDessert();
                spa.CodeSpecificationAdditionsDessert = new DetailingDessertInPurchase() { CodeSpecificationDessert = code };
                spa.CodeAdditions = item;
                said.Add(spa);
            }

            fic = new List<FlavorsIiceCream>();
            //txsum2.Text = specialdessertlist[].Price;

        }

       
        private void cmbFlavors_Checked(object sender, RoutedEventArgs e)
        {
            
            var x= (sender as CheckBox).Tag ;
            fic.Add((FlavorsIiceCream)x);
        }

        private void cmbFlavors_Unchecked(object sender, RoutedEventArgs e)
        {
            var x = (sender as CheckBox).Tag;
            fic.Remove((FlavorsIiceCream)x);
        }
        

        private async void b1_Click(object sender, RoutedEventArgs e)
        {
            Class1.total = sum;
            this.Frame.Navigate(typeof(payment),txsum2.Text);
            
            //Purchases p = new Purchases();
            ////p=
            //p.CodeClient = Class1.c;
            //p.DatePurchase = DateTime.Today.ToString("dd/mm/yy");
            //p.Time = DateTime.Now.ToString();
            ////p.FinalPrice = txsum2.Text.ToString();
            //p.PaymentMethod = Class1.payment;
            ////הוספת הזמנה
            //await client.AddPurchesAsync(p);
            //foreach (var item in ld)
            //{ 

            //    //    //הוספה לטבלה
            //    //await client.AddDettalingDessertImPurchesAsync(item);
            //}

        }
         int counter = 0;
        private async void cmbAddition_Checked(object sender, RoutedEventArgs e)
        {
            //counter++;
            //if (counter < (sender as SpecialDessert).AmountAdditions)
            //    var x = (sender as shopping).Tag;
            //dish.Add((Additions)x);
            //else
            //{
            //    var x = (sender as CheckBox) = false;
            //}
        }

        private void cmbAddition_Unchecked(object sender, RoutedEventArgs e)
        {
            var x = (sender as CheckBox).Tag;
            dish.Remove((Additions)x);
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var f = lvInvantion.SelectedItem as SpecialDessert;
            sum -= f.Price;
            txsum2.Text = sum.ToString();

            shopping.Remove((f));
            lvSal.ItemsSource = shopping.ToList();
            //f = null;
        }
    }     
}
