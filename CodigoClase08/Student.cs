using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        // Propiedad de navegación para el profesor asignado al estudiante
        //public Teacher Teacher { get; set; }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Nombre del estudiante: {Name}");
            Console.WriteLine($"Calificación: {Grade}");
        }
    }

}
