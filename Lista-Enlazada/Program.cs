using System;

namespace ListasEnlazadas
{
    // Nodo de la lista enlazada
    public class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Lista enlazada simple
    public class ListaEnlazada
    {
        public Nodo Cabeza;

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        // Método para agregar un nodo al final
        public void AgregarAlFinal(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Ejercicio 1.1: Función para contar elementos
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = Cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        // Ejercicio 2.2: Método para invertir la lista enlazada
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = Cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // guardar siguiente
                actual.Siguiente = anterior;  // invertir enlace
                anterior = actual;             // mover anterior adelante
                actual = siguiente;           // avanzar actual
            }
            Cabeza = anterior; // actualizar cabeza
        }

        // Método para mostrar la lista
        public void MostrarLista()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregar datos de ejemplo
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(30);
            lista.AgregarAlFinal(40);

            Console.WriteLine("Lista original:");
            lista.MostrarLista();

            // Ejercicio 1.1: contar elementos
            int cantidad = lista.ContarElementos();
            Console.WriteLine($"Número de elementos en la lista: {cantidad}");

            // Ejercicio 2.2: invertir lista
            lista.InvertirLista();
            Console.WriteLine("Lista invertida:");
            lista.MostrarLista();
        }
    }
}