using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Mari",
                Age = 31,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new People()
            {
                Id = 2,
                Name = "Jark",
                Age = 24,
                GenderId = Guid.Parse("76dff529-9824-4923-81d4-91f91916f057")
            },

            new People()
            {
                Id = 3,
                Name = "Varia",
                Age = 18,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new People()
            {
                Id = 4,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            },

            new People()
            {
                Id = 5,
                Name = "Jakob",
                Age = 30,
                GenderId = Guid.Parse("76dff529-9824-4923-81d4-91f91916f057")
            },

            new People()
            {
                Id = 6,
                Name = "Hanna",
                Age = 20,
                GenderId = Guid.Parse("b8172c9b-7dae-485a-9fef-32f6e5a4bb43")
            }
        };
    }
}
