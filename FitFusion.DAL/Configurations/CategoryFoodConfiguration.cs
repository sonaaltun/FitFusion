
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class CategoryFoodConfiguration : IEntityTypeConfiguration<CategoryFood>
{
    
    public void Configure(EntityTypeBuilder<CategoryFood> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x=> x.CaloriesPerServing).IsRequired();
        builder.Property(x=> x.Protein).IsRequired();
        builder.Property(x => x.Fat).IsRequired();
        builder.Property(x => x.Carbonhydrat).IsRequired();


        builder.Property(x=> x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x=> x.Statu).IsRequired();
        //builder.HasData(
        //    new FoodCategory
        //    {
        //        Food = new Food { Name = "Tavuk Sote", Description = "Soslu", CaloriesPerServing = 200 },
        //        CaloriesPerServing=200,
        //        FoodDescription = "Soslu",
        //        FoodName= "Tavuk Sote",
        //        Category=new Category { CategoryName = "Tavuklu Yemekler", Description ="Tavuk barından yemek çeşiştleri", },
        //        CategoryName= "Tavuklu Yemekler",

        //    });
        
        
          
    }
}
