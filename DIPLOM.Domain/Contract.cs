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

        public Vacancy Vacancy { get; set; }

        public Vacancy VacancyId { get; set; }

        public Employer Employer { get; set; }

        public Employer EmployerId { get; set; }

        public Customer Customer { get; set; }

        public Customer CustomerId { get; set; }



    }
}
