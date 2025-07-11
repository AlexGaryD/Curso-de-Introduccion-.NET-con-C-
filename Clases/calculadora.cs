using System;
using System.Collections.Generic;
using System.Linq;

namespace Operaciones
{
    /// <summary>
    /// Clase Calculadora que demuestra conceptos de POO en C#
    /// Incluye encapsulación, métodos, propiedades y manejo de estado
    /// </summary>
    public class Calculadora
    {
        // ============================================================================
        // CAMPOS PRIVADOS (ENCAPSULACIÓN)
        // ============================================================================
        
        private string _nombre;
        private List<string> _historial;
        private DateTime _fechaCreacion;
        private int _contadorOperaciones;
        
        // ============================================================================
        // PROPIEDADES PÚBLICAS (ENCAPSULACIÓN)
        // ============================================================================
        
        /// <summary>
        /// Nombre de la calculadora
        /// </summary>
        public string Nombre 
        { 
            get => _nombre; 
            set => _nombre = string.IsNullOrWhiteSpace(value) ? "Calculadora Sin Nombre" : value; 
        }
        
        /// <summary>
        /// Fecha de creación de la calculadora (solo lectura)
        /// </summary>
        public DateTime FechaCreacion => _fechaCreacion;
        
        /// <summary>
        /// Número total de operaciones realizadas (solo lectura)
        /// </summary>
        public int ContadorOperaciones => _contadorOperaciones;
        
        /// <summary>
        /// Historial de operaciones (solo lectura)
        /// </summary>
        public IReadOnlyList<string> Historial => _historial.AsReadOnly();
        
        /// <summary>
        /// Última operación realizada
        /// </summary>
        public string UltimaOperacion => _historial.LastOrDefault() ?? "Ninguna operación realizada";
        
        // ============================================================================
        // CONSTRUCTORES (DIFERENTES FORMAS DE CREAR OBJETOS)
        // ============================================================================
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Calculadora()
        {
            _nombre = "Calculadora Básica";
            _historial = new List<string>();
            _fechaCreacion = DateTime.Now;
            _contadorOperaciones = 0;
        }
        
        /// <summary>
        /// Constructor con nombre personalizado
        /// </summary>
        /// <param name="nombre">Nombre de la calculadora</param>
        public Calculadora(string nombre) : this()
        {
            Nombre = nombre;
        }
        
        /// <summary>
        /// Constructor completo con configuración inicial
        /// </summary>
        /// <param name="nombre">Nombre de la calculadora</param>
        /// <param name="mantieneHistorial">Si debe mantener historial de operaciones</param>
        public Calculadora(string nombre, bool mantieneHistorial) : this(nombre)
        {
            if (!mantieneHistorial)
            {
                _historial = null; // Calculadora sin historial
            }
        }
        
        // ============================================================================
        // MÉTODOS BÁSICOS MEJORADOS (TU CÓDIGO ORIGINAL EXPANDIDO)
        // ============================================================================
        
        /// <summary>
        /// Realiza la suma de dos números enteros
        /// </summary>
        /// <param name="numero1">Primer número</param>
        /// <param name="numero2">Segundo número</param>
        /// <returns>Resultado de la suma</returns>
        public int Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            RegistrarOperacion($"{numero1} + {numero2} = {resultado}");
            return resultado;
        }
        
        /// <summary>
        /// Realiza la resta de dos números enteros
        /// </summary>
        public int Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            RegistrarOperacion($"{numero1} - {numero2} = {resultado}");
            return resultado;
        }
        
        /// <summary>
        /// Realiza la multiplicación de dos números enteros
        /// </summary>
        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            RegistrarOperacion($"{numero1} × {numero2} = {resultado}");
            return resultado;
        }
        
        /// <summary>
        /// Realiza la división de dos números enteros con validación mejorada
        /// </summary>
        public double Division(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                var error = "No se puede dividir por cero";
                RegistrarOperacion($"ERROR: {numero1} ÷ {numero2} - {error}");
                throw new DivideByZeroException(error);
            }
            
            double resultado = numero1 / numero2;
            RegistrarOperacion($"{numero1} ÷ {numero2} = {resultado:F2}");
            return resultado;
        }
        
        // ============================================================================
        // MÉTODOS SOBRECARGADOS (OVERLOADING)
        // ============================================================================
        
        /// <summary>
        /// Suma dos números decimales (sobrecarga)
        /// </summary>
        public double Suma(double numero1, double numero2)
        {
            double resultado = numero1 + numero2;
            RegistrarOperacion($"{numero1:F2} + {numero2:F2} = {resultado:F2}");
            return resultado;
        }
        
        /// <summary>
        /// Suma tres números enteros (sobrecarga)
        /// </summary>
        public int Suma(int numero1, int numero2, int numero3)
        {
            int resultado = numero1 + numero2 + numero3;
            RegistrarOperacion($"{numero1} + {numero2} + {numero3} = {resultado}");
            return resultado;
        }
        
        /// <summary>
        /// Suma múltiples números (sobrecarga con params)
        /// </summary>
        public double Suma(params double[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                throw new ArgumentException("Debe proporcionar al menos un número");
            
            double resultado = numeros.Sum();
            string operacion = string.Join(" + ", numeros.Select(n => n.ToString("F1")));
            RegistrarOperacion($"Suma múltiple: {operacion} = {resultado:F2}");
            return resultado;
        }
        
        // ============================================================================
        // MÉTODOS AVANZADOS
        // ============================================================================
        
        /// <summary>
        /// Calcula la potencia de un número
        /// </summary>
        public double Potencia(double baseNum, double exponente)
        {
            double resultado = Math.Pow(baseNum, exponente);
            RegistrarOperacion($"{baseNum}^{exponente} = {resultado:F2}");
            return resultado;
        }
        
        /// <summary>
        /// Calcula la raíz cuadrada
        /// </summary>
        public double RaizCuadrada(double numero)
        {
            if (numero < 0)
            {
                var error = "No se puede calcular raíz cuadrada de número negativo";
                RegistrarOperacion($"ERROR: √{numero} - {error}");
                throw new ArgumentException(error);
            }
            
            double resultado = Math.Sqrt(numero);
            RegistrarOperacion($"√{numero} = {resultado:F2}");
            return resultado;
        }
        
        /// <summary>
        /// Calcula el factorial de un número
        /// </summary>
        public long Factorial(int numero)
        {
            if (numero < 0)
                throw new ArgumentException("El factorial no está definido para números negativos");
            
            if (numero > 20)
                throw new ArgumentException("Número demasiado grande para calcular factorial");
            
            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            
            RegistrarOperacion($"{numero}! = {resultado}");
            return resultado;
        }
        
        /// <summary>
        /// Calcula el promedio de varios números
        /// </summary>
        public double Promedio(params double[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                throw new ArgumentException("Debe proporcionar al menos un número");
            
            double resultado = numeros.Average();
            string nums = string.Join(", ", numeros.Select(n => n.ToString("F1")));
            RegistrarOperacion($"Promedio de [{nums}] = {resultado:F2}");
            return resultado;
        }
        
        // ============================================================================
        // MÉTODOS DE UTILIDAD Y MANEJO DE ESTADO
        // ============================================================================
        
        /// <summary>
        /// Registra una operación en el historial (método privado)
        /// </summary>
        private void RegistrarOperacion(string operacion)
        {
            _contadorOperaciones++;
            _historial?.Add($"[{DateTime.Now:HH:mm:ss}] {operacion}");
        }
        
        /// <summary>
        /// Limpia el historial de operaciones
        /// </summary>
        public void LimpiarHistorial()
        {
            _historial?.Clear();
            RegistrarOperacion("Historial limpiado");
        }
        
        /// <summary>
        /// Obtiene estadísticas de uso de la calculadora
        /// </summary>
        public EstadisticasCalculadora ObtenerEstadisticas()
        {
            return new EstadisticasCalculadora
            {
                Nombre = this.Nombre,
                FechaCreacion = this.FechaCreacion,
                TotalOperaciones = this.ContadorOperaciones,
                TiempoDeUso = DateTime.Now - this.FechaCreacion,
                OperacionesPorMinuto = this.ContadorOperaciones / Math.Max(1, (DateTime.Now - this.FechaCreacion).TotalMinutes)
            };
        }
        
        /// <summary>
        /// Reinicia la calculadora a su estado inicial
        /// </summary>
        public void Reiniciar()
        {
            _historial?.Clear();
            _contadorOperaciones = 0;
            _fechaCreacion = DateTime.Now;
            RegistrarOperacion("Calculadora reiniciada");
        }
        
        /// <summary>
        /// Representación en cadena de la calculadora
        /// </summary>
        public override string ToString()
        {
            return $"Calculadora '{Nombre}' - {ContadorOperaciones} operaciones realizadas";
        }
        
        // ============================================================================
        // MÉTODOS ESTÁTICOS (NO REQUIEREN INSTANCIA)
        // ============================================================================
        
        /// <summary>
        /// Convierte grados Celsius a Fahrenheit
        /// </summary>
        public static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
        
        /// <summary>
        /// Convierte grados Fahrenheit a Celsius
        /// </summary>
        public static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
        
        /// <summary>
        /// Valida si un número es primo
        /// </summary>
        public static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }

    // ============================================================================
    // CLASE AUXILIAR PARA ESTADÍSTICAS
    // ============================================================================

    /// <summary>
    /// Clase que representa las estadísticas de uso de una calculadora
    /// </summary>
    public class EstadisticasCalculadora
    {
        public string Nombre { get; set; } = "";
        public DateTime FechaCreacion { get; set; }
        public int TotalOperaciones { get; set; }
        public TimeSpan TiempoDeUso { get; set; }
        public double OperacionesPorMinuto { get; set; }

        public override string ToString()
        {
            return $"""
                📊 ESTADÍSTICAS DE {Nombre.ToUpper()}
                ═══════════════════════════════════════════
                📅 Creada: {FechaCreacion:dd/MM/yyyy HH:mm:ss}
                ⏱️ Tiempo de uso: {TiempoDeUso.TotalMinutes:F1} minutos
                🔢 Total operaciones: {TotalOperaciones}
                📈 Operaciones/min: {OperacionesPorMinuto:F2}
                """;
        }
    }
}

