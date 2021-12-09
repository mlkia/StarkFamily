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
            new Person{FirstName="Rickard",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),},
            new Person{FirstName="Mother",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21")},
            new Person{FirstName="Brandon",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21"),FatherId=1,},
            new Person{FirstName="Eddard",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{FirstName="Benjen",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{FirstName="Lyanna",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{FirstName="Catelyn",LastName="Tulle", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21")},
            new Person{FirstName ="Rhaenys",LastName ="Tagaryen",BirthDate = DateTime.Parse("1936-03-17"),DeathDate = DateTime.Parse("1986-9-21")},
            new Person{FirstName="Robb",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21"),FatherId=4 },
            new Person{FirstName="Snas",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=4,},
            new Person{FirstName="Arya",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=4 },
            new Person{FirstName="Bran",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=4 },
            new Person{FirstName="Rickon",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=4 },
            new Person{FirstName="Jon",LastName="Snow", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=8,},
            };
            foreach (Person s in persons)
            {
                context.Personos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
