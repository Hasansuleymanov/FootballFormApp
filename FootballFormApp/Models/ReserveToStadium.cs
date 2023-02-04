using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class ReserveToStadium
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int StadiumId { get; set; }
        public virtual Stadium Stadium { get; set; }
    }
}
