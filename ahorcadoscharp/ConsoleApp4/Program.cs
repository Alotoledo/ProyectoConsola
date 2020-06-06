
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ahorcadoconsolascharp
{
    class Orcado//clase principal
    {
        static void Main(string [] args )//argumento en el  metodo main
        {
            //AQUI EMPIEZA EL PROGRAMA cambiamos las propiedades color de letra y de fondo 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //A LAS PALABRAS
            // 
            String[] palabra = new String[100]; //arreglo en el cual le asignamos una cantidad
                                                 // Palabra que esta adentro de cada arreglo          
            palabra[1] = "edificio";
            palabra[2] = "casa";
            palabra[3] = "parque";
            palabra[4] = "carro";
            palabra[5] = "restaurant";
            palabra[6] = "plaza";
            palabra[7] = "semaforo";
            palabra[8] = "señalamiento";
            palabra[9] = "perro";
            palabra[10] = "museos";
            palabra[11] = "transporte";
            palabra[12] = "biblioteca";
            palabra[13] = "auditorio";
           

            Random objeto = new Random();//objeto de la clase random clase local random objeto
           //declaramos   variables i,na(numero del 1,13 de arreglo ),tl(cantidad de letras de la palabra)
            int i = 0, na = 0, tl = 0;   


            String palabra2 = "", palabra3 = "", le = "", lp = ""; 

            na = objeto.Next(1, 13); //na = numero de arreglo
            palabra2 = palabra[na];
            tl = palabra2.Length;
            Console.WriteLine(" El numero aletorio es " + na);
            Console.WriteLine("\n La palabra clave es : Cuidad " );
            //AQUI TE MUESTRA LA PALABRA ALEATORIA
            Console.WriteLine("\nY tiene " + tl + " letras");


            //este ciclo for es para poner los signos ? o espacio
            for (i = 1; i <= tl; i++)
            {
                if (palabra2.Substring(i, 0) != " ")
                    palabra3 = palabra3 + "?";
                else
                    palabra3 = palabra3 + " ";

            }


            Console.WriteLine(palabra3);


            //aqui empiezas a adivinar la palabra presionando teclas

            //declaramos variable intento 
            int intento = 0;


            do
            {
               
               //metodo
                Boolean exito = false;
                Console.Write("Presione una letra ");
                lp = Console.ReadLine();
                for (i = 0; i <= tl - 1; i++) //empieza CICLO 

                {

                    le = palabra2.Substring(i, 1);
                    if (le.Equals(lp))//instruccion
                    {

                        palabra3 = palabra3.Remove(i, 1);
                        palabra3 = palabra3.Insert(i, lp);
                        exito = true;

                    }

                }

                if (exito) //las variables booleanas solo van solar//ciclo en el cual  si te equivocas te da un msj 
     //si agotas los 5 intentos da msj que perdiste 
                {
                    Console.WriteLine("Palabra oculta = " + palabra3);
                }
                else
                {
                    intento++;
                    Console.WriteLine("Letra no existente lleva " +
                        intento + " intento");
                }

                if (intento == 5)
                {
                    Console.WriteLine("Intentos agotados, !!!!! PERDISTE !!!! ");
                    Console.WriteLine("La palabra correcta era: "+"!!" +palabra2 +"!!");
                }
                if (palabra2 == palabra3)
                {
                    Console.WriteLine("Felicidades, !!!! GANASTE !!!!!!!!! ");
                    break;
                }


            }
            while (intento < 5);


            Console.ReadKey();//cierra

        }

    }
}
