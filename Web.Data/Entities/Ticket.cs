using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Data.Entities
{
   public class Ticket
    {
        public Guid id { get; set; }
        public string name { get; set; }
       
        public DateTime hetmoban { get; set; }
        public double gia { get; set; }
        public int toida { get; set; }
        public int giuphan { get; set; }
        public int chuaxacnhan { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
        public ICollection<Participants> Participants { get; set; }
    }
}
