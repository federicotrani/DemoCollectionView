using DemoCollectionView.Models;

namespace DemoCollectionView.Views;

public partial class ListaProductos : ContentPage
{
	public List<Producto> Productos { get; set; }

	public Producto productoSeleccionado { get; set; }
    public ListaProductos()
	{
		InitializeComponent();
        Productos = new List<Producto>()
        {
            new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.0f, Stock = 5, Imagen = "imagen1.png" },
            new Producto { Id = 2, Nombre = "Producto 2", Precio = 20.0f, Stock = 3, Imagen = "imagen2.png" },
            new Producto { Id = 3, Nombre = "Producto 3", Precio = 30.0f, Stock = 8, Imagen = "imagen3.png" },
            new Producto { Id = 4, Nombre = "Producto 4", Precio = 40.0f, Stock = 2, Imagen = "imagen4.png" },
            new Producto { Id = 5, Nombre = "Producto 5", Precio = 50.0f, Stock = 10, Imagen = "imagen5.png" }
        };

        BindingContext = this;
    }
}