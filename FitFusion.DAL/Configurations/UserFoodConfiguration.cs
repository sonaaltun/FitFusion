using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class UserFoodConfiguration : IEntityTypeConfiguration<UserFood>
{
    public void Configure(EntityTypeBuilder<UserFood> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.TotalCalories).IsRequired();
        builder.Property(x => x.TotalProtein).IsRequired();
        builder.Property(x => x.TotalFat).IsRequired();
        builder.Property(x => x.TotalCarbonhydrat).IsRequired();

        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();

    }
}
