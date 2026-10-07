using System;
using System.Collections.Generic;
using System.Text;

namespace Codice.Registro
{
    public class Calificacion
    {
        public Calificacion(double valor, DateTime fecha, Asignatura asignatura)
        {
            Valor = valor;
            Fecha = fecha;
            Asignatura = asignatura;
        }

        public double Valor { get; private set; }
        public DateTime Fecha { get; private set; }
        public Asignatura Asignatura { get; private set; }
        public bool EsValida() => EstaEnRango(Valor);
        private static bool EstaEnRango(double v) => v >= 1.0 && v <= 7.0;
        public void Modificar(double nuevoValor)
        {
            if (!EstaEnRango(nuevoValor))
                throw new ArgumentOutOfRangeException(nameof(nuevoValor), "La nota debe estar entre 1,0 y 7,0.");

            Valor = nuevoValor;
        }
    }
}
