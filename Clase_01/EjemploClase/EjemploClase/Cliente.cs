using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase;

internal class Cliente: Persona
{
    public string NumeroCliente { get; set; }

    // Sobrescribir el método para agregar información específica del cliente.
    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); // Llamar al método de la clase base.
        Console.WriteLine($"Número de Cliente: {NumeroCliente}");
    }
}
