using System;

namespace VariablesFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE 1 (3 punts)
            Console.WriteLine("Fase 1");


            string name = "Cristina";

            string surname1 = "Fernandez";

            string surname2 = "Navarro";


            const int day = 7;

            const int month = 07;

            const int year = 1986;

            
            Console.WriteLine(name + " " + surname1 + " " + surname2);

            Console.WriteLine(day + "/" + month + "/" + year);

            Console.WriteLine();



            /* FASE 2(3 punts)
          
            Sabiendo que en 1948 es un año bisiesto:
            ● Cree una variable constante con el valor del año(1948).
            ● Cree una variable constante que guarde cada cuando hay un año bisiesto.
            ● Calcular cuantos años bisiestos hay entre 1948 y su año de nacimiento y almacene el valor
            resultando en una variable.
            ● Muestre por pantalla el resultado del cálculo.*/

            Console.WriteLine("Fase 2");

            const int yearLeap = 1948;

            const int leapPeriod = 4;

            int yearl;

            int contador = 0;

            for ( yearl = yearLeap; yearl <= year; yearl+=leapPeriod)
            {
                contador++;
            }


            Console.WriteLine("Entre las dos fechas hay {0} años bisiestos.", contador);

            Console.WriteLine();

            /*FASE 3 (3 punts)
             Partiendo del año 1948 tiene que hacer un bucle for y mostrar los años bisiestos hasta llega a su año
             de nacimiento. (0,75 puntos)
             ATENCION! Deberá cambiar el tipo de variable de 1948 para poder modificarla.
                ● Cree una variable bool que sera cierta si el año de nacimiento es bisiesto o falsa si no lo es. (0,75 puntos)
                ● En caso de que la variable bool sea cierta, debe mostrar por consola una frase donde lo diga, en caso de ser
            falsa mostraréis la frase pertinente. Crea dos variables string para guardar las frases. (1,5 puntos) */

            Console.WriteLine("Fase 3");

            for ( yearl = 1948; yearl <= year; yearl += leapPeriod)
            {
                Console.WriteLine(yearl);
            }


            bool bisiesto = (yearl == year);

            string textLeap = ("Mi cumple cae en año es bisiesto");

            string textNotLeap = ("Mi cumple no cae en año es bisiesto");

            if (bisiesto == true)
{
                Console.WriteLine(textLeap);
            }
            else
            {
                Console.WriteLine(textNotLeap);
            }


            Console.WriteLine();


            /* FASE 4(1 punt)
             ● Creeu una variable on juntareu el nom i els cognoms(tot en una variable) i un altre on juntareu la data
             de naixement separada per “/” (tot en una variable). Mostreu per consola les variables del nom complet,
             la data de naixement i si l’any de naixement es de traspàs o no.*/
            
            Console.WriteLine("Fase 4");


            string fullName = name+" "+surname1+" "+surname2;

            Console.WriteLine("Mi super nombre es " +" "+ fullName);


            string fullBirthday = String.Concat(day,"/", month, "/", year);

            Console.WriteLine("Mi cumple es el dia" + " " + fullBirthday);

            
            
            Console.ReadLine();

        }



    }
    }

