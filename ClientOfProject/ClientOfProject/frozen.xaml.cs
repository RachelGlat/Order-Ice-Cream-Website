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
    public sealed partial class frozen : Page
    {
        Service1Client client = new Service1Client();
        List<Additions> additionslist = null;

        public frozen()
        {
            this.InitializeComponent();
        }
        private async void Page_Loading(FrameworkElement sender, object args)
        {
            //List<Category> ll = await client.GetAllCategoryAsync();
            //lvCategory.ItemsSource = ll;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Category c = (sender as Button).Tag as Category;
            //var temp = await client.GetAllAdditionsAsync(c);
            //additionslist = temp.Where(x => x.CodeCategory.CodeCategory == c.CodeCategory).Select(x => x.CodeAddition).ToList();
            //lvAddition.ItemsSource = additionslist;


        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(first));
        }

        
    }
}
