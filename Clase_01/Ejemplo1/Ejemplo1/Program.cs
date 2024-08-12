// vamos a crear una aplicación para el control de excepciones de entrada de datos
// vamos a leer un dato de tipo númérico y la vamos a someter a diferentes valores de entrrada

int numeroEntero = 0;
int salir = 1;
do
{
    try
    {
        Console.WriteLine("Ingrese un valor entero ");
        numeroEntero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese un valor igual de 0 para terminar");
        salir = Convert.ToInt32(Console.ReadLine());
#if DEBUG
        Console.WriteLine($"EJECUTO EN MODO DEBUG (Dentro del try)\nel valor de numeroEntero es:{numeroEntero}\nel valor de salir es:{salir}");
#endif
    }


    catch (FormatException objFE)
    {
        Console.WriteLine("Message");
        Console.WriteLine(objFE.Message);
        Console.WriteLine("InnerException");
        Console.WriteLine(objFE.InnerException);
        Console.WriteLine("Source");
        Console.WriteLine(objFE.Source);
        Console.WriteLine("StackTrace");
        Console.WriteLine(objFE.StackTrace);
        Console.WriteLine("TargetSite");
        Console.WriteLine(objFE.TargetSite);
    }

    catch (Exception objE)
    {
        Console.WriteLine("Message");
        Console.WriteLine(objE.Message);
        Console.WriteLine("InnerException");
        Console.WriteLine(objE.InnerException);
        Console.WriteLine("Source");
        Console.WriteLine(objE.Source);
        Console.WriteLine("StackTrace");
        Console.WriteLine(objE.StackTrace);
        Console.WriteLine("TargetSite");
        Console.WriteLine(objE.TargetSite);

        salir = 0;
        Console.WriteLine("FORZAMOS LA INTERRUPCIÓN DEL PROGRAMA");
    }
} while (salir != 0);