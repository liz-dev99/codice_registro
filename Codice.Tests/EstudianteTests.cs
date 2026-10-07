using Codice.Registro;

namespace Codice.Tests
{
    public class EstudianteTests
    {
        [Fact]
        public void CalcularPromedio_DosNotasDeLaMismaAsignatura_DevuelvePromedioCorrecto()
        {
            // Arrange (preparar)
            var taller = new Asignatura("PRO205", "Taller de Programación");
            var estudiante = new Estudiante("12.345.678-9", "Ana Pérez", "ana@codice.cl");
            estudiante.AgregarCalificacion(new Calificacion(5.0, DateTime.Today, taller));
            estudiante.AgregarCalificacion(new Calificacion(7.0, DateTime.Today, taller));

            // Act (actuar)
            double promedio = estudiante.CalcularPromedio(taller);

            // Assert (verificar)
            Assert.Equal(6.0, promedio);
        }

        [Fact]
        public void CalcularPromedio_SinNotas_DevuelveCero()
        {
            // Arrange (preparar): estudiante SIN notas
            var taller = new Asignatura("PRO205", "Taller de Programación");
            var estudiante = new Estudiante("12.345.678-9", "Ana Pérez", "ana@codice.cl");

            // Act (actuar)
            double promedio = estudiante.CalcularPromedio(taller);

            // Assert (verificar): debe ser 0, no un error
            Assert.Equal(0, promedio);
        }
    }
}