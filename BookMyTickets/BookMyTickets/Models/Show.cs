using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookMyTickets.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }

        public int MovieId { get; set; }

        public int TheaterId { get; set; }

        public string MovieName { get; set; }

        public string TheaterName { get; set; }

        public string City { get; set; }

        public int ScreenNo { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public double Price { get; set; }

        public virtual Movie Movie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Theater Theater { get; set; }

    }
}
