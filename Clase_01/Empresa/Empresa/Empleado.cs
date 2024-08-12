using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa;

public class Empleado : Persona
{
   

    public override string mostrarInformacion()
    {
        return this.nombre + " - " + this.apellido;
    }
}
