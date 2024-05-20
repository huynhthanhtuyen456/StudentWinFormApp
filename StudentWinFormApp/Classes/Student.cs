using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinFormApp.Classes
{
    public class Student
    {
        /* Attributes Definition */
        public required string Id { get; set; }
        public required string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        /* Methods Definition */
        public int CalculateAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - this.DateOfBirth.Year;
            return age;
        }
    }
}
