namespace Dsw2026Ej8.Ejercicio_3;

public class Problema3
{
    private string CompararCopias(int originalValue, Product product)
    {
        int copiarValor = originalValue;
        copiarValor++;

        Product copiaProducto = product;
        copiaProducto.ModificarDescripcion(copiaProducto.Description + "(Modificado)");

        return $"{originalValue} - {copiarValor} - {copiaProducto.Description}";

    }
}