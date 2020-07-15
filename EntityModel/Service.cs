using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModel
{
    [Table("Service")]
    public class Service
    {
        public int id { get; set; }
        public int StudentId { get; set; }
        public string SchoolYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
