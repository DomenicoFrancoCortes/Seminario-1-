// Inyección de dependencia
using EjemploInterfaces;

IArchivo archivo = new AWS();
API api = new API(archivo);
api.SubirImagen("base:123445");
