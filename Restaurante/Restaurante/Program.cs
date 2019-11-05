using System;
using System.Collections.Generic;

namespace Restaurante
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Restaurante Casa Cristi!" + "\r\n");

            /*El ejercicio consiste en mostrar por consola una carta de un restaurante donde añadiremos diferentes platos y luego escogeremos que queremos 
             * para comer. Una vez hecho esto se deberá calcular el precio de la comida el programa nos dirá con qué billetes debemos pagar.
           
            FASE 1 (2 puntos)
            Cree una variable int por cada uno de los billetes que existen desde 5 € a 500 €, deberá crear otro variable para guardar el precio total de la comida. (1 punto)
            */

            #region Fase1

            int[] divisas = new int[8] { 500, 100, 50, 20, 10, 5, 2, 1 };

            int precioTotalMenu = 0;

            Console.WriteLine("¿En cuántos platos va a consistir el menu de hoy?");
            int numPlatos = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre de los " + numPlatos + " platos del menu de hoy");

            /*Crea dos arrays, uno donde guardaremos el menú(5 platos) y otro donde guardaremos el precio de cada
            plato. (1 punto)*/

            string[] platosMenu = new string[numPlatos];

            int[] precioPlatosMenu = new int[platosMenu.Length];

            #endregion

            #region Fase2
            //FASE 2 (3 puntos)
            //Con un bucle for deberemos rellenar los dos arrays anteriormente creados. Añadiremos el nombre del plato y luego el precio. (1 punto)

            for (int i = 0; i < platosMenu.Length; i++)
            {
                Console.WriteLine("Introduce el nombre del plato número " + (i+1));
                platosMenu[i] = Console.ReadLine();

                Console.WriteLine("PRECIO Plato número " + (i+1));
                precioPlatosMenu[i] = int.Parse(Console.ReadLine());
            }

            //resumen menu
            Console.WriteLine();
            Console.WriteLine("CARTA RESTAURANTE CASA CRISTI:" + "\r\n" + "El menu de hoy es el siguiente: " + "\r\n");

            for (int i = 0; i < platosMenu.Length; i++)
            {
                Console.WriteLine(" Plato " + (i+1) + ": " + platosMenu[i] + " Precio: " + precioPlatosMenu[i] + " EUR" + "\r\n");
            }

            Console.WriteLine();

            /*Una vez llenos los dos arrays tendremos que mostrarles y preguntar que se quiere para comer, guardaremos la información en una List usando un bucle
              while. (1 punto)
            Tendremos que preguntar si se quiere seguir pidiendo comida.Puede utilizar el sistema(1: Si / 0: No), por lo tanto deberá crear otro variable int
            para guardar la información. (1 punto) */

            Console.WriteLine("¿Qué platos desea elegir? " + "\r\n");
            
            List<string> election = new List<string>();

            string electionitem = "";
            bool seguir = true;
            string continuar;

            while (seguir)
            {
                Console.WriteLine("Introduce el nombre del plato");
                electionitem = Console.ReadLine();
                election.Add(electionitem);

                Console.WriteLine("¿Quiere algo más? 1: Si / 0: No");
                continuar = Console.ReadLine();
                if (continuar == "1")
                {
                    seguir = true;
                }
                else
                    seguir = false;
            }

            Console.WriteLine();
            Console.WriteLine("Los platos seleccionados son:");
            foreach (string s in election)
            {

                Console.WriteLine(s);
            }

            #endregion

            #region Fase3
            /*Una vez hemos acabado de pedir la comida, tendremos que comparar la lista con el array que hemos hecho al principio. En caso de que la información 
             que hemos introducido en la List coincida con la del array, tendremos que sumar el precio del producto solicitado; en el caso contrario tendremos que 
             mostrar un mensaje que diga que el producto que hemos pedido no existe.*/

            for (int i = 0; i < election.Count; i++)
            {
                bool control = false;
                var jfound = 0;
                for (int j = 0; j < platosMenu.Length; j++)
                {

                    if (election[i] == platosMenu[j])
                    {
                        control = true;
                        jfound = j;
                    }
                }

                if (control) 
                {
                    precioTotalMenu = precioTotalMenu + precioPlatosMenu[jfound];  
                }
                else
                {
                    Console.WriteLine("\r\n"+ election[i]+" no está en el menu");
                }

            }
            
            Console.WriteLine();
            Console.WriteLine("\r\n"+"El total a pagar es: " + precioTotalMenu + " EUR");

            #endregion

            #region Fase4
            //Una vez hecho esto se deberá calcular el precio de la comida el programa nos dirá con qué billetes debemos pagar.


            Console.WriteLine("Con que cantidad va a pagar? Introduzca el importe en EUR");
            int cash = int.Parse(Console.ReadLine());
            
            int devolver = (cash - precioTotalMenu);
            
            int [] cambio = new int[divisas.Length];

            Console.WriteLine("\r\n"+"Total factura en EUR: " + precioTotalMenu + "\r");
            Console.WriteLine("Importe entregado en EUR: " + cash + "\r");
            Console.WriteLine("Importe a devolver en EUR: " + devolver + "\r\n");
            
            do
            {
               
                for (var i = 0; i < divisas.Length; i++)
                {
                
                    // Si el importe actual, es superior a la moneda
                    if (devolver >= divisas[i])
                    {
                        // obtenemos cantidad de monedas
                        cambio[i] = devolver / divisas[i];

                        // actualizamos el valor del importe que nos queda por didivir
                        devolver = (devolver - (cambio[i] * divisas[i]));
                    }
                    
                }
                
            } while (devolver > 0);
            Console.WriteLine();
           

            for (int i = 0; i < divisas.Length; i++)
            {
                if (cambio[i] != 0)
                {
                    Console.WriteLine("La cantidad en billetes de " + divisas[i] + " euros es: " + cambio[i] + "\n");
                }
            }

            #endregion
            
            Console.ReadLine();



        }
    }
}
