using System;
using System.Collections.Generic;
using System.Linq;

// ============================================================================
// MÉTODOS BÁSICOS DE CALCULADORA - DEBEN IR ANTES DEL CÓDIGO EJECUTABLE
// ============================================================================

/// <summary>
/// Realiza la suma de dos números enteros
/// </summary>
/// <param name="numero1">Primer número a sumar</param>
/// <param name="numero2">Segundo número a sumar</param>
/// <returns>El resultado de la suma</returns>
static int Suma(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    Console.WriteLine($"📊 Operación: {numero1} + {numero2} = {resultado}");
    return resultado;
}

/// <summary>
/// Realiza la resta de dos números enteros
/// </summary>
static int Resta(int numero1, int numero2)
{
    int resultado = numero1 - numero2;
    Console.WriteLine($"📊 Operación: {numero1} - {numero2} = {resultado}");
    return resultado;
}

/// <summary>
/// Realiza la multiplicación de dos números enteros
/// </summary>
static int Multiplicacion(int numero1, int numero2)
{
    int resultado = numero1 * numero2;
    Console.WriteLine($"📊 Operación: {numero1} × {numero2} = {resultado}");
    return resultado;
}

/// <summary>
/// Realiza la división de dos números con validación
/// </summary>
static double Division(double numero1, double numero2)
{
    if (numero2 == 0)
    {
        Console.WriteLine("❌ Error: No se puede dividir por cero");
        return 0;
    }
    
    double resultado = numero1 / numero2;
    Console.WriteLine($"📊 Operación: {numero1} ÷ {numero2} = {resultado:F2}");
    return resultado;
}

/// <summary>
/// Calcula la potencia de un número
/// </summary>
static double Potencia(double baseNum, double exponente)
{
    double resultado = Math.Pow(baseNum, exponente);
    Console.WriteLine($"📊 Operación: {baseNum}^{exponente} = {resultado:F2}");
    return resultado;
}

/// <summary>
/// Calcula la raíz cuadrada de un número
/// </summary>
static double RaizCuadrada(double numero)
{
    if (numero < 0)
    {
        Console.WriteLine("❌ Error: No se puede calcular la raíz cuadrada de un número negativo");
        return 0;
    }
    
    double resultado = Math.Sqrt(numero);
    Console.WriteLine($"📊 Operación: √{numero} = {resultado:F2}");
    return resultado;
}

// ============================================================================
// MÉTODOS AVANZADOS - OPERACIONES CON MÚLTIPLES NÚMEROS
// ============================================================================

/// <summary>
/// Suma una lista de números enteros
/// </summary>
static int SumaMultiple(params int[] numeros)
{
    int resultado = numeros.Sum();
    string operacion = string.Join(" + ", numeros);
    Console.WriteLine($"📊 Suma múltiple: {operacion} = {resultado}");
    return resultado;
}

/// <summary>
/// Calcula el promedio de varios números
/// </summary>
static double Promedio(params double[] numeros)
{
    if (numeros.Length == 0)
    {
        Console.WriteLine("❌ Error: No se proporcionaron números");
        return 0;
    }
    
    double resultado = numeros.Average();
    string nums = string.Join(", ", numeros.Select(n => n.ToString("F1")));
    Console.WriteLine($"📊 Promedio de [{nums}] = {resultado:F2}");
    return resultado;
}

/// <summary>
/// Encuentra el número mayor de una lista
/// </summary>
static double Maximo(params double[] numeros)
{
    if (numeros.Length == 0)
    {
        Console.WriteLine("❌ Error: No se proporcionaron números");
        return 0;
    }
    
    double resultado = numeros.Max();
    string nums = string.Join(", ", numeros.Select(n => n.ToString("F1")));
    Console.WriteLine($"📊 Máximo de [{nums}] = {resultado:F1}");
    return resultado;
}

/// <summary>
/// Encuentra el número menor de una lista
/// </summary>
static double Minimo(params double[] numeros)
{
    if (numeros.Length == 0)
    {
        Console.WriteLine("❌ Error: No se proporcionaron números");
        return 0;
    }
    
    double resultado = numeros.Min();
    string nums = string.Join(", ", numeros.Select(n => n.ToString("F1")));
    Console.WriteLine($"📊 Mínimo de [{nums}] = {resultado:F1}");
    return resultado;
}

// ============================================================================
// MÉTODOS DE VALIDACIÓN Y UTILIDAD
// ============================================================================

/// <summary>
/// Valida si un string es un número entero válido
/// </summary>
static bool EsNumeroEnteroValido(string input, out int numero)
{
    return int.TryParse(input, out numero);
}

/// <summary>
/// Valida si un string es un número decimal válido
/// </summary>
static bool EsNumeroDecimalValido(string input, out double numero)
{
    return double.TryParse(input, out numero);
}

/// <summary>
/// Solicita un número entero al usuario con validación
/// </summary>
static int SolicitarNumeroEntero(string mensaje)
{
    int numero;
    string input;
    
    do
    {
        Console.Write(mensaje);
        input = Console.ReadLine() ?? "";
        
        if (EsNumeroEnteroValido(input, out numero))
        {
            return numero;
        }
        
        Console.WriteLine("❌ Por favor, ingresa un número entero válido.");
    } while (true);
}

/// <summary>
/// Solicita un número decimal al usuario con validación
/// </summary>
static double SolicitarNumeroDecimal(string mensaje)
{
    double numero;
    string input;
    
    do
    {
        Console.Write(mensaje);
        input = Console.ReadLine() ?? "";
        
        if (EsNumeroDecimalValido(input, out numero))
        {
            return numero;
        }
        
        Console.WriteLine("❌ Por favor, ingresa un número válido.");
    } while (true);
}

// ============================================================================
// MÉTODOS DE MENÚ Y NAVEGACIÓN
// ============================================================================

/// <summary>
/// Muestra el menú principal de la calculadora
/// </summary>
static void MostrarMenu()
{
    Console.WriteLine("\n🧮 CALCULADORA - MENÚ PRINCIPAL");
    Console.WriteLine("=".PadRight(40, '='));
    Console.WriteLine("   1. ➕ Suma");
    Console.WriteLine("   2. ➖ Resta");
    Console.WriteLine("   3. ✖️ Multiplicación");
    Console.WriteLine("   4. ➗ División");
    Console.WriteLine("   5. 🔺 Potencia");
    Console.WriteLine("   6. √ Raíz Cuadrada");
    Console.WriteLine("   7. 📊 Suma Múltiple");
    Console.WriteLine("   8. 📈 Promedio");
    Console.WriteLine("   9. ⬆️ Máximo");
    Console.WriteLine("   10. ⬇️ Mínimo");
    Console.WriteLine("   11. 📝 Historial");
    Console.WriteLine("   0. 🚪 Salir");
    Console.WriteLine("-".PadRight(40, '-'));
}

/// <summary>
/// Procesa la operación básica seleccionada
/// </summary>
static double ProcesarOperacionBasica(int opcion)
{
    return opcion switch
    {
        1 => EjecutarSuma(),
        2 => EjecutarResta(),
        3 => EjecutarMultiplicacion(),
        4 => EjecutarDivision(),
        5 => EjecutarPotencia(),
        6 => EjecutarRaizCuadrada(),
        7 => EjecutarSumaMultiple(),
        8 => EjecutarPromedio(),
        9 => EjecutarMaximo(),
        10 => EjecutarMinimo(),
        _ => 0
    };
}

// ============================================================================
// MÉTODOS DE EJECUCIÓN DE OPERACIONES
// ============================================================================

static double EjecutarSuma()
{
    Console.WriteLine("\n➕ SUMA");
    int num1 = SolicitarNumeroEntero("Primer número: ");
    int num2 = SolicitarNumeroEntero("Segundo número: ");
    return Suma(num1, num2);
}

static double EjecutarResta()
{
    Console.WriteLine("\n➖ RESTA");
    int num1 = SolicitarNumeroEntero("Primer número: ");
    int num2 = SolicitarNumeroEntero("Segundo número: ");
    return Resta(num1, num2);
}

static double EjecutarMultiplicacion()
{
    Console.WriteLine("\n✖️ MULTIPLICACIÓN");
    int num1 = SolicitarNumeroEntero("Primer número: ");
    int num2 = SolicitarNumeroEntero("Segundo número: ");
    return Multiplicacion(num1, num2);
}

static double EjecutarDivision()
{
    Console.WriteLine("\n➗ DIVISIÓN");
    double num1 = SolicitarNumeroDecimal("Dividendo: ");
    double num2 = SolicitarNumeroDecimal("Divisor: ");
    return Division(num1, num2);
}

static double EjecutarPotencia()
{
    Console.WriteLine("\n🔺 POTENCIA");
    double baseNum = SolicitarNumeroDecimal("Base: ");
    double exponente = SolicitarNumeroDecimal("Exponente: ");
    return Potencia(baseNum, exponente);
}

static double EjecutarRaizCuadrada()
{
    Console.WriteLine("\n√ RAÍZ CUADRADA");
    double numero = SolicitarNumeroDecimal("Número: ");
    return RaizCuadrada(numero);
}

static double EjecutarSumaMultiple()
{
    Console.WriteLine("\n📊 SUMA MÚLTIPLE");
    Console.Write("¿Cuántos números quieres sumar?: ");
    int cantidad = SolicitarNumeroEntero("");
    
    int[] numeros = new int[cantidad];
    for (int i = 0; i < cantidad; i++)
    {
        numeros[i] = SolicitarNumeroEntero($"Número {i + 1}: ");
    }
    
    return SumaMultiple(numeros);
}

static double EjecutarPromedio()
{
    Console.WriteLine("\n📈 PROMEDIO");
    Console.Write("¿Cuántos números?: ");
    int cantidad = SolicitarNumeroEntero("");
    
    double[] numeros = new double[cantidad];
    for (int i = 0; i < cantidad; i++)
    {
        numeros[i] = SolicitarNumeroDecimal($"Número {i + 1}: ");
    }
    
    return Promedio(numeros);
}

static double EjecutarMaximo()
{
    Console.WriteLine("\n⬆️ MÁXIMO");
    Console.Write("¿Cuántos números comparar?: ");
    int cantidad = SolicitarNumeroEntero("");
    
    double[] numeros = new double[cantidad];
    for (int i = 0; i < cantidad; i++)
    {
        numeros[i] = SolicitarNumeroDecimal($"Número {i + 1}: ");
    }
    
    return Maximo(numeros);
}

static double EjecutarMinimo()
{
    Console.WriteLine("\n⬇️ MÍNIMO");
    Console.Write("¿Cuántos números comparar?: ");
    int cantidad = SolicitarNumeroEntero("");
    
    double[] numeros = new double[cantidad];
    for (int i = 0; i < cantidad; i++)
    {
        numeros[i] = SolicitarNumeroDecimal($"Número {i + 1}: ");
    }
    
    return Minimo(numeros);
}

static void MostrarHistorial(List<string> historial)
{
    Console.WriteLine("\n📝 HISTORIAL DE OPERACIONES");
    Console.WriteLine("=".PadRight(40, '='));
    
    if (historial.Count == 0)
    {
        Console.WriteLine("📋 No hay operaciones en el historial");
        return;
    }
    
    for (int i = 0; i < historial.Count; i++)
    {
        Console.WriteLine($"   {i + 1}. {historial[i]}");
    }
    
    Console.WriteLine($"\n📊 Total de operaciones: {historial.Count}");
}

// ============================================================================
// CÓDIGO EJECUTABLE PRINCIPAL - VA AL FINAL
// ============================================================================

Console.Clear();
Console.WriteLine("🧮 CALCULADORA AVANZADA EN C#");
Console.WriteLine("=".PadRight(50, '='));
Console.WriteLine("💡 Aprende a crear métodos personalizados");
Console.WriteLine("=".PadRight(50, '='));

// ============================================================================
// 1. DEMOSTRACIÓN DE TU CÓDIGO ORIGINAL (MEJORADO)
// ============================================================================

Console.WriteLine("\n📋 1. EJEMPLO BÁSICO - TU CÓDIGO ORIGINAL");
Console.WriteLine("-".PadRight(45, '-'));

// Tu código original mejorado
int numeroResultado = Suma(5, 10);
Console.WriteLine($"💾 Resultado almacenado: {numeroResultado}");

// Más ejemplos básicos
Console.WriteLine("\n🔢 Más ejemplos básicos:");
int resultado1 = Suma(15, 25);
int resultado2 = Resta(30, 12);
int resultado3 = Multiplicacion(7, 8);
double resultado4 = Division(100, 4);

Console.WriteLine($"\n📊 Resumen de resultados:");
Console.WriteLine($"   Suma: {resultado1}");
Console.WriteLine($"   Resta: {resultado2}");  
Console.WriteLine($"   Multiplicación: {resultado3}");
Console.WriteLine($"   División: {resultado4:F2}");

Thread.Sleep(2000);

// ============================================================================
// 2. CALCULADORA INTERACTIVA
// ============================================================================

Console.WriteLine("\n📋 2. CALCULADORA INTERACTIVA");
Console.WriteLine("-".PadRight(35, '-'));

List<string> historial = new List<string>();
bool continuar = true;

while (continuar)
{
    MostrarMenu();
    
    Console.Write("🎯 Selecciona una opción: ");
    string input = Console.ReadLine() ?? "";
    
    if (int.TryParse(input, out int opcion))
    {
        switch (opcion)
        {
            case 0:
                continuar = false;
                Console.WriteLine("👋 ¡Gracias por usar la calculadora!");
                break;
                
            case 11:
                MostrarHistorial(historial);
                break;
                
            case >= 1 and <= 10:
                try
                {
                    double resultado = ProcesarOperacionBasica(opcion);
                    string operacion = opcion switch
                    {
                        1 => "Suma",
                        2 => "Resta", 
                        3 => "Multiplicación",
                        4 => "División",
                        5 => "Potencia",
                        6 => "Raíz Cuadrada",
                        7 => "Suma Múltiple",
                        8 => "Promedio",
                        9 => "Máximo",
                        10 => "Mínimo",
                        _ => "Operación"
                    };
                    
                    string entrada = $"{operacion} → Resultado: {resultado:F2}";
                    historial.Add(entrada);
                    
                    Console.WriteLine($"✅ Operación completada. Resultado guardado en historial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error: {ex.Message}");
                }
                break;
                
            default:
                Console.WriteLine("❌ Opción no válida. Intenta de nuevo.");
                break;
        }
    }
    else
    {
        Console.WriteLine("❌ Por favor, ingresa un número válido.");
    }
    
    if (continuar)
    {
        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
}

// ============================================================================
// 3. DEMOSTRACIÓN DE MÉTODOS AVANZADOS
// ============================================================================

Console.WriteLine("\n📋 3. DEMOSTRACIÓN DE MÉTODOS AVANZADOS");
Console.WriteLine("-".PadRight(45, '-'));

// Operaciones con múltiples números
Console.WriteLine("\n🔢 Operaciones con múltiples números:");
SumaMultiple(10, 20, 30, 40, 50);
Promedio(85.5, 92.3, 78.8, 95.2, 88.1);
Maximo(45.2, 67.8, 23.1, 89.5, 34.7);
Minimo(45.2, 67.8, 23.1, 89.5, 34.7);

// Operaciones matemáticas avanzadas
Console.WriteLine("\n🧮 Operaciones matemáticas avanzadas:");
Potencia(2, 8);
Potencia(5, 3);
RaizCuadrada(144);
RaizCuadrada(50);

// ============================================================================
// 4. RESUMEN Y CONCEPTOS APRENDIDOS
// ============================================================================

Console.WriteLine("\n📋 RESUMEN - CONCEPTOS DE MÉTODOS EN C#");
Console.WriteLine("=".PadRight(50, '='));

Console.WriteLine("\n✅ TIPOS DE MÉTODOS CREADOS:");
Console.WriteLine("   • 🔄 Métodos que devuelven valores (int, double)");
Console.WriteLine("   • 🚫 Métodos void (no devuelven valores)");
Console.WriteLine("   • 📝 Métodos con parámetros múltiples (params)");
Console.WriteLine("   • ✅ Métodos con validación de entrada");
Console.WriteLine("   • 🔍 Métodos de utilidad y helper");

Console.WriteLine("\n🎯 CARACTERÍSTICAS IMPLEMENTADAS:");
Console.WriteLine("   • 📚 Documentación XML en métodos");
Console.WriteLine("   • 🛡️ Validación de entrada con TryParse");
Console.WriteLine("   • ❌ Manejo de errores (división por cero, etc.)");
Console.WriteLine("   • 🔄 Métodos que llaman a otros métodos");
Console.WriteLine("   • 📊 Parámetros opcionales y múltiples");

Console.WriteLine("\n🚀 BUENAS PRÁCTICAS APLICADAS:");
Console.WriteLine("   • 📝 Nombres descriptivos de métodos");
Console.WriteLine("   • 🎯 Un método = una responsabilidad");
Console.WriteLine("   • 📋 Validación antes de procesar");
Console.WriteLine("   • 💾 Retorno de valores calculados");
Console.WriteLine("   • 🔧 Reutilización de código");

Console.WriteLine("\n📚 PRÓXIMOS PASOS:");
Console.WriteLine("   • 🏗️ Crear clases con métodos");
Console.WriteLine("   • 🔄 Métodos estáticos vs instancia");
Console.WriteLine("   • 📦 Sobrecarga de métodos (overloading)");
Console.WriteLine("   • 🎭 Métodos genéricos <T>");

Console.WriteLine($"\n📊 ESTADÍSTICAS DE LA SESIÓN:");
Console.WriteLine($"   🧮 Operaciones realizadas: {historial.Count}");
Console.WriteLine($"   📝 Métodos creados: 25+");
Console.WriteLine($"   ⭐ Funcionalidades: Calculadora completa");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de métodos personalizados!");
Console.WriteLine("💪 Ahora sabes crear métodos efectivos en C#");
Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
Console.ReadKey();
