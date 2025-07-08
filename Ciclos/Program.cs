// ============================================================================
// CICLOS FOR Y WHILE EN C# .NET - GUÍA COMPLETA E INTERACTIVA
// ============================================================================

using System;
using System.Collections.Generic;
using System.Threading;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("🔄 CICLOS FOR Y WHILE EN C# .NET");
Console.WriteLine("=".PadRight(50, '='));
Console.ResetColor();

// ============================================================================
// 1. CICLO FOR BÁSICO
// ============================================================================

Console.WriteLine("\n📋 1. CICLO FOR BÁSICO");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("💡 Sintaxis: for (inicialización; condición; incremento)");
Console.WriteLine("🔍 Ejemplo: Contar del 1 al 5");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"   Iteración {i}: i = {i}");
    Thread.Sleep(300); // Pausa para visualizar mejor
}

Console.WriteLine("\n📊 Análisis del ciclo:");
Console.WriteLine("   for (int i = 1; i <= 5; i++)");
Console.WriteLine("        ↑         ↑       ↑");
Console.WriteLine("   Inicializa  Condición  Incremento");
Console.WriteLine("   • i = 1: Variable contador inicia en 1");
Console.WriteLine("   • i <= 5: Se ejecuta mientras i sea ≤ 5");
Console.WriteLine("   • i++: Incrementa i en 1 cada iteración");

// ============================================================================
// 2. CICLO FOR CON DIFERENTES INCREMENTOS
// ============================================================================

Console.WriteLine("\n📋 2. FOR CON DIFERENTES INCREMENTOS");
Console.WriteLine("-".PadRight(45, '-'));

// Incremento de 2 en 2
Console.WriteLine("🔢 Números pares del 2 al 10:");
for (int i = 2; i <= 10; i += 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

// Decremento
Console.WriteLine("\n⬇️ Cuenta regresiva del 5 al 1:");
for (int i = 5; i >= 1; i--)
{
    Console.Write($"{i} ");
    Thread.Sleep(400);
}
Console.WriteLine("🚀 ¡Despegue!");

// Incremento por 5
Console.WriteLine("\n📈 Incremento de 5 en 5 (0 a 25):");
for (int i = 0; i <= 25; i += 5)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

// ============================================================================
// 3. CICLO FOR INTERACTIVO
// ============================================================================

Console.WriteLine("\n📋 3. CICLO FOR INTERACTIVO");
Console.WriteLine("-".PadRight(40, '-'));

Console.Write("🔢 ¿Hasta qué número quieres contar? ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int limite))
{
    Console.WriteLine($"\n🎯 Contando del 1 al {limite}:");
    
    for (int i = 1; i <= limite; i++)
    {
        // Mostrar progreso visual
        string barra = new string('█', i * 20 / limite);
        string espacios = new string('░', 20 - (i * 20 / limite));
        
        Console.Write($"\r   [{barra}{espacios}] {i}/{limite}");
        Thread.Sleep(100);
    }
    Console.WriteLine("\n✅ ¡Completado!");
}

// ============================================================================
// 4. CICLO WHILE BÁSICO
// ============================================================================

Console.WriteLine("\n📋 4. CICLO WHILE BÁSICO");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("💡 Sintaxis: while (condición) { código }");
Console.WriteLine("🔍 Ejemplo: Contar del 1 al 5 con while");

int contador = 1;
while (contador <= 5)
{
    Console.WriteLine($"   Iteración: contador = {contador}");
    contador++; // IMPORTANTE: No olvidar incrementar
    Thread.Sleep(300);
}

Console.WriteLine("\n📊 Diferencias For vs While:");
Console.WriteLine("   FOR:");
Console.WriteLine("   • Mejor para iteraciones con contador conocido");
Console.WriteLine("   • Inicialización, condición e incremento en una línea");
Console.WriteLine("   • Menos propenso a errores");
Console.WriteLine();
Console.WriteLine("   WHILE:");
Console.WriteLine("   • Mejor para condiciones complejas o desconocidas");
Console.WriteLine("   • Más flexible");
Console.WriteLine("   • Requiere manejo manual del contador");

// ============================================================================
// 5. WHILE CON VALIDACIÓN DE ENTRADA
// ============================================================================

Console.WriteLine("\n📋 5. WHILE PARA VALIDACIÓN");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🎯 Adivina el número secreto (1-10):");
int numeroSecreto = new Random().Next(1, 11);
int intentos = 0;
int adivinanza = 0;
bool adivinado = false;

while (!adivinado && intentos < 3)
{
    Console.Write($"🤔 Intento {intentos + 1}/3: ");
    string inputNumero = Console.ReadLine() ?? "";
    
    if (int.TryParse(inputNumero, out adivinanza))
    {
        intentos++;
        
        if (adivinanza == numeroSecreto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"🎉 ¡Correcto! El número era {numeroSecreto}");
            Console.WriteLine($"🏆 Lo lograste en {intentos} intento(s)");
            Console.ResetColor();
            adivinado = true;
        }
        else if (adivinanza < numeroSecreto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("📈 El número es mayor");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("📉 El número es menor");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Ingresa un número válido");
        Console.ResetColor();
    }
}

if (!adivinado)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"😔 Se agotaron los intentos. El número era {numeroSecreto}");
    Console.ResetColor();
}

// ============================================================================
// 6. DO-WHILE (EJECUTA AL MENOS UNA VEZ)
// ============================================================================

Console.WriteLine("\n📋 6. CICLO DO-WHILE");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("💡 do { código } while (condición);");
Console.WriteLine("🔑 Diferencia: Se ejecuta AL MENOS UNA VEZ");

int opcion;
do
{
    Console.WriteLine("\n🎮 MENÚ DE OPCIONES:");
    Console.WriteLine("   1. Saludar");
    Console.WriteLine("   2. Mostrar fecha");
    Console.WriteLine("   3. Número aleatorio");
    Console.WriteLine("   4. Salir");
    Console.Write("🎯 Elige una opción (1-4): ");
    
    string inputOpcion = Console.ReadLine() ?? "";
    
    if (int.TryParse(inputOpcion, out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("👋 ¡Hola! ¿Cómo estás?");
                Console.ResetColor();
                break;
                
            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"📅 Fecha actual: {DateTime.Now:dddd, dd/MM/yyyy HH:mm}");
                Console.ResetColor();
                break;
                
            case 3:
                int aleatorio = new Random().Next(1, 101);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"🎲 Número aleatorio: {aleatorio}");
                Console.ResetColor();
                break;
                
            case 4:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("👋 ¡Hasta luego!");
                Console.ResetColor();
                break;
                
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Opción inválida. Intenta de nuevo.");
                Console.ResetColor();
                break;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Ingresa un número válido");
        Console.ResetColor();
        opcion = 0; // Para que continue el ciclo
    }
    
} while (opcion != 4);

// ============================================================================
// 7. FOREACH PARA COLECCIONES
// ============================================================================

Console.WriteLine("\n📋 7. CICLO FOREACH");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("💡 foreach (elemento in colección) { código }");
Console.WriteLine("🎯 Ideal para recorrer arrays y listas");

// Array de nombres
string[] nombres = { "Ana", "Carlos", "María", "Pedro", "Lucía" };

Console.WriteLine("\n👥 Lista de estudiantes:");
int posicion = 1;
foreach (string nombre in nombres)
{
    Console.WriteLine($"   {posicion}. {nombre}");
    posicion++;
}

// Lista de números
List<int> numeros = new List<int> { 10, 25, 30, 45, 50 };

Console.WriteLine("\n🔢 Procesando números:");
foreach (int numero in numeros)
{
    string estado = numero % 2 == 0 ? "par" : "impar";
    Console.WriteLine($"   {numero} es {estado}");
}

// ============================================================================
// 8. CONTROL DE FLUJO: BREAK Y CONTINUE
// ============================================================================

Console.WriteLine("\n📋 8. CONTROL DE FLUJO: BREAK Y CONTINUE");
Console.WriteLine("-".PadRight(50, '-'));

Console.WriteLine("🛑 BREAK - Termina el ciclo completamente");
Console.WriteLine("⏭️ CONTINUE - Salta a la siguiente iteración");

Console.WriteLine("\n🔍 Ejemplo con BREAK:");
for (int i = 1; i <= 10; i++)
{
    if (i == 6)
    {
        Console.WriteLine($"   💥 BREAK en i = {i} - Terminando ciclo");
        break;
    }
    Console.WriteLine($"   Procesando: {i}");
}

Console.WriteLine("\n🔍 Ejemplo con CONTINUE:");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"   ⏭️ CONTINUE en i = {i} (par) - Saltando");
        continue;
    }
    Console.WriteLine($"   Procesando impar: {i}");
}

// ============================================================================
// 9. CICLOS ANIDADOS
// ============================================================================

Console.WriteLine("\n📋 9. CICLOS ANIDADOS");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🎯 Tabla de multiplicar:");
Console.Write("🔢 ¿Qué tabla quieres generar? ");
string inputTabla = Console.ReadLine() ?? "";

if (int.TryParse(inputTabla, out int tabla))
{
    Console.WriteLine($"\n📊 Tabla del {tabla}:");
    Console.WriteLine("-".PadRight(25, '-'));
    
    for (int i = 1; i <= 10; i++)
    {
        int resultado = tabla * i;
        Console.WriteLine($"   {tabla} × {i,2} = {resultado,3}");
        Thread.Sleep(200);
    }
}

Console.WriteLine("\n🎨 Patrón de asteriscos:");
for (int fila = 1; fila <= 5; fila++)
{
    // Espacios para centrar
    for (int espacio = 5; espacio > fila; espacio--)
    {
        Console.Write(" ");
    }
    
    // Asteriscos
    for (int asterisco = 1; asterisco <= fila; asterisco++)
    {
        Console.Write("* ");
    }
    
    Console.WriteLine(); // Nueva línea
    Thread.Sleep(300);
}

// ============================================================================
// 10. EJERCICIO PRÁCTICO: CALCULADORA SIMPLE
// ============================================================================

Console.WriteLine("\n📋 10. EJERCICIO PRÁCTICO: CALCULADORA");
Console.WriteLine("-".PadRight(45, '-'));

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n🧮 CALCULADORA SIMPLE");
    Console.Write("🔢 Primer número: ");
    string num1 = Console.ReadLine() ?? "";
    
    Console.Write("🔢 Segundo número: ");
    string num2 = Console.ReadLine() ?? "";
    
    Console.WriteLine("\n⚙️ Operaciones disponibles:");
    Console.WriteLine("   1. Sumar (+)");
    Console.WriteLine("   2. Restar (-)");
    Console.WriteLine("   3. Multiplicar (×)");
    Console.WriteLine("   4. Dividir (÷)");
    
    Console.Write("🎯 Elige operación (1-4): ");
    string operacion = Console.ReadLine() ?? "";
    
    if (double.TryParse(num1, out double n1) && 
        double.TryParse(num2, out double n2) && 
        int.TryParse(operacion, out int op))
    {
        double resultado = op switch
        {
            1 => n1 + n2,
            2 => n1 - n2,
            3 => n1 * n2,
            4 => n2 != 0 ? n1 / n2 : double.NaN,
            _ => double.NaN
        };
        
        string simbolo = op switch
        {
            1 => "+",
            2 => "-", 
            3 => "×",
            4 => "÷",
            _ => "?"
        };
        
        if (!double.IsNaN(resultado))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n📊 Resultado: {n1} {simbolo} {n2} = {resultado}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Error: División por cero u operación inválida");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: Ingresa números y operación válidos");
        Console.ResetColor();
    }
    
    Console.Write("\n🔄 ¿Realizar otro cálculo? (s/n): ");
    char respuesta = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
    
    continuar = respuesta == 's';
}

// ============================================================================
// 11. COMPARACIÓN DE RENDIMIENTO
// ============================================================================

Console.WriteLine("\n📋 11. COMPARACIÓN DE RENDIMIENTO");
Console.WriteLine("-".PadRight(45, '-'));

Console.WriteLine("⏱️ Midiendo tiempo de ejecución...");

// FOR vs WHILE para contar hasta 1,000,000
DateTime inicio = DateTime.Now;

// Ciclo FOR
for (int i = 0; i < 1000000; i++)
{
    // Operación simple
}

DateTime finFor = DateTime.Now;

// Ciclo WHILE
int j = 0;
while (j < 1000000)
{
    j++;
}

DateTime finWhile = DateTime.Now;

Console.WriteLine($"🏃‍♂️ FOR:   {(finFor - inicio).TotalMilliseconds:F2} ms");
Console.WriteLine($"🚶‍♂️ WHILE: {(finWhile - finFor).TotalMilliseconds:F2} ms");
Console.WriteLine("📊 En general, FOR y WHILE tienen rendimiento similar");

// ============================================================================
// 12. RESUMEN Y BUENAS PRÁCTICAS
// ============================================================================

Console.WriteLine("\n📋 12. RESUMEN Y BUENAS PRÁCTICAS");
Console.WriteLine("=".PadRight(50, '='));

Console.WriteLine("\n✅ CUÁNDO USAR CADA CICLO:");
Console.WriteLine("   📊 FOR:");
Console.WriteLine("      • Cuando conoces el número de iteraciones");
Console.WriteLine("      • Para recorrer arrays con índice");
Console.WriteLine("      • Contadores simples");
Console.WriteLine();
Console.WriteLine("   🔄 WHILE:");
Console.WriteLine("      • Condiciones complejas");
Console.WriteLine("      • Número de iteraciones desconocido");
Console.WriteLine("      • Validación de entrada del usuario");
Console.WriteLine();
Console.WriteLine("   🎯 DO-WHILE:");
Console.WriteLine("      • Cuando necesitas ejecutar al menos una vez");
Console.WriteLine("      • Menús interactivos");
Console.WriteLine("      • Validaciones que requieren entrada inicial");
Console.WriteLine();
Console.WriteLine("   📋 FOREACH:");
Console.WriteLine("      • Recorrer colecciones sin necesidad de índice");
Console.WriteLine("      • Cuando solo necesitas leer elementos");
Console.WriteLine("      • Código más limpio y legible");

Console.WriteLine("\n🚫 ERRORES COMUNES A EVITAR:");
Console.WriteLine("   • Ciclos infinitos (olvidar incrementar contador)");
Console.WriteLine("   • Modificar la variable del ciclo dentro del FOR");
Console.WriteLine("   • No validar entradas en ciclos WHILE");
Console.WriteLine("   • Usar BREAK/CONTINUE innecesariamente");

Console.WriteLine("\n🎯 CONSEJOS DE RENDIMIENTO:");
Console.WriteLine("   • Evita operaciones costosas dentro de ciclos");
Console.WriteLine("   • Usa FOREACH para colecciones cuando sea posible");
Console.WriteLine("   • Considera usar LINQ para operaciones complejas");
Console.WriteLine("   • Cachea resultados de cálculos repetitivos");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de ciclos en C#!");
Console.WriteLine("Presiona cualquier tecla para finalizar...");
Console.ReadKey();