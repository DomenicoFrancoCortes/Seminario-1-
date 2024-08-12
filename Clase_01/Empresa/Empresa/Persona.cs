using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa;

public abstract class Persona
{
    public  string nombre { get; set; }
    public string apellido { get; set; }

   
    public abstract string mostrarInformacion();
}
