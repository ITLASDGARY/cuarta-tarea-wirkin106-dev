using System;
using System.Collections.Generic;

namespace EjerciciosCS
{
    /// <summary>
    /// Ejercicios de C# para practicar Arrays y Listas
    /// </summary>
    public class Ejercicios
    {
        private int[] _arrayGenerado = Array.Empty<int>();
        /// <summary>
        /// 1. EL PROFESOR PEREZOSO (Arrays)
        /// 
        /// PISTAS:
        /// - Crea un array de 'double' llamado 'temperaturas' con 5 elementos
        /// - Asigna valores inventados directamente en el código (ej: 23.5, 24.0, etc.)
        /// - Usa un bucle 'for' para sumar todas las temperaturas
        /// - Divide la suma entre 5 para obtener el promedio
        /// - Retorna el promedio calculado
        /// </summary>
        /// <returns>El promedio de las 5 temperaturas</returns>
        public double CalcularPromedioTemperatura()
        {
            // TODO: Implementar el cálculo del promedio de temperaturas

            double promedio = 0.0;

            double[] temperaturas = {23.5, 43.6, 32.7, 13.3, 4.3};

            double suma = 0 ;

            for (int i = 0; i < temperaturas.Length; i++)

            {
                suma += temperaturas[i];
            }

            promedio = suma / 5;
            
            return promedio;
        }

        /// <summary>
        /// 2. LISTA DE SUPERMERCADO (Listas)
        /// 
        /// PISTAS:
        /// - Crea una 'List<string>' para almacenar los productos
        /// - Usa Console.WriteLine() para pedir al usuario que ingrese productos
        /// - Usa un bucle 'while (true)' para pedir productos continuamente
        /// - Usa Console.ReadLine() para leer lo que escribe el usuario
        /// - Si el usuario escribe "salir", termina el bucle con 'break'
        /// - Usa 'foreach' para imprimir todos los productos de la lista
        /// </summary>
        /// <returns>Una List<string> con los productos ingresados por el usuario</returns>
        public List<string> CrearListaCompras()
        {
            // TODO: Implementar la lista de compras interactiva
            
            List<string> listaCompras = new List<string>();

            Console.WriteLine("Ingresa productos (escribe 'salir' para terminar):");
            while (true)
            {
                  string entrada = Console.ReadLine();
                  if (entrada?.ToLower() == "salir") break;
                  listaCompras.Add(entrada);
            }

            foreach (var item in listaCompras) Console.WriteLine($"- {item}");
            

            return listaCompras;
        }

        /// <summary>
        /// 3. EL BUSCADOR (Reto)
        /// 
        /// PISTAS:
        /// - Crea un 'Random' para generar números aleatorios
        /// - Crea un array de 'int' con 10 elementos
        /// - Usa un bucle 'for' para llenar el array con números aleatorios (0-100)
        ///   Puedes usar: random.Next(0, 101)
        /// - Recorre el array con otro bucle 'for' buscando el número de la variable 'numeroBuscado'
        /// - Si encuentras el número, retorna 'true'
        /// - Si terminas el bucle sin encontrarlo, retorna 'false'
        /// 
        /// BONUS: Muestra los números generados en el array
        /// </summary>
        /// <param name="numeroBuscado">El número que el usuario quiere buscar</param>
        /// <returns>true si el número está en el array, false si no</returns>
        public bool BuscarNumeroDinamico(int numeroBuscado)
        {
            // TODO: Implementar la búsqueda de número en array aleatorio
            bool encontrado = false;
            Random random = new Random();

            
            int[] numeros = new int[10];

    
            Console.WriteLine("Números en el array:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 101);
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine(); // saalto de línea

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                   encontrado = true;
                   break; // Si lo encontramos, dejamos de buscar
                }
           }
            

            return encontrado;
        }

        
    }
}
