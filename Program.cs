using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ejercicio 1
/*             for(int x = 0; x < 10; x++) {
                Console.WriteLine(x+1);
            }
 */
            //ejercicio 2
            /* int n, numeroMayor = 0;

            for(int x = 0; x < 10; x++) {

                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if(x == 0) {
                    numeroMayor = n;
                } else if(n > numeroMayor) {
                    numeroMayor = n;
                }

            }

            Console.WriteLine("El número mayor fue: " + numeroMayor); */

            //ejercicio 3
            /* int edad, acu = 0, contador = 0, promedio;

            for (int x = 0; x < 20; x++) {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18) {
                    acu += edad;
                    contador++;
                }
            }

            promedio = acu / contador;
            Console.WriteLine("El promedio de edad de las personas mayores a 18 fue: " + promedio); */

            //ejercicio 4
            /* int n, con = 0; 

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            for(int x = 1; x <= n; x++) {
                if(n % x == 0) {
                    con++;
                }
            }

            if(con == 2) {
                Console.WriteLine("Es primo");
            } else {
                Console.WriteLine("No es primo");
            }
 */

            //ejercicio 5
            int n, bp = 0, bi = 0, numeroMaximo = 0, numeroMinimo = 0;

            for(int x = 0; x < 20; x++) {
                Console.WriteLine("Ingrese un nro:");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0) {
                    if(bp == 0) {
                        numeroMaximo = n;
                        bp = 1;
                    } else {
                        if(n > numeroMaximo) {
                            numeroMaximo = n;
                        }
                    }
                } else {
                    if(bi == 0) {
                        numeroMinimo = n;
                        bi = 1;
                    } else {
                        if(n < numeroMinimo) {
                            numeroMinimo = n;
                        }
                    }
                }
            }

            Console.WriteLine("El número maximo par es: " + numeroMaximo + " y el número minimo impar es: " + numeroMinimo);

        }
    }
}
