using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Domain
{
   public class Contract
    {
        public Guid Id { get; set; }

        public int Contract_percentage { get; set; }

        public Guid VacancyId { get; set; }
        public List<Vacancy> Vacancies { get; set; }

        public Guid EmployerId { get; set; }
        public List<Employer> Employers { get; set; }

        public Guid CustomerId { get; set; }
        public List<Customer> Customers { get; set; }

        



    }
}
