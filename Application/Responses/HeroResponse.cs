using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class HeroResponse
    {
        public Int64 HeroId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Power { get; set; }
    }
}
