
List<string> nombre = new List<string>();// Crear una lista de nombres
// Agregar nombres a la lista
nombre.Add("Alex");
nombre.Add("Gary");
nombre.Add("Marta");
nombre.Add("Sofía");

switch (nombre[0])// Cambia el índice para probar con otros nombres
{
    case "Alex":
        Console.WriteLine("Hola Alex, ¿cómo estás?");
        break;
    case "Gary":
        Console.WriteLine("Hola Gary, ¿cómo va todo?");
        break;
    case "Marta":
        Console.WriteLine("Hola Marta, ¿qué tal tu día?");
        break;
    case "Sofía":
        Console.WriteLine("Hola Sofía, ¿cómo te encuentras?");
        break;
    default:
        Console.WriteLine("Hola, no te reconozco.");
        break;
}