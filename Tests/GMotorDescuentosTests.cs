using Xunit;
using Dominio;

// ARCHIVO DE EVIDENCIA - NO SE EJECUTA
public class MotorDescuentosTestsGreen
{
    [Fact(Skip = "Evidencia TDD")]
    public void PrecioBase_SinDescuento()
    {
        var motor = new MotorDescuentos();
        var resultado = motor.CalcularPrecioFinal(0, "");
        Assert.Equal(100, resultado);
    }

    [Fact(Skip = "Evidencia TDD")]
    public void DescuentoPorAntiguedad()
    {
        var motor = new MotorDescuentos();
        var resultado = motor.CalcularPrecioFinal(2, "");
        Assert.Equal(90, resultado);
    }

    [Fact(Skip = "Evidencia TDD")]
    public void DescuentoPorCodigo()
    {
        var motor = new MotorDescuentos();
        var resultado = motor.CalcularPrecioFinal(0, "OMNI20");
        Assert.Equal(80, resultado);
    }

    [Fact(Skip = "Evidencia TDD")]
    public void DescuentoMaximo()
    {
        var motor = new MotorDescuentos();
        var resultado = motor.CalcularPrecioFinal(2, "OMNI20");
        Assert.Equal(75, resultado);
    }
}