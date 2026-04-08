public class MotorDescuentosGreen
{
    public double CalcularPrecioFinal(int anios, string codigo)
    {
        double precio = 100;
        double descuento = 0;

        if (anios > 1)
            descuento += 0.10;

        if (codigo == "OMNI20")
            descuento += 0.20;

        if (descuento > 0.25)
            descuento = 0.25;

        return precio - (precio * descuento);
    }
}