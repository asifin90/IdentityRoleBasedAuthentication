using Microsoft.EntityFrameworkCore;

namespace Identity_Employee.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee()
               {
                   ID = 2,
                   Name = "Asif",
                   Department = Department.IT,
                   Email = "Asif@test.com"
               },
                new Employee()
                {
                    ID = 3,
                    Name = "Amir",
                    Department = Department.HR,
                    Email = "Amir@test.com"
                }
           );
        }
    }
}
