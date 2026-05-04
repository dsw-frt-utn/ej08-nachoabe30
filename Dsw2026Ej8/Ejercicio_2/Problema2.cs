namespace Dsw2026Ej8.Ejercicio_2;

public class Problema2
{
    
    private long _productCode;
    private string _productDescription;
    private int _quantify;
    private decimal unitPrice;

    public string CrearResumenVenta(long productoCode, string productoDescription, int quantify, decimal unitPrice)
    {
        //Condición de cuantificador (total iniciamos en 0)
        decimal total = 0;
        if (quantify > 0)
        { 
            total = quantify * unitPrice;
        }

        var resumen = new
        {
            Code = productoCode,
            Description = productoDescription,
            Quantify = quantify,
            Total = total
        };

        return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";


    }

}