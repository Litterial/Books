using BookApp.Models.Enumerations;
namespace BookApp.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public uint Salary{ get; set; }

        public int LibraryId { get; set; }
        public Library Library { get; set; }
    }
}