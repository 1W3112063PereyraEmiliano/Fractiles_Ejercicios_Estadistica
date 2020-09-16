using System;

namespace NetArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int porc = 0;
            float result = 0f;
            const int RES = 10;
            int[] numeros = new int[RES];
            numeros[0] = 1;
            numeros[1] = 3;
            numeros[2] = 4;
            numeros[3] = 4;
            numeros[4] = 5;
            numeros[5] = 5;
            numeros[6] = 6;
            numeros[7] = 7;
            numeros[8] = 8;
            numeros[9] = 8;

            Console.WriteLine("Decile de los siguientes numeros.");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int h = 0; h < 10000; h++)
            {
                for (int i = 0; i < RES; i++)
                {
                    Console.Write(numeros[i].ToString() + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Que Cuartil deseas buscar? [1-2-3]");
                do
                {
                    porc = int.Parse(Console.ReadLine());
                    if (porc > 3 || porc < 1)
                        Console.WriteLine("Digite Un Numero Correcto.");
                } while (porc > 3 || porc < 1);
                result = (porc * (RES+1))/4;
                if (result % 1 == 0)
                {
     
                    Console.WriteLine("Tu Decile es el Numero: {0}", numeros[Convert.ToInt32(result)]);
                    Console.WriteLine("Aproximadamente el {0}% de los numeros son menores o iguales a {1} mientras el restante {2}% son mayores o iguales a {3}",porc*25, numeros[Convert.ToInt32(result)], 100-porc*25, numeros[Convert.ToInt32(result)]);
                      
                }
                else
                {
                    int pos_ant = 0;
                    int pos_des = 0;
                    for (int R = 0; R < RES; R++)
                    {
                        if (Math.Round(result, 0) == numeros[R])
                        {
                            pos_ant = numeros[R];
                        }
                    }
                    pos_des = pos_des + 2;
                    result = pos_ant + pos_des / 2;
                    Console.WriteLine("Tu Decile es el Numero: {0}", numeros[Convert.ToInt32(result)]);
                }

                if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                }

            }

        }
    }
}
