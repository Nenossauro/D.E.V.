using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dev.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class events : ContentPage
    {
        List<string> efeitosativos = new List<string>();

        public events(string[] eventos)
        {
            InitializeComponent();
            foreach(string efeitos in eventos)
            {
                pickefeito.Items.Add(efeitos);
            }
        }

        private void bind(object sender, EventArgs args)
        {
            efeitosativos.Add(pickefeito.SelectedItem.ToString());
            ListaEfeitos.ItemsSource = null;
            ListaEfeitos.ItemsSource = efeitosativos;


        }
        private void limpefeito(object sender, EventArgs args)
        {
            efeitosativos.Clear();
            ListaEfeitos.ItemsSource = null;
            ListaEfeitos.ItemsSource = efeitosativos;


        }
    }
}