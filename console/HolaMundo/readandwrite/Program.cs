using System.Globalization;

// ============================================================================
// APLICACIONES INTERACTIVAS CON ENTRADA Y SALIDA EN C#
// ============================================================================

Console.Clear(); // Limpiar la consola para una mejor presentación

// ============================================================================
// 1. MÉTODOS BÁSICOS DE SALIDA (OUTPUT)
// ============================================================================

Console.WriteLine("=== MÉTODOS DE SALIDA EN C# ===\n");

// Console.WriteLine() - Escribe una línea y salta a la siguiente
Console.WriteLine("1. Console.WriteLine() - Escribe y salta línea");

// Console.Write() - Escribe sin saltar de línea
Console.Write("2. Console.Write() - Escribe sin saltar: ");
Console.Write("Texto continuado ");
Console.WriteLine("en la misma línea\n");

// Formateo con colores (opcional, mejora la experiencia)
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("3. Texto con color verde");
Console.ResetColor(); // Volver al color original

// ============================================================================
// 2. MÉTODOS BÁSICOS DE ENTRADA (INPUT)
// ============================================================================

Console.WriteLine("\n=== MÉTODOS DE ENTRADA EN C# ===\n");

// Entrada básica de texto con validación
string nombre = "";
do
{
    Console.Write("📝 Escribe tu nombre (mínimo 2 caracteres): ");
    nombre = Console.ReadLine() ?? ""; // ?? "" evita valores null
    
    if (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: El nombre debe tener al menos 2 caracteres.");
        Console.ResetColor();
    }
} while (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 2);

// Capitalizar la primera letra del nombre
nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre.ToLower());

// Entrada de apellido con validación
string apellido = "";
do
{
    Console.Write("📝 Escribe tu apellido (mínimo 2 caracteres): ");
    apellido = Console.ReadLine() ?? "";
    
    if (string.IsNullOrWhiteSpace(apellido) || apellido.Length < 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: El apellido debe tener al menos 2 caracteres.");
        Console.ResetColor();
    }
} while (string.IsNullOrWhiteSpace(apellido) || apellido.Length < 2);

apellido = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apellido.ToLower());

// ============================================================================
// 3. CONVERSIÓN SEGURA DE TIPOS DE DATOS
// ============================================================================

Console.WriteLine("\n=== CONVERSIÓN SEGURA DE DATOS ===\n");

// Método 1: int.Parse() (puede fallar si el input es inválido)
int edad = 0;
bool edadValida = false;

do
{
    Console.Write("🎂 Escribe tu edad (5-120 años): ");
    string inputEdad = Console.ReadLine() ?? "";
    
    // Método seguro: int.TryParse()
    if (int.TryParse(inputEdad, out edad))
    {
        if (edad >= 5 && edad <= 120)
        {
            edadValida = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚠️  La edad debe estar entre 5 y 120 años.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: Debes ingresar un número válido.");
        Console.ResetColor();
    }
} while (!edadValida);

// Entrada de peso con validación para decimales
double peso = 0;
bool pesoValido = false;

do
{
    Console.Write("⚖️  Escribe tu peso en kg (30-300 kg): ");
    string inputPeso = Console.ReadLine() ?? "";
    
    // Método seguro: double.TryParse()
    if (double.TryParse(inputPeso, out peso))
    {
        if (peso >= 30 && peso <= 300)
        {
            pesoValido = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚠️  El peso debe estar entre 30 y 300 kg.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: Debes ingresar un número válido (usa . para decimales).");
        Console.ResetColor();
    }
} while (!pesoValido);

// Entrada de altura con validación
double altura = 0;
bool alturaValida = false;

do
{
    Console.Write("📏 Escribe tu altura en metros (0.5-3.0 m): ");
    string inputAltura = Console.ReadLine() ?? "";
    
    if (double.TryParse(inputAltura, out altura))
    {
        if (altura >= 0.5 && altura <= 3.0)
        {
            alturaValida = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("⚠️  La altura debe estar entre 0.5 y 3.0 metros.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: Debes ingresar un número válido (ejemplo: 1.75).");
        Console.ResetColor();
    }
} while (!alturaValida);

// ============================================================================
// 4. ENTRADA DE OPCIONES Y MENÚS INTERACTIVOS
// ============================================================================

Console.WriteLine("\n=== MENÚS INTERACTIVOS ===\n");

// Menú de opciones
Console.WriteLine("🎓 ¿Cuál es tu nivel de estudios?");
Console.WriteLine("1. Primaria");
Console.WriteLine("2. Secundaria");
Console.WriteLine("3. Universidad");
Console.WriteLine("4. Posgrado");

int opcionEstudios = 0;
bool opcionValida = false;
string nivelEstudios = "";

do
{
    Console.Write("Selecciona una opción (1-4): ");
    string input = Console.ReadLine() ?? "";
    
    if (int.TryParse(input, out opcionEstudios) && opcionEstudios >= 1 && opcionEstudios <= 4)
    {
        opcionValida = true;
        nivelEstudios = opcionEstudios switch
        {
            1 => "Primaria",
            2 => "Secundaria", 
            3 => "Universidad",
            4 => "Posgrado",
            _ => "No especificado"
        };
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ Error: Selecciona un número del 1 al 4.");
        Console.ResetColor();
    }
} while (!opcionValida);

// Entrada de tipo sí/no
Console.Write("\n🏃 ¿Practicas algún deporte? (s/n): ");
char deporteInput = char.ToLower(Console.ReadKey().KeyChar);
bool practicaDeporte = deporteInput == 's';
Console.WriteLine(); // Salto de línea después de ReadKey()

// ============================================================================
// 5. PRESENTACIÓN DE RESULTADOS CON FORMATO
// ============================================================================

Console.WriteLine("\n" + new string('=', 60));
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("📋 RESUMEN DE TU INFORMACIÓN");
Console.ResetColor();
Console.WriteLine(new string('=', 60));

// Información personal
Console.WriteLine($"👤 Nombre completo: {nombre} {apellido}");
Console.WriteLine($"🎂 Edad: {edad} años");
Console.WriteLine($"⚖️  Peso: {peso:F1} kg");
Console.WriteLine($"📏 Altura: {altura:F2} metros");
Console.WriteLine($"🎓 Estudios: {nivelEstudios}");
Console.WriteLine($"🏃 Deporte: {(practicaDeporte ? "Sí practica" : "No practica")}");

// ============================================================================
// 6. CÁLCULOS Y ANÁLISIS INTERACTIVOS
// ============================================================================

Console.WriteLine("\n" + new string('-', 60));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("📊 ANÁLISIS DE DATOS");
Console.ResetColor();
Console.WriteLine(new string('-', 60));

// Calcular IMC (Índice de Masa Corporal)
double imc = peso / (altura * altura);
string categoriaIMC = imc switch
{
    < 18.5 => "Bajo peso",
    >= 18.5 and < 25 => "Peso normal",
    >= 25 and < 30 => "Sobrepeso",
    >= 30 => "Obesidad",
    _ => "Valor no válido"
};

Console.WriteLine($"📈 Tu IMC es: {imc:F1} ({categoriaIMC})");

// Determinar si es mayor de edad
string mayoriaEdad = edad >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
Console.WriteLine($"🆔 Estatus legal: {mayoriaEdad}");

// Calcular año de nacimiento aproximado
int anioActual = DateTime.Now.Year;
int anioNacimiento = anioActual - edad;
Console.WriteLine($"📅 Año aproximado de nacimiento: {anioNacimiento}");

// ============================================================================
// 7. INTERACCIÓN FINAL
// ============================================================================

Console.WriteLine("\n" + new string('=', 60));
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("🎉 ¡GRACIAS POR USAR NUESTRA APLICACIÓN!");
Console.ResetColor();
Console.WriteLine(new string('=', 60));

Console.WriteLine($"¡Hola {nombre}! Ha sido un placer conocerte. 😊");

// Mensaje personalizado según la edad
if (edad < 18)
{
    Console.WriteLine("¡Sigue estudiando y persiguiendo tus sueños! 📚✨");
}
else if (edad < 30)
{
    Console.WriteLine("¡Estás en una edad fantástica llena de oportunidades! 🚀");
}
else if (edad < 50)
{
    Console.WriteLine("¡La experiencia es tu mejor aliada! 💪");
}
else
{
    Console.WriteLine("¡Tu sabiduría es invaluable! 🧠💎");
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();

// ============================================================================
// CONCEPTOS DEMOSTRADOS EN ESTA APLICACIÓN:
// ============================================================================
/*
1. Console.WriteLine() vs Console.Write() - Diferencias en salida
2. Console.ReadLine() - Lectura de texto
3. Console.ReadKey() - Lectura de una sola tecla
4. Validación de entrada con bucles do-while
5. TryParse() para conversión segura de tipos
6. Manejo de valores null con operador ??
7. Formateo de texto con interpolación de cadenas
8. Uso de colores en consola
9. Expresiones switch para múltiples opciones
10. Operador ternario para condiciones simples
11. Formateo de números decimales
12. Cálculos matemáticos con entrada del usuario
13. Menús interactivos
14. Validación de rangos de datos
15. Capitalización de texto
*/