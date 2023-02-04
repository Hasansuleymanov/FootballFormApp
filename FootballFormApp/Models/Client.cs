using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; } = null!;
        [MaxLength(80)]
        public string Surname { get; set; } = null!;
        public int Count { get; set; }
        public string Telephone { get; set; } = null!;
    }
}
