using Codice.Registro;

namespace Codice.Tests
{
    public class CalificacionTests
    {
        [Fact]
        public void Modificar_ValorFueraDeRango_LanzaExcepcion()
        {
            // Arrange (preparar): una nota válida de 5.0
            var taller = new Asignatura("PRO205", "Taller de Programación");
            var nota = new Calificacion(5.0, DateTime.Today, taller);

            // Act + Assert: intentar cambiarla a 8.0 debe lanzar la excepción
            Assert.Throws<ArgumentOutOfRangeException>(() => nota.Modificar(8.0));
        }
    }
}