using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2.Models
{
    public class Pracownik
    {
        [Key]
        public int idPracownik { get; set; }
        public string Imie { get; set; }

        public string  Nazwisko { get; set; }
        public ICollection<Zamowienie> Zamowienies { get; set; }
    }
}
