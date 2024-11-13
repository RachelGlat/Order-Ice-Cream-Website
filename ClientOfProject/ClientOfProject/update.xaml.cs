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
    public sealed partial class update : Page
    {
        Service1Client proxy = new Service1Client();
      
        public update()
        {
            this.InitializeComponent();
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            List<SpecialDessert>sp = await proxy.GetSpecielDessertAsync();
            lv.ItemsSource = sp;

            
        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //if (e.Parameter != null)
            //{
            //    s = e.Parameter as SpecialDessert;
            //    TbCodeDessert.Text = s.CodeDessert.ToString();
            //    TbNameDessert.Text = s.NameDessert;
            //    TbPriceDessert.Text = s.Price.ToString();
            //    TbIceCreamDessert.Text = s.AmountIceCream.ToString();
            //    TbPictureDessert.Text = s.Picture;
            //    TbCodeCategoryDessert.Text = s.CodeCategory.ToString();
            //    TbAdditionsDessert.Text = s.AmountAdditions.ToString();
            //    TbDetallingDessert.Text = s.Description;
            //    TbSizeDessert.Text = s.Size;
            //}
        }


        private  void cmbDessert_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            SpecialDessert s = (sender as Button).Tag as SpecialDessert;
            this.Frame.Navigate(typeof(update), s);


            //SpecialDessert s = (SpecialDessert)cmbDessert.SelectedItem;
            //TbCodeDessert.Text = s.CodeDessert.ToString();
            //TbNameDessert.Text = s.NameDessert;
            //TbPriceDessert.Text = s.Price.ToString();
            //TbIceCreamDessert.Text = s.AmountIceCream.ToString();
            //TbPictureDessert.Text = s.Picture;
            //TbCodeCategoryDessert.Text = s.CodeCategory.ToString();
            //TbAdditionsDessert.Text = s.AmountAdditions.ToString();
            //TbDetallingDessert.Text = s.Description;
            //TbSizeDessert.Text = s.Size;


        }
        //void FillForm()
        //{
        //    SpecialDessert s = SpecialDessert. SetValue;
        ////    TbCodeDessert.Text = s.CodeDessert.ToString();
        ////    TbNameDessert.Text = s.NameDessert;
        ////    TbPriceDessert.Text = s.Price.ToString();
        ////    TbIceCreamDessert.Text = s.AmountIceCream.ToString();
        ////    TbPictureDessert.Text = s.Picture;
        ////    TbCodeCategoryDessert.Text = s.CodeCategory.ToString();
        ////    TbAdditionsDessert.Text = s.AmountAdditions.ToString();
        ////    TbDetallingDessert.Text = s.Description;
        ////    TbSizeDessert.Text = s.Size;

        ////}

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

    
      
      
        private void SymbolIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            lvUpDateDessert.IsEnabled = true;
            SpecialDessert s = (sender as SymbolIcon).Tag as SpecialDessert;
            TbCodeDessert.Text = s.CodeDessert.ToString();
            TbNameDessert.Text = s.NameDessert;
            TbPriceDessert.Text = s.Price.ToString();
            TbIceCreamDessert.Text = s.AmountIceCream.ToString();
            TbPictureDessert.Text = s.Picture;
            TbCodeCategoryDessert.Text = s.CodeCategory.ToString();
            TbAdditionsDessert.Text = s.AmountAdditions.ToString();
            TbDetallingDessert.Text = s.Description;
            TbSizeDessert.Text = s.Size;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(maneger));
        }
    }
}

