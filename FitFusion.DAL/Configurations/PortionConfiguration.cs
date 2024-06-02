
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class PortionConfiguration : IEntityTypeConfiguration<Portion>
{
    public void Configure(EntityTypeBuilder<Portion> builder)
    {
        builder.Property(x => x.PortionType).IsRequired();
        builder.Property(x => x.Amount).IsRequired();


        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();
        builder.HasData(
            new Portion { PortionType="Kase", Amount =400},
            new Portion { PortionType = "100 gr", Amount = 100 }
            
            );
    }
}
