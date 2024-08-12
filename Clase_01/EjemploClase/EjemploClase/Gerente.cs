using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase;

internal class Gerente : Persona, IGenerarReporte
{
    public void GenerarReporte()
    {
        Console.WriteLine("Gerente generando reporte");
    }
}
