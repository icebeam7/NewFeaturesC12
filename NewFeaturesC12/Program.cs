// Demo 6 - Alias any type
using NewFeaturesC12;
using Calificacion = decimal;

Rectangulo rect = new (100, 20);
Console.WriteLine(rect);
Console.WriteLine(rect.Area);

Rectangulo rect2 = new();
Console.WriteLine(rect2);
Console.WriteLine(rect2.Area);

// Demo 7 - Experimental attribute
#pragma warning disable ClaseExperimental
Producto producto = new Producto();
producto.Imprimir();
#pragma warning restore ClaseExperimental

//Producto producto1 = new Producto();

// Demo 2 - Collection Expressions
int[] arreglo = [1, 2, 3, 4];
List<string> palabras = [ "hola", "dotnet", "C#" ];
int[] numeros = [5, 6, 7, 8, 9];

int[] valores = [.. arreglo, .. numeros];
foreach (int val in valores)
    Console.WriteLine(val);

// Demo 5 - Ref readonly parameters
void Display(in int numero1, in int numero2)
{
    var suma = numero1 + numero2;
    Console.WriteLine($"La suma de {numero1} + {numero2} es {suma}");
}

int num1 = 235, num2 = 123;
Display(num1, num2);

// Demo 4 - Optional parameters in lambda expressions
var Suma = (int valor1, int valor2 = 100) => valor1 + valor2;
Console.WriteLine(Suma(20, 30));
Console.WriteLine(Suma(200));

// Demo 3 - Inline arrays
var buffer = new Buffer();
for (int i = 0; i < 10; i++)
{
    buffer[i] = i;
    Console.WriteLine(buffer[i]);
}

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    int element;
}




// Demo 1 - Primary constructors
public struct Rectangulo(double x, double y)
{
    public Rectangulo() : this(10, 10) { }

    public double Area { get; } = x * y;

    public override string ToString()
    {
        return $"Base: {x}, Altura: {y}";
    }
}

public class Estudiante(string nombre, int id, Calificacion[] calificaciones)
{
    public Estudiante(string nombre, int id) : 
        this(nombre, id, Array.Empty<Calificacion>())
    {

    }

    Calificacion altura;
}

