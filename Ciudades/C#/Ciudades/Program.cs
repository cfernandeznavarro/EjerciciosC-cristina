using System;

namespace Ciudades
{
    class Program
    {
        static void Main(string[] args)
        {

            
        /*Ejercicio:
        El ejercicio consiste en mostrar por consola diferentes nombres de ciudades partiendo de un array y modificar 
        los nombres cambiando letras.


        FASE 1(2 puntos)
        ● Crear seis variables tipu string vacías. (0, 5 puntos)
        ● Pide por consola que se introduzcan los nombres. (0, 5 puntos)
        ● Introduce los siguientes nombres de ciudades(Barcelona, ​​Madrid, Valencia, Málaga, Cádiz, Santander) para
        teclado. (0, 5 puntos)
        ● Mostrar por consola el nombre de las 6 ciudades. (0, 5 puntos)*/

        Console.WriteLine("FASE 1");

            string city1, city2, city3, city4, city5, city6;
      
            Console.WriteLine("Introduzca los nombre de las ciudades");
            Console.WriteLine("Introduzca de la ciudad 1");
            city1 = Console.ReadLine();

            Console.WriteLine("Introduzca de la ciudad 2");
            city2 = Console.ReadLine();

            Console.WriteLine("Introduzca de la ciudad 3");
            city3 = Console.ReadLine();

            Console.WriteLine("Introduzca de la ciudad 4");
            city4 = Console.ReadLine();

            Console.WriteLine("Introduzca de la ciudad 5");
            city5 = Console.ReadLine();

            Console.WriteLine("Introduzca de la ciudad 6");
            city6 = Console.ReadLine();

            Console.WriteLine("Las cuidades introducidas por el usuario son:" + city1 + " "+ city2 + " " + city3 + " " + city4+ " " + city5 +  " " + city6 );

            
            Console.WriteLine();

            /*FASE 2(2 puntos)
            ● Una vez tenemos los nombres de las ciudades guardados en variables tendremos que pasar la información a un array
            (ArrayCiutats). (1 punto)
            ● Cuando tengamos el array lleno, tendremos que mostrar por consola el nombre de las ciudades ordenadas por orden
            alfabético. (1 punto)*/

            Console.WriteLine("FASE 2");

            string[] ArrayCities = { city1, city2, city3, city4, city5, city6 };

            Array.Sort(ArrayCities);

            foreach (var value in ArrayCities)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine();

            Console.WriteLine();
            
            /* FASE 3(3 puntos)
             ● cambiar las vocales "a" de los nombres de las ciudades por el numero 4 y guarde los nombres modificados en un nuevo
             array(ArrayCiutatsModificades). (2 puntos)
             ● Muestre por consola el array modificado y ordenado por orden alfabético. (1 punto)*/
             
            Console.WriteLine("FASE 3");


            Console.WriteLine();

            string newcity1 = city1.Replace('a', '4');
            string newcity2 = city2.Replace('a', '4');
            string newcity3 = city3.Replace('a', '4');
            string newcity4 = city4.Replace('a', '4');
            string newcity5 = city5.Replace('a', '4');
            string newcity6 = city6.Replace('a', '4');

            string[] ArrayCiutatsModificades = { newcity1, newcity2, newcity3, newcity4, newcity5, newcity6 };

            Array.Sort(ArrayCiutatsModificades);

            foreach (var value in ArrayCiutatsModificades)
            {
                Console.WriteLine(value);
            }


            /*FASE 4(3 puntos)
            Crea un nuevo array para cada una de las ciudades que tenemos. El tamaño de los nuevos arrays será la
            longitud de cada string(string nomCiutat.Length). (0, 5 puntos)
            ● Llene los nuevos arrays letra por letra. (2 puntos) */

            Console.WriteLine();

            Console.WriteLine("FASE 4");

            char[] citychar1 = new char[city1.Length];
            Console.WriteLine("introduzca letra por letra los caracteres de" + " "+ city1);

            foreach (var value in citychar1)
            {
                Console.ReadLine();
            }

            Console.WriteLine(citychar1);

            
            char[] citychar2 = new char[city2.Length];
            Console.WriteLine("introduzca letra por letra los caracteres de" + " " + city2);

             foreach (var value in citychar2)
             {
                 Console.ReadLine();
             }

             char[] citychar3 = new char[city3.Length];
             Console.WriteLine("introduzca letra por letra los caracteres de" + " " + city3);

             foreach (var value in citychar3)
             {
                 Console.ReadLine();
             }

             char[] citychar4 = new char[city4.Length];
             Console.WriteLine("introduzca letra por letra los caracteres de" + " " + city4);

             foreach (var value in citychar4)
             {
                 Console.ReadLine();
             }


             char[] citychar5 = new char[city5.Length];
             Console.WriteLine("introduzca letra por letra los caracteres de" + " " + city5);

             foreach (var value in citychar5)
             {
                 Console.ReadLine();
             }


             char[] citychar6 = new char[city6.Length];
             Console.WriteLine("introduzca letra por letra los caracteres de" + " " + city6);

             foreach (var value in citychar6)
             {
                 Console.ReadLine();
             }

              //● Muestre por consola los nuevos arrays con los nombres invertidos(Ej: Barcelona - anolecraB). (0, 5 puntos)*/


             Console.WriteLine("Reversed charArray: " + city1);
             Array.Reverse(citychar1);

            foreach (char value in citychar1)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(citychar2);
            foreach (char value in citychar2)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(citychar3);
            foreach (char value in citychar3)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(citychar4);
            foreach (char value in citychar4)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(citychar5);
            foreach (char value in citychar5)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Array.Reverse(citychar6);
            foreach (char value in citychar6)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();



        }
    }
}

