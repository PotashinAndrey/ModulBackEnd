using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModulThird.Models
{
    public class Film
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
