using System;
using System.Collections.Generic;
using System.Text;

namespace Codice.Registro
{
    public abstract class Persona
    {
        public string Rut { get; protected set; }
        public string Nombre { get; protected set; }
        public string Email { get; protected set; }

        protected Persona(string rut, string nombre, string email)
        {
            Rut = rut;
            Nombre = nombre;
            Email = email;
        }
        public void ActualizarDatos(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }   

    }

}
