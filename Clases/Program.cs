using System;
using System.Threading;
using Operaciones;

Console.Clear();
Console.WriteLine("🏗️ CLASES Y MÉTODOS EN C# - PROGRAMACIÓN ORIENTADA A OBJETOS");
Console.WriteLine("═".PadRight(70, '═'));
Console.WriteLine("💡 Aprende POO con una calculadora completa");
Console.WriteLine("═".PadRight(70, '═'));

// ============================================================================
// 1. CREACIÓN DE OBJETOS (INSTANCIACIÓN)
// ============================================================================

Console.WriteLine("\n📋 1. CREACIÓN DE OBJETOS");
Console.WriteLine("─".PadRight(40, '─'));

// Diferentes formas de crear objetos
Calculadora calc1 = new Calculadora(); // Constructor por defecto
Calculadora calc2 = new Calculadora("Mi Calculadora Personal"); // Constructor con parámetros
Calculadora calc3 = new Calculadora("Calculadora Científica", true); // Constructor completo

Console.WriteLine($"✅ Calculadora 1: {calc1}");
Console.WriteLine($"✅ Calculadora 2: {calc2}");
Console.WriteLine($"✅ Calculadora 3: {calc3}");

Thread.Sleep(1500);

// ============================================================================
// 2. USO DE PROPIEDADES (ENCAPSULACIÓN)
// ============================================================================

Console.WriteLine("\n📋 2. PROPIEDADES Y ENCAPSULACIÓN");
Console.WriteLine("─".PadRight(40, '─'));

Console.WriteLine($"📝 Nombre de calc1: {calc1.Nombre}");
Console.WriteLine($"📅 Fecha creación: {calc1.FechaCreacion:dd/MM/yyyy HH:mm:ss}");
Console.WriteLine($"🔢 Operaciones realizadas: {calc1.ContadorOperaciones}");

// Modificar propiedades
calc1.Nombre = "Calculadora Mejorada";
Console.WriteLine($"📝 Nuevo nombre: {calc1.Nombre}");

Thread.Sleep(1500);

// ============================================================================
// 3. MÉTODOS BÁSICOS (TU CÓDIGO ORIGINAL)
// ============================================================================

Console.WriteLine("\n📋 3. MÉTODOS BÁSICOS - TU CÓDIGO ORIGINAL");
Console.WriteLine("─".PadRight(50, '─'));

Console.WriteLine("\n🧮 Operaciones básicas:");

// Tu código original funcionando
int suma = calc1.Suma(15, 25);
Console.WriteLine($"➕ Suma: 15 + 25 = {suma}");

int resta = calc1.Resta(50, 20);
Console.WriteLine($"➖ Resta: 50 - 20 = {resta}");

int multiplicacion = calc1.Multiplicacion(7, 8);
Console.WriteLine($"✖️ Multiplicación: 7 × 8 = {multiplicacion}");

try
{
    double division = calc1.Division(100, 4);
    Console.WriteLine($"➗ División: 100 ÷ 4 = {division}");
    
    // Ejemplo de manejo de errores
    // double error = calc1.Division(10, 0); // Esto lanzaría excepción
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"❌ Error capturado: {ex.Message}");
}

Console.WriteLine($"\n📊 Estado actual: {calc1.ContadorOperaciones} operaciones realizadas");

Thread.Sleep(2000);

// ============================================================================
// 4. SOBRECARGA DE MÉTODOS (OVERLOADING)
// ============================================================================

Console.WriteLine("\n📋 4. SOBRECARGA DE MÉTODOS");
Console.WriteLine("─".PadRight(35, '─'));

Console.WriteLine("\n🔄 Mismo método, diferentes parámetros:");

// Diferentes versiones del método Suma
int sumaEnteros = calc2.Suma(10, 20);
Console.WriteLine($"   Enteros: Suma(10, 20) = {sumaEnteros}");

double sumaDecimales = calc2.Suma(10.5, 20.3);
Console.WriteLine($"   Decimales: Suma(10.5, 20.3) = {sumaDecimales:F2}");

int sumaTres = calc2.Suma(5, 10, 15);
Console.WriteLine($"   Tres números: Suma(5, 10, 15) = {sumaTres}");

double sumaMultiple = calc2.Suma(1.1, 2.2, 3.3, 4.4, 5.5);
Console.WriteLine($"   Múltiples: Suma(1.1, 2.2, 3.3, 4.4, 5.5) = {sumaMultiple:F2}");

Thread.Sleep(2000);

// ============================================================================
// 5. MÉTODOS AVANZADOS
// ============================================================================

Console.WriteLine("\n📋 5. MÉTODOS AVANZADOS");
Console.WriteLine("─".PadRight(30, '─'));

Console.WriteLine("\n🚀 Operaciones científicas:");

double potencia = calc3.Potencia(2, 8);
Console.WriteLine($"🔺 Potencia: 2^8 = {potencia}");

double raiz = calc3.RaizCuadrada(144);
Console.WriteLine($"√ Raíz cuadrada: √144 = {raiz}");

long factorial = calc3.Factorial(5);
Console.WriteLine($"❗ Factorial: 5! = {factorial}");

double promedio = calc3.Promedio(85.5, 92.3, 78.8, 95.2);
Console.WriteLine($"📈 Promedio: [85.5, 92.3, 78.8, 95.2] = {promedio:F2}");

Thread.Sleep(2000);

// ============================================================================
// 6. MÉTODOS ESTÁTICOS (NO REQUIEREN INSTANCIA)
// ============================================================================

Console.WriteLine("\n📋 6. MÉTODOS ESTÁTICOS");
Console.WriteLine("─".PadRight(30, '─'));

Console.WriteLine("\n🌡️ Conversiones de temperatura:");

double fahrenheit = Calculadora.CelsiusAFahrenheit(25);
Console.WriteLine($"   25°C = {fahrenheit:F1}°F");

double celsius = Calculadora.FahrenheitACelsius(77);
Console.WriteLine($"   77°F = {celsius:F1}°C");

Console.WriteLine("\n🔢 Validación de números primos:");
int[] numeros = { 7, 12, 17, 20, 23 };
foreach (int num in numeros)
{
    bool esPrimo = Calculadora.EsPrimo(num);
    string resultado = esPrimo ? "SÍ es primo" : "NO es primo";
    Console.WriteLine($"   {num} → {resultado}");
}

Thread.Sleep(2000);

// ============================================================================
// 7. HISTORIAL Y ESTADO DE OBJETOS
// ============================================================================

Console.WriteLine("\n📋 7. HISTORIAL Y ESTADO DE OBJETOS");
Console.WriteLine("─".PadRight(45, '─'));

Console.WriteLine($"\n📝 Historial de {calc1.Nombre}:");
foreach (string operacion in calc1.Historial.Take(5)) // Mostrar solo las primeras 5
{
    Console.WriteLine($"   {operacion}");
}

if (calc1.Historial.Count > 5)
{
    Console.WriteLine($"   ... y {calc1.Historial.Count - 5} más");
}

Console.WriteLine($"\n🎯 Última operación: {calc1.UltimaOperacion}");

Thread.Sleep(2000);

// ============================================================================
// 8. ESTADÍSTICAS Y MÉTODOS DE UTILIDAD
// ============================================================================

Console.WriteLine("\n📋 8. ESTADÍSTICAS Y MÉTODOS DE UTILIDAD");
Console.WriteLine("─".PadRight(50, '─'));

var estadisticas1 = calc1.ObtenerEstadisticas();
var estadisticas2 = calc2.ObtenerEstadisticas();

Console.WriteLine($"\n{estadisticas1}");
Console.WriteLine($"\n{estadisticas2}");

Thread.Sleep(2000);

// ============================================================================
// 9. COMPARACIÓN DE OBJETOS
// ============================================================================

Console.WriteLine("\n📋 9. COMPARACIÓN DE OBJETOS");
Console.WriteLine("─".PadRight(35, '─'));

Console.WriteLine("\n📊 Comparando calculadoras:");
Console.WriteLine($"   {calc1.Nombre}: {calc1.ContadorOperaciones} operaciones");
Console.WriteLine($"   {calc2.Nombre}: {calc2.ContadorOperaciones} operaciones");
Console.WriteLine($"   {calc3.Nombre}: {calc3.ContadorOperaciones} operaciones");

var calculadoraMasUsada = new[] { calc1, calc2, calc3 }
    .OrderByDescending(c => c.ContadorOperaciones)
    .First();

Console.WriteLine($"\n🏆 Calculadora más usada: {calculadoraMasUsada.Nombre}");

// ============================================================================
// 10. EJEMPLO INTERACTIVO
// ============================================================================

Console.WriteLine("\n📋 10. EJEMPLO INTERACTIVO");
Console.WriteLine("─".PadRight(30, '─'));

Console.WriteLine("\n🎮 Probemos la calculadora interactivamente:");
Console.Write("Ingresa el primer número: ");
if (double.TryParse(Console.ReadLine(), out double num1))
{
    Console.Write("Ingresa el segundo número: ");
    if (double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("\n🧮 Operaciones disponibles:");
        Console.WriteLine("   1. Suma    2. Resta    3. Multiplicación    4. División");
        Console.Write("Elige una opción (1-4): ");
        
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            try
            {
                double resultado = opcion switch
                {
                    1 => calc1.Suma(num1, num2),
                    2 => calc1.Resta((int)num1, (int)num2),
                    3 => calc1.Multiplicacion((int)num1, (int)num2),
                    4 => calc1.Division(num1, num2),
                    _ => throw new ArgumentException("Opción inválida")
                };
                
                Console.WriteLine($"\n✅ Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Error: {ex.Message}");
            }
        }
    }
}

// ============================================================================
// 11. RESUMEN DE CONCEPTOS POO
// ============================================================================

Console.WriteLine("\n📋 RESUMEN - CONCEPTOS DE POO APLICADOS");
Console.WriteLine("═".PadRight(50, '═'));

Console.WriteLine("\n✅ CONCEPTOS IMPLEMENTADOS:");
Console.WriteLine("   🏗️ CLASES - Plantillas para crear objetos");
Console.WriteLine("   🎯 OBJETOS - Instancias de clases");
Console.WriteLine("   🔒 ENCAPSULACIÓN - Campos privados y propiedades públicas");
Console.WriteLine("   🔄 SOBRECARGA - Múltiples versiones de métodos");
Console.WriteLine("   📊 ESTADO - Campos que mantienen información");
Console.WriteLine("   🛠️ COMPORTAMIENTO - Métodos que realizan acciones");

Console.WriteLine("\n🎯 CARACTERÍSTICAS DE LA CLASE:");
Console.WriteLine("   • 🏷️ Propiedades con get/set");
Console.WriteLine("   • 🔧 Constructores múltiples");
Console.WriteLine("   • 📝 Métodos de instancia");
Console.WriteLine("   • ⚡ Métodos estáticos");
Console.WriteLine("   • 🛡️ Validación y manejo de errores");
Console.WriteLine("   • 📊 Mantenimiento de estado interno");

Console.WriteLine("\n🚀 VENTAJAS DE POO:");
Console.WriteLine("   • ♻️ Reutilización de código");
Console.WriteLine("   • 🧩 Modularidad y organización");
Console.WriteLine("   • 🔒 Encapsulación de datos");
Console.WriteLine("   • 🔧 Fácil mantenimiento");
Console.WriteLine("   • 📈 Escalabilidad");

Console.WriteLine($"\n📊 ESTADÍSTICAS FINALES:");
Console.WriteLine($"   🧮 Total de calculadoras creadas: 3");
Console.WriteLine($"   🔢 Total de operaciones: {calc1.ContadorOperaciones + calc2.ContadorOperaciones + calc3.ContadorOperaciones}");
Console.WriteLine($"   ⏱️ Tiempo de ejecución: {DateTime.Now - calc1.FechaCreacion:mm\\:ss}");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de Clases y POO en C#!");
Console.WriteLine("💪 Ahora entiendes los conceptos fundamentales de la programación orientada a objetos");
Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
Console.ReadKey();
