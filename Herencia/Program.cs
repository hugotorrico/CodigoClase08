


using Herencia;
using System.Data;


Persona persona = new Persona
{
    Apellidos="Torrico",
     DNI="45524520"
};


Vendedor vendedor = new Vendedor();
vendedor.Codigo = "VEN001";
vendedor.Sueldo = 3000;
vendedor.CalcularImpuesto();

Vendedor vendedor2 = new Vendedor();
vendedor2.Codigo = "VEN002";
vendedor2.Sueldo = 5000;
vendedor2.CalcularImpuesto(0.09);

Vendedor vendedor3 = new Vendedor();
vendedor3.Codigo = "VEN003";
vendedor3.Sueldo = 5000;
vendedor3.CalcularImpuesto(0.09,50);


//Propiedades de la herencia
vendedor.Nombres = "Nombre Vendedor";
vendedor.Apellidos = "Apellidos Vendedor";
vendedor.DNI = "55555555";

//Herencia de funciones
vendedor.EsMayorEdad();



Cliente cliente = new Cliente();
cliente.Email = "Torricomarquezh@gmail.com";
cliente.Direccion = "Santa Anita";
cliente.Telefono = "97825856";

//Propiedades de la herencia
cliente.Nombres = "Nombre Vendedor";
cliente.Apellidos = "Apellidos Vendedor";
cliente.DNI = "55555555";

//Herencia de funciones
cliente.EsMayorEdad();
