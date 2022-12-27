using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //1 - Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica
            //guardar el valor de la suma de las 3 anteriores.Mostrar por consola.
            //
            //
            byte v1 = 5;
            short v2 = 6;   
            int v3 = 7;

            int res = v1 + v2 + v3;

            Console.WriteLine("Suma de v1 (" + v1 + "), v2(" + v2 + "), v3(" + v3 + ") = " + res);

            //
            //
            //2 - Pedir dos números al usuario por teclado y decir que número es el mayor.
            //
            //
            // Pedir el primer número al usuario
            Console.WriteLine("Ingresa el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Pedir el segundo número al usuario
            Console.WriteLine("Ingresa el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Comparar los números y mostrar el mayor por consola
            if (num1 > num2)
            {
                Console.WriteLine("El primer número es mayor.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El segundo número es mayor.");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }

            //
            //
            // 3 - Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo
            //
            //


            Console.WriteLine("Introduce el nombre del dia de la semana");
            string dia = Console.ReadLine();

            dia = dia.ToLower();

            // Comparar el nombre del día y mostrar el resultado por consola
            if (dia == "sábado" || dia == "domingo")
            {
                Console.WriteLine("Es fin de semana.");
            }
            else if (dia == "lunes" || dia == "martes" || dia == "miércoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("No es fin de semana.");
            }
            else
            {
                Console.WriteLine("El nombre del día ingresado es inválido.");
            }

            //
            //
            // 4- Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
            // si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).
            //
            //

            // Pedir el precio del producto al usuario
            Console.WriteLine("Ingresa el precio del producto:");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Validar que el precio sea positivo
            if (precio <= 0)
            {
                Console.WriteLine("El precio del producto debe ser mayor a 0.");
                return;
            }

            // Pedir la forma de pago al usuario
            Console.WriteLine("Ingresa la forma de pago (efectivo o tarjeta):");
            string formaPago = Console.ReadLine();

            // Convertir la forma de pago a minúsculas para compararla más fácilmente
            formaPago = formaPago.ToLower();

            // Si la forma de pago es mediante tarjeta, pedir el número de cuenta al usuario
            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Ingresa el número de cuenta:");
                string numCuenta = Console.ReadLine();
            }


            //
            //
            // 5 - Recorre los números del 1 al 100. Usa un bucle for.
            //
            //

            for(int i=1; i<101; i++)
            {
                Console.WriteLine(i);
            }

            //
            //
            // 6- Recorre los números del 1 al 100. Usa un bucle while.
            //
            //

            int i = 0;
            while(i < 100)
            {
                i++;
                Console.WriteLine(i);   
            }

            //
            //
            // 7- Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
            //
            //

            for(int j=1; j<101; j++)
            {
                if(j % 2 == 0)
                {
                    //es par 
                    Console.WriteLine(j);
                }
            }

            //
            //
            // 8- Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
            //
            //

            for (int j = 1; j < 101; j++)
            {
                if (j % 2 == 0 || j % 3 == 0)
                { 
                    Console.WriteLine(j);
                }
            }

            //
            //
            // 9- Crea un array e inserta los números pares del 1 al 100 en ese array.
            //
            //

            int[] npar = new int[50];
            int it = 0;
            for (int j = 2; j < 100; j+=2)
            {
                npar[it] = j;
                it++;
            }


            //
            //
            // 10- Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
            //
            //

            int[] n10 = new int[10];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Introduce numero " + i+1);
                n10[i] = Convert.ToInt32(Console.ReadLine());
            }

            int res10 = 0;
            foreach (var item in n10)
            {
                if(item % 2 == 0)
                {
                    res10 += item;
                }
                else
                {
                    res10 -= item;

                }
            }

            Console.WriteLine("El resultado es : "+ res10);

            //
            //
            // 11- Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana ,
            // teniendo en cuenta que el 1 es Lunes, hacer con un switch.
            //
            //

            Console.WriteLine("Introduce numero del 1 al 7");
            int in11 = Convert.ToInt32(Console.ReadLine());

            switch (in11)
            {
                case 1: Console.WriteLine("Lunes");
                    break;
                case 2: Console.WriteLine("Martes");
                    break;
                case 3: Console.WriteLine("Miercoles");
                    break;
                case 4: Console.WriteLine("Jueves");
                    break;
                case 5: Console.WriteLine("Viernes");
                    break;
                case 6: Console.WriteLine("Sabado");
                    break;
                case 7: Console.WriteLine("Domingo");
                    break;
            }

            //
            //
            // 12- Crea un programa que pida por consola un numero del 1 al 1000
            // (validara que el numero introducido es correcto) y sume todos los
            // números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.
            //
            //


            Console.WriteLine("Introduce un numero del 1 al 1000");
            int num12 = Convert.ToInt32(Console.ReadLine());
            int res12 = 0;
            if(num12 > 0 && num12 < 1001)
            {
                for(int i=0; i<=num12; i++)
                {
                    res12 += i;
                }

                Console.WriteLine("La suma es" + res12);
                Console.WriteLine("El promedio es" + res12/num12);

            }else
            {
                Console.WriteLine("Numero incorrcto");
            }


            //
            //
            // 13- Comprobar si un numero introducido por consola es primo
            //
            //





            //
            //
            // 14- Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).
            //
            //

            // Pedir el número al usuario
            Console.WriteLine("Ingresa un número entero positivo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Validar que el número sea positivo
            if (numero <= 0)
            {
                Console.WriteLine("El número debe ser positivo.");
                return;
            }

            // Contar cuántas cifras tiene el número
            int contador = 0;
            while (numero > 0)
            {
                numero /= 10;
                contador++;
            }

            // Mostrar el resultado por consola
            Console.WriteLine("El número tiene " + contador + " cifras.");

        }
    }
}
