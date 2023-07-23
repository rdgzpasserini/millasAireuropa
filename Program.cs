using System;


namespace AirEuropa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            int opc;
            bool exit = false;

            do {


                Console.WriteLine("\tMENU");
                Console.WriteLine();
                Console.WriteLine("1. Cash & Miles ");
                Console.WriteLine("2. Cheque regalo Amazon");
                Console.WriteLine("3. Tarjetas regalo - Halcon viajes & Viajes Ecuador ");
                Console.WriteLine("4. NH Hotel Group - Millas por noche en habitacion");
                Console.WriteLine("5. Europcar - Millas por alquiler de vehiculo");
                Console.WriteLine("6. Salir");
                Console.WriteLine();
                Console.Write("X. Elige una opción: ");


                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        // condigo opcion
                        Console.WriteLine("Cash & Miles");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Introduce la cantidad de millas que tienes:");
                        Console.Write("Millas: ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Tus millas equivalen a: " + (int)Millas(x) + "EUR");
                        Console.ReadKey();
                        break;
                    case 2:
                        // condigo opcion 
                        Console.Write("Introduce la cantidad de millas que tienes: ");

                        int totalMillas = int.Parse(Console.ReadLine());

                        int millas = totalMillas;

                        (int total, int millasRestantes) = Bonos(millas);

                        Console.WriteLine("el total de cheque regalo Amazon es: " + total + "EUR");
                        Console.WriteLine("El resto de millas es: " + millasRestantes);
                        Console.ReadKey();


                        break;
                    case 3:
                        // condigo opcion
                        Console.Write("Introduce la cantidad de millas que tienes: ");

                        int puntos = int.Parse(Console.ReadLine());

                        (int tot, int puntosRestantes) = Bonos(puntos);

                        Console.WriteLine("el total de cheque regalo es: " + tot + "EUR");
                        Console.WriteLine("El resto de millas es: " + puntosRestantes);
                        Console.ReadKey();

                        break;
                    case 4:
                        // condigo opcion
                        Console.Write("Introduce la cantidad de millas que tienes: ");
                        int alfa = int.Parse(Console.ReadLine());
                        int collectionB = NH1(alfa);
                        int collectionP = NH2(alfa);
                        int hotels4B = NH3(alfa);
                        int hotels4P = NH4(alfa);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("NH Collection \tTarifa Básica --> " + collectionB + " noches ");
                        Console.WriteLine();
                        Console.WriteLine("NH Collection \tTarifa Promocional --> " + collectionP + " noches ");
                        Console.WriteLine();
                        Console.WriteLine("NH Hotels 4*  \tTarifa Básica --> " + hotels4B + " noches ");
                        Console.WriteLine();
                        Console.WriteLine("NH Hotels 4*  \tTarifa Promocional --> " + hotels4P + " noches ");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine();


                        break;
                    case 5:
                        // condigo opcion 
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Saliendo del programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                }


            } while (opc != 6);
        }

        static double Millas(double x)
        {
            return (x / 1500) * 5;
        }

        static (int, int) Bonos(int millas)

        {

            int cheque60 = 0;

            while (millas >= 13200)
            {
                cheque60++;
                millas -= 13200;
            }

            int cheque40 = 0;

            while (millas >= 8800)
            {
                cheque40++;
                millas -= 8800;
            }

            int cheque20 = 0;

            while (millas >= 4400)
            {
                cheque20++;
                millas -= 4400;
            }

            int total = cheque60 * 60 + cheque40 * 40 + cheque20 * 20;

            return (total, millas);

        }

        static int NH1 (int miles) 
        {

            int collectionB = 0;
            //int hotels4 = 0;
            //int collectionP = 0;

            while (miles >= 35000) 
            {
                collectionB++;
                miles -= 35000;
            }
            return collectionB;
        }

        static int NH2(int miles)
        {
            int collectionP = 0;
            //int hotels4 = 0;
            //int collectionP = 0;

            while (miles >= 25000)
            {
                collectionP++;
                miles -= 25000;

                //hotels4++;
                //miles -= 26000;

                //collectionP++;
                //miles -= 25000;

            }
            return collectionP;
        }

        static int NH3(int miles) 
        {
            int hotels4B = 0;

            while (miles >= 26000)
            {
                hotels4B++;
                miles -= 26000;
            }
            return hotels4B;
        }

        static int NH4(int miles)
        {
            int hotels4P = 0;

            while (miles >= 17000)
            {
                hotels4P++;
                miles -= 17000;
            }
            return hotels4P;
        }








    }
}
