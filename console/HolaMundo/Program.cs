// ============================================================================
// VARIABLES Y TIPOS DE DATOS PRIMITIVOS EN C#
// ============================================================================

Console.WriteLine("=== TIPOS DE DATOS PRIMITIVOS EN C# ===\n");

// 1. TIPOS NUMERICOS ENTEROS
Console.WriteLine("1. TIPOS NUMERICOS ENTEROS:");
byte edad = 30;                    // 8 bits (0-255)
short anio = 2025;                 // 16 bits (-32,768 a 32,767)
int poblacion = 1000000;           // 32 bits (-2,147,483,648 a 2,147,483,647)
long habitantes = 7800000000L;     // 64 bits (muy grandes)

Console.WriteLine($"   byte edad = {edad} (rango: 0 a 255)");
Console.WriteLine($"   short anio = {anio} (rango: -32,768 a 32,767)");
Console.WriteLine($"   int poblacion = {poblacion:N0}");
Console.WriteLine($"   long habitantes = {habitantes:N0}");

// 2. TIPOS NUMERICOS DECIMALES
Console.WriteLine("\n2. TIPOS NUMERICOS DECIMALES:");
float temperatura = 36.5f;         // 32 bits, precisión ~7 dígitos
double altura = 1.75;              // 64 bits, precisión ~15-17 dígitos
decimal precio = 29.99m;           // 128 bits, precisión ~28-29 dígitos (ideal para dinero)

Console.WriteLine($"   float temperatura = {temperatura}°C (precisión: ~7 dígitos)");
Console.WriteLine($"   double altura = {altura}m (precisión: ~15-17 dígitos)");
Console.WriteLine($"   decimal precio = ${precio} (precisión: ~28-29 dígitos)");

// 3. TIPOS DE CARACTERES Y TEXTO
Console.WriteLine("\n3. TIPOS DE CARACTERES Y TEXTO:");
char inicial = 'A';                // Un solo carácter Unicode
string nombre = "Alex";            // Cadena de caracteres
string apellido = "Vera";

Console.WriteLine($"   char inicial = '{inicial}' (un solo carácter)");
Console.WriteLine($"   string nombre = \"{nombre}\" (cadena de caracteres)");
Console.WriteLine($"   string apellido = \"{apellido}\"");

// 4. TIPO BOOLEANO
Console.WriteLine("\n4. TIPO BOOLEANO:");
bool esEstudiante = true;          // true o false
bool esMayorDeEdad = edad >= 18;

Console.WriteLine($"   bool esEstudiante = {esEstudiante}");
Console.WriteLine($"   bool esMayorDeEdad = {esMayorDeEdad} (calculado: {edad} >= 18)");

// 5. INFERENCIA DE TIPOS CON 'var'
Console.WriteLine("\n5. INFERENCIA DE TIPOS CON 'var':");
var peso = 70.5;                   // El compilador infiere que es double
var activo = true;                 // El compilador infiere que es bool
var codigo = 12345;                // El compilador infiere que es int

Console.WriteLine($"   var peso = {peso} (inferido como: {peso.GetType().Name})");
Console.WriteLine($"   var activo = {activo} (inferido como: {activo.GetType().Name})");
Console.WriteLine($"   var codigo = {codigo} (inferido como: {codigo.GetType().Name})");

// ============================================================================
// CONSTANTES VS VARIABLES
// ============================================================================

Console.WriteLine("\n\n=== CONSTANTES VS VARIABLES ===\n");

// CONSTANTES: Valores que NO pueden cambiar durante la ejecución
Console.WriteLine("CONSTANTES (valores inmutables):");
const double PI = 3.14159;         // Constante matemática
const int DIAS_SEMANA = 7;         // Constante de configuración
const string EMPRESA = "Mi Empresa S.A."; // Constante de texto
const bool ES_VERSION_DEBUG = true; // Constante de configuración

Console.WriteLine($"   const double PI = {PI}");
Console.WriteLine($"   const int DIAS_SEMANA = {DIAS_SEMANA}");
Console.WriteLine($"   const string EMPRESA = \"{EMPRESA}\"");
Console.WriteLine($"   const bool ES_VERSION_DEBUG = {ES_VERSION_DEBUG}");

// Intentar cambiar una constante causaría un error de compilación:
// PI = 3.14; // ❌ ERROR: No se puede asignar a una constante

// VARIABLES: Valores que SÍ pueden cambiar durante la ejecución
Console.WriteLine("\nVARIABLES (valores mutables):");
string nombreUsuario = "Alex";     // Puede cambiar
int intentos = 0;                  // Puede cambiar
double saldo = 1000.50;            // Puede cambiar

Console.WriteLine($"   Valores iniciales:");
Console.WriteLine($"   string nombreUsuario = \"{nombreUsuario}\"");
Console.WriteLine($"   int intentos = {intentos}");
Console.WriteLine($"   double saldo = ${saldo}");

// Modificando las variables
nombreUsuario = "Alex Vera";       // ✅ Válido: las variables pueden cambiar
intentos++;                        // ✅ Válido: incrementar
saldo -= 50.25;                    // ✅ Válido: restar del saldo

Console.WriteLine($"\n   Después de modificaciones:");
Console.WriteLine($"   nombreUsuario = \"{nombreUsuario}\" (cambió)");
Console.WriteLine($"   intentos = {intentos} (incrementó)");
Console.WriteLine($"   saldo = ${saldo} (decrementó)");

// ============================================================================
// CUÁNDO USAR CADA UNA
// ============================================================================

Console.WriteLine("\n\n=== CUÁNDO USAR CONSTANTES VS VARIABLES ===\n");

Console.WriteLine("USA CONSTANTES cuando:");
Console.WriteLine("  • El valor NUNCA cambiará (PI, días de la semana)");
Console.WriteLine("  • Configuraciones fijas del sistema");
Console.WriteLine("  • Valores que definen límites o reglas de negocio");
Console.WriteLine("  • Mejora la legibilidad y mantención del código");

Console.WriteLine("\nUSA VARIABLES cuando:");
Console.WriteLine("  • El valor puede cambiar durante la ejecución");
Console.WriteLine("  • Almacenas datos ingresados por el usuario");
Console.WriteLine("  • Realizas cálculos que pueden variar");
Console.WriteLine("  • Necesitas flexibilidad en tu programa");

// ============================================================================
// EJEMPLOS PRÁCTICOS
// ============================================================================

Console.WriteLine("\n\n=== EJEMPLOS PRÁCTICOS ===\n");

// Ejemplo 1: Calculadora de área de círculo
Console.WriteLine("Ejemplo 1: Calculadora de área de círculo");
const double PI_EXACTO = 3.14159265359; // Constante: nunca cambia
double radio = 5.0;                      // Variable: puede cambiar
double area = PI_EXACTO * radio * radio; // Cálculo usando constante y variable

Console.WriteLine($"   Radio: {radio} metros");
Console.WriteLine($"   Área: {area:F2} metros cuadrados");

// Cambiar el radio (la variable)
radio = 10.0;
area = PI_EXACTO * radio * radio;
Console.WriteLine($"   Nuevo radio: {radio} metros");
Console.WriteLine($"   Nueva área: {area:F2} metros cuadrados");

// Ejemplo 2: Sistema de calificaciones
Console.WriteLine("\nEjemplo 2: Sistema de calificaciones");
const double NOTA_MAXIMA = 10.0;        // Constante: la nota máxima no cambia
const double NOTA_APROBACION = 6.0;     // Constante: la nota mínima para aprobar
double notaEstudiante = 8.5;            // Variable: cada estudiante tiene diferente nota

Console.WriteLine($"   Nota máxima posible: {NOTA_MAXIMA}");
Console.WriteLine($"   Nota mínima para aprobar: {NOTA_APROBACION}");
Console.WriteLine($"   Nota del estudiante: {notaEstudiante}");
Console.WriteLine($"   ¿Aprobó?: {(notaEstudiante >= NOTA_APROBACION ? "Sí" : "No")}");

Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
