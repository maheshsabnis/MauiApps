using CollectionViewApp.Data;

namespace CollectionViewApp
{
    public partial class MainPage : ContentPage
    {
        Products products;
        public MainPage()
        {
            InitializeComponent();
            products = new Products();
            this.BindingContext= products;
        }

                
    }
}