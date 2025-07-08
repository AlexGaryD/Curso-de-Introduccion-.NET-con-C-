// ============================================================================
// CICLO FOREACH PARA CARACTERES Y CADENAS EN C# .NET - GUÍA COMPLETA
// ============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("🔤 CICLO FOREACH PARA CARACTERES Y CADENAS EN C# .NET");
Console.WriteLine("=".PadRight(60, '='));
Console.ResetColor();

// ============================================================================
// 1. FOREACH BÁSICO CON CARACTERES
// ============================================================================

Console.WriteLine("\n📋 1. FOREACH BÁSICO CON CARACTERES");
Console.WriteLine("-".PadRight(45, '-'));

Console.WriteLine("💡 En C#, un string es una secuencia de caracteres");
Console.WriteLine("🔍 Podemos iterar cada carácter con foreach");

string palabra = "PROGRAMACIÓN";
Console.WriteLine($"\n🎯 Analizando la palabra: '{palabra}'");

Console.WriteLine("\n📊 Carácter por carácter:");
int posicion = 0;
foreach (char caracter in palabra)
{
    Console.WriteLine($"   Posición {posicion,2}: '{caracter}' (Código ASCII: {(int)caracter})");
    posicion++;
    Thread.Sleep(200);
}

Console.WriteLine($"\n📏 Total de caracteres: {palabra.Length}");

// ============================================================================
// 2. FOREACH INTERACTIVO CON ENTRADA DEL USUARIO
// ============================================================================

Console.WriteLine("\n📋 2. ANÁLISIS INTERACTIVO DE TEXTO");
Console.WriteLine("-".PadRight(45, '-'));

Console.Write("✏️ Escribe una palabra o frase: ");
string textoUsuario = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(textoUsuario))
{
    Console.WriteLine($"\n🔍 Analizando: '{textoUsuario}'");
    
    // Contadores
    int contadorVocales = 0;
    int contadorConsonantes = 0;
    int contadorNumeros = 0;
    int contadorEspacios = 0;
    int contadorEspeciales = 0;
    
    // Vocales para comparar
    string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";
    
    Console.WriteLine("\n📊 Análisis detallado:");
    posicion = 0;
    
    foreach (char c in textoUsuario)
    {
        string tipo = "";
        ConsoleColor color = ConsoleColor.White;
        
        if (char.IsLetter(c))
        {
            if (vocales.Contains(c))
            {
                tipo = "Vocal";
                color = ConsoleColor.Green;
                contadorVocales++;
            }
            else
            {
                tipo = "Consonante";
                color = ConsoleColor.Blue;
                contadorConsonantes++;
            }
        }
        else if (char.IsDigit(c))
        {
            tipo = "Número";
            color = ConsoleColor.Yellow;
            contadorNumeros++;
        }
        else if (char.IsWhiteSpace(c))
        {
            tipo = "Espacio";
            color = ConsoleColor.Gray;
            contadorEspacios++;
        }
        else
        {
            tipo = "Especial";
            color = ConsoleColor.Magenta;
            contadorEspeciales++;
        }
        
        Console.ForegroundColor = color;
        Console.WriteLine($"   [{posicion,2}] '{c}' → {tipo}");
        Console.ResetColor();
        
        posicion++;
        Thread.Sleep(100);
    }
    
    // Resumen estadístico
    Console.WriteLine("\n📈 RESUMEN ESTADÍSTICO:");
    Console.WriteLine($"   🔤 Total caracteres: {textoUsuario.Length}");
    Console.WriteLine($"   🟢 Vocales: {contadorVocales}");
    Console.WriteLine($"   🔵 Consonantes: {contadorConsonantes}");
    Console.WriteLine($"   🟡 Números: {contadorNumeros}");
    Console.WriteLine($"   ⚪ Espacios: {contadorEspacios}");
    Console.WriteLine($"   🟣 Especiales: {contadorEspeciales}");
}

// ============================================================================
// 3. TRANSFORMACIÓN DE CARACTERES CON FOREACH
// ============================================================================

Console.WriteLine("\n📋 3. TRANSFORMACIÓN DE CARACTERES");
Console.WriteLine("-".PadRight(45, '-'));

Console.Write("🔄 Ingresa texto para transformar: ");
string textoTransformar = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(textoTransformar))
{
    Console.WriteLine($"\n📝 Texto original: '{textoTransformar}'");
    
    // Diferentes transformaciones usando foreach
    StringBuilder textoInvertido = new StringBuilder();
    StringBuilder textoMayusculas = new StringBuilder();
    StringBuilder textoMinusculas = new StringBuilder();
    StringBuilder textoSinVocales = new StringBuilder();
    StringBuilder textoCifrado = new StringBuilder();
    
    string vocalesParaEliminar = "aeiouAEIOU";
    
    Console.WriteLine("\n🔄 Procesando transformaciones...");
    
    foreach (char c in textoTransformar)
    {
        // 1. Texto invertido (se construye al revés)
        textoInvertido.Insert(0, c);
        
        // 2. Todo en mayúsculas
        textoMayusculas.Append(char.ToUpper(c));
        
        // 3. Todo en minúsculas
        textoMinusculas.Append(char.ToLower(c));
        
        // 4. Sin vocales
        if (!vocalesParaEliminar.Contains(c))
        {
            textoSinVocales.Append(c);
        }
        
        // 5. Cifrado simple (ROT1 - cada letra +1)
        if (char.IsLetter(c))
        {
            if (char.IsUpper(c))
            {
                textoCifrado.Append((char)((c - 'A' + 1) % 26 + 'A'));
            }
            else
            {
                textoCifrado.Append((char)((c - 'a' + 1) % 26 + 'a'));
            }
        }
        else
        {
            textoCifrado.Append(c);
        }
        
        Thread.Sleep(50);
    }
    
    Console.WriteLine("\n✨ RESULTADOS DE TRANSFORMACIONES:");
    Console.WriteLine($"   🔄 Invertido:     '{textoInvertido}'");
    Console.WriteLine($"   📢 Mayúsculas:    '{textoMayusculas}'");
    Console.WriteLine($"   🔻 Minúsculas:    '{textoMinusculas}'");
    Console.WriteLine($"   🚫 Sin vocales:   '{textoSinVocales}'");
    Console.WriteLine($"   🔐 Cifrado ROT1:  '{textoCifrado}'");
}

// ============================================================================
// 4. FOREACH CON ARRAYS DE STRINGS
// ============================================================================

Console.WriteLine("\n📋 4. FOREACH CON ARRAYS DE CADENAS");
Console.WriteLine("-".PadRight(45, '-'));

string[] nombres = { "Ana María", "Carlos", "Sofía", "Diego", "Valentina" };
string[] ciudades = { "Madrid", "Barcelona", "Valencia", "Sevilla", "Bilbao" };
string[] lenguajes = { "C#", "Python", "JavaScript", "Java", "Go" };

Console.WriteLine("👥 ANÁLISIS DE NOMBRES:");
foreach (string nombre in nombres)
{
    int longitud = nombre.Length;
    int espacios = nombre.Count(c => c == ' ');
    int palabras = espacios + 1;
    
    Console.WriteLine($"   📝 '{nombre}' → {longitud} caracteres, {palabras} palabra(s)");
    
    // Análisis detallado de cada nombre
    Console.Write("      Caracteres: ");
    foreach (char c in nombre)
    {
        if (char.IsUpper(c))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{c}");
        }
        else if (char.IsLower(c))
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{c}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"{c}");
        }
    }
    Console.ResetColor();
    Console.WriteLine();
    Thread.Sleep(300);
}

Console.WriteLine("\n🏙️ ANÁLISIS DE CIUDADES:");
foreach (string ciudad in ciudades)
{
    Console.WriteLine($"   🌍 {ciudad}:");
    
    // Contar vocales y consonantes
    int vocales = 0, consonantes = 0;
    string vocalesString = "aeiouAEIOUáéíóúÁÉÍÓÚ";
    
    foreach (char c in ciudad)
    {
        if (char.IsLetter(c))
        {
            if (vocalesString.Contains(c))
                vocales++;
            else
                consonantes++;
        }
    }
    
    Console.WriteLine($"      📊 {vocales} vocales, {consonantes} consonantes");
}

// ============================================================================
// 5. BÚSQUEDA Y FILTRADO CON FOREACH
// ============================================================================

Console.WriteLine("\n📋 5. BÚSQUEDA Y FILTRADO");
Console.WriteLine("-".PadRight(40, '-'));

Console.Write("🔍 ¿Qué carácter quieres buscar? ");
string busqueda = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(busqueda) && busqueda.Length == 1)
{
    char caracterBuscar = busqueda[0];
    
    Console.WriteLine($"\n🎯 Buscando '{caracterBuscar}' en diferentes textos:");
    
    string[] textosEjemplo = { 
        "Programación en C#", 
        "Desarrollo web", 
        "Inteligencia artificial",
        "Base de datos",
        "Algoritmos y estructuras"
    };
    
    foreach (string texto in textosEjemplo)
    {
        List<int> posicionesEncontradas = new List<int>();
        int posicionActual = 0;
        
        foreach (char c in texto)
        {
            if (char.ToLower(c) == char.ToLower(caracterBuscar))
            {
                posicionesEncontradas.Add(posicionActual);
            }
            posicionActual++;
        }
        
        Console.Write($"   📄 '{texto}' → ");
        if (posicionesEncontradas.Count > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✅ Encontrado en posiciones: {string.Join(", ", posicionesEncontradas)}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ No encontrado");
        }
        Console.ResetColor();
    }
}

// ============================================================================
// 6. VALIDACIÓN DE PATRONES CON FOREACH
// ============================================================================

Console.WriteLine("\n📋 6. VALIDACIÓN DE PATRONES");
Console.WriteLine("-".PadRight(40, '-'));

Console.Write("🔐 Ingresa una contraseña para validar: ");
string password = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(password))
{
    Console.WriteLine($"\n🔍 Validando contraseña: '{password}'");
    
    bool tieneMayuscula = false;
    bool tieneMinuscula = false;
    bool tieneNumero = false;
    bool tieneEspecial = false;
    bool tieneEspacio = false;
    
    Console.WriteLine("\n📊 Análisis de seguridad:");
    
    foreach (char c in password)
    {
        string descripcion = "";
        ConsoleColor color = ConsoleColor.White;
        
        if (char.IsUpper(c))
        {
            tieneMayuscula = true;
            descripcion = "Mayúscula ✅";
            color = ConsoleColor.Green;
        }
        else if (char.IsLower(c))
        {
            tieneMinuscula = true;
            descripcion = "Minúscula ✅";
            color = ConsoleColor.Blue;
        }
        else if (char.IsDigit(c))
        {
            tieneNumero = true;
            descripcion = "Número ✅";
            color = ConsoleColor.Yellow;
        }
        else if (char.IsWhiteSpace(c))
        {
            tieneEspacio = true;
            descripcion = "Espacio ⚠️";
            color = ConsoleColor.Red;
        }
        else
        {
            tieneEspecial = true;
            descripcion = "Especial ✅";
            color = ConsoleColor.Magenta;
        }
        
        Console.ForegroundColor = color;
        Console.WriteLine($"   '{c}' → {descripcion}");
        Console.ResetColor();
        Thread.Sleep(100);
    }
    
    // Evaluación final
    Console.WriteLine("\n🛡️ EVALUACIÓN DE SEGURIDAD:");
    
    int puntuacion = 0;
    if (tieneMayuscula) { Console.WriteLine("   ✅ Contiene mayúsculas"); puntuacion++; }
    else { Console.WriteLine("   ❌ Falta mayúscula"); }
    
    if (tieneMinuscula) { Console.WriteLine("   ✅ Contiene minúsculas"); puntuacion++; }
    else { Console.WriteLine("   ❌ Falta minúscula"); }
    
    if (tieneNumero) { Console.WriteLine("   ✅ Contiene números"); puntuacion++; }
    else { Console.WriteLine("   ❌ Falta número"); }
    
    if (tieneEspecial) { Console.WriteLine("   ✅ Contiene caracteres especiales"); puntuacion++; }
    else { Console.WriteLine("   ❌ Falta carácter especial"); }
    
    if (password.Length >= 8) { Console.WriteLine("   ✅ Longitud adecuada (8+)"); puntuacion++; }
    else { Console.WriteLine("   ❌ Muy corta (mínimo 8 caracteres)"); }
    
    if (tieneEspacio) { Console.WriteLine("   ⚠️ Contiene espacios (no recomendado)"); puntuacion--; }
    
    string nivelSeguridad = puntuacion switch
    {
        >= 5 => "🟢 EXCELENTE",
        4 => "🟡 BUENA",
        3 => "🟠 REGULAR",
        2 => "🔴 DÉBIL",
        _ => "⚫ MUY DÉBIL"
    };
    
    Console.WriteLine($"\n🎯 Nivel de seguridad: {nivelSeguridad} ({puntuacion}/5 puntos)");
}

// ============================================================================
// 7. GENERACIÓN DE PATRONES CON FOREACH
// ============================================================================

Console.WriteLine("\n📋 7. GENERACIÓN DE PATRONES");
Console.WriteLine("-".PadRight(40, '-'));

Console.WriteLine("🎨 Generando patrones con caracteres:");

// Patrón 1: Pirámide de letras
string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("\n🔺 Pirámide del alfabeto:");

for (int nivel = 1; nivel <= 5; nivel++)
{
    // Espacios para centrar
    for (int i = 5; i > nivel; i--)
    {
        Console.Write(" ");
    }
    
    // Letras del nivel actual
    for (int i = 0; i < nivel; i++)
    {
        if (i < alfabeto.Length)
        {
            Console.Write($"{alfabeto[i]} ");
        }
    }
    Console.WriteLine();
    Thread.Sleep(300);
}

// Patrón 2: Análisis de frecuencia
Console.Write("\n📊 Ingresa texto para análisis de frecuencia: ");
string textoFrecuencia = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(textoFrecuencia))
{
    Dictionary<char, int> frecuencias = new Dictionary<char, int>();
    
    // Contar frecuencias
    foreach (char c in textoFrecuencia.ToLower())
    {
        if (char.IsLetter(c))
        {
            if (frecuencias.ContainsKey(c))
                frecuencias[c]++;
            else
                frecuencias[c] = 1;
        }
    }
    
    Console.WriteLine("\n📈 Frecuencia de caracteres:");
    foreach (var par in frecuencias.OrderByDescending(x => x.Value))
    {
        string barra = new string('█', par.Value);
        Console.WriteLine($"   '{par.Key}': {barra} ({par.Value})");
    }
}

// ============================================================================
// 8. EJERCICIO PRÁCTICO: ANALIZADOR DE TEXTO COMPLETO
// ============================================================================

Console.WriteLine("\n📋 8. EJERCICIO: ANALIZADOR DE TEXTO COMPLETO");
Console.WriteLine("-".PadRight(50, '-'));

Console.WriteLine("📝 Ingresa un párrafo para análisis completo:");
string parrafo = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(parrafo))
{
    Console.WriteLine($"\n🔍 ANÁLISIS COMPLETO DEL TEXTO:");
    Console.WriteLine("=".PadRight(40, '='));
    
    // Estadísticas básicas
    int caracteres = parrafo.Length;
    int palabras = parrafo.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    int oraciones = parrafo.Split(new char[] {'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
    
    Console.WriteLine($"📊 ESTADÍSTICAS BÁSICAS:");
    Console.WriteLine($"   Caracteres: {caracteres}");
    Console.WriteLine($"   Palabras: {palabras}");
    Console.WriteLine($"   Oraciones: {oraciones}");
    Console.WriteLine($"   Promedio caracteres/palabra: {(double)caracteres / palabras:F1}");
    
    // Análisis de caracteres
    Dictionary<string, int> contadores = new Dictionary<string, int>
    {
        ["vocales"] = 0,
        ["consonantes"] = 0,
        ["numeros"] = 0,
        ["espacios"] = 0,
        ["puntuacion"] = 0
    };
    
    string vocalesTexto = "aeiouAEIOUáéíóúÁÉÍÓÚ";
    
    foreach (char c in parrafo)
    {
        if (char.IsLetter(c))
        {
            if (vocalesTexto.Contains(c))
                contadores["vocales"]++;
            else
                contadores["consonantes"]++;
        }
        else if (char.IsDigit(c))
            contadores["numeros"]++;
        else if (char.IsWhiteSpace(c))
            contadores["espacios"]++;
        else if (char.IsPunctuation(c))
            contadores["puntuacion"]++;
    }
    
    Console.WriteLine($"\n🔤 ANÁLISIS DE CARACTERES:");
    foreach (var contador in contadores)
    {
        double porcentaje = (double)contador.Value / caracteres * 100;
        Console.WriteLine($"   {contador.Key}: {contador.Value} ({porcentaje:F1}%)");
    }
    
    // Palabras más largas
    var palabrasArray = parrafo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var palabrasLimpias = palabrasArray.Select(p => new string(p.Where(char.IsLetter).ToArray()));
    var palabrasOrdenadas = palabrasLimpias.OrderByDescending(p => p.Length).Take(3);
    
    Console.WriteLine($"\n📏 PALABRAS MÁS LARGAS:");
    foreach (string palabraLarga in palabrasOrdenadas)
    {
        if (!string.IsNullOrEmpty(palabraLarga))
        {
            Console.WriteLine($"   '{palabraLarga}' ({palabraLarga.Length} caracteres)");
        }
    }
}

// ============================================================================
// 9. COMPARACIÓN FOREACH VS FOR
// ============================================================================

Console.WriteLine("\n📋 9. FOREACH VS FOR - COMPARACIÓN");
Console.WriteLine("-".PadRight(45, '-'));

string textoComparacion = "EJEMPLO DE COMPARACIÓN";
Console.WriteLine($"📝 Texto: '{textoComparacion}'");

Console.WriteLine("\n🔄 USANDO FOREACH:");
Console.Write("   ");
foreach (char c in textoComparacion)
{
    Console.Write($"[{c}] ");
}
Console.WriteLine();

Console.WriteLine("\n🔢 USANDO FOR:");
Console.Write("   ");
for (int i = 0; i < textoComparacion.Length; i++)
{
    Console.Write($"[{textoComparacion[i]}] ");
}
Console.WriteLine();

Console.WriteLine("\n📊 DIFERENCIAS:");
Console.WriteLine("   FOREACH:");
Console.WriteLine("   ✅ Más simple y legible");
Console.WriteLine("   ✅ No hay riesgo de desbordamiento");
Console.WriteLine("   ✅ Funciona con cualquier IEnumerable");
Console.WriteLine("   ❌ No tienes acceso al índice directamente");
Console.WriteLine();
Console.WriteLine("   FOR:");
Console.WriteLine("   ✅ Tienes acceso al índice");
Console.WriteLine("   ✅ Puedes modificar la cadena (con StringBuilder)");
Console.WriteLine("   ✅ Puedes iterar hacia atrás");
Console.WriteLine("   ❌ Más propenso a errores de índice");

// ============================================================================
// 10. RESUMEN Y BUENAS PRÁCTICAS
// ============================================================================

Console.WriteLine("\n📋 10. RESUMEN Y BUENAS PRÁCTICAS");
Console.WriteLine("=".PadRight(50, '='));

Console.WriteLine("\n✅ CUÁNDO USAR FOREACH CON STRINGS:");
Console.WriteLine("   • Procesar cada carácter individualmente");
Console.WriteLine("   • Validar formato de entrada");
Console.WriteLine("   • Contar tipos de caracteres");
Console.WriteLine("   • Transformaciones simples");
Console.WriteLine("   • Búsqueda de patrones");

Console.WriteLine("\n🎯 BUENAS PRÁCTICAS:");
Console.WriteLine("   • Usa StringBuilder para modificaciones");
Console.WriteLine("   • Valida strings null o vacíos");
Console.WriteLine("   • Considera LINQ para operaciones complejas");
Console.WriteLine("   • Usa char.IsXXX() para validaciones");
Console.WriteLine("   • Maneja caracteres Unicode correctamente");

Console.WriteLine("\n🚫 EVITA:");
Console.WriteLine("   • Concatenar strings en ciclos (usa StringBuilder)");
Console.WriteLine("   • Modificar strings directamente (son inmutables)");
Console.WriteLine("   • Asumir que todos los caracteres son ASCII");

Console.WriteLine("\n📚 MÉTODOS ÚTILES APRENDIDOS:");
Console.WriteLine("   • char.IsLetter(), char.IsDigit(), char.IsWhiteSpace()");
Console.WriteLine("   • char.ToUpper(), char.ToLower()");
Console.WriteLine("   • string.Contains(), string.Split()");
Console.WriteLine("   • StringBuilder para construcción eficiente");

Console.WriteLine("\n🎉 ¡Has completado el tutorial de foreach con strings!");
Console.WriteLine("Presiona cualquier tecla para finalizar...");
Console.ReadKey();