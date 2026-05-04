namespace Dsw2026Ej8.Ejercicio_3;

public class Product
{
    public string Description { get; private set; }
    public Product (String description) => Description = description;
    public void ModificarDescripcion(string nuevaDescripcion) => Description = nuevaDescripcion;
}