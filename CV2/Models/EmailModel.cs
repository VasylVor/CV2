using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.Models
{
    public class EmailModel
    {
        //[Compare("Email")]
        [EmailAddress()]
        [Required(ErrorMessage = "Input Address mail")]
        public string FromMessage { get; set; }

        [Required(ErrorMessage = "Input Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Input Text")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Input Name")]
        public string Name { get; set; }
        public string Answer { get; set; } = "";
    }
}
