string cadena1 = "Oscar";
string cadena2 = "Felipe";
string cadena3 = "Alexis";
string cadena4 = "Gary";

string[] cadenas = new string[4];
cadenas[0] = cadena1;
cadenas[1] = cadena2;
cadenas[2] = cadena3;
cadenas[3] = cadena4;
Console.WriteLine("=== ARREGLOS EN C# ===\n");
Console.WriteLine("1. Declaración y Asignación de Arreglos:");
foreach (string nombre in cadenas)
{
    Console.WriteLine($"   {nombre}");
}

Console.WriteLine("\n2. Acceso a Elementos por lista");
List<string> listaNombres = new List<string>(cadenas);
Console.WriteLine("   Lista de nombres:");
for (int i = 0; i < listaNombres.Count; i++)
{
    Console.WriteLine($"   {i + 1}. {listaNombres[i]}");
}
Console.WriteLine("\n3. Modificación de Elementos:");
listaNombres[2] = "Alex";
Console.WriteLine($"   Modificado: {listaNombres[2]}");
Console.WriteLine("\n4. Recorrido de Arreglo con foreach:");
foreach (string nombre in listaNombres)
{
    Console.WriteLine($"   {nombre}");
}
Console.WriteLine("\n5. Recorrido de Arreglo con for:");
for (int i = 0; i < listaNombres.Count; i++)
{
    Console.WriteLine($"   {i + 1}. {listaNombres[i]}");
}
Console.WriteLine("\n6. Recorrido de Arreglo con while:");
int index = 0;
while (index < listaNombres.Count)
{
    Console.WriteLine($"   {index + 1}. {listaNombres[index]}");
    index++;
}
Console.WriteLine("\n7. Recorrido de Arreglo con do-while:");
index = 0;
do
{
    Console.WriteLine($"   {index + 1}. {listaNombres[index]}");
    index++;
} while (index < listaNombres.Count);
Console.WriteLine("\n8. Búsqueda de Elementos:");
string buscarNombre = "Alex";
int encontradoIndex = listaNombres.IndexOf(buscarNombre);
if (encontradoIndex != -1)
{
    Console.WriteLine($"   Nombre '{buscarNombre}' encontrado en el índice {encontradoIndex}.");
}
else
{
    Console.WriteLine($"   Nombre '{buscarNombre}' no encontrado.");
}
Console.WriteLine("\n9. Eliminación de Elementos:");
listaNombres.Remove("Gary");
Console.WriteLine("   Nombre 'Gary' eliminado.");
Console.WriteLine("   Lista actualizada:");