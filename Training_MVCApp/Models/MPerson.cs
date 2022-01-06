using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Training_MVCApp.Models
{
    public class MPerson
    {
        [Required]
        public int PersonID { get; set; }

        [DisplayName("Person First Name")]
        [Required(ErrorMessage = "Person Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
    }
}