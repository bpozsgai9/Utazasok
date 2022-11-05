using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utazasok.Model
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
    }
}
