using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HammerV2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HammerV2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProducts : ContentPage
    {
        private GlobalList list = new GlobalList();
        
        public AddProducts()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            list.GlobalProducts.Add(new Product()
                {
                    Name = Name.Text,
                    Price = Double.Parse(Price.Text),
                    Quantity = int.Parse(Quantity.Text),
                    Description = Description.Text
                    
                });
            Counter.Text ="Se han agreado: " + Convert.ToString(list.GlobalProducts.Count) +" Productos";
        }
        
        async void OnNextPageButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new ProductsListView());
        }
    }
}