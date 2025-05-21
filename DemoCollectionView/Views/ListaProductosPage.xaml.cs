using DemoCollectionView.Models;

namespace DemoCollectionView.Views;

public partial class ListaProductosPage : ContentPage
{
	public List<Producto> ProductosLista { get; set; }

	public Producto productoSeleccionado { get; set; }
    public ListaProductosPage()
	{
		InitializeComponent();
        
        this.CargarDatos();

        BindingContext = this;
    }

    private void CargarDatos()
    {
        ProductosLista = new List<Producto>()
        {
            new Producto { Id = 1, Nombre = "Pan Salvado", Precio = 1500, Stock = 5, Imagen = "pan_salvado.jpg" },
            new Producto { Id = 2, Nombre = "Pan Lactal", Precio = 1800, Stock = 3, Imagen = "pan_lactal.jpg" },
            new Producto { Id = 3, Nombre = "Tomate Perita", Precio = 2800, Stock = 8, Imagen = "tomate_perita.jpg" },
            new Producto { Id = 4, Nombre = "Yerba Taragui", Precio = 3145, Stock = 2, Imagen = "yerba_taragui.jpg" },
            new Producto { Id = 5, Nombre = "Yerba Rosamonte", Precio = 3266, Stock = 10, Imagen = "yerba_rosamonte.jpg" }
        };
    }

    public void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // DisplayAlert("Producto Seleccionado", "El producto seleccionado es: " + e.CurrentSelection[0].ToString(), "OK");
        DisplayAlert("Producto Seleccionado", "El producto seleccionado es: " + productoSeleccionado.Nombre, "OK");
    }
}