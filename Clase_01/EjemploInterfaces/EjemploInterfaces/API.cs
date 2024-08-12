using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces;

internal class API
{
    IArchivo archivo;
    public API(IArchivo archivo)
    {
        this.archivo = archivo;
    }
    public void SubirImagen(string base64)
    {
        archivo.SubirArchivo(base64);
    }
}
