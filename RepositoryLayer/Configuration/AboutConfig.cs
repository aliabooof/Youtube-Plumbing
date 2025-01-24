using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Configuration
{
    public class AboutConfig : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {

            builder.Property(p=>p.Header)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(p=>p.Description)
                .IsRequired()
                .HasMaxLength(5000);
            builder.Property(p => p.Clients)
                .IsRequired()
                .HasMaxLength(5); 
            builder.Property(p => p.Projects)
                .IsRequired()
                .HasMaxLength(5); 
            builder.Property(p => p.HoursOfsupport)
                .IsRequired()
                .HasMaxLength(5);  
            builder.Property(p => p.HardWorkers)
                .IsRequired()
                .HasMaxLength(5);
            

        }
    }
}
