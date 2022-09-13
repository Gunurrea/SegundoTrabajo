using trabajo.Classes;

bool condicion = true;
string nombingre;
int cantingre;
float precio;

Pastel pastel = new Pastel();

while (condicion)
{
    Console.WriteLine("\nPorfavor ingrese el nombre del Pastel (1)"); 
    Console.WriteLine("Porfavor ingrese un ingrediente (2)"); 
    Console.WriteLine("Listar ingredientes (3)");
    Console.WriteLine("Calcular la cantidad de ingredientes(4)");
    Console.WriteLine("Calcular el costo(5)");
    Console.WriteLine("SALIR (6)");

    int menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine("\nNOMBRE DEL PASTEL: ");      
            pastel.nombre = (Console.ReadLine()).ToUpper();
            break;

        case 2:
        
            Console.WriteLine("\nPorfavor ingrese el nombre del ingrediente"); 
            nombingre= (Console.ReadLine()).ToUpper();
            Console.WriteLine("\nPorfavor ingrese la Cantidad"); 
            cantingre = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPorfavor ingrese el precio del ingrediente"); 
            precio= float.Parse(Console.ReadLine());
            pastel.AgregarIngrediente(nombingre,cantingre,precio);
            break; 

        case 3:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("INGREDIENTES: ");         
            pastel.ListarIngredientes();
            break; 

        case 4:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("CANTIDAD DE INGREDIENTES: "); 
            Console.WriteLine(pastel.CantidadIngredientes());
            break; 

        case 5:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("COSTO DEL PASTEL: "); 
            Console.WriteLine(pastel.CalcularCosto()); 
            break; 

        case 6:
        default: 
            condicion = false;
            break;
    }
}