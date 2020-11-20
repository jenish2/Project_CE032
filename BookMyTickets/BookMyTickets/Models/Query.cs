using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyTickets.Models
{
    public class Query
    {
        public int QueryId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string QueryContactUs { get; set; }
    }
}
