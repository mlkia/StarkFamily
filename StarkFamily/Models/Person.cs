using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Models
{
    
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public int? FatherId { get; set; }
        [ForeignKey("FatherId")]
        public virtual Person Father { get; set; }
        public virtual ICollection<Person> FatherChildren { get; set; }
        public int? MotherId { get; set; }
        [ForeignKey("MotherId")]
        public virtual Person Mother { get; set; }

        public virtual ICollection<Person> MotherChildren { get; set; }

    }

    //public class Parents
    //{
    //    public Person Father { get; set; }
    //    public Person Mother { get; set; }

        
    //}
}