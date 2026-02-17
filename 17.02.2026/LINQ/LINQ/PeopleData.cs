using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ
{
    public class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
            new PeopleList()
            {
                Id = 1,
                Name = "Gilbert-Glock",
                Age = 31,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new PeopleList()
            {
                Id = 2,
                Name = "Mark",
                Age = 500,
                GenderId = Guid.Parse("76dff529-9824-4923-81d4-91f91916f057")
            },

            new PeopleList()
            {
                Id = 3,
                Name = "Ronaldo",
                Age = 18,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new PeopleList()
            {
                Id = 4,
                Name = "Emex",
                Age = 21,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new PeopleList()
            {
                Id = 5,
                Name = "Suur Frank",
                Age = 900,
                GenderId = Guid.Parse("76dff529-9824-4923-81d4-91f91916f057")
            },

            new PeopleList()
            {
                Id = 6,
                Name = "Ronaldo",
                Age = 20,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new PeopleList()
            {
                Id = 7,
                Name = "William",
                Age = 3,
                GenderId = Guid.Parse("76dff529-9824-4923-81d4-91f91916f057")
            }
        };
    }
}
