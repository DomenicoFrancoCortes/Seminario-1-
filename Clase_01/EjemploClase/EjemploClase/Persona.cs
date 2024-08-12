using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    // Método común para mostrar la información de la persona.
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
    }
}
