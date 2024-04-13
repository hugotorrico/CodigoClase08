

using Sobreescribir;

Console.WriteLine("SIN POLIMORFISMO");

//Declraciones
Circulo circulo = new Circulo { Radio = 10 };
Cuadrado cuadrado = new Cuadrado { Lado = 10 };
Rectangulo rectangulo = new Rectangulo { Base = 10, Altura = 20 };

//Mostrar resultados
Console.WriteLine( circulo.CalcularArea());
Console.WriteLine(cuadrado.CalcularArea());
Console.WriteLine(rectangulo.CalcularArea());


Console.WriteLine("CON POLIMORFISMO");
List<Poligono> poligonos= new List<Poligono>();
Poligono poligono1 = new Circulo { Radio = 10 };
Poligono poligono2 = new Cuadrado { Lado = 10 };
Poligono poligono3 = new Rectangulo { Base = 10, Altura = 20 };
poligonos.Add(poligono1);
poligonos.Add(poligono2);
poligonos.Add(poligono3);



foreach (var item in poligonos)
{
    Console.WriteLine(item.CalcularArea());
}





Console.Read();




