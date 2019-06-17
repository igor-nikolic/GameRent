using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }        
        public Category Category { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Rent> Rents { get; set; }

    }
}
