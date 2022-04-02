using System.Windows.Input;
using HammerV2.Models;
using HammerV2.Views;
using Xamarin.Forms;

namespace HammerV2.ViewModels
{
    public class ProductViewModel : BaseModel

    {
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private double _price;

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }


    public ICommand ClearCommand { private set; get; }
    public ICommand CreateCommand { private set; get; }

    public ProductViewModel()
    {
        ClearCommand = new Command(() => Clear());
        CreateCommand = new Command(() => Create());
    }

    void Clear()
    {
        Name = string.Empty;
        Price = 0;
    }

    void Create()
    {

    }
    }
}