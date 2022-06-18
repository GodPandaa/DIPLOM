using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Lastname { get; set; }

        public string Profession { get; set; }

        public int Salary { get; set; }

        public string Education { get; set; }

        public Contract Contract { get; set; }
    }
}
