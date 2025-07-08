// ============================================================================
// DIFERENCIAS ENTRE ARREGLOS Y LISTAS EN .NET C# - GUÍA COMPLETA
// ============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("📊 ARREGLOS VS LISTAS EN .NET C#");
Console.WriteLine("=".PadRight(50, '='));
Console.ResetColor();

// ============================================================================
// 1. DEFINICIÓN Y DECLARACIÓN BÁSICA
// ============================================================================

Console.WriteLine("\n📋 1. DEFINICIÓN Y DECLARACIÓN BÁSICA");
Console.WriteLine("-".PadRight(45, '-'));

Console.WriteLine("🔹 ARREGLOS (Arrays):");
Console.WriteLine("   • Tamaño FIJO definido en tiempo de compilación");
Console.WriteLine("   • Almacenados en memoria contigua");
Console.WriteLine("   • Mejor rendimiento para acceso por índice");
Console.WriteLine("   • Tipo: int[], string[], etc.");

Console.WriteLine("\n🔸 LISTAS (Lists):");
Console.WriteLine("   • Tamaño DINÁMICO que puede cambiar en tiempo de ejecución");
Console.WriteLine("   • Implementan IList<T> y ICollection<T>");
Console.WriteLine("   • Más funcionalidades incorporadas");
Console.WriteLine("   • Tipo: List<int>, List<string>, etc.");

// ============================================================================
// 2. DECLARACIÓN E INICIALIZACIÓN
// ============================================================================

Console.WriteLine("\n📋 2. DECLARACIÓN E INICIALIZACIÓN");
Console.WriteLine("-".PadRight(45, '-'));

Console.WriteLine("🔹 ARREGLOS - Diferentes formas de declarar:");

// Forma 1: Declaración con tamaño fijo
int[] numerosArray1 = new int[5]; // Array de 5 elementos (todos inicializados en 0)
Console.WriteLine($"   Array vacío[5]: [{string.Join(", ", numerosArray1)}]");

// Forma 2: Declaración con inicialización
int[] numerosArray2 = new int[] { 10, 20, 30, 40, 50 };
Console.WriteLine($"   Array inicializado: [{string.Join(", ", numerosArray2)}]");

// Forma 3: Declaración simplificada
int[] numerosArray3 = { 1, 2, 3, 4, 5 };
Console.WriteLine($"   Array simplificado: [{string.Join(", ", numerosArray3)}]");

Console.WriteLine("\n🔸 LISTAS - Diferentes formas de declarar:");

// Forma 1: Lista vacía
List<int> numerosList1 = new List<int>();
Console.WriteLine($"   Lista vacía: [{string.Join(", ", numerosList1)}]");

// Forma 2: Lista con capacidad inicial
List<int> numerosList2 = new List<int>(10); // Capacidad inicial de 10
Console.WriteLine($"   Lista con capacidad[10]: [{string.Join(", ", numerosList2)}]");

// Forma 3: Lista con inicialización
List<int> numerosList3 = new List<int> { 100, 200, 300, 400, 500 };
Console.WriteLine($"   Lista inicializada: [{string.Join(", ", numerosList3)}]");

// Forma 4: Lista desde array
List<int> numerosList4 = new List<int>(numerosArray2);
Console.WriteLine($"   Lista desde array: [{string.Join(", ", numerosList4)}]");

Thread.Sleep(2000);

// ============================================================================
// 3. OPERACIONES BÁSICAS - COMPARACIÓN DIRECTA
// ============================================================================

Console.WriteLine("\n📋 3. OPERACIONES BÁSICAS - COMPARACIÓN");
Console.WriteLine("-".PadRight(45, '-'));

// Inicializar estructuras de prueba
string[] frutasArray = { "Manzana", "Banana", "Naranja" };
List<string> frutasList = new List<string> { "Manzana", "Banana", "Naranja" };

Console.WriteLine("🍎 Datos iniciales:");
Console.WriteLine($"   Array:  [{string.Join(", ", frutasArray)}]");
Console.WriteLine($"   Lista:  [{string.Join(", ", frutasList)}]");

Console.WriteLine("\n📏 LONGITUD/TAMAÑO:");
Console.WriteLine($"   Array.Length: {frutasArray.Length}");
Console.WriteLine($"   List.Count:   {frutasList.Count}");

Console.WriteLine("\n🔍 ACCESO POR ÍNDICE:");
Console.WriteLine($"   Array[1]: {frutasArray[1]}");
Console.WriteLine($"   Lista[1]: {frutasList[1]}");

Console.WriteLine("\n➕ AGREGAR ELEMENTOS:");
Console.WriteLine("   Array: ❌ NO se puede cambiar el tamaño");
Console.WriteLine("   Lista: ✅ Sí se puede agregar");

frutasList.Add("Pera");
frutasList.Add("Uva");
Console.WriteLine($"   Lista después de agregar: [{string.Join(", ", frutasList)}]");

// ============================================================================
// 4. MÉTODOS ESPECÍFICOS DE LISTAS
// ============================================================================

Console.WriteLine("\n📋 4. MÉTODOS ESPECÍFICOS DE LISTAS");
Console.WriteLine("-".PadRight(45, '-'));

List<int> numeros = new List<int> { 5, 2, 8, 1, 9, 3 };
Console.WriteLine($"Lista original: [{string.Join(", ", numeros)}]");

Console.WriteLine("\n🔧 MÉTODOS DISPONIBLES EN LISTAS:");

// Add - Agregar al final
numeros.Add(15);
Console.WriteLine($"   Add(15):      [{string.Join(", ", numeros)}]");

// Insert - Insertar en posición específica
numeros.Insert(2, 99);
Console.WriteLine($"   Insert(2,99): [{string.Join(", ", numeros)}]");

// Remove - Remover primera ocurrencia
numeros.Remove(8);
Console.WriteLine($"   Remove(8):    [{string.Join(", ", numeros)}]");

// RemoveAt - Remover por índice
numeros.RemoveAt(0);
Console.WriteLine($"   RemoveAt(0):  [{string.Join(", ", numeros)}]");

// Contains - Verificar si contiene
bool contiene5 = numeros.Contains(5);
Console.WriteLine($"   Contains(5):  {contiene5}");

// IndexOf - Encontrar índice
int indice = numeros.IndexOf(9);
Console.WriteLine($"   IndexOf(9):   {indice}");

// Sort - Ordenar
numeros.Sort();
Console.WriteLine($"   Sort():       [{string.Join(", ", numeros)}]");

// Reverse - Invertir
numeros.Reverse();
Console.WriteLine($"   Reverse():    [{string.Join(", ", numeros)}]");

// Clear - Limpiar todos los elementos
List<int> copia = new List<int>(numeros);
copia.Clear();
Console.WriteLine($"   Clear():      [{string.Join(", ", copia)}]");

Thread.Sleep(3000);

// ============================================================================
// 5. EJERCICIO INTERACTIVO: GESTIÓN DE ESTUDIANTES
// ============================================================================

Console.WriteLine("\n📋 5. EJERCICIO INTERACTIVO: GESTIÓN DE ESTUDIANTES");
Console.WriteLine("-".PadRight(55, '-'));

Console.WriteLine("🎯 Vamos a comparar cómo manejar una lista de estudiantes");

// Array fijo de estudiantes
string[] estudiantesArray = new string[3];
Console.WriteLine("\n📊 USANDO ARRAY FIJO:");
Console.WriteLine($"   Capacidad máxima: {estudiantesArray.Length} estudiantes");

for (int i = 0; i < estudiantesArray.Length; i++)
{
    Console.Write($"   Ingresa nombre del estudiante {i + 1}: ");
    string nombre = Console.ReadLine() ?? "";
    estudiantesArray[i] = string.IsNullOrEmpty(nombre) ? $"Estudiante{i + 1}" : nombre;
}

Console.WriteLine($"   Array completo: [{string.Join(", ", estudiantesArray)}]");

// Lista dinámica de estudiantes
List<string> estudiantesList = new List<string>();
Console.WriteLine("\n📈 USANDO LISTA DINÁMICA:");
Console.WriteLine("   Capacidad: ¡Ilimitada!");

bool agregarMas = true;
int contador = 1;

while (agregarMas && contador <= 5) // Límite para el ejemplo
{
    Console.Write($"   Ingresa nombre del estudiante {contador}: ");
    string nombre = Console.ReadLine() ?? "";
    
    if (!string.IsNullOrEmpty(nombre))
    {
        estudiantesList.Add(nombre);
        Console.WriteLine($"   ✅ Agregado: {nombre}");
        Console.WriteLine($"   Lista actual: [{string.Join(", ", estudiantesList)}]");
    }
    else
    {
        estudiantesList.Add($"Estudiante{contador}");
    }
    
    if (contador < 5)
    {
        Console.Write("   ¿Agregar otro estudiante? (s/n): ");
        char respuesta = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        agregarMas = respuesta == 's';
    }
    
    contador++;
}

Console.WriteLine($"\n📊 COMPARACIÓN FINAL:");
Console.WriteLine($"   Array:  {estudiantesArray.Length} elementos fijos");
Console.WriteLine($"   Lista:  {estudiantesList.Count} elementos dinámicos");

// ============================================================================
// 6. RENDIMIENTO Y MEMORIA
// ============================================================================

Console.WriteLine("\n📋 6. RENDIMIENTO Y MEMORIA");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("⏱️ Midiendo rendimiento...");

// Preparar datos de prueba
const int tamañoPrueba = 100000;

// Prueba con Array
DateTime inicioArray = DateTime.Now;
int[] arrayPrueba = new int[tamañoPrueba];
for (int i = 0; i < tamañoPrueba; i++)
{
    arrayPrueba[i] = i;
}
DateTime finArray = DateTime.Now;

// Prueba con List
DateTime inicioList = DateTime.Now;
List<int> listPrueba = new List<int>(tamañoPrueba); // Pre-allocate capacity
for (int i = 0; i < tamañoPrueba; i++)
{
    listPrueba.Add(i);
}
DateTime finList = DateTime.Now;

Console.WriteLine($"\n📊 RESULTADOS ({tamañoPrueba:N0} elementos):");
Console.WriteLine($"   Array: {(finArray - inicioArray).TotalMilliseconds:F2} ms");
Console.WriteLine($"   Lista: {(finList - inicioList).TotalMilliseconds:F2} ms");

Console.WriteLine("\n💾 USO DE MEMORIA:");
Console.WriteLine("   Array:");
Console.WriteLine("     ✅ Menor overhead de memoria");
Console.WriteLine("     ✅ Almacenamiento contiguo");
Console.WriteLine("     ❌ Desperdicio si no se usa completamente");
Console.WriteLine();
Console.WriteLine("   Lista:");
Console.WriteLine("     ✅ Usa solo la memoria necesaria");
Console.WriteLine("     ✅ Crece dinámicamente");
Console.WriteLine("     ❌ Overhead adicional por funcionalidades");

// ============================================================================
// 7. CUÁNDO USAR CADA UNO
// ============================================================================

Console.WriteLine("\n📋 7. CUÁNDO USAR CADA UNO");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🎯 USA ARRAYS CUANDO:");
Console.WriteLine("   ✅ Conoces el tamaño exacto de antemano");
Console.WriteLine("   ✅ El tamaño no cambiará");
Console.WriteLine("   ✅ Necesitas máximo rendimiento");
Console.WriteLine("   ✅ Trabajas con matrices matemáticas");
Console.WriteLine("   ✅ Interoperabilidad con código nativo");

Console.WriteLine("\n🎯 USA LISTAS CUANDO:");
Console.WriteLine("   ✅ El tamaño puede cambiar dinámicamente");
Console.WriteLine("   ✅ Necesitas agregar/quitar elementos frecuentemente");
Console.WriteLine("   ✅ Quieres métodos útiles incorporados");
Console.WriteLine("   ✅ Trabajas con colecciones de datos variables");
Console.WriteLine("   ✅ Prototipado rápido y desarrollo ágil");

// ============================================================================
// 8. EJEMPLOS PRÁCTICOS DEL MUNDO REAL
// ============================================================================

Console.WriteLine("\n📋 8. EJEMPLOS PRÁCTICOS");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🌍 CASOS DE USO REALES:");

Console.WriteLine("\n🔹 ARRAYS - Ejemplos perfectos:");
Console.WriteLine("   • Días de la semana (siempre 7)");
string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
Console.WriteLine($"     [{string.Join(", ", diasSemana)}]");

Console.WriteLine("   • Meses del año (siempre 12)");
string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };
Console.WriteLine($"     [{string.Join(", ", meses)}]");

Console.WriteLine("   • Coordenadas 3D (siempre x,y,z)");
double[] coordenadas = { 10.5, 20.3, 15.7 };
Console.WriteLine($"     [X:{coordenadas[0]}, Y:{coordenadas[1]}, Z:{coordenadas[2]}]");

Console.WriteLine("\n🔸 LISTAS - Ejemplos perfectos:");
Console.WriteLine("   • Carrito de compras (tamaño variable)");
List<string> carrito = new List<string>();
carrito.Add("Laptop");
carrito.Add("Mouse");
carrito.Add("Teclado");
Console.WriteLine($"     [{string.Join(", ", carrito)}]");
carrito.Remove("Mouse");
Console.WriteLine($"     Después de quitar mouse: [{string.Join(", ", carrito)}]");

Console.WriteLine("   • Historial de navegación");
List<string> historial = new List<string>();
historial.Add("google.com");
historial.Add("github.com");
historial.Add("stackoverflow.com");
Console.WriteLine($"     [{string.Join(", ", historial)}]");

Console.WriteLine("   • Lista de tareas pendientes");
List<string> tareas = new List<string> { "Estudiar C#", "Hacer ejercicio", "Leer libro" };
Console.WriteLine($"     [{string.Join(", ", tareas)}]");
tareas.Add("Ir al supermercado");
Console.WriteLine($"     Nueva tarea: [{string.Join(", ", tareas)}]");

// ============================================================================
// 9. CONVERSIONES ENTRE ARRAYS Y LISTAS
// ============================================================================

Console.WriteLine("\n📋 9. CONVERSIONES ENTRE ARRAYS Y LISTAS");
Console.WriteLine("-".PadRight(50, '-'));

Console.WriteLine("🔄 CONVERSIONES COMUNES:");

// Array a Lista
int[] arrayOriginal = { 1, 2, 3, 4, 5 };
List<int> listaDesdeArray = new List<int>(arrayOriginal);
// O también: arrayOriginal.ToList();
Console.WriteLine($"   Array → Lista: [{string.Join(", ", listaDesdeArray)}]");

// Lista a Array
List<string> listaOriginal = new List<string> { "A", "B", "C", "D" };
string[] arrayDesdeLista = listaOriginal.ToArray();
Console.WriteLine($"   Lista → Array: [{string.Join(", ", arrayDesdeLista)}]");

// Usando LINQ para transformaciones
var numerosArray = new int[] { 1, 2, 3, 4, 5 };
var numerosPares = numerosArray.Where(n => n % 2 == 0).ToList();
Console.WriteLine($"   Solo pares: [{string.Join(", ", numerosPares)}]");

var numerosDobles = listaDesdeArray.Select(n => n * 2).ToArray();
Console.WriteLine($"   Números × 2: [{string.Join(", ", numerosDobles)}]");

// ============================================================================
// 10. EJERCICIO PRÁCTICO: SISTEMA DE INVENTARIO
// ============================================================================

Console.WriteLine("\n📋 10. EJERCICIO: SISTEMA DE INVENTARIO");
Console.WriteLine("-".PadRight(45, '-'));

Console.WriteLine("🏪 Simulando un sistema de inventario:");

// Categorías fijas (perfecto para array)
string[] categorias = { "Electrónicos", "Ropa", "Hogar", "Deportes" };
Console.WriteLine($"📂 Categorías disponibles: [{string.Join(", ", categorias)}]");

// Productos por categoría (dinámico, perfecto para listas)
Dictionary<string, List<string>> inventario = new Dictionary<string, List<string>>();

foreach (string categoria in categorias)
{
    inventario[categoria] = new List<string>();
}

// Agregar algunos productos de ejemplo
inventario["Electrónicos"].AddRange(new[] { "Laptop", "Mouse", "Teclado" });
inventario["Ropa"].AddRange(new[] { "Camisa", "Pantalón" });
inventario["Hogar"].AddRange(new[] { "Mesa", "Silla", "Lámpara" });
inventario["Deportes"].AddRange(new[] { "Pelota", "Raqueta" });

Console.WriteLine("\n📦 INVENTARIO ACTUAL:");
foreach (var categoria in inventario)
{
    Console.WriteLine($"   {categoria.Key}: {categoria.Value.Count} productos");
    Console.WriteLine($"     └─ [{string.Join(", ", categoria.Value)}]");
}

// Simulación de operaciones dinámicas
Console.WriteLine("\n🔄 OPERACIONES DINÁMICAS:");
Console.WriteLine("   ➕ Agregando 'Smartphone' a Electrónicos");
inventario["Electrónicos"].Add("Smartphone");

Console.WriteLine("   ➖ Removiendo 'Mouse' de Electrónicos");
inventario["Electrónicos"].Remove("Mouse");

Console.WriteLine("   🔍 Buscando 'Laptop' en Electrónicos");
bool tieneeLaptop = inventario["Electrónicos"].Contains("Laptop");
Console.WriteLine($"     Resultado: {(tieneeLaptop ? "✅ Encontrado" : "❌ No encontrado")}");

Console.WriteLine($"\n📊 INVENTARIO ACTUALIZADO:");
foreach (var categoria in inventario)
{
    Console.WriteLine($"   {categoria.Key}: [{string.Join(", ", categoria.Value)}]");
}

// ============================================================================
// 11. RESUMEN Y MEJORES PRÁCTICAS
// ============================================================================

Console.WriteLine("\n📋 11. RESUMEN Y MEJORES PRÁCTICAS");
Console.WriteLine("=".PadRight(50, '='));

Console.WriteLine("\n✅ REGLAS DE ORO:");

Console.WriteLine("\n🔹 ARRAYS:");
Console.WriteLine("   ✅ Usa cuando el tamaño es conocido y fijo");
Console.WriteLine("   ✅ Para datos que no cambiarán (constantes)");
Console.WriteLine("   ✅ Cuando necesites máximo rendimiento");
Console.WriteLine("   ✅ Para matrices matemáticas o científicas");
Console.WriteLine("   ✅ Interoperabilidad con APIs nativas");

Console.WriteLine("\n🔸 LISTAS:");
Console.WriteLine("   ✅ Usa cuando el tamaño puede cambiar");
Console.WriteLine("   ✅ Para colecciones dinámicas de datos");
Console.WriteLine("   ✅ Cuando necesites métodos útiles incorporados");
Console.WriteLine("   ✅ Para prototipado rápido");
Console.WriteLine("   ✅ La mayoría de casos de uso en aplicaciones");

Console.WriteLine("\n🚫 ERRORES COMUNES A EVITAR:");
Console.WriteLine("   • Usar arrays cuando necesitas tamaño dinámico");
Console.WriteLine("   • Usar listas para datos de tamaño absolutamente fijo");
Console.WriteLine("   • No especificar capacidad inicial en listas grandes");
Console.WriteLine("   • Acceder a índices fuera de rango");
Console.WriteLine("   • Modificar colecciones mientras las iteras");

Console.WriteLine("\n🎯 CONSEJOS DE RENDIMIENTO:");
Console.WriteLine("   • Especifica capacidad inicial en List<T> si conoces el tamaño aproximado");
Console.WriteLine("   • Usa AddRange() para agregar múltiples elementos");
Console.WriteLine("   • Considera usar ArrayPool<T> para arrays temporales grandes");
Console.WriteLine("   • Para búsquedas frecuentes, considera HashSet<T> o Dictionary<K,V>");

Console.WriteLine("\n📚 MÉTODOS MÁS ÚTILES APRENDIDOS:");
Console.WriteLine("   Array: Length, GetValue(), SetValue(), Array.Sort()");
Console.WriteLine("   Lista: Count, Add(), Remove(), Contains(), Sort(), ToArray()");
Console.WriteLine("   LINQ: Where(), Select(), ToList(), ToArray(), First(), Any()");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de Arrays vs Listas!");
Console.WriteLine("💡 Recuerda: Arrays para tamaño fijo, Listas para tamaño dinámico");
Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
Console.ReadKey();