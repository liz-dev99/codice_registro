using System;
using System.Collections.Generic;
using System.Text;

namespace Codice.Registro
{
    public class Asignatura
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public Asignatura(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }   
    }
}
