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
    public sealed partial class Client : Page
    {
        Service1Client proxy = new Service1Client();
        public Client()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(help));
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clients c = new Clients();
            c.CodeClient= await proxy.GetCodeToClientAsync();
             if (legal.IsHebrew(tfirst.Text))
            {
             c.FirstName = tfirst.Text;
            }
             else
            {
                c.FirstName = "יש להקיש שם בעברית";
            }
            if (legal.IsHebrew(tlast.Text))
            {
                c.LastName = tlast.Text;
            }
            else
            {
                c.LastName = "יש להקיש שם משפחה בעברית";
            }
           if(legal.IsCellPhone(tphone.Text))
            {
             c.Phone = tphone.Text;
            }
           else
            {
                tphone.Text = "מס' הפלאפון שהוקש אינו תקין";
            }
           if(legal.CheackMail(tmail.Text))
            {
             c.Mail = tmail.Text;
            }
           else
            {
                tmail.Text = "כתובת המייל שהוקשה אינה תקינה";
            }
           
            
            await proxy.AddClientAsync(c);
            Class1.c = c;
            ////הודעה האם התוספת נוספה בהצלחה או לא 
            //int x = await proxy.AddClientAsync(c);
            //if (x > 0)
            //    tbok.Text = "הרשומה נוספה בהצלחה";
            //else
            //    tbok.Text = "הנתונים לא נשמרו - בדוק את תקינות הנתונים";

        }

        private void Page_Loading(FrameworkElement sender, object args)
        {

        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(help));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(first));
        }
    }
}
