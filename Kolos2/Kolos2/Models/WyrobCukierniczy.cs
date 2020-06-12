using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2.Models
{
    public class WyrobCukierniczy
    {
        [Key]
        public int IdWyrobuCukierniczego { get; set; }
        public string nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }
    }
}
