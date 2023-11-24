using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLista
{
    public class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        public Lista()
        {
            primero = ultimo = null;
        }

        public bool IsNull()
        {
            return primero == null;
        }

        public void InsertarInicio(Persona persona)
        {
            if (IsNull())
            {
                primero = ultimo = new Nodo(persona);
            }
            else
            {
                primero = new Nodo(persona, primero);
            }
        }
        public void InsertarFinal(Persona persona)
        {
            if (IsNull())
            {
                primero = ultimo = new Nodo(persona);
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    if(actual.getSiguiente == null)
                    {
                        actual = actual.getSiguiente = new Nodo(persona);
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente;
                    }
                }
            }
        }

        public void Buscar(string nombre)
        {
            if(IsNull())
            {
                Console.WriteLine("No hay valores en la lista");
                return;
            }
            else
            {
                Nodo actual = primero;
                bool encontrado = false;
                int cont = 0;
                while (actual != null)
                {
                    cont++;
                    if(actual.getPersona.Nombre == nombre)
                    {
                        Console.WriteLine($"La persona {actual.getPersona.Nombre} esta en la lista en la posicion");
                        encontrado= true;
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente;
                        Console.WriteLine("a");
                    }
                }
                if(!encontrado)
                {
                    Console.WriteLine("El nombre no esta en la lista");
                    return;
                }
            }
        }

        public void MostrarLista()
        {
            
            if(IsNull())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            else
            {
                Nodo actual = ultimo;
                while (actual != null)
                {
                    Console.WriteLine($"El nombre es: {actual.getPersona.Nombre} y la edad es: {actual.getPersona.Edad}");
                    actual = actual.getSiguiente;
                }
                
            }
        }


    }
}
