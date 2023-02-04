using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class ReserveToSchedule
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
