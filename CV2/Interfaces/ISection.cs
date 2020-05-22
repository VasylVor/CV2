using CV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.Interfaces
{
    interface ISection
    {
        IEnumerable<Section> Menu { get; }
    }
}
