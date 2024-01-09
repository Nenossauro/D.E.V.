using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dev;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cartaspux : ContentPage
    {
        public cartaspux(string[] parametro)
        {
            InitializeComponent();
            List<string> items = parametro.ToList();
            cartlist.ItemsSource = items;
        }
        private void limpefeito(object sender, EventArgs args)
        {
            cartlist.ItemsSource = null;


        }
    }
}