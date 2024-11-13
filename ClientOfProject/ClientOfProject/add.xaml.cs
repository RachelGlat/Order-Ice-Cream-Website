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
    public sealed partial class add : Page
    {
        Service1Client proxy = new Service1Client();
       
        //List<Additions> GetAdditions = null;
        public add()
        {
            this.InitializeComponent();
        }

        private async void btAddMutzar_Click(object sender, RoutedEventArgs e)
        {
            SpecialDessert sp = new SpecialDessert();
            sp.CodeDessert = await proxy.GetCodeToMutzarAsync();
            if (legal.IsHebrew(tNamedessert.Text))
            {
                sp.NameDessert = tNamedessert.Text;
            }
            else
                tNamedessert.Text = "יש לכתוב שם מוצר/מנה בעברית בלבד";
            if (legal.IsNumber(tPricedessert.Text))
            {
                sp.Price = Convert.ToInt32(tPricedessert.Text);
            }
            else
                tPricedessert.Text = "יש לכתוב מחיר רק במספר";
            sp.AmountIceCream = Convert.ToInt32(tAmountIceCream.Text);
            sp.Picture = tPicturedessert.Text;
            if (rs1.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 1 };
            if (rs2.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 2 };
            if (rs3.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 3 };
            if (rs4.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 4 };
            if (rs5.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 5 };
            if (rs6.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 6 };
            if (rs7.IsChecked == true)
                sp.CodeCategory = new Category() { CodeCategory = 7 };
            sp.AmountAdditions = Convert.ToInt32(tAmountAdditions.Text);
            if (legal.IsHebrew(tdescrption.Text))
            {
                sp.Description= tdescrption.Text;
            }
            else
                tdescrption.Text = "יש לכתוב תאור מוצר/מנה בעברית בלבד";
            sp.Size = tsize.Text.ToString();
            await proxy.AddspecialdessertAsync(sp);
        }

        
        //הוספת תוספת
        private async void btAddAddition_Click(object sender, RoutedEventArgs e)
        {
          
            Additions a = new Additions();
            a.CodeAddition = await proxy.GetCodeToAdditionAsync();
            if (legal.IsHebrew(tNameAddition.Text))
            {
                a.NameAddition = tNameAddition.Text;
            }
            else
                tNameAddition.Text = "יש לכתוב שם תוספת בעברית בלבד";
            a.Picture = tPictureAddition.Text;
            await proxy.AddAditionAsync(a);
            //הודעה האם התוספת נוספה בהצלחה או לא 
            int x = await proxy.AddAditionAsync(a);
            if (x > 0)
               txtadd1.Text = "הרשומה נוספה בהצלחה";
            else
                txtadd1.Text = "הנתונים לא נשמרו - בדוק את תקינות הנתונים";



        }
        //הוספת טעם


        private async void btAddFlavorIceCream_Click(object sender, RoutedEventArgs e)
        {
            FlavorsIiceCream f = new FlavorsIiceCream();
            f.CodeIceCream = await proxy.GetCodeToFlavorsAsync();
            if (legal.IsHebrew(tNameflavors.Text))
            {
                f.NameIceCream = tNameflavors.Text;
            }
            else
                tNameflavors.Text = "יש לכתוב שם טעם גלידה בעברית בלבד";
            f.NameIceCream = tNameflavors.Text;
            f.Picture = tPictureFlavors.Text;
            if (c1.IsChecked == true)
                f.IsMilk = true;
            else
                f.IsMilk = false;
            //f.IsMilk = c1.IsChecked==true;
            //string d = (string)cmbMilk.SelectedItem;
            //if (d == "True")
            //    f.IsMilk = true;
            //else
            //    f.IsMilk=false;
            await proxy.AddFlavorIceCreamAsync(f);
            //הודעה האם התוספת נוספה בהצלחה או לא 
            //int x = await proxy.AddFlavorIceCreamAsync(f);
            //if (x > 0)
            //    txtadd1.Text = "הרשומה נוספה בהצלחה";
            //else
            //    txtadd1.Text = "הנתונים לא נשמרו - בדוק את תקינות הנתונים";

        }

        private bool b1_Click()
        {
            throw new NotImplementedException();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (lvAddFlavorIceCream.IsEnabled == true)
                lvAddFlavorIceCream.IsEnabled = false;
            if (lvAddDessert.IsEnabled == true)
                lvAddDessert.IsEnabled = false;
            lvAddAddition.IsEnabled = true;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (lvAddAddition.IsEnabled == true)
                lvAddAddition.IsEnabled = false;
            if (lvAddDessert.IsEnabled == true)
                lvAddDessert.IsEnabled = false;
            lvAddFlavorIceCream.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lvAddFlavorIceCream.IsEnabled == true)
                lvAddFlavorIceCream.IsEnabled = false;
            if (lvAddAddition.IsEnabled == true)
                lvAddAddition.IsEnabled = false;
            lvAddDessert.IsEnabled = true;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(maneger));
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            //List<Category> c = await proxy.GetAllCategoryAsync();




        }


    }
}
