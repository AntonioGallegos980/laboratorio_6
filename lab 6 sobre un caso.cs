using System;

class Program
{
    static int max = 0;
    static int actuales = 0;
    static int pingresaron = 0;
    static int psalieron = 0;
    static int vLleno = 0;
    static int vVacio = 0;

    static void Main()
    {
        Ejercicio01();
    }

    static void Ejercicio01()
    {
        Console.Write("Ingrese un número máximo de personas:");
        max = int.Parse(Console.ReadLine());
        Console.WriteLine("========================================");
        Console.WriteLine("El número máximo establecido es de " + max + " personas, presione una tecla para comenzar a contar");
        Console.ReadKey();
        Console.Clear();

        Ejercicio02y03();
    }

    static void Ejercicio02y03()
    {
        char opcion;
        do
        {
            Console.WriteLine("=================================");
            Console.WriteLine("| Asistentes actuales | " + actuales);
            Console.WriteLine($"| Aforo | {((double)actuales / max * 100):0.0}%");
            Console.WriteLine($"| Máximo | " + max + "personas");
            Console.WriteLine("====================================");
            Console.WriteLine("Presione");
            Console.WriteLine("[ i ] si ingresa una persona");
            Console.WriteLine("[ s ] si sale una persona");
            Console.WriteLine("[ x ] para terminar");
            opcion = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (opcion)
            {
                case 'i':
                    if (actuales < max)
                    {
                        actuales++;
                        pingresaron++;
                    }
                    break;
                case 's':
                    if (actuales > 0)
                    {
                        actuales--;
                        psalieron++;
                    }
                    break;
                case 'x':
                    Ejercicio04();
                    return;
            }
            if (actuales == max)
            {
                vLleno++;
            }
            if (actuales == 0)
            {
                vVacio++;
            }
        } while (true);
    }

    static void Ejercicio04()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("El programa ha terminado");
        Console.WriteLine("====================================");
        Console.WriteLine("Estadísticas:");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("" + pingresaron + " personas ingresaron");
        Console.WriteLine("" + psalieron + " personas salieron");
        Console.WriteLine("" + vLleno + " veces se llenó el local");
        Console.WriteLine("Estuvo vacío " + vVacio + " veces");
        Console.ReadKey();
    }
}
