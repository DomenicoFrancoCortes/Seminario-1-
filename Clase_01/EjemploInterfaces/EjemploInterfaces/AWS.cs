using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces;

internal class AWS : IArchivo
{
    public bool SubirArchivo(string base64)
    {
        Console.WriteLine("Subiendo archivo a los servidores de AWS");
        return true;
    }
}
