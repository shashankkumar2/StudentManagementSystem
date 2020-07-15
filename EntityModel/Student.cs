using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModel
{
    [Table("Student")]
    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Ssn { get; set; }

    }
}
