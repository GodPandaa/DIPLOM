using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Domain
{
   public class Employer
    {
        public Guid Id { get; set; }

        public string Address { get; set; }

        public string Company { get; set; }

        public List<Contract> Contracts { get; set; }

        public List<Vacancy> Vacancies { get; set; }
    }
}
