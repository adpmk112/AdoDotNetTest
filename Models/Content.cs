using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Models
{
    public class Content
    {
        public int id { get; set; }
        public string name { get; set; }
        public string airDate { get; set; }
        public string genre { get; set; }
        public string recommendedFor { get; set; }
        public string rating { get; set; }
        public string nbVoting { get; set; }
        public string photo { get; set; }
        public string link { get; set; }
    }
}
