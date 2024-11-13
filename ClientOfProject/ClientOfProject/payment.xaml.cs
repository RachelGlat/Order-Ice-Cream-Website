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
    public sealed partial class payment : Page
    {
        Service1Client proxy = new Service1Client();
        public payment()
        {
            this.InitializeComponent();
        }

        
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            lvcreditcard.Visibility = Visibility.Visible;
            Class1.payment = "כרטיס אשראי";
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            lvcreditcard.Visibility = Visibility.Collapsed;
            Class1.payment = "צ'ק";
        }

        private void SymbolIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
this.Frame.Navigate(typeof(help));
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            lvcreditcard.Visibility = Visibility.Collapsed;
            Class1.payment = "מזומן";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(help));
        }
        
        private async void bend_Click(object sender, RoutedEventArgs e)
        {
            pophappy.IsOpen = true;
            Purchases p = new Purchases();
            //p=
            p.CodeClient = Class1.c;
            p.DatePurchase = DateTime.Today.ToString("dd/mm/yy");
            p.Time = DateTime.Now.ToString();
            //p.FinalPrice = Class1.payment.;
            p.PaymentMethod = Class1.payment;
            ////הוספת הזמנה
            //await proxy.AddPurchesAsync(p);
            //foreach (var item in )
            {

                //    //הוספה לטבלה
                //await client.AddDettalingDessertImPurchesAsync(item);
            }
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            sof.Text = Class1.total.ToString();
        }
    }
}
