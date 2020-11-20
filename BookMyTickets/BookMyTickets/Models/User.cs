using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookMyTickets.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

       
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid First Name.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

      
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Last Name.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
      
        public string UserName { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        [DisplayName("Password")]
        public string Password { get; set; }

      
        public string Gender { get; set; }
       
        [Required]
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }

       
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

    }
}
