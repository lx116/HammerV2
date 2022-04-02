using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using HammerV2.Models;
using Xamarin.Forms;


namespace HammerV2.ViewModels
{
    
    public class ListProductViewModel:BaseModel
    {
        private GlobalList _list = new GlobalList();
        
        private ObservableCollection<Product> _products;
        
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }
        
        public ICommand GoToDetailsCommand {  set; get; }
        
        public INavigation Navigation { get; set; }

        public ListProductViewModel(INavigation navigation)
        {
            Navigation = navigation;
            
            Products = new ObservableCollection<Product>();
            
            foreach (var elements in _list.GlobalProducts)
            {
                Products.Add(new Product()
                {
                    Name = elements.Name,
                    Description = elements.Description,
                    Price = elements.Price,
                    Quantity = elements.Quantity
                });
            }
        }
    }
    
}