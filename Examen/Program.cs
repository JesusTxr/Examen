using System;

class Producto
{
    public string Nombre {get; set;}
    public int Codigo {get; set;}
    public double Precio {get; set;}

    public Producto(string nombre, int codigo, double precio)
    {
        Nombre = nombre;
        Codigo = codigo;
        Precio = precio;
    }
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Codigo: {Codigo}, Precio: {Precio}";
    }
}

class Tienda
{
    private Producto PrimerProducto;
    public Tienda()
    {
        PrimerProducto = null;
    }
    public void AggProducto(string nombre, int codigo, double precio)
    {
        if (PrimerProducto == null)
        {
            PrimerProducto = new Producto(nombre, codigo, precio);
        }
        /*else
        {
            AggRecursivo(PrimerProducto, new Producto(nombre, codigo, precio));
        }
    }
    private void AggRecursivo(Producto actual, Producto nuevo)
    {
        if (actual.Siguiente == null)
        {
            actual.Siguiente = nuevo;
        }
        else
        {
            AggRecursivo(actual.Sigueinte, nuevo);
        }
    }*/
    public void VerProducto()
    {
        MostrarRecursivo(PrimerProducto);
    }
    private void MostrarRecursivo(Producto actual)
    {
        if (actual!= null)
        {
            Console.WriteLine(actual);
            MostrarRecursivo(actual.Siguiente);
        }
    }

}

class Program
{
    static void Main()
    {
        Tienda tienda = new Tienda();

        tienda.AggProducto("Laptop", 101, 8000.99);
        tienda.AggProducto("Telefono", 102, 5999.99);

        Console.WriteLine("Productos en la tienda: ");
        tienda.VerProducto();
    }
}