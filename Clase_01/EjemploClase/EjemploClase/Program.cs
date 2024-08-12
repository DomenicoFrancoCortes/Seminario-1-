using EjemploClase;

Cliente cliente = new Cliente { Nombre = "Juan", Apellido = "Pérez", Edad = 30, NumeroCliente = "C12345" };
Empleado empleado = new Empleado { Nombre = "Ana", Apellido = "Gómez", Edad = 28, NumeroEmpleado = "E67890" };

// Mostrar la información de ambos.
cliente.MostrarInformacion();
Console.WriteLine(); // Espacio entre la información del cliente y del empleado.
empleado.MostrarInformacion();

IGenerarReporte trabajador = new Empleado();
trabajador.GenerarReporte();

Gerente gerente = new Gerente();
gerente.GenerarReporte();