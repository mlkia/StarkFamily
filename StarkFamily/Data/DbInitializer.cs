using StarkFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Data
{
    public class DbInitializer
    {
        public static void Initialize(FamilyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Personos.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
            new Person{FirstName="Rickard",LastName="Stark", BirthDate=DateTime.Parse("1908-03-17"), DeathDate=DateTime.Parse("1964-09-21"),},
            new Person{FirstName="Mother",LastName="Stark", BirthDate=DateTime.Parse("1912-02-11"), DeathDate=DateTime.Parse("1971-01-19")},
            new Person{FirstName="Brandon",LastName="Stark", BirthDate=DateTime.Parse("1939-01-09"),DeathDate=DateTime.Parse("1977-05-03"),FatherId=1, MotherId=2},
            new Person{FirstName="Eddard",LastName="Stark", BirthDate=DateTime.Parse("1940-12-13"), DeathDate=DateTime.Parse("1986-09-21"),FatherId=1, MotherId=2},
            new Person{FirstName="Benjen",LastName="Stark", BirthDate=DateTime.Parse("1942-06-10"), DeathDate=DateTime.Parse("1963-11-11"),FatherId=1, MotherId=2},
            new Person{FirstName="Lyanna",LastName="Stark", BirthDate=DateTime.Parse("1946-03-31"), DeathDate=DateTime.Parse("1975-08-05"),FatherId=1, MotherId=2},
            new Person{FirstName="Catelyn",LastName="Tulle", BirthDate=DateTime.Parse("1949-11-23"),DeathDate=DateTime.Parse("1996-09-09")},
            new Person{FirstName ="Rhaenys",LastName ="Tagaryen",BirthDate = DateTime.Parse("1939-07-22"),DeathDate = DateTime.Parse("1970-04-07")},
            new Person{FirstName="Robb",LastName="Stark", BirthDate=DateTime.Parse("1965-03-01"),DeathDate=DateTime.Parse("1996-09-09"),FatherId=4, MotherId=7},
            new Person{FirstName="Snasa",LastName="Stark", BirthDate=DateTime.Parse("1967-03-11"), FatherId=4, MotherId=7},
            new Person{FirstName="Arya",LastName="Stark", BirthDate=DateTime.Parse("1979-07-07"), FatherId=4,MotherId=7},
            new Person{FirstName="Bran",LastName="Stark", BirthDate=DateTime.Parse("1985-10-10"), FatherId=4, MotherId=7 },
            new Person{FirstName="Rickon",LastName="Stark", BirthDate=DateTime.Parse("1987-05-15"), DeathDate=DateTime.Parse("1997-9-21"),FatherId=4, MotherId=7 },
            new Person{FirstName="Jon",LastName="Snow", BirthDate=DateTime.Parse("1966-09-02"),FatherId=8, MotherId=6},
            };
            foreach (Person s in persons)
            {
                context.Personos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
