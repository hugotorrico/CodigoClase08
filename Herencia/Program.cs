


using Herencia;
using System.Data;

Vendedor vendedor = new Vendedor();
vendedor.Codigo = "VEN001";
vendedor.Sueldo = 3000;
vendedor.Sucursal = "Santa Anita";
vendedor.CalcularImpuesto();

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
