using System.Diagnostics.CodeAnalysis;

namespace NewFeaturesC12
{
    [Experimental(diagnosticId: "ClaseExperimental")]
    public class Producto
    {
        [Experimental(diagnosticId: "MetodoExperimental")]
        public void Imprimir()
        {
            Console.WriteLine("Hola desde clase y método experimental");
        }
    }
}
