using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        // Propiedad de navegación para la lista de estudiantes asignados a este profesor
        public List<Student> Students { get; set; }
    }

}
