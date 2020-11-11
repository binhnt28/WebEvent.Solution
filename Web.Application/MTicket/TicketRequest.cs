using System;
using System.Collections.Generic;
using System.Text;
using Web.Data.Entities;

namespace Web.Application.MTicket
{
  public class TicketRequest
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public AppUser nguoidat { get; set; }
        public DateTime hetmoban { get; set; }
        public double gia { get; set; }
        public int toida { get; set; }
        public int giuphan { get; set; }
        public int chuaxacnhan { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
