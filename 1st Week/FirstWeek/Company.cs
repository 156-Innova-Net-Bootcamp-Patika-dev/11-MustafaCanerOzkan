using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeek
{
    //Company isminde nesnemiz ve özelliklerini oluşturduk.
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string FoundingDate { get; set; }
    }
}
