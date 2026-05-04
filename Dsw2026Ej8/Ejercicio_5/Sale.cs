namespace Dsw2026Ej8.Ejercicio_5;

public class Sale
{
    public decimal _ImporteBase { get; set; }
    
    
    //Creo metodo llamada Virtual 

    public virtual decimal CalculateTotal()
    {
        return _ImporteBase;
    }

    
    //Clase derivada numero 1 
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return _ImporteBase;
        }
    }
    
    //Clase derivada 2
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return _ImporteBase * 0.90m;
        }
    }
    
    //CReo la clase principal llamada problema 5
    public class Problema5
    {
        public decimal ObetenerInporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}