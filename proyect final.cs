using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proyectofinal
{
    class Program
    {
        public static void Main()
        {
            bool cc = false;
            string nombre = "";
            int pin = 0;
            int balance = 0;

            string[,] user = new string[5, 3] { {"luis", "1234", "4321"}, {"juan", "5678", "8765"}, {"pedro", "7890", "0987"}, {"maria", "3574", "4753"}, {"juana", "4789", "9874" } };


            Console.WriteLine("                                   Bienvenido a tu cajero preferido                            ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                          ****** digite su usuario por favor  para poder usar el cajero******                                                         ");
            nombre = Print("Ingrese tu usuario: ");

            Console.Clear();
            try
            {
                Console.Write(nombre + " digite su pin ");
                pin = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception er)
            {
                Console.WriteLine("El pin debe ser un numero");
                Console.ReadKey();
            }
            
            Console.Clear();

            for (int fila = 0; fila < 5; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (user[fila, col] == nombre && user[fila, col + 1] == pin.ToString())
                    {
                        Console.WriteLine($"Bienvenido {nombre}");
                        cc = true;
                        break;
                    }
                    else if (user[fila, col] == nombre && user[fila, col + 2] == pin.ToString()) /* validar si datos que ingreso el usuario estan registrados*/
                    {
                        Console.WriteLine("el cajero no funciona ya van en camino  (para arreglarlo )");
                        break;
                        cc = true;
                        
                        
                        break;
                    }
                    
                }
                if (cc)
                    break;
            }
            if(cc == false)
            {
                Console.WriteLine("incorrecto");
                Console.ReadKey();
                Console.Clear();
                Main();
            }

            //Console.WriteLine();
            //funciones();
            //Console.Clear();
            while (cc)
            {
                int procesos = 0;
                try
                {
                    
                    Console.WriteLine("Elige una opcion que quieras realizar  ");

                    Console.WriteLine("Pulse [1] para retiro de efectivo ");
                    Console.WriteLine("Pulse [2] para depositos  ");
                    Console.WriteLine("Pulse [3] para consultar balance ");
                    Console.WriteLine("pulse [4] si desea salir de el cajero");
                    procesos = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception er)
                {
                    Console.WriteLine("Debes ingresar una opcion");
                    Console.ReadKey();
                    Console.Clear();
                }
                



                switch  (procesos)
                {
                    case 1:
                        //balance = 50000;
                        Console.Clear();

                        Console.WriteLine("cuanto dinero desea retirar de su cuenta  ");
                        int retiro = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        balance = balance - retiro;

                        if (retiro > balance)
                        {

                            Console.WriteLine("Este retiro no puede ser realizado porque no posee ese dinero en la cuenta");
                            Console.WriteLine("");
                            string cont1 = "";
                            Console.WriteLine("¿Desea hacer otro proceso bancario? si/no");
                            cont1 = Console.ReadLine();
                            if (cont1 == "si")
                            {
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                //funciones();
                            }
                            else
                            {
                                Console.WriteLine("Cerrando cajero...");
                                Console.WriteLine("presione enter para cerrar");
                                Console.ReadKey();
                                cc = false;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("En su tarjeta de credito ahora le quedan " + balance + " pesos ");
                            Console.WriteLine("presione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("saludos y bienvenido es para informarle que a realizado un retiro de " + retiro + " y ahora en su cuenta le quedan " + balance + " pesos");
                            Console.WriteLine("presione enter para continuar");
                            Console.ReadKey();

                            string cont1 = "";
                            Console.WriteLine("¿Desea hacer otro proceso bancario? si/no");
                            cont1 = Console.ReadLine();
                            if (cont1 == "si")
                            {
                                Console.WriteLine("Presiona enter para continuar");
                                Console.ReadKey();
                                Console.Clear();
                                //funciones();
                            }
                            else
                            {
                                Console.WriteLine("Cerrando cajero...");
                                Console.WriteLine("presione enter para cerrar");
                                Console.ReadKey();
                                cc = false;
                            }
                            Console.ReadKey();
                        }

                        break;

                    case 2:
                       int dinero = 0;
                        Console.Clear();
                        Console.WriteLine("cuanto dinero desea depositar en su cuenta ");
                        dinero = int.Parse(Console.ReadLine());
                        Console.Clear();
                        balance = balance + dinero;
                        Console.WriteLine("Ahora en su cuenta pose " + balance  + " pesos ");
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("saludos y bienvenido es para informarle que a realizado un deposito de " + balance + " pesos y ahora en su cuenta posee " + balance + " pesos");
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        string cont2 = "";
                        Console.WriteLine("¿¿Desea hacer otro proceso bancario? si/no");
                        cont2 = Console.ReadLine();
                        Console.Clear();
                        if (cont2 == "si")
                        {
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            //funciones();
                        }
                        else
                        {
                            Console.WriteLine("Cerrando cajero...");
                            Console.WriteLine("presione enter para cerrar");
                            Console.ReadKey();
                            cc = false;
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        //balance = 50000;
                        Console.Clear();
                        Console.WriteLine("su balance es de " + balance + " pesos ");
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("saludos y bienvenido es para informarle que usted a entrado a su cuenta para revisar su balance ");
                        Console.WriteLine("presione enter para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        string cont3 = "";
                        Console.WriteLine("¿¿Desea hacer otro proceso bancario? si/no");
                        cont3 = Console.ReadLine();
                        Console.Clear();
                        if (cont3 == "si")
                        {
                            Console.WriteLine("Presiona enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            //funciones();
                        }
                        else
                        {
                            Console.WriteLine("Cerrando cajero...");
                            Console.WriteLine("presione enter para cerrar");
                            Console.ReadKey();
                            cc = false;
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("bye gracias por pertenecer a nuestra familia bancaria y usar nuestro servicio");
                        Console.WriteLine("presione enter ");
                        Console.ReadKey();
                        cc = false;
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;



                }
            }
        }

        public static string Print(string msg)
        {
            Console.Write(msg);
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.Write("No puedes dejar el nombre vacio");
                Console.ReadKey();
                Console.Clear();
                Print(msg);
            }
            else
            {
                return name;
            }
            return name;
        }
  
       
    }

}
