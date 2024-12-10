using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Log
    {
        public int Id { get; set; }
        public int VoluntaryId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public double WorkingTime { get; set; }
        public string WorkDetails { get; set; } // Yapılan proje detayları

    }
}
