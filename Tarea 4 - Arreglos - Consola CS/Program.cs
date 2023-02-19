using System.Globalization;
using Tarea_2___Segundo_Semestre;

int cantidadContactos = 0;
int siguienteIndex = 0;
Contacto[] contactos;
List<Contacto> contactoList;
contactoList= new List<Contacto>();

while (cantidadContactos == 0)
{
    try
    {
        Console.WriteLine("Cuantos contactos deseas agregar?");
        cantidadContactos = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("El formato no es correcto, ingrese números enteros únicamente, por favor.");
    }
}

contactos = new Contacto[cantidadContactos];
while (siguienteIndex < contactos.Length)
{
    Contacto nuevo = new Contacto();
    Console.WriteLine("Nombre: "); nuevo.Nombre = Console.ReadLine();Console.Clear();
    Console.WriteLine("Telefono: "); nuevo.Telefono = Console.ReadLine();Console.Clear();
    Console.WriteLine("Fecha de Nacimiento (dd/mm/aaaa): ");
    while (nuevo.FechaNacimiento == null)
    {
        try
        {
            nuevo.FechaNacimiento = DateTime.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("El formato de la fecha debe de ser dd/mm/aaaa.");
        }
    }Console.Clear();
    Console.WriteLine("Correo: "); nuevo.Correo = Console.ReadLine();Console.Clear();

    contactos[siguienteIndex] = nuevo;
    siguienteIndex++;
}

for (int i = 0; i < contactos.Length;i++)
{ 
    Console.WriteLine(contactos[i].ToString());
}

Console.WriteLine("La cantidad de contactos por agregar ha sido completada. Presiona cualquier tecla para cerrar el programa.");


