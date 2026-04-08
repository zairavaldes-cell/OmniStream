namespace Dominio
{
    public class MotorDescuentos
    {
        private const double PRECIO_BASE = 100;
        private const double DESCUENTO_ANTIGUEDAD = 0.10;
        private const double DESCUENTO_CODIGO = 0.20;
        private const double DESCUENTO_MAX = 0.25;

        public double CalcularPrecioFinal(int anios, string codigo)
        {
            double descuento = CalcularDescuento(anios, codigo);
            return PRECIO_BASE - (PRECIO_BASE * descuento);
        }

        private double CalcularDescuento(int anios, string codigo)
        {
            double descuento = 0;

            if (anios > 1)
                descuento += DESCUENTO_ANTIGUEDAD;

            if (codigo == "OMNI20")
                descuento += DESCUENTO_CODIGO;

            return Math.Min(descuento, DESCUENTO_MAX);
        }
    }
}