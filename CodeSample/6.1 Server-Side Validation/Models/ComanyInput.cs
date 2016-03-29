using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _6._1_Server_Side_Validation.Models
{
    public class ComanyInput
    {
        [Required]
        public string CompanyName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}