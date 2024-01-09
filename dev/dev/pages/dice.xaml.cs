using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dice : ContentPage
    {
        public dice()
        {
            InitializeComponent();
        }
        int rod = 0;

        public int dado(int l) 
        {
            Random rd = new Random();
            int n = rd.Next(1, (l+1));
            return n;
        }
        public void rods()
        {
            rod += 1;
            txtrod.Text = "Rodada: " + rod.ToString();
        }

        private void rodars(object sender, EventArgs args)
        {
            
            DisplayAlert("D6 rolado!", "Ande "+dado(6).ToString()+" casas", "OK");
            rods();
        }
        private void rodarq(object sender, EventArgs args)
        {
            DisplayAlert("D4 rolado!", "Ande " + dado(4).ToString() + " casas", "OK");
            rods();
        }
        private void rodaro(object sender, EventArgs args)
        {
            DisplayAlert("D8 rolado!", "Ande " + dado(8).ToString() + " casas", "OK");
            rods();
        }
    }
}