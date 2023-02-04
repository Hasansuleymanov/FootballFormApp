using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class Reserve
    {
        public int Id { get; set; }
        public virtual List<ReserveToStadium> ClientToStadiums { get; set; }
        public virtual List<ReserveToSchedule> ClientToSchedules { get; set; }
        public virtual List<ReserveToRoom> ClientToRooms { get; set; }
        public virtual List<ReserveToClient> ReserveToClients { get; set; }
    }
}
