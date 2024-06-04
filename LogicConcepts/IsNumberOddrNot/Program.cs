using System.ComponentModel.Design;

var NumberString = String.Empty;

do
{ 
    Console.WriteLine("Ingrese numero  entero para validar o presione 'S' para salir ");

    NumberString = Console.ReadLine();

    if(NumberString! .ToLower() == "s")
    {
        continue;
    }

    var NumberInt = 0;

if  (int.TryParse(NumberString, out NumberInt))
{
        if ((NumberInt % 2 == 0))
        {
        }
        else
        {
            Console.WriteLine($"El {NumberInt} no es par.");
        }
 }

else
    {
 Console.WriteLine($" ¡El valor que ingresastes:{NumberString}, no es valido!");
    }
} while (NumberString != "s");

Console.WriteLine("El programa ha finalizado");