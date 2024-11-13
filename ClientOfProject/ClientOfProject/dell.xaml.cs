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
    public sealed partial class dell : Page
    {
        Service1Client client = new Service1Client();
        public dell()
        {
            this.InitializeComponent();
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            //List<Category> ll = await client.GetAllCategoryAsync();
            //lvCategory.ItemsSource = ll;

            List<FlavorsIiceCream> f = await client.GetAllFlavorsAsync();
            lvFlavor.ItemsSource = f;

            List<Additions> a = await client.GetAdditionsAsync();
            lvAddition.ItemsSource = a;

            List<SpecialDessert> s = await client.GetSpecielDessertAsync();
            lvspecialDessert.ItemsSource = s;

            List<AdditionAccordingCategory> ada = await client.GetAdditionAccordingCategoriesAsync();
            lvAdditionAccordingCategory.ItemsSource = ada;
        }

        private void bDellAdditionAcordingCategory_Click(object sender, RoutedEventArgs e)
        {
            if (lvAddition.IsEnabled == true)
                lvAddition.IsEnabled = false;
            if (lvFlavor.IsEnabled == true)
                lvFlavor.IsEnabled = false;
            if (lvspecialDessert.IsEnabled == true)
                lvspecialDessert.IsEnabled = false;
            lvAdditionAccordingCategory.IsEnabled = true;
        }

        private void bDellAddition_Click(object sender, RoutedEventArgs e)
        {
            if (lvAdditionAccordingCategory.IsEnabled == true)
                lvAdditionAccordingCategory.IsEnabled = false;
            if (lvFlavor.IsEnabled == true)
                lvFlavor.IsEnabled = false;
            if (lvspecialDessert.IsEnabled == true)
                lvspecialDessert.IsEnabled = false;
            lvAddition.IsEnabled = true;
        }

        private void bDellFlavor_Click(object sender, RoutedEventArgs e)
        {
            if (lvAddition.IsEnabled == true)
                lvAddition.IsEnabled = false;
            if (lvAdditionAccordingCategory.IsEnabled == true)
                lvAdditionAccordingCategory.IsEnabled = false;
            if (lvspecialDessert.IsEnabled == true)
                lvspecialDessert.IsEnabled = false;
            lvFlavor.IsEnabled = true;
        }

        private void bDellSpecialDessert_Click(object sender, RoutedEventArgs e)
        {
            if (lvAddition.IsEnabled == true)
                lvAddition.IsEnabled = false;
            if (lvFlavor.IsEnabled == true)
                lvFlavor.IsEnabled = false;
            if (lvAdditionAccordingCategory.IsEnabled == true)
                lvAdditionAccordingCategory.IsEnabled = false;
            lvspecialDessert.IsEnabled = true;
        }


        //מחיקת מנה/מוצר
        private void SymbolIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {

                //if (lvspecialDessert.SelectedIndex > 0)
                //{
                //    SauceTxt.Text = "";
                //    ServiceReference1.SpecialDessert sas = new ServiceReference1.SpecialDessert();
                //    sas.CodeDessert = (lstSauce.SelectedItem as ServiceReference2.Sauce).CodeSauce;
                //    c.NameSauce = (lstSauce.SelectedItem as ServiceReference2.Sauce).NameSauce;
                //    await client.DeleteSauceAsync(c);
                //    SauceTxt.Text = "";
                //}
                //else
                //{
                //    SauceTxt.Text = "יש לבחור תוספת למחיקה";
                //}
        }


        //מחיקת טעם גלידה
        private async void SymbolIcon_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            FlavorsIiceCream fc = (sender as SymbolIcon).Tag as FlavorsIiceCream; 
            fc.CodeIceCream = (lvFlavor.SelectedItem as FlavorsIiceCream).CodeIceCream;
            fc.NameIceCream = (lvFlavor.SelectedItem as FlavorsIiceCream).NameIceCream;
            fc.Picture = (lvFlavor.SelectedItem as FlavorsIiceCream).Picture;
            fc.IsMilk = (lvFlavor.SelectedItem as FlavorsIiceCream).IsMilk;
            await client.DellFlavorIceCreamAsync(fc);
        }


        //מחיקת תוספת
        private async void SymbolIcon_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            if (lvAddition.SelectedIndex > 0)
            {

                ServiceReference1.Additions a = new ServiceReference1.Additions();
                a.CodeAddition = (lvAddition.SelectedItem as ServiceReference1.Additions).CodeAddition;
                a.NameAddition = (lvAddition.SelectedItem as ServiceReference1.Additions).NameAddition;
                a.Picture = (lvAddition.SelectedItem as ServiceReference1.Additions).Picture;
                await client.DellAdditionsAsync(a);

            }
        }


        //מחיקת תוספת לפי קטגוריה
        private void SymbolIcon_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            //if (lvspecialDessert.SelectedIndex > 0)
            //{
            //    SauceTxt.Text = "";
            //    ServiceReference1.SpecialDessert sas = new ServiceReference1.SpecialDessert();
            //    sas.CodeDessert = (lstSauce.SelectedItem as ServiceReference2.Sauce).CodeSauce;
            //    c.NameSauce = (lstSauce.SelectedItem as ServiceReference2.Sauce).NameSauce;
            //    await client.DeleteSauceAsync(c);
            //    SauceTxt.Text = "";
            //}
            //else
            //{
            //    SauceTxt.Text = "יש לבחור תוספת למחיקה";
            //}
        }
        //אישןר מחיקת טעם גלידה
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
     FlavorsIiceCream fc = (sender as Button).Tag as FlavorsIiceCream; 
            fc.CodeIceCream = (lvFlavor.SelectedItem as FlavorsIiceCream).CodeIceCream;
                fc.NameIceCream = (lvFlavor.SelectedItem as FlavorsIiceCream).NameIceCream;
            fc.Picture = (lvFlavor.SelectedItem as FlavorsIiceCream).Picture;
                fc.IsMilk = (lvFlavor.SelectedItem as FlavorsIiceCream).IsMilk;
                await client.DellFlavorIceCreamAsync(fc);
        }
        //מחיקת טעם גלידה
        private void SymbolIcon_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            IfDellFlavor.IsOpen = true;
            lvFlavor.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(maneger));
        }
    }
}

