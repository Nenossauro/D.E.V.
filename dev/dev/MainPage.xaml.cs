using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using dev.pages;

namespace dev
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();


        }
        private void jogar(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Jogo());

        }
        private void regras(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new regras());

        }

    }
}
