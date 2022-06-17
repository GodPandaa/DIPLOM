using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Domain
{
    public class Vacancy
    {
        public Guid Id { get; set; }

        public int Wages { get; set; }

        public string Post { get; set; }

        public List<Contract> Contracts { get; set; }
    }
}
