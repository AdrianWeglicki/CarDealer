using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarDealer.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="Username is required")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email  { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(5000, ErrorMessage = "The message is too long")]
        public string Message { get; set; }
        public bool ExpectAnswer{ get; set; }
    
    }
}
