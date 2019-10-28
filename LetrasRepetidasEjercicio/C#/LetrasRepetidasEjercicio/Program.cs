using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasRepetidasEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /*FASE 1
            Crea una array de caracteres(char[]) con tu nombre donde cada posición corresponda a una letra.
            Haz un bucle que recorra este array ii muestre por consola cada una de las letras.*/

            Console.WriteLine("Fase 1");

            char[] name = { 'C', 'R', 'I', 'S', 'T', 'I', 'N', 'A' };

            foreach (char value in name)
            {

                Console.WriteLine(value);

            }


            /*FASE 2
            Cambia el array por una lista (List <char>)
            Al bucle, si la letra es una vocal imprime en la consola: 'VOCAL'. Sino, imprime: 'CONSONTANT'.
            Si encuentras un numero, muestra por pantalla: 'Los nombres de personas no contienen números!'.*/

            Console.WriteLine();
            Console.WriteLine("Fase 2");

            List<char> listCharacters = name.ToList<char>();



            foreach (char value in listCharacters)
            {

                if (int.TryParse(value.ToString(), out int i))

                    Console.WriteLine(value + " Es un numero y los nombres de personas no contienen números");


                else
                {

                    char element = Char.ToLower(value);
                    if (element == 'a' || element == 'e' || element == 'i' || element == 'o' || element == 'u')
                        Console.WriteLine(value + " es vocal");

                    else
                        Console.WriteLine(value + " es consonante");
                }

            }


            /*FASE 3
            Almacenar en un Dictionary tanto las letras de la lista como el número de veces que aparecen*/

            Console.WriteLine();

            Console.WriteLine("Fase 3");
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < name.Length; i++)
            {
                char caracter = name[i];
                int countcaracter = 0;


                if (!dictionary.ContainsKey(caracter))
                {

                    for (int j = 0; j < name.Length; j++)
                    {

                        if (name[j] == caracter)
                        {
                            countcaracter++;
                        }

                    }

                    dictionary.Add(caracter, countcaracter);
                }

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            /*FASE 4
             Crea otra lista con tu apellido donde cada posición corresponda a una letra.

             Combinar las dos listas en una sola.Además, añade una posición con un espacio vacío entre la primera y la segunda.
             Es decir, partimos de la lista name y surname y al terminar la ejecución sólo tendremos una que se llamará fullname.

             Fullname: [ 'N', 'A', 'M', 'E', '', 'S', 'U', 'R', 'N', 'A', 'M', 'E']*/

            Console.WriteLine();
            Console.WriteLine("Fase 4");

            List<Char> mylistSurname = new List<char> { 'F', 'E', 'R', 'N', 'A', 'N', 'D', 'E', 'Z' };


            List<Char> targetList = listCharacters.Concat(" ").Concat(mylistSurname).ToList();

            foreach (char dimequesi in targetList)

            {
                Console.WriteLine(dimequesi);

            }


            Console.ReadKey();

        }
    }
}
