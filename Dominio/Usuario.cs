public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Saldo { get; set; }
    public bool TieneDeudas { get; set; }
    public bool EsPremium { get; set; }

    public bool PuedeSerPremium()
    {
        return Saldo > 50 && !TieneDeudas;
    }
}