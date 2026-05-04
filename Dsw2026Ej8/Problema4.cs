namespace Dsw2026Ej8;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        int?[] notas = { nota1, nota2, nota3 };
        double suma = 0;
        int cantidadValidas = 0;


        /*
         Resumen de funciones que no entendía:
         .HasValue nos dice si tiene un número (es decir, no es null)
         .Value nos da el número real para poder compararlo
         */
        foreach (var nota in notas)
        {
            if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
            {
                suma += nota.Value;
                cantidadValidas++;
            }
        }

        if (cantidadValidas == 0)
        {
            return 0;
        }

        return suma / cantidadValidas;
    }
}