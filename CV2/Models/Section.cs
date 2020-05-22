using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string MenuName { get; set; }
        public bool Active { get; set; }
        public List<ControlsValue> ControlsValues { get; set; }
    }
}
