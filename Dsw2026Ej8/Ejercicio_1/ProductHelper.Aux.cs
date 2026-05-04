namespace Dsw2026Ej8;


public partial class ProductHelper
{
    private const string FormatoMoneda = "C";
    
    private string FormatearPrecio(decimal price)
    {
        return price.ToString(FormatoMoneda);
    }
}