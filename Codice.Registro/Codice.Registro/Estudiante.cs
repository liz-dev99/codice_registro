using System;
using System.Collections.Generic;
using System.Text;

namespace Codice.Registro
{
    public class Estudiante : Persona
    {
        private readonly List<Calificacion> calificaciones = new List<Calificacion>();
        public Estudiante(string rut, string nombre, string email) : base(rut, nombre, email)
        {
        }
        public void AgregarCalificacion(Calificacion nota)
        {
            calificaciones.Add(nota);
        }
        public double CalcularPromedio(Asignatura asignatura)
        {
            double suma = 0;
            int cantidad = 0;
            foreach (var calificacion in calificaciones)
            {
                if (calificacion.Asignatura == asignatura && calificacion.EsValida())
                {
                    suma += calificacion.Valor;
                    cantidad++;
                }
                
            }
            if (cantidad == 0)
                return 0;
            return suma / cantidad;
        }
    }
}
