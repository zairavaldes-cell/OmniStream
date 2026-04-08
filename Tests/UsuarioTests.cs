using Xunit;
using Dominio;

namespace Tests
{
    public class UsuarioTests
    {
        [Fact]
        public void PuedeSerPremium_SaldoMayor50SinDeudas_True()
        {
            var u = new Usuario { Saldo = 60.0, TieneDeudas = false };
            Assert.True(u.PuedeSerPremium());
        }

        [Fact]
        public void PuedeSerPremium_SaldoIgual50_False()
        {
            var u = new Usuario { Saldo = 50.0, TieneDeudas = false };
            Assert.False(u.PuedeSerPremium());
        }

        [Fact]
        public void PuedeSerPremium_SaldoMenor50_False()
        {
            var u = new Usuario { Saldo = 30.0, TieneDeudas = false };
            Assert.False(u.PuedeSerPremium());
        }

        [Fact]
        public void PuedeSerPremium_TieneDeudas_False()
        {
            var u = new Usuario { Saldo = 100.0, TieneDeudas = true };
            Assert.False(u.PuedeSerPremium());
        }
    }
}