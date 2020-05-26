using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;


namespace ShoppingCarts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kickstart : ContentPage
    {

        //public ICommand TapCommand => new Command<string>(OpenBrowser);
        public Kickstart()
        {
            InitializeComponent();
            // Process.Start("http://www.google.com/");
            Device.OpenUri(new System.Uri("www.google.com"));
        }
        

    }
}