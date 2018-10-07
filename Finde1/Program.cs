using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finde1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombre, carnetResp;
            //int edad, origen, dias, semanas;
            //bool carnet;
            //const int diasSem = 7, precioDia = 10;

            //Console.WriteLine("¿Cómo te llamas?");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Cliente " + nombre + "\n\n");

            //do
            //{
            //    Console.WriteLine("¿Qué edad tienes?");
            //    edad = Int32.Parse(Console.ReadLine());
            //    if (edad < 0 || edad > 100)
            //    {
            //        Console.WriteLine("Edad no válida, introduzca de nuevo");
            //    }
            //} while (edad < 0 || edad > 100);
            //Console.WriteLine("Cliente " + nombre + ", " + edad + " años" + "\n\n");
            //if (edad < 18 && edad > 0)
            //{
            //    Console.WriteLine("Eres menor de edad, no puedes alquilar un coche");
            //}
            //else
            //{
            //    Console.WriteLine("¿Tienes carnet de conducir?(S/N)");
            //    carnetResp = Console.ReadLine();
            //    if (carnetResp.ToUpper() == "S")//Toupper lleva unos parentesis al final
            //    {
            //        carnet = true;//damos valor al bool

            //    }
            //    else
            //    {
            //        carnet = false;

            //    }
            //    if (carnet)
            //    {
            //        Console.WriteLine("Cliente " + nombre + ", " + edad + " años" + ", con carnet de conducir" + "\n\n");
            //        Console.WriteLine("¿Dónde quieres recoger el coche?");
            //        Console.WriteLine("1- Bilbao");
            //        Console.WriteLine("2- Madrid");
            //        Console.WriteLine("3- Barcelona");
            //        Console.WriteLine("4- Santander");
            //        origen = Int32.Parse(Console.ReadLine());
            //        Console.Write("Vas a coger el coche en ");
            //        switch (origen)
            //        {
            //            case 1:
            //                Console.WriteLine("Bilbao");
            //                break;
            //            case 2:
            //                Console.WriteLine("Madrid");
            //                break;
            //            case 3:
            //                Console.WriteLine("Barcelona");
            //                break;
            //            case 4:
            //                Console.WriteLine("Santander");
            //                break;
            //            default:
            //                Console.WriteLine("\n\nRespuesta no válida");
            //                break;
            //        }
            //        Console.WriteLine("¿Cuántos días quieres el coche?");
            //        dias = Int32.Parse(Console.ReadLine());
            //        semanas = dias / diasSem;
            //        Console.Write(" Y alquilas el coche durante ");
            //        if (semanas > 0)
            //        {
            //            Console.Write(semanas + " semanas y ");
            //        }
            //        Console.Write(dias % 7 + " días");
            //        Console.WriteLine(" por un precio de " + (dias - semanas) * precioDia + " Euros.");//DESCUENTO POR SEMANA AQUI
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sin carnet no puedes alquilar un coche");
            //    }//LE DEJAS SIN PULIR                        
            //}



            string potatosChoice, drinkChoice;
            bool addPotatoes, largeDrink;
            int option1, cont1 = 0, cont2 = 0, menuOption, burgerOption, drinkOption;
            string[] menus =
                        {
                "Grand Big Boot",
                "Big Boot",
                "BootPollo",
                "Cuarto de libra",
                "BootRoyal Deluxe"
            };

            string[] burgers =
            {
                "Grand Big Boot",
                "Big Boot",
                "BootPollo",
                "Cuarto de libra",
                "BootRoyal Deluxe"
            };

            string[] drinks =
            {
                "CocaCola",
                "Fanta",
                "Agua",
                "Cerveza"
            };


            Console.WriteLine("BIENVENIDO AL BOOTDONALDS");
            do
            {
                if (cont1 > 0)
                {
                    Console.WriteLine("\n\nIntroduzca una respuesta válida por favor");
                }
                Console.WriteLine("\n\nElija entre estas opciones:\n1.-Pedir menú\n2.-Pedir hamburguesa\n3.-Pedir bebida\n4.-Salir");
                option1 = Int32.Parse(Console.ReadLine());
                cont1 = cont1 + 1;
            } while (option1 <= 0 || option1 > 4);
            Console.Write("\nHas elegido la opción ");
            switch (option1)
            {
                case 1:
                    Console.WriteLine("elegir menú");
                    do
                    {
                        if (cont2 > 0)
                        {
                            Console.WriteLine("Opción no válida.Elija otra opción");
                        }
                        for (int i = 0; i < menus.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "- " + menus[i]);
                        }
                        cont2 = cont2 + 1;
                        menuOption = Convert.ToInt32(Console.ReadLine());
                    } while (menuOption <= 0 || menuOption > 5);//Faltaria meter la opcion de salir en menuOption
                    Console.WriteLine("Aquí tienes tu menú " + menus[menuOption - 1]);
                    break;
                case 2:
                    Console.WriteLine("Elegir hamburguesa");
                    for (int i = 0; i < burgers.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "- " + burgers[i]);
                    }
                    burgerOption = Convert.ToInt32(Console.ReadLine());//podrias poner un do while para que elijan resp correcta

                    do
                    {
                        Console.Write("¿Quieres patatas con la hamburguesa? (S/N) : ");
                        potatosChoice = Console.ReadLine();
                    } while (potatosChoice.ToUpper() != "S" && potatosChoice.ToUpper() != "N");
                    //ESTO TIENE UN &&, MIENTRAS CUAQUIERA DE LAS DOS NO SEA S O N EL WHILE SERA TRUE Y SEGUIRA DANDO VUELTAS
                    if (potatosChoice.ToUpper() == "S")
                    {
                        addPotatoes = true;
                    }
                    else//PREGUNTAR POR QUE AQUI NO IF=N FALSE
                    {
                        addPotatoes = false;
                    }

                    Console.Write("Aquí tienes tu hamburguesa " + burgers[burgerOption - 1]);
                    if (addPotatoes)//porque no se pone ==true. Si quisieramos el caso falso seria !addPotatoes
                    {
                        Console.Write(" con ");
                    }
                    else
                    {
                        Console.Write(" sin ");
                    }
                    Console.WriteLine("patatas");

                    break;
                case 3:
                    Console.WriteLine("Elegir bebida");
                    for (int i = 0; i < drinks.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "- " + drinks[i]);
                    }
                    drinkOption = Convert.ToInt32(Console.ReadLine());//Podrias ponerlo en un do while mientras no elija correcto

                    do
                    {
                        Console.Write("¿Quieres bebida grande? (S/N) : ");
                        drinkChoice = Console.ReadLine();
                    } while (drinkChoice.ToUpper() != "S" && drinkChoice.ToUpper() != "N");
                    //ESTO TIENE UN &&, MIENTRAS CUAQUIERA DE LAS DOS NO SEA S O N EL WHILE SERA TRUE Y SEGUIRA DANDO VUELTAS
                    if (drinkChoice.ToUpper() == "S")
                    {
                        largeDrink = true;
                    }
                    else//PREGUNTAR POR QUE AQUI NO IF=N FALSE
                    {
                        largeDrink = false;
                    }

                    Console.Write("Aquí tienes tu bebida " + drinks[drinkOption - 1]);
                    if (largeDrink)
                    {
                        Console.Write(" grande");
                    }
                    else
                    {
                        Console.Write(" mediana");
                    }

                    break;
                case 4:
                    Console.WriteLine("salir");
                    break;//NO HACEN FALTA MAS OPCIONES PORQUE EN LA PRIMERA HAS OBLIGADO A ELEGIR BIEN

            }
            //TE FALTA PONER BUCLES EN LAS OPCIONES Y MENSAJES QUE SALTEN AL DE UNA VUELTA




            Console.ReadLine();
            
        }
    }
}
