
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.CaloriesPerServing).IsRequired();
        builder.Property(x => x.Carbonhydrat).IsRequired();
        builder.Property(x => x.Protein).IsRequired();
        builder.Property(x => x.Fat).IsRequired();




        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();
       
    }
}
