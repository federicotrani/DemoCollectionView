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
            new Producto { Id = 1, Nombre = "Pan Salvado MArca", Precio = 10.0f, Stock = 5, Imagen = "pan_salvado.jpg" },
            new Producto { Id = 2, Nombre = "Producto 2", Precio = 20.0f, Stock = 3, Imagen = "pan_lactal.jpg" },
            new Producto { Id = 3, Nombre = "Producto 3", Precio = 30.0f, Stock = 8, Imagen = "pan_lactal.jpg" },
            new Producto { Id = 4, Nombre = "Producto 4", Precio = 40.0f, Stock = 2, Imagen = "imagen4.png" },
            new Producto { Id = 5, Nombre = "Producto 5", Precio = 50.0f, Stock = 10, Imagen = "imagen5.png" }
        };
    }
}