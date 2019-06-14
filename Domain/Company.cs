using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
