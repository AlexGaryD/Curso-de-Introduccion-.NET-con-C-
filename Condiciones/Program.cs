// ============================================================================
// SENTENCIAS IF Y OPERADORES LÓGICOS EN C# - GUÍA COMPLETA E INTERACTIVA
// ============================================================================

using System;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("🎯 SENTENCIAS IF Y OPERADORES LÓGICOS EN C#");
Console.WriteLine("=".PadRight(50, '='));
Console.ResetColor();

// ============================================================================
// 1. ESTRUCTURA IF BÁSICA
// ============================================================================

Console.WriteLine("\n📋 1. ESTRUCTURA IF BÁSICA");
Console.WriteLine("-".PadRight(40, '-'));

// Ejemplo simple de if
int edad = 25;
Console.WriteLine($"💡 Ejemplo: edad = {edad}");

if (edad >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("✅ Eres mayor de edad");
    Console.ResetColor();
}

Console.WriteLine("\n🔍 Análisis del código:");
Console.WriteLine("   if (edad >= 18)  ← Condición booleana");
Console.WriteLine("   {");
Console.WriteLine("       // Código que se ejecuta SI la condición es TRUE");
Console.WriteLine("   }");

// ============================================================================
// 2. ESTRUCTURA IF-ELSE COMPLETA
// ============================================================================

Console.WriteLine("\n📋 2. ESTRUCTURA IF-ELSE");
Console.WriteLine("-".PadRight(40, '-'));

Console.Write("🎂 Ingresa tu edad: ");
string inputEdad = Console.ReadLine() ?? "";

if (int.TryParse(inputEdad, out int edadUsuario))
{
    Console.WriteLine($"\n💭 Evaluando: {edadUsuario} >= 18");
    
    if (edadUsuario >= 18)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ Eres mayor de edad - Puedes votar");
        Console.ResetColor();
        
        // Condición anidada para licencia de conducir
        if (edadUsuario >= 16)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("🚗 También puedes obtener licencia de conducir");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("⚠️  Eres menor de edad - No puedes votar");
        Console.ResetColor();
        
        int aniosRestantes = 18 - edadUsuario;
        Console.WriteLine($"📅 Te faltan {aniosRestantes} años para ser mayor de edad");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("❌ Error: Ingresa un número válido");
    Console.ResetColor();
}

// ============================================================================
// 3. ESTRUCTURA IF-ELSE IF-ELSE (MÚLTIPLES CONDICIONES)
// ============================================================================

Console.WriteLine("\n📋 3. MÚLTIPLES CONDICIONES (IF-ELSE IF-ELSE)");
Console.WriteLine("-".PadRight(50, '-'));

Console.Write("📊 Ingresa tu calificación (0-100): ");
string inputCalificacion = Console.ReadLine() ?? "";

if (double.TryParse(inputCalificacion, out double calificacion))
{
    Console.WriteLine($"\n🎯 Evaluando calificación: {calificacion}");
    
    if (calificacion >= 90)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🏆 EXCELENTE (A) - ¡Felicitaciones!");
        Console.ResetColor();
    }
    else if (calificacion >= 80)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("👍 MUY BUENO (B) - Buen trabajo");
        Console.ResetColor();
    }
    else if (calificacion >= 70)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("📝 BUENO (C) - Puedes mejorar");
        Console.ResetColor();
    }
    else if (calificacion >= 60)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("⚡ SUFICIENTE (D) - Necesitas estudiar más");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ INSUFICIENTE (F) - Debes mejorar mucho");
        Console.ResetColor();
    }
    
    // Mostrar el flujo de evaluación
    Console.WriteLine("\n🔍 Flujo de evaluación:");
    Console.WriteLine($"   calificacion >= 90? {(calificacion >= 90 ? "TRUE ✅" : "FALSE ❌")}");
    if (calificacion < 90)
        Console.WriteLine($"   calificacion >= 80? {(calificacion >= 80 ? "TRUE ✅" : "FALSE ❌")}");
    if (calificacion < 80)
        Console.WriteLine($"   calificacion >= 70? {(calificacion >= 70 ? "TRUE ✅" : "FALSE ❌")}");
    if (calificacion < 70)
        Console.WriteLine($"   calificacion >= 60? {(calificacion >= 60 ? "TRUE ✅" : "FALSE ❌")}");
}

// ============================================================================
// 4. OPERADORES LÓGICOS
// ============================================================================

Console.WriteLine("\n📋 4. OPERADORES LÓGICOS");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🔧 Los operadores lógicos en C#:");
Console.WriteLine("   && (AND)  - Ambas condiciones deben ser TRUE");
Console.WriteLine("   || (OR)   - Al menos una condición debe ser TRUE");
Console.WriteLine("   !  (NOT)  - Invierte el valor booleano");

// Ejemplo práctico con operador AND (&&)
Console.WriteLine("\n🎯 OPERADOR AND (&&):");
Console.Write("💰 Ingresa tu salario mensual: $");
string inputSalario = Console.ReadLine() ?? "";

if (double.TryParse(inputSalario, out double salario))
{
    bool tieneTrabajo = salario > 0;
    bool salarioDecente = salario >= 1000;
    
    Console.WriteLine($"\n📊 Análisis:");
    Console.WriteLine($"   Tiene trabajo: {tieneTrabajo}");
    Console.WriteLine($"   Salario >= $1000: {salarioDecente}");
    Console.WriteLine($"   Resultado AND: {tieneTrabajo} && {salarioDecente} = {tieneTrabajo && salarioDecente}");
    
    if (tieneTrabajo && salarioDecente)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ Califica para un préstamo bancario");
        Console.ResetColor();
    }
    else if (tieneTrabajo && !salarioDecente)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("⚠️  Tiene trabajo pero salario insuficiente para préstamo");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ No califica para préstamo - Sin trabajo");
        Console.ResetColor();
    }
}

// Ejemplo práctico con operador OR (||)
Console.WriteLine("\n🎯 OPERADOR OR (||):");
Console.Write("🎓 ¿Eres estudiante? (s/n): ");
char esEstudiante = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

Console.Write("👴 ¿Eres mayor de 65 años? (s/n): ");
char esMayor65 = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

bool estudianteDescuento = esEstudiante == 's';
bool mayoresDe65Descuento = esMayor65 == 's';

Console.WriteLine($"\n📊 Análisis:");
Console.WriteLine($"   Es estudiante: {estudianteDescuento}");
Console.WriteLine($"   Es mayor de 65: {mayoresDe65Descuento}");
Console.WriteLine($"   Resultado OR: {estudianteDescuento} || {mayoresDe65Descuento} = {estudianteDescuento || mayoresDe65Descuento}");

if (estudianteDescuento || mayoresDe65Descuento)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("🎉 ¡Tienes descuento del 20%!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("💰 Precio normal - Sin descuento");
    Console.ResetColor();
}

// Ejemplo práctico con operador NOT (!)
Console.WriteLine("\n🎯 OPERADOR NOT (!):");
Console.Write("☔ ¿Está lloviendo? (s/n): ");
char lluvia = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

bool estaLloviendo = lluvia == 's';
bool noEstaLloviendo = !estaLloviendo;

Console.WriteLine($"\n📊 Análisis:");
Console.WriteLine($"   Está lloviendo: {estaLloviendo}");
Console.WriteLine($"   NO está lloviendo: !{estaLloviendo} = {noEstaLloviendo}");

if (!estaLloviendo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("☀️ ¡Perfecto para salir a caminar!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("🏠 Mejor quedarse en casa");
    Console.ResetColor();
}

// ============================================================================
// 5. OPERADORES LÓGICOS COMBINADOS
// ============================================================================

Console.WriteLine("\n📋 5. COMBINACIÓN DE OPERADORES LÓGICOS");
Console.WriteLine("-".PadRight(50, '-'));

Console.Write("🌡️ Temperatura actual (°C): ");
string inputTemp = Console.ReadLine() ?? "";

if (double.TryParse(inputTemp, out double temperatura))
{
    Console.Write("💨 ¿Hay viento fuerte? (s/n): ");
    char viento = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
    
    Console.Write("🌧️ ¿Está lloviendo? (s/n): ");
    char llueve = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
    
    bool temperaturaIdeal = temperatura >= 18 && temperatura <= 25;
    bool vientoFuerte = viento == 's';
    bool estaLluvioso = llueve == 's';
    
    Console.WriteLine($"\n🔍 Análisis completo:");
    Console.WriteLine($"   Temperatura ideal (18-25°C): {temperaturaIdeal}");
    Console.WriteLine($"   Viento fuerte: {vientoFuerte}");
    Console.WriteLine($"   Está lloviendo: {estaLluvioso}");
    
    // Condición compleja: buen clima para actividad al aire libre
    bool buenClima = temperaturaIdeal && !vientoFuerte && !estaLluvioso;
    
    Console.WriteLine($"\n🎯 Evaluación final:");
    Console.WriteLine($"   ({temperaturaIdeal} && !{vientoFuerte} && !{estaLluvioso})");
    Console.WriteLine($"   = ({temperaturaIdeal} && {!vientoFuerte} && {!estaLluvioso})");
    Console.WriteLine($"   = {buenClima}");
    
    if (buenClima)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("🌟 ¡Excelente día para actividades al aire libre!");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("🏠 Mejor planear actividades bajo techo");
        
        // Sugerencias específicas
        if (!temperaturaIdeal)
            Console.WriteLine($"   - Temperatura no ideal: {temperatura}°C");
        if (vientoFuerte)
            Console.WriteLine("   - Hay viento fuerte");
        if (estaLluvioso)
            Console.WriteLine("   - Está lloviendo");
            
        Console.ResetColor();
    }
}

// ============================================================================
// 6. CONDICIONAL TERNARIO (OPERADOR ? :)
// ============================================================================

Console.WriteLine("\n📋 6. OPERADOR TERNARIO (? :)");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("💡 Sintaxis: condición ? valorSiTrue : valorSiFalse");

Console.Write("🔢 Ingresa un número: ");
string inputNumero = Console.ReadLine() ?? "";

if (int.TryParse(inputNumero, out int numero))
{
    // Operador ternario simple
    string tipoNumero = numero >= 0 ? "positivo" : "negativo";
    Console.WriteLine($"📊 {numero} es {tipoNumero}");
    
    // Operador ternario anidado
    string clasificacion = numero > 0 ? "positivo" : 
                          numero < 0 ? "negativo" : 
                          "cero";
    Console.WriteLine($"🎯 Clasificación: {numero} es {clasificacion}");
    
    // Comparación con if-else tradicional
    Console.WriteLine("\n🔍 Equivalencia:");
    Console.WriteLine($"   Ternario: numero >= 0 ? \"positivo\" : \"negativo\"");
    Console.WriteLine($"   If-else tradicional:");
    Console.WriteLine($"   if (numero >= 0)");
    Console.WriteLine($"       resultado = \"positivo\";");
    Console.WriteLine($"   else");
    Console.WriteLine($"       resultado = \"negativo\";");
}

// ============================================================================
// 7. SWITCH EXPRESSION (C# 8.0+)
// ============================================================================

Console.WriteLine("\n📋 7. SWITCH EXPRESSIONS (MODERNO)");
Console.WriteLine("-".PadRight(40, '-'));

Console.Write("📅 Ingresa un número de día (1-7): ");
string inputDia = Console.ReadLine() ?? "";

if (int.TryParse(inputDia, out int dia))
{
    // Switch expression moderno
    string nombreDia = dia switch
    {
        1 => "Lunes",
        2 => "Martes", 
        3 => "Miércoles",
        4 => "Jueves",
        5 => "Viernes",
        6 => "Sábado",
        7 => "Domingo",
        _ => "Día inválido"
    };
    
    string tipoDia = dia switch
    {
        >= 1 and <= 5 => "Día laboral 💼",
        6 or 7 => "Fin de semana 🎉",
        _ => "Día inválido ❌"
    };
    
    Console.WriteLine($"📅 Día {dia}: {nombreDia}");
    Console.WriteLine($"🏷️ Tipo: {tipoDia}");
    
    // Mostrar equivalencia con switch tradicional
    Console.WriteLine("\n🔍 Switch tradicional equivalente:");
    Console.WriteLine("switch (dia)");
    Console.WriteLine("{");
    Console.WriteLine("    case 1: nombreDia = \"Lunes\"; break;");
    Console.WriteLine("    case 2: nombreDia = \"Martes\"; break;");
    Console.WriteLine("    // ... más casos");
    Console.WriteLine("    default: nombreDia = \"Día inválido\"; break;");
    Console.WriteLine("}");
}

// ============================================================================
// 8. EJERCICIO PRÁCTICO INTERACTIVO
// ============================================================================

Console.WriteLine("\n📋 8. EJERCICIO PRÁCTICO: SISTEMA DE ACCESO");
Console.WriteLine("-".PadRight(50, '-'));

Console.Write("👤 Nombre de usuario: ");
string usuario = Console.ReadLine() ?? "";

Console.Write("🔐 Contraseña: ");
string password = Console.ReadLine() ?? "";

Console.Write("👑 ¿Eres administrador? (s/n): ");
char esAdmin = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

// Simulación de credenciales válidas
bool usuarioValido = usuario.ToLower() == "admin" || usuario.ToLower() == "user";
bool passwordValido = password == "123456";
bool esAdministrador = esAdmin == 's';

Console.WriteLine($"\n🔍 Verificación de acceso:");
Console.WriteLine($"   Usuario válido: {usuarioValido}");
Console.WriteLine($"   Password correcto: {passwordValido}");
Console.WriteLine($"   Es administrador: {esAdministrador}");

// Lógica compleja de acceso
if (usuarioValido && passwordValido)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("✅ ¡Acceso concedido!");
    Console.ResetColor();
    
    if (esAdministrador)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("👑 Acceso de administrador - Todos los permisos");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("👤 Acceso de usuario estándar - Permisos limitados");
        Console.ResetColor();
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("❌ Acceso denegado");
    
    if (!usuarioValido && !passwordValido)
        Console.WriteLine("   Razón: Usuario y contraseña incorrectos");
    else if (!usuarioValido)
        Console.WriteLine("   Razón: Usuario incorrecto");
    else
        Console.WriteLine("   Razón: Contraseña incorrecta");
        
    Console.ResetColor();
}

// ============================================================================
// 9. RESUMEN Y BUENAS PRÁCTICAS
// ============================================================================

Console.WriteLine("\n📋 9. RESUMEN Y BUENAS PRÁCTICAS");
Console.WriteLine("=".PadRight(50, '='));

Console.WriteLine("\n✅ BUENAS PRÁCTICAS:");
Console.WriteLine("   • Usa paréntesis para clarificar condiciones complejas");
Console.WriteLine("   • Prefiere switch expressions para múltiples valores");
Console.WriteLine("   • Usa operador ternario para asignaciones simples");
Console.WriteLine("   • Valida siempre las entradas del usuario");
Console.WriteLine("   • Usa nombres descriptivos para variables booleanas");

Console.WriteLine("\n🚫 EVITA:");
Console.WriteLine("   • Condiciones demasiado complejas en una línea");
Console.WriteLine("   • Anidar muchos if-else (considera switch)");
Console.WriteLine("   • Comparar booleanos con == true");

Console.WriteLine("\n📚 OPERADORES APRENDIDOS:");
Console.WriteLine("   • if, else if, else");
Console.WriteLine("   • && (AND), || (OR), ! (NOT)");
Console.WriteLine("   • ?: (ternario)");
Console.WriteLine("   • switch expressions");
Console.WriteLine("   • Pattern matching");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de condiciones en C#!");
Console.WriteLine("Presiona cualquier tecla para continuar...");
Console.ReadKey();
