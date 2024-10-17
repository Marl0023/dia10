using problema1;
using System.Diagnostics.CodeAnalysis;
int valor;
char opcion;
Random rnd = new Random();
Funciones fun = new Funciones();
do
{

    do
    {
        Console.Write("Se va a generar aleatoriamente N numero de valores, ingrese cuantos desea: ");
    } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);
    Console.WriteLine("\nLista aleatoria");
    for (int i = 0; i < valor; i++)
    {
        int aleatorio = rnd.Next(-20, 21);
        Console.WriteLine("\n" + aleatorio);
        if (aleatorio > 0)
        {
            fun.positivos();
        }
        else if (aleatorio < 0)
        {
            fun.negativos();
        }
    }
    Console.WriteLine("\n #Numeros Negativos:  " + fun.negativos());
    Console.WriteLine("#Numeros Positivos: " + fun.positivos());
    do
    {
        Console.Write("\n Desea volver a intentar? (s/n) : ");
        opcion = char.ToLower(Console.ReadKey().KeyChar);
    } while (opcion != 's' && opcion != 'n');
    fun.reset();
    Console.Clear();
} while (opcion == 's');
Console.WriteLine("Graciela :v ");