using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Calculadora {
    static void Main(string[] args) {
                 //Le pongo un titulo a la ventana 
                   Console.Title = "Calculadora básica"; 
                string resp = "";
              do
                {
                    // primer valor ingresado
                int valor1 = 0;
                    //segundo valor ingresado
                int valor2 = 0; 
                  // Resultado de la operación
                int R = 0; 

               //muestro el menú de selección 
                Console.WriteLine("Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("Eliga Una Opcion: ");
                // El string antes de que se ejecute el ciclo se almacena en esta variable
                resp = Console.ReadLine();
                // realizo la conversión de la respuesta en string
                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("Ingrese sus dos numeros");
                Console.Write("Valor1: ");
                //Convertimos la cadena en valor númerico
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                // se agrega la ocndicional
                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        //dentro del WriteLine deseamos observar la operación con los valores ingresados
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                }
                //Se vuelve a preguntar en caso de que se desee continuar o no 
                Console.Write("¿Desea Continuar? s/n: "); 
                resp = Console.ReadLine();
            }
            //La condicional para que se repita el proceso en caso de que se desee continuar con las operaciones
            while (resp == "s" || resp == "s");
        }

    }

