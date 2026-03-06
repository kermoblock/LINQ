using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ClientList
    {
        public static readonly List<Client> Clients = new List<Client>()
        {
            new Client()
            {
                Id = 1,
                Name = "Foo",
                City = "London",
            },

            new Client()
            {
                Id = 2,
                Name = "Peeter",
                City = "Kopli",
            },

            new Client()
            {
                Id = 3,
                Name = "Oskar",
                City = "Viimsi",
            },

            new Client()
            {
                Id = 4,
                Name = "Frank",
                City = "Riga",
            },

            new Client()
            {
                Id = 5,
                Name = "Karl",
                City = "Tartu",
            },
        };
    }
}
