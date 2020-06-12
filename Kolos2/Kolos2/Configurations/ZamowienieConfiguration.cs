using Kolos2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2.Configurations
{
    public class ZamowienieConfiguration : IEntityTypeConfiguration<Zamowienie>
    {


        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.HasKey(key => key.IdZamowieni);
            builder.Property(x => x.DataPrzyjecia);
            builder.Property(x => x.DataRealizacji);
            builder.Property(x => x.IdKlient);
            builder.Property(x => x.IdPracownik);
            builder.Property(x => x.Uwagi).HasMaxLength(300);
        }
    }
}
