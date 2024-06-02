
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class UserMealConfiguration : IEntityTypeConfiguration<UserMeal>
{
    public void Configure(EntityTypeBuilder<UserMeal> builder)
    {

        builder.Property(x=> x.TotalCalories).IsRequired();
        builder.Property(x => x.TotalProtein).IsRequired();
        builder.Property(x => x.TotalFat).IsRequired();
        builder.Property(x => x.MealTime).IsRequired();
        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();
    }
}
