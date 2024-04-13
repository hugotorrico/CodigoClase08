// Crear objetos Teacher
using CodigoClase08;

var teacher1 = new Teacher {
    Id = 1,
    Name = "Profesor A",
    Subject = "Matemáticas",
   Students = new List<Student>()
    
};
var teacher2 = new Teacher { 
    Id = 2, 
    Name = "Profesor B",
    Subject = "Ciencias" };

// Crear objetos Student
var student1 = new Student { Id = 1, Name = "Estudiante 1", Grade = 95.5 };
var student2 = new Student { Id = 2, Name = "Estudiante 2", Grade = 85.0 };
var student3 = new Student { Id = 3, Name = "Estudiante 3", Grade = 78.3 };
var student4 = new Student { Id = 4, Name = "Estudiante 4", Grade = 90.2 };

// Asignar estudiantes a profesores usando propiedades de navegación
teacher1.Students.Add(student1);
teacher1.Students.Add(student2);

teacher2.Students = new List<Student> { student3, student4 };

// Llamar al método PrintStudentInfo de cada estudiante para mostrar su información
Console.WriteLine("Información de los estudiantes asignados al Profesor A:");
foreach (var student in teacher1.Students)
{
    student.PrintStudentInfo();
}

Console.WriteLine("\nInformación de los estudiantes asignados al Profesor B:");
foreach (var student in teacher2.Students)
{
    student.PrintStudentInfo();
}

Console.Read();