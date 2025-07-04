var nombre = "Alex"; // Variable de tipo string
string apellido = "Vera"; // Variable de tipo string
var edad = 30; // Variable de tipo int
int anioNacimiento = 1993; // Variable de tipo int

bool esEstudiante = true; // Variable de tipo bool

double altura = 1.75; // Variable de tipo double
var peso = 70.5; // Variable de tipo double

Console.WriteLine("Hola, " + nombre + " " + apellido + "!"); // Imprime un saludo
Console.WriteLine("Tienes " + edad + " años y naciste en " + anioNacimiento + "."); // Imprime la edad y el año de nacimiento
Console.WriteLine("¿Eres estudiante? " + esEstudiante); // Imprime si es estudiante
Console.WriteLine("Tu altura es " + altura + " metros y pesas " + peso + " kg."); // Imprime la altura y el peso
Console.WriteLine($"Hola, {nombre} {apellido}!"); // Imprime un saludo usando interpolación de cadenas
Console.WriteLine($"Tienes {edad} años y naciste en {anioNacimiento}."); // Imprime la edad y el año de nacimiento usando interpolación de cadenas
Console.WriteLine($"¿Eres estudiante? {esEstudiante}"); // Imprime si es estudiante usando interpolación de cadenas
Console.WriteLine($"Tu altura es {altura} metros y pesas {peso} kg."); // Imprime la altura y el peso usando interpolación de cadenas 


