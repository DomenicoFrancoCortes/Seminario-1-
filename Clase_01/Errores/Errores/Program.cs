//Manejo de errores
/*int dividendo, divisor;
double resultado;
try
{

    Console.WriteLine("Ingrese el dividendo: ");
    dividendo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor");
    divisor = int.Parse(Console.ReadLine());
    Console.WriteLine($"El resultado es {resultado = dividendo / divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No puede dividir entre 0");
}
finally
{
    Console.WriteLine("Se ejecuto el primer finally");
}*/






/*-----------------------------------------------------------------------------*/



/*
try
{
    Console.WriteLine("Ingrese el dividendo: ");
    dividendo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor");
    divisor = int.Parse(Console.ReadLine());

    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    resultado = dividendo / (double)divisor;
    Console.WriteLine($"El resultado es {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No puede dividir entre 0");
}
finally
{
    Console.WriteLine("Se ejecuto el segundo finally");
}*/
/*-----------------------------------------------------------------------------*/

int numero = -1;
do
{
    try
    {
        Console.Write("Por favor, ingrese un número entero (0 para finalizar): ");
        string input = Console.ReadLine();

        // Intentamos convertir la entrada del usuario a un número entero
        numero = int.Parse(input);

        Console.WriteLine($"El número ingresado es: {numero}");
    }
    catch (FormatException ex)
    {
        // Capturamos el error si la entrada no es un número entero válido
        Console.WriteLine("Error: La entrada no es un número entero válido.");
        Console.WriteLine($"Detalles del error: {ex.Message}");
    }
    catch (Exception ex)
    {
        // Capturamos cualquier otro tipo de excepción inesperada
        Console.WriteLine("Ocurrió un error inesperado.");
        Console.WriteLine($"Detalles del error: {ex.Message}");
    }
    finally
    {
        // Código que siempre se ejecuta, independientemente de si hubo o no una excepción
        Console.WriteLine("Finalizando el intento actual.");
    }
} while (numero != 0);
    Console.WriteLine("Programa finalizado");


