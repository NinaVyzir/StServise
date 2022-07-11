using Microsoft.EntityFrameworkCore;
using StudentsServise.Models;



namespace StudentsServise.StudentsData;

public class StudentDataContext : DbContext
{
    public StudentDataContext (DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        builder.Entity<Student>().HasData(
            GetStudents()
        );
    }

    public DbSet<Student> Students { get; set; }

    private static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>() {
            new Student() {    
                StudentId = 1,
                FirstName="Nina",
                LastName="Vyzir",
                Email= "nina.vyzir@brightstar-academy.com",
                
            },
            new Student() {    
                StudentId = 2,
                FirstName="Oleksandr",
                LastName="Yevtushenko",
                Email= "oleksandr.yevtushenko@brightstar-academy.com",
                
            },
            new Student() {    
                StudentId= 3,
                FirstName="Roman",
                LastName="Shyrin",
                Email= "roman.shyrin@brightstar-academy.com",
            },
            new Student() {    
                StudentId= 4,
                FirstName="Viktor",
                LastName="Кozhyn",
                Email= "viktor.kozhyn@brightstar-academy.com",
            },
            new Student() {    
                StudentId= 5,
                FirstName="Mykola",
                LastName="Karpenko",
                Email= "mykola.karpenko@brightstar-academy.com",
            },
        };

        return students;
    }
}