using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.Models
{
    public class ControlsValue
    {
        public int Id { get; set; }
        public string ControlName { get; set; }
        public string ControlValue { get; set; }
        public int IdSection { get; set; }
        public virtual Section Section { get; set; }
    }
}
