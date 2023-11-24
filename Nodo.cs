using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLista
{
    public class Nodo
    {
        private Persona _Persona;
        private Nodo _Siguiente;

        public Nodo(Persona persona)
        {
            _Persona = persona;
            _Siguiente = null;
        }

        public Nodo(Persona persona, Nodo siguiente)
        {
            _Persona= persona;
            _Siguiente= siguiente;
        }

        public Nodo getSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }

        public Persona getPersona
        {
            get { return _Persona; }
            set { _Persona= value; }
        }


    }
}
