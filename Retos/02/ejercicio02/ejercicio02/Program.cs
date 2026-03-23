// Reto 02 - Ejercicio 02: Funciones Básicas
// Ejemplos de diferentes tipos de funciones en C#

// ============================================
// 1. FUNCIÓN SIN PARÁMETROS NI RETORNO
// ============================================
void SaludarBasico()
{
    Console.WriteLine("¡Hola! Soy una función sin parámetros ni retorno.");
}

// ============================================
// 2. FUNCIÓN CON PARÁMETRO(S) SIN RETORNO
// ============================================
void SaludarConNombre(string nombre)
{
    Console.WriteLine($"¡Hola, {nombre}! Esta función tiene un parámetro.");
}

void MostrarInfo(string nombre, int edad, string ciudad)
{
    Console.WriteLine($"Información personal:");
    Console.WriteLine($"  Nombre: {nombre}");
    Console.WriteLine($"  Edad: {edad} años");
    Console.WriteLine($"  Ciudad: {ciudad}");
}

// ============================================
// 3. FUNCIÓN SIN PARÁMETROS CON RETORNO
// ============================================
int ObtenerNumeroAleatorio()
{
    Random random = new Random();
    return random.Next(1, 101); // Retorna un número entre 1 y 100
}

string ObtenerMensajeDeBienvenida()
{
    return "Bienvenido Al Programa de Funciones en C#";
}

// ============================================
// 4. FUNCIÓN CON PARÁMETRO(S) Y RETORNO
// ============================================
int Sumar(int a, int b)
{
    return a + b;
}

double CalcularPromedio(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}

string Concatenar(string texto1, string texto2)
{
    return $"{texto1} {texto2}";
}

// ============================================
// 5. FUNCIÓN CON PARÁMETROS OPCIONALES
// ============================================
void Desped(string nombre, string despedida = "Hasta luego")
{
    Console.WriteLine($"{despedida}, {nombre}!");
}

// ============================================
// 6. FUNCIÓN CON RETORNO DE BOOLEANO
// ============================================
bool EsMayorDeEdad(int edad)
{
    return edad >= 18;
}

bool ContienePalabra(string texto, string palabra)
{
    return texto.Contains(palabra);
}

// ============================================
// 7. FUNCIÓN CON PARÁMETROS NOMBRADOS
// ============================================
void CrearProducto(string nombre, decimal precio, int cantidad)
{
    Console.WriteLine($"Producto: {nombre}");
    Console.WriteLine($"Precio: ${precio}");
    Console.WriteLine($"Cantidad: {cantidad} unidades");
}

// ============================================
// LLAMADAS A LAS FUNCIONES
// ============================================

Console.WriteLine("=== EJEMPLOS DE FUNCIONES EN C# ===\n");

// Función sin parámetros ni retorno
Console.WriteLine("--- 1. Sin parámetros ni retorno ---");
SaludarBasico();

// Función con parámetro(s) sin retorno
Console.WriteLine("\n--- 2. Con parámetros, sin retorno ---");
SaludarConNombre("Carlos");
MostrarInfo("María", 25, "Madrid");

// Función sin parámetros con retorno
Console.WriteLine("\n--- 3. Sin parámetros, con retorno ---");
string saludo = ObtenerMensajeDeBienvenida();
Console.WriteLine(saludo);
int numAleatorio = ObtenerNumeroAleatorio();
Console.WriteLine($"Número aleatorio: {numAleatorio}");

// Función con parámetro(s) y retorno
Console.WriteLine("\n--- 4. Con parámetros y retorno ---");
int resultado = Sumar(15, 25);
Console.WriteLine($"15 + 25 = {resultado}");

double promedio = CalcularPromedio(8.5, 9.0, 7.5);
Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");

string mensaje = Concatenar("Hola", "Mundo");
Console.WriteLine($"Concatenación: {mensaje}");

// Función con parámetros opcionales
Console.WriteLine("\n--- 5. Con parámetros opcionales ---");
Desped("Juan");
Desped("Pedro", "¡Hasta pronto");

// Función con retorno booleano
Console.WriteLine("\n--- 6. Con retorno booleano ---");
bool esAdulto = EsMayorDeEdad(20);
Console.WriteLine($"¿Es mayor de edad? {esAdulto}");

bool encuentra = ContienePalabra("El programador crea código", "código");
Console.WriteLine($"¿Contiene la palabra 'código'? {encuentra}");

// Función con parámetros nombrados
Console.WriteLine("\n--- 7. Con parámetros nombrados ---");
CrearProducto(nombre: "Laptop", precio: 999.99m, cantidad: 5);


void BizzBuzz(int numero)
{
    for (int i = 1; i <= numero; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("BizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Bizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

BizzBuzz(100); // BizzBuzz