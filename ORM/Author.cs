using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain
{
    public class Author: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
