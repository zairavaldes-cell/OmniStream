using Xunit;
using Moq;
using Dominio;

namespace Tests
{
    public class ServicioSuscripcionTests
    {
        [Fact]
        public void ActivarPremium_UsuarioExisteYCumple_RetornaMensajeExitoYActualiza()
        {
            // Arrange
            var usuario = new Usuario 
            { 
                Id = 1, 
                Saldo = 70.0, 
                TieneDeudas = false, 
                EsPremium = false 
            };
            var mockRepo = new Mock<IUsuarioRepositorio>();
            mockRepo.Setup(r => r.ObtenerPorId(1)).Returns(usuario);
            mockRepo.Setup(r => r.Guardar(It.IsAny<Usuario>())).Verifiable();

            var servicio = new ServicioSuscripcion(mockRepo.Object);

            // Act
            var resultado = servicio.ActivarPremium(1);

            // Assert
            Assert.Equal("Usuario ahora es PREMIUM", resultado);
            Assert.True(usuario.EsPremium);
            mockRepo.Verify(r => r.Guardar(It.Is<Usuario>(u => u.EsPremium == true)), Times.Once);
        }

        [Fact]
        public void ActivarPremium_UsuarioNoExiste_RetornaNoExiste()
        {
            var mockRepo = new Mock<IUsuarioRepositorio>();
            mockRepo.Setup(r => r.ObtenerPorId(99)).Returns((Usuario)null);

            var servicio = new ServicioSuscripcion(mockRepo.Object);
            var resultado = servicio.ActivarPremium(99);

            Assert.Equal("Usuario no existe", resultado);
            mockRepo.Verify(r => r.Guardar(It.IsAny<Usuario>()), Times.Never);
        }

        [Fact]
        public void ActivarPremium_UsuarioNoCumpleCondiciones_RetornaNoCumple()
        {
            var usuario = new Usuario 
            { 
                Id = 2, 
                Saldo = 30.0, 
                TieneDeudas = false, 
                EsPremium = false 
            };
            var mockRepo = new Mock<IUsuarioRepositorio>();
            mockRepo.Setup(r => r.ObtenerPorId(2)).Returns(usuario);

            var servicio = new ServicioSuscripcion(mockRepo.Object);
            var resultado = servicio.ActivarPremium(2);

            Assert.Equal("No cumple condiciones", resultado);
            Assert.False(usuario.EsPremium);
            mockRepo.Verify(r => r.Guardar(It.IsAny<Usuario>()), Times.Never);
        }
    }
}