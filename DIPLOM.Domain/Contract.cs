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
        public Vacancy Vacancy { get; set; }

        public Guid EmployerId { get; set; }
        public Employer Employer { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        



    }
}
