using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase;

internal class Empleado: Persona, IGenerarReporte
{
    public string NumeroEmpleado { get; set; }

    public void GenerarReporte()
    {
        Console.WriteLine("Generando reporte...");
    }

    // Sobrescribir el método para agregar información específica del empleado.
    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); // Llamar al método de la clase base.
        Console.WriteLine($"Número de Empleado: {NumeroEmpleado}");
    }
}
