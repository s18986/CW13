using Kolos2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2.Configurations
{
    public class Zamowienie_WyrobCukierniczyConfiguration : IEntityTypeConfiguration<Zamowienie_WyrobCukierniczy>
    {

        public void Configure(EntityTypeBuilder<Zamowienie_WyrobCukierniczy> builder)
        {
            builder.HasKey(key => key.IdWyrobCukierniczy);
            builder.HasKey(key => key.IdZamowienia);
            builder.Property(x => x.Ilosc);
            builder.Property(x => x.Uwagi).HasMaxLength(100);

        }
    }
}
