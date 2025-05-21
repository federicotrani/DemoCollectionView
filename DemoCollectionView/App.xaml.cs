using DemoCollectionView.Views;

namespace DemoCollectionView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListaProductosPage();
        }
    }
}
