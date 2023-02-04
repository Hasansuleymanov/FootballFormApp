using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class ReserveToClient
    {
        public int Id { get; set; }
        public int ReserveId { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
