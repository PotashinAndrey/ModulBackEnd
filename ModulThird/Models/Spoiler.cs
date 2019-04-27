using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModulThird.Models
{
    public class Spoiler
    {
        public Guid Id { get; set; }
        public Guid FilmId { get; set; }
        public string spoiler { get; set; }
}
}
